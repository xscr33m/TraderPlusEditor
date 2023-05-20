using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraderPlusEditor._Core._Engine;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor.Properties;
using static TraderPlusEditor._Core._Engine.JSONData;

namespace TraderPlusEditor._Core._Forms
{
    public partial class FormMain : Form
    {
        // --- Main Fields --- //
        readonly string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string LogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        private readonly Timer notificationTimer = new Timer();
        public string userLanguageKey = Settings.Default.LanguageKey;
        public static FormMain Instance;
        // --- TraderPlusEditor Fields --- //
        static readonly string editorFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EXPORTS");
        static readonly string previewFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TraderPlusEditor", "PREVIEW");
        private JsonData loadedJsonData;
        private bool IsChangedEntry;
        private bool IsErrorEntry;

        public FormMain()
        {
            InitializeComponent();
            Text = "TraderPlusEditor";
            Instance = this;
        }

        // --- Main Load --- //
        private async void FormMain_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
            ApplySettings();

            IsChangedEntry = false;
            IsErrorEntry = false;

            await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_Startup"), IconChar.Check, Color.LightGreen);
        }

        // --- Apply Settings --- //
        private void ApplySettings()
        {
            PanelPreview.Visible = Settings.Default.ShowPreview;
            GridViewProducts.Columns["products_category"].Visible = Settings.Default.ShowCategories;
        }

        // --- Apply Language Variables --- //
        private void ApplyLanguage()
        {
            Label_Version.Text = "Version " + version;
            LabelCategories.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelCategories");
            LabelNewCategory.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelNewCategorie");
            LabelNewProductName.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelNewProductName");
            LabelCoefficent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelCoefficent");
            LabelMaxStock.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelMaxStock");
            LabelTradeQuantity.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelTradeQuantity");
            LabelBuyPrice.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelBuyPrice");
            LabelSellPrice.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelSellPrice");
            LabelDestockCoefficent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelDestockCoefficient");
            LabelVersion.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_LabelVersion");
            CheckBoxAutoCalculation.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxAutoCalculation");
            CheckBoxDefaultTraderStock.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxDefaultTraderStock");
            CheckBoxAutoDestock.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxAutoDestock");

            GridViewProducts.Columns["products_category"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewCategorie");
            GridViewProducts.Columns["products_name"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewProduct");
            GridViewProducts.Columns["products_coefficient"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewCoefficient");
            GridViewProducts.Columns["products_maxstock"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewMaxStock");
            GridViewProducts.Columns["products_tradeqty"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewTradeQty");
            GridViewProducts.Columns["products_buyprice"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewBuyPrice");
            GridViewProducts.Columns["products_sellPrice"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewSellPrice");
            GridViewProducts.Columns["products_destock"].HeaderText = MainForm.ResourceManager.GetString(userLanguageKey + "_GridViewDestock");
        }

        // --- Notifications --- //
        public async Task ShowNotification(string text, IconChar icon, Color iconColor) // Warnung ignorieren. Wenn nicht async, werden die Meldungen nicht nacheinander angezeigt! 
        {
            IconNotification.IconChar = icon;
            IconNotification.IconColor = iconColor;

            PanelNotifications.Visible = true;
            LabelNotifications.Visible = true;

            LabelNotifications.Text = text;

            if (notificationTimer.Enabled != false)
            {
                await Task.Delay(notificationTimer.Interval);
                notificationTimer.Stop();
            }

            notificationTimer.Interval = 5000;
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            PanelNotifications.Visible = false;
            LabelNotifications.Visible = false;

            notificationTimer.Stop();
        }

        // --- START TRADERPLUSEDITOR --- //
        private void PictureBox_Logo_DoubleClick(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&t=43s";
            WebsiteLauncher.OpenWebsite(url);
        }

        // --- Import-Button --- //
        private string filePath;
        private async void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JSON Files (*TraderPlusPriceConfig*.json)|*TraderPlusPriceConfig*.json"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dateipfad speichern
                filePath = openFileDialog.FileName;

                // Datei mit Hilfe der FileHelper-Klasse laden
                loadedJsonData = FileManager.LoadFile(filePath);

                // Erstelle eine Instanz von TPVerif mit dem Pfad der Konfigurationsdatei
                TPVerif verifier = new TPVerif(filePath);

                JSONValidator validator = new JSONValidator(filePath);

                try
                {
                    verifier.VerifyTPPC();

                    if (!verifier.IsInvalid)
                    {
                        validator.BeautifyFile();

                        UpdateUIAfterFileLoad();

                        SetTextBoxes();

                        ButtonSaveFile.Enabled = true;
                        ButtonFileClose.Visible = true;
                        ButtonOpenFile.Visible = false;

                        IsChangedEntry = false;

                        await Instance.ShowNotification("'" + filePath + Notifications.ResourceManager.GetString(userLanguageKey + "_ImportSuccess"), IconChar.Check, Color.LightGreen);
                    }
                    else
                    {
                        await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_ImportFail"), IconChar.Xmark, Color.Red);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessage PopupMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    PopupMessage.ButtonOkay.Visible = true;
                    PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    PopupMessage.IconPictureBox.IconColor = Color.Red;
                    PopupMessage.LabelMessageContent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_TPValidError") + $"{ex.Message}";
                    PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    PopupMessage.ButtonNo.Visible = false;
                    PopupMessage.ButtonYes.Visible = false;
                    if (PopupMessage.ShowDialog() == DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + MainForm.ResourceManager.GetString(userLanguageKey + "_TPValidError") + $"{ex.Message}\n");
                    }
                }
            }
        }

        // --- UI laden nach Import --- //
        private void UpdateUIAfterFileLoad()
        {
            // DataGridView leeren
            GridViewProducts.Rows.Clear();

            // Deaktiviere Sortierfunktion für alle Spaltenheader
            foreach (DataGridViewColumn column in GridViewProducts.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Version in TextBox eintragen
            TextBoxVersion.Text = loadedJsonData.Version;

            // CheckBoxes entsprechend setzen
            CheckBoxAutoCalculation.Checked = loadedJsonData.EnableAutoCalculation == 1;
            CheckBoxAutoDestock.Checked = loadedJsonData.EnableAutoDestockAtRestart == 1;
            CheckBoxDefaultTraderStock.Checked = loadedJsonData.EnableDefaultTraderStock == 1;

            // TraderCategories durchlaufen
            foreach (var category in loadedJsonData.TraderCategories)
            {
                // Kategorie zur ListView hinzufügen
                ListViewCategories.Items.Add(category.CategoryName);

                // Produkte der Kategorie durchlaufen
                foreach (var productString in category.Products)
                {
                    // Produkt-String in einzelne Eigenschaften aufteilen
                    var productData = productString.Split(',');

                    // Überprüfen, ob das productData-Array genügend Elemente enthält
                    if (productData.Length >= 7)
                    {
                        // Produkt erstellen mit DestockCoefficient
                        var product = new Product
                        {
                            Category = category.CategoryName,
                            Name = productData[0],
                            Coefficient = productData[1],
                            MaxStock = productData[2],
                            TradeQuantity = productData[3],
                            BuyPrice = productData[4],
                            SellPrice = productData[5],
                            DestockCoefficient = productData[6]
                        };
                        // Produkt in DataGridView einfügen
                        int rowIndex = GridViewProducts.Rows.Add();
                        GridViewProducts.Rows[rowIndex].Cells["products_category"].Value = product.Category;
                        GridViewProducts.Rows[rowIndex].Cells["products_name"].Value = product.Name;
                        GridViewProducts.Rows[rowIndex].Cells["products_coefficient"].Value = product.Coefficient;
                        GridViewProducts.Rows[rowIndex].Cells["products_maxstock"].Value = product.MaxStock;
                        GridViewProducts.Rows[rowIndex].Cells["products_tradeqty"].Value = product.TradeQuantity;
                        GridViewProducts.Rows[rowIndex].Cells["products_buyprice"].Value = product.BuyPrice;
                        GridViewProducts.Rows[rowIndex].Cells["products_sellPrice"].Value = product.SellPrice;
                        GridViewProducts.Rows[rowIndex].Cells["products_destock"].Value = product.DestockCoefficient;
                    }
                    else
                    {
                        // Produkt erstellen ohne DestockCoefficient
                        var product = new Product
                        {
                            Category = category.CategoryName,
                            Name = productData[0],
                            Coefficient = productData[1],
                            MaxStock = productData[2],
                            TradeQuantity = productData[3],
                            BuyPrice = productData[4],
                            SellPrice = productData[5],
                            DestockCoefficient = "" // Standardwert oder leeren String zuweisen
                        };
                        // Produkt in DataGridView einfügen
                        int rowIndex = GridViewProducts.Rows.Add();
                        GridViewProducts.Rows[rowIndex].Cells["products_category"].Value = product.Category;
                        GridViewProducts.Rows[rowIndex].Cells["products_name"].Value = product.Name;
                        GridViewProducts.Rows[rowIndex].Cells["products_coefficient"].Value = product.Coefficient;
                        GridViewProducts.Rows[rowIndex].Cells["products_maxstock"].Value = product.MaxStock;
                        GridViewProducts.Rows[rowIndex].Cells["products_tradeqty"].Value = product.TradeQuantity;
                        GridViewProducts.Rows[rowIndex].Cells["products_buyprice"].Value = product.BuyPrice;
                        GridViewProducts.Rows[rowIndex].Cells["products_sellPrice"].Value = product.SellPrice;
                        GridViewProducts.Rows[rowIndex].Cells["products_destock"].Value = product.DestockCoefficient;
                    }
                }
            }

            ActivateUI();

            SelectCategory();
        }

        // --- UI aktivieren nach Import --- //
        private void ActivateUI()
        {
            PanelProductsMain.Enabled = true;
            PanelCategoriesBottom.Enabled = true;
            PanelFileSettings.Enabled = true;
            PanelProductControls.Enabled = true;
            PanelSearch.Enabled = true;
        }

        private void DeactivateUI()
        {
            PanelProductsMain.Enabled = false;
            PanelCategoriesBottom.Enabled = false;
            PanelFileSettings.Enabled = false;
            PanelProductControls.Enabled = false;
            PanelSearch.Enabled = false;
        }

        // --- Export-Button --- //
        private async void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            if (IsErrorEntry == true)
            {
                // Zeige fehlerhafte Einträge
                ShowInvalidEntries();
            }
            else if (IsErrorEntry == false)
            {
                if (IsChangedEntry == true)
                {
                    CustomMessage messsageBox = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    messsageBox.ButtonOkay.Visible = false;
                    messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                    messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                    messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_SaveConfirm");
                    messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                    messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                    messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                    messsageBox.ButtonNo.Visible = true;
                    messsageBox.ButtonYes.Visible = true;

                    if (messsageBox.ShowDialog() == DialogResult.Yes)
                    {
                        // Exportiere Datei
                        if (loadedJsonData != null)
                        {
                            // Übertrage die Änderungen aus dem DataGridView zurück in die loadedJsonData-Instanz
                            // Kategorien aktualisieren
                            loadedJsonData.TraderCategories.Clear();

                            foreach (DataGridViewRow row in GridViewProducts.Rows)
                            {
                                string categoryName = row.Cells[0].Value?.ToString();
                                string productName = row.Cells[1].Value?.ToString();
                                string productCoefficient = row.Cells[2].Value?.ToString();
                                string maxStock = row.Cells[3].Value?.ToString();
                                string tradeQuantity = row.Cells[4].Value?.ToString();
                                string buyPrice = row.Cells[5].Value?.ToString();
                                string sellPrice = row.Cells[6].Value?.ToString();
                                string destockCoefficient = row.Cells[7].Value?.ToString();

                                if (!string.IsNullOrEmpty(categoryName) && !string.IsNullOrEmpty(productName))
                                {
                                    Category existingCategory = loadedJsonData.TraderCategories.FirstOrDefault(c => c.CategoryName == categoryName);

                                    if (existingCategory == null)
                                    {
                                        existingCategory = new Category
                                        {
                                            CategoryName = categoryName,
                                            Products = new List<string>()
                                        };
                                        loadedJsonData.TraderCategories.Add(existingCategory);
                                    }

                                    string productData;

                                    if (!string.IsNullOrEmpty(destockCoefficient))
                                    {
                                        productData = $"{productName},{productCoefficient},{maxStock},{tradeQuantity},{buyPrice},{sellPrice},{destockCoefficient}";
                                    }
                                    else
                                    {
                                        productData = $"{productName},{productCoefficient},{maxStock},{tradeQuantity},{buyPrice},{sellPrice}";
                                    }

                                    existingCategory.Products.Add(productData);
                                }
                            }

                            // Geladene Daten in eine neue JSON-Datei serialisieren und speichern
                            string serializedJson = JsonConvert.SerializeObject(loadedJsonData, Formatting.Indented);
                            string newFilePath = Path.Combine(editorFolderPath, "TraderPlusPriceConfig.json");

                            // Existierende Datei archivieren, falls vorhanden
                            if (File.Exists(newFilePath))
                            {
                                int counter = 1;
                                string oldFilePath = $"{newFilePath}.old{counter}";

                                while (File.Exists(oldFilePath))
                                {
                                    counter++;
                                    oldFilePath = $"{newFilePath}.old{counter}";
                                }

                                File.Move(newFilePath, oldFilePath);
                            }

                            File.WriteAllText(newFilePath, serializedJson);

                            IsChangedEntry = false;

                            await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_SaveSuccess"), IconChar.Check, Color.Green);
                        }
                    }
                }
                else
                {
                    await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_SaveFailed"), IconChar.Warning, Color.Yellow);
                }
            }
        }

        private async void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.Reload();

                userLanguageKey = Settings.Default.LanguageKey;
                PanelPreview.Visible = Settings.Default.ShowPreview;
                GridViewProducts.Columns["products_category"].Visible = Settings.Default.ShowCategories;

                Enabled = true;
                ApplyLanguage();
                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_SettingsSaved"), IconChar.Check, Color.LightGreen);
            }
        }

        private void Button_Info_Click(object sender, EventArgs e)
        {
            FormInfo form = new FormInfo();
            form.ShowDialog();
        }

        // Anzeigen der unmgültigen Einträge-Methode
        private void ShowInvalidEntries()
        {
            List<string> invalidEntries = new List<string>();

            foreach (DataGridViewRow row in GridViewProducts.Rows)
            {
                string productName = row.Cells[1].Value?.ToString();
                string productCoefficient = row.Cells[2].Value?.ToString();
                string maxStock = row.Cells[3].Value?.ToString();
                string tradeQuantity = row.Cells[4].Value?.ToString();
                string buyPrice = row.Cells[5].Value?.ToString();
                string sellPrice = row.Cells[6].Value?.ToString();
                string destock = row.Cells[7].Value?.ToString();

                if (string.IsNullOrEmpty(productName) || productName.Equals("ERROR", StringComparison.OrdinalIgnoreCase) ||
                    string.IsNullOrEmpty(productCoefficient) || productCoefficient.Equals("ERROR", StringComparison.OrdinalIgnoreCase) ||
                    string.IsNullOrEmpty(maxStock) || maxStock.Equals("ERROR", StringComparison.OrdinalIgnoreCase) ||
                    string.IsNullOrEmpty(tradeQuantity) || tradeQuantity.Equals("ERROR", StringComparison.OrdinalIgnoreCase) ||
                    string.IsNullOrEmpty(buyPrice) || buyPrice.Equals("ERROR", StringComparison.OrdinalIgnoreCase) ||
                    string.IsNullOrEmpty(sellPrice) || sellPrice.Equals("ERROR", StringComparison.OrdinalIgnoreCase) ||
                    destock.Equals("ERROR", StringComparison.OrdinalIgnoreCase))
                {
                    invalidEntries.Add(productName);
                }
            }

            string errorMessage = MessageForm.ResourceManager.GetString(userLanguageKey + "_InvalidEntries");
            errorMessage += string.Join("\n", invalidEntries);

            CustomMessage messsageBox = new CustomMessage();
            SystemSounds.Exclamation.Play();
            messsageBox.ButtonOkay.Visible = true;
            messsageBox.IconPictureBox.IconChar = IconChar.Xmark;
            messsageBox.IconPictureBox.ForeColor = Color.Red;
            messsageBox.LabelMessageContent.Text = errorMessage;
            messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
            messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
            messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
            messsageBox.ButtonNo.Visible = false;
            messsageBox.ButtonYes.Visible = false;

            if (messsageBox.ShowDialog() == DialogResult.OK)
            {
                return;
            }
        }

        // --- Schließen-Button --- //
        private void ButtonCloseFile_Click(object sender, EventArgs e)
        {
            if (IsChangedEntry == true)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_DiscardChanges");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    // Daten zurücksetzen
                    loadedJsonData = null;
                    filePath = string.Empty;
                    GridViewProducts.Rows.Clear();
                    ListViewCategories.Items.Clear();
                    TextBoxCategoryName.Text = string.Empty;
                    TextBoxNewProductName.Text = string.Empty;
                    TextBoxCoefficent.Text = string.Empty;
                    TextBoxMaxStock.Text = string.Empty;
                    TextBoxTradeQuantity.Text = string.Empty;
                    TextBoxBuyPrice.Text = string.Empty;
                    TextBoxSellPrice.Text = string.Empty;
                    TextBoxDestockCoefficent.Text = string.Empty;
                    TextBoxVersion.Text = string.Empty;
                    CheckBoxAutoCalculation.Checked = false;
                    CheckBoxDefaultTraderStock.Checked = false;
                    CheckBoxAutoDestock.Checked = false;

                    ButtonFileClose.Visible = false;
                    ButtonOpenFile.Visible = true;
                    ButtonSaveFile.Enabled = false;

                    DeactivateUI();
                }
            }
            else if (IsChangedEntry == false)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_CloseFile");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    // Daten zurücksetzen
                    loadedJsonData = null;
                    filePath = string.Empty;
                    GridViewProducts.Rows.Clear();
                    ListViewCategories.Items.Clear();
                    TextBoxCategoryName.Text = string.Empty;
                    TextBoxNewProductName.Text = string.Empty;
                    TextBoxCoefficent.Text = string.Empty;
                    TextBoxMaxStock.Text = string.Empty;
                    TextBoxTradeQuantity.Text = string.Empty;
                    TextBoxBuyPrice.Text = string.Empty;
                    TextBoxSellPrice.Text = string.Empty;
                    TextBoxDestockCoefficent.Text = string.Empty;
                    TextBoxVersion.Text = string.Empty;
                    CheckBoxAutoCalculation.Checked = false;
                    CheckBoxDefaultTraderStock.Checked = false;
                    CheckBoxAutoDestock.Checked = false;

                    ButtonFileClose.Visible = false;
                    ButtonOpenFile.Visible = true;
                    ButtonSaveFile.Enabled = false;

                    DeactivateUI();
                }
            }
        }

        // --- Export-öffnen-Button --- //
        private async void ButtonOpenExport_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(editorFolderPath))
            {
                Process.Start("explorer.exe", editorFolderPath);
            }
            else
            {
                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_NoExistingFolder"), IconChar.Xmark, Color.Red);
            }
        }

        // --- Vorschau Methode --- //
        private void ShowProductPreview(string productName)
        {
            if (Settings.Default.ShowPreview == true)
            {
                string JPGimagePath = Path.Combine(previewFolderPath, $"{productName}.jpg");
                string PNGimagePath = Path.Combine(previewFolderPath, $"{productName}.png");

                if (File.Exists(JPGimagePath))
                {
                    PictureBoxPreview.Image = Image.FromFile(JPGimagePath);
                }
                else if (File.Exists(PNGimagePath))
                {
                    PictureBoxPreview.Image = Image.FromFile(PNGimagePath);
                }
                else
                {
                    PictureBoxPreview.Image = Resources.NoImage;
                }
            }
        }

        // --- Vorschau Ordner öffnen --- // 
        private async void PictureBoxPreview_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(previewFolderPath))
            {
                Process.Start("explorer.exe", previewFolderPath);
            }
            else
            {
                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_NoExistingFolder"), IconChar.Xmark, Color.Red);
            }
        }

        // --- File Settings --- //
        private void CkeckBoxAutoDestock_CheckedChanged(object sender, EventArgs e)
        {
            ButtonSaveFile.Enabled = true;
            IsChangedEntry = true;
        }

        private void CheckBoxAutoCalculation_CheckedChanged(object sender, EventArgs e)
        {
            ButtonSaveFile.Enabled = true;
            IsChangedEntry = true;
        }

        private void CheckBoxDefaultTraderStock_CheckedChanged(object sender, EventArgs e)
        {
            ButtonSaveFile.Enabled = true;
            IsChangedEntry = true;
        }

        // --- Suche Button --- //
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            PerformSearchProduct();
        }

        // --- Suche Enter --- //
        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearchProduct();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // --- Suche Methode --- //
        private int lastFoundRowIndex = -1; // Variable zum Speichern des Index des zuletzt gefundenen Eintrags

        private async void PerformSearchProduct()
        {
            string searchText = TextboxSearch.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Aufheben der aktuellen Markierung
                GridViewProducts.ClearSelection();

                bool found = false;

                // Starte die Suche ab dem nächsten Index, wenn ein vorheriger Eintrag gefunden wurde
                int startIndex = lastFoundRowIndex != -1 ? lastFoundRowIndex + 1 : 0;

                // Durchlaufe alle Zeilen des DataGridView ab dem Startindex
                for (int i = startIndex; i < GridViewProducts.Rows.Count; i++)
                {
                    DataGridViewRow row = GridViewProducts.Rows[i];

                    // Überprüfe den Produktnamen in der aktuellen Zeile
                    string productName = row.Cells["products_name"].Value?.ToString();

                    if (!string.IsNullOrEmpty(productName) && productName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Produkt gefunden, Zeile markieren
                        row.Selected = true;

                        // Scrolle zum gefundenen Eintrag
                        GridViewProducts.FirstDisplayedScrollingRowIndex = row.Index;

                        found = true;

                        SetTextBoxes();

                        SelectCategory();

                        lastFoundRowIndex = row.Index; // Aktualisiere den Index des zuletzt gefundenen Eintrags

                        break;
                    }
                }

                if (!found)
                {
                    await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_SearchNoResult") + searchText + "'", IconChar.Warning, Color.Yellow);
                    lastFoundRowIndex = -1; // Setze den Index des zuletzt gefundenen Eintrags zurück
                }
            }
            else
            {
                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_SearchNoTerm"), IconChar.Xmark, Color.Red);
            }
        }

        // --- Sortierung der Einträge rauf --- //
        private void ButtonProductUp_Click(object sender, EventArgs e)
        {
            MoveSelectedRow(true);

            SetTextBoxes();

            IsChangedEntry = true;
        }

        // --- Sortierung der Einträge runter --- //
        private void ButtonProductDown_Click(object sender, EventArgs e)
        {
            MoveSelectedRow(false);

            SetTextBoxes();

            IsChangedEntry = true;
        }

        // --- Sortierung der Einträge Methode --- //
        private void MoveSelectedRow(bool moveUp)
        {
            if (GridViewProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = GridViewProducts.SelectedRows[0].Index;
                int targetIndex = moveUp ? selectedIndex - 1 : selectedIndex + 1;

                if (targetIndex >= 0 && targetIndex < GridViewProducts.Rows.Count)
                {
                    DataGridViewRow selectedRow = GridViewProducts.Rows[selectedIndex];
                    DataGridViewRow targetRow = GridViewProducts.Rows[targetIndex];

                    string selectedCategory = selectedRow.Cells["products_category"].Value.ToString();
                    string targetCategory = targetRow.Cells["products_category"].Value.ToString();

                    // Kategorie des verschobenen Eintrags anpassen, wenn sie sich ändert
                    if (selectedCategory != targetCategory)
                    {
                        selectedRow.Cells["products_category"].Value = targetCategory;
                    }

                    GridViewProducts.Rows.RemoveAt(selectedIndex);
                    GridViewProducts.Rows.Insert(targetIndex, selectedRow);

                    // Die verschobene Zeile auswählen
                    GridViewProducts.ClearSelection();
                    GridViewProducts.Rows[targetIndex].Selected = true;

                    // Überprüfen, ob die verschobene Zeile außerhalb des sichtbaren Bereichs liegt
                    if (targetIndex < GridViewProducts.FirstDisplayedScrollingRowIndex ||
                        targetIndex >= GridViewProducts.FirstDisplayedScrollingRowIndex + GridViewProducts.DisplayedRowCount(false))
                    {
                        // Die verschobene Zeile in den sichtbaren Bereich scrollen
                        GridViewProducts.FirstDisplayedScrollingRowIndex = targetIndex;
                    }

                    SelectCategory();

                    IsChangedEntry = true;
                }
            }
        }

        // --- ListBox Kategorie: zu Produkt springen --- // 
        private async void ListViewCategories_DoubleClick(object sender, EventArgs e)
        {
            if (ListViewCategories.SelectedItems.Count > 0)
            {
                string selectedCategory = ListViewCategories.SelectedItems[0].Text;

                bool categoryFound = false; // Variable zum Speichern des Ergebnisses der Kategorieüberprüfung

                foreach (DataGridViewRow row in GridViewProducts.Rows)
                {
                    if (row.Cells["products_category"].Value.ToString() == selectedCategory)
                    {
                        GridViewProducts.ClearSelection();
                        row.Selected = true;
                        GridViewProducts.FirstDisplayedScrollingRowIndex = row.Index;
                        categoryFound = true; // Kategorie wurde gefunden
                        break;
                    }
                }

                if (!categoryFound)
                {
                    // Keine Einträge in der ausgewählten Kategorie gefunden, zeige Notification an
                    await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_CategoryNoProduct") + selectedCategory + "'", IconChar.Warning, Color.Yellow);
                }

                SetTextBoxes();

                DataGridViewRow selectedRow = GridViewProducts.SelectedRows[0];
                string productName = selectedRow.Cells["products_name"].Value.ToString();
                ShowProductPreview(productName);
            }
        }

        // --- Kategorie in Textbox einfügen --- //
        private void ListViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewCategories.SelectedItems.Count > 0)
            {
                string selectedCategory = ListViewCategories.SelectedItems[0].Text;
                {
                    TextBoxCategoryName.Text = selectedCategory;
                }
            }
        }

        // --- Kategorie in ListView markieren --- //
        private void SelectCategory()
        {
            if (GridViewProducts.SelectedRows.Count > 0)
            {
                string selectedCategory = GridViewProducts.SelectedRows[0].Cells["products_category"].Value.ToString();

                foreach (ListViewItem item in ListViewCategories.Items)
                {
                    if (item.Text == selectedCategory)
                    {
                        ListViewCategories.SelectedItems.Clear();
                        item.Selected = true;
                        item.EnsureVisible();
                        break;
                    }
                }

                DataGridViewRow selectedRow = GridViewProducts.SelectedRows[0];
                string productName = selectedRow.Cells["products_name"].Value.ToString();
                ShowProductPreview(productName);
            }
        }

        // --- Produkte Auswahl --- // 
        private void GridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetTextBoxes();

            SelectCategory();
        }

        // --- Textboxen mit markiertem Produkt füllen --- //
        private void SetTextBoxes()
        {
            if (GridViewProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridViewProducts.SelectedRows[0];

                // Überprüfen, ob die ausgewählte Zeile nicht null ist
                if (selectedRow != null)
                {
                    // Überprüfen, ob die Zellenwerte nicht null sind
                    string product = selectedRow.Cells["products_name"].Value?.ToString();
                    string coefficient = selectedRow.Cells["products_coefficient"].Value?.ToString();
                    string maxStock = selectedRow.Cells["products_maxstock"].Value?.ToString();
                    string tradeQuantity = selectedRow.Cells["products_tradeqty"].Value?.ToString();
                    string buyPrice = selectedRow.Cells["products_buyprice"].Value?.ToString();
                    string sellPrice = selectedRow.Cells["products_sellPrice"].Value?.ToString();
                    string destockCoefficient = selectedRow.Cells["products_destock"].Value?.ToString();

                    TextBoxNewProductName.Text = product ?? string.Empty;
                    TextBoxCoefficent.Text = coefficient ?? string.Empty;
                    TextBoxMaxStock.Text = maxStock ?? string.Empty;
                    TextBoxTradeQuantity.Text = tradeQuantity ?? string.Empty;
                    TextBoxBuyPrice.Text = buyPrice ?? string.Empty;
                    TextBoxSellPrice.Text = sellPrice ?? string.Empty;
                    TextBoxDestockCoefficent.Text = destockCoefficient ?? string.Empty;
                }
            }
            else if (GridViewProducts.SelectedRows.Count == 0)
            {
                TextBoxNewProductName.Text = string.Empty;
                TextBoxCoefficent.Text = string.Empty;
                TextBoxMaxStock.Text = string.Empty;
                TextBoxTradeQuantity.Text = string.Empty;
                TextBoxBuyPrice.Text = string.Empty;
                TextBoxSellPrice.Text = string.Empty;
                TextBoxDestockCoefficent.Text = string.Empty;
            }
        }

        // --- Geänderte Zelle melden --- //
        private void GridViewProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsChangedEntry = true;
        }

        // --- Neue Kategorie hinzufügen --- // 
        private async void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            string newCategoryName = TextBoxCategoryName.Text;

            // Überprüfe, ob die Textbox nicht leer ist
            if (!string.IsNullOrEmpty(newCategoryName))
            {
                // Überprüfe, ob die Kategorie bereits existiert
                bool categoryExists = false;
                foreach (ListViewItem item in ListViewCategories.Items)
                {
                    if (item.Text.Equals(newCategoryName))
                    {
                        categoryExists = true;
                        break;
                    }
                }

                // Füge die Kategorie hinzu, falls sie noch nicht existiert
                if (!categoryExists)
                {
                    ListViewItem newCategoryItem = new ListViewItem(newCategoryName);
                    ListViewCategories.Items.Add(newCategoryItem);

                    // Markiere den hinzugefügten Eintrag
                    newCategoryItem.Selected = true;

                    // Scrollen zum markierten Eintrag
                    newCategoryItem.EnsureVisible();
                }
                else
                {
                    await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_CategoryExists"), IconChar.Xmark, Color.Red);
                }
            }
            else
            {
                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_CategoryInvalidName"), IconChar.Xmark, Color.Red);
            }
        }

        // --- Markierte Kategorie bearbeiten/Speichern --- //
        private async void ButtonEditCategory_Click(object sender, EventArgs e)
        {
            if (ListViewCategories.SelectedItems.Count > 0)
            {
                string markedCategory = ListViewCategories.SelectedItems[0].Text;
                string newCategoryName = TextBoxCategoryName.Text;

                // Überprüfe, ob die Textbox nicht leer ist
                if (!string.IsNullOrEmpty(newCategoryName))
                {
                    // Aktualisiere den markierten Eintrag in lv_categories
                    ListViewCategories.SelectedItems[0].Text = newCategoryName;

                    // Aktualisiere die entsprechenden Werte in dgv_PriceConfig
                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value != null && row.Cells["products_category"].Value.ToString() == markedCategory)
                        {
                            row.Cells["products_category"].Value = newCategoryName;
                        }
                    }
                }
                else
                {
                    await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_CategoryInvalidName"), IconChar.Xmark, Color.Red);
                }
            }
        }

        // --- Markierte Kategorie löschen --- // 
        private void ButtonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (ListViewCategories.SelectedItems.Count > 0)
            {
                string markedCategory = ListViewCategories.SelectedItems[0].Text;

                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = "'" + markedCategory + MessageForm.ResourceManager.GetString(userLanguageKey + "_CategoryDelete");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

                    // Durchsuche die Spalte "products_category" im DataGridView
                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value != null && row.Cells["products_category"].Value.ToString() == markedCategory)
                        {
                            // Markiere die Zeile zum Entfernen
                            rowsToRemove.Add(row);
                        }
                    }

                    // Entferne die markierten Zeilen aus dem DataGridView
                    foreach (DataGridViewRow rowToRemove in rowsToRemove)
                    {
                        GridViewProducts.Rows.Remove(rowToRemove);
                    }

                    // Entferne die Kategorie aus lv_categories
                    ListViewCategories.SelectedItems[0].Remove();
                }
            }
        }

        // --- Neues Produkt einfügen --- // 
        private async void ButtonAddNewProduct_Click(object sender, EventArgs e)
        {
            if (ListViewCategories.SelectedItems.Count > 0)
            {
                if (TextBoxNewProductName.Text != string.Empty && TextBoxCoefficent.Text != string.Empty &&
                    TextBoxMaxStock.Text != string.Empty && TextBoxTradeQuantity.Text != string.Empty &&
                    TextBoxBuyPrice.Text != string.Empty && TextBoxSellPrice.Text != string.Empty)
                {
                    string markedCategory = ListViewCategories.SelectedItems[0].Text;
                    int categoryIndex = ListViewCategories.SelectedIndices[0];

                    int targetIndex = -1;

                    // Überprüfen, ob die Kategorie bereits im DataGridView existiert
                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        string category = row.Cells[0].Value?.ToString();

                        if (category == markedCategory)
                        {
                            targetIndex = row.Index + 1;
                            break;
                        }
                    }

                    if (targetIndex == -1)
                    {
                        // Kategorie existiert nicht im DataGridView, also wird der Eintrag am Ende der Kategorie eingefügt
                        for (int i = categoryIndex + 1; i < ListViewCategories.Items.Count; i++)
                        {
                            string nextCategory = ListViewCategories.Items[i].Text;

                            foreach (DataGridViewRow row in GridViewProducts.Rows)
                            {
                                string category = row.Cells[0].Value?.ToString();

                                if (category == nextCategory)
                                {
                                    targetIndex = row.Index;
                                    break;
                                }
                            }

                            if (targetIndex != -1)
                                break;
                        }

                        if (targetIndex == -1)
                        {
                            // Es wurde keine Kategorie gefunden, nach der die neue Kategorie eingefügt werden kann,
                            // also wird der Eintrag am Ende des DataGridView eingefügt
                            targetIndex = GridViewProducts.Rows.Count;

                            IsChangedEntry = true;
                        }
                    }
                    else
                    {
                        // Überprüfen, ob das Produkt bereits in der Kategorie existiert
                        foreach (DataGridViewRow row in GridViewProducts.Rows)
                        {
                            string category = row.Cells[0].Value?.ToString();
                            string productName = row.Cells[1].Value?.ToString();

                            if (category == markedCategory && productName == TextBoxNewProductName.Text)
                            {
                                await Instance.ShowNotification("'" + productName + Notifications.ResourceManager.GetString(userLanguageKey + "_ProductExists") + category + "'!", IconChar.Xmark, Color.Red);
                                return;
                            }
                        }
                    }

                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(GridViewProducts);

                    newRow.Cells[0].Value = TextBoxCategoryName.Text; // Spaltenindex 0 für "products_category"
                    newRow.Cells[1].Value = TextBoxNewProductName.Text; // Spaltenindex 1 für "products_name"
                    newRow.Cells[2].Value = TextBoxCoefficent.Text; // Spaltenindex 2 für "products_coefficient"
                    newRow.Cells[3].Value = TextBoxMaxStock.Text; // Spaltenindex 3 für "products_maxstock"
                    newRow.Cells[4].Value = TextBoxTradeQuantity.Text; // Spaltenindex 4 für "products_tradeqty"
                    newRow.Cells[5].Value = TextBoxBuyPrice.Text; // Spaltenindex 5 für "products_buyprice"
                    newRow.Cells[6].Value = TextBoxSellPrice.Text; // Spaltenindex 6 für "products_sellPrice"
                    newRow.Cells[7].Value = TextBoxDestockCoefficent.Text; // Spaltenindex 7 für "products_destock"

                    GridViewProducts.Rows.Insert(targetIndex, newRow);
                    GridViewProducts.ClearSelection();
                    GridViewProducts.Rows[targetIndex].Selected = true;

                    if (targetIndex < GridViewProducts.FirstDisplayedScrollingRowIndex ||
                        targetIndex >= GridViewProducts.FirstDisplayedScrollingRowIndex + GridViewProducts.DisplayedRowCount(false))
                    {
                        GridViewProducts.FirstDisplayedScrollingRowIndex = targetIndex;
                    }

                    IsChangedEntry = true;
                }
                else
                {
                    await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_MissingTextBoxes"), IconChar.Xmark, Color.Red);
                }
            }
            else
            {
                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_ProductNoSelectedCategory"), IconChar.Xmark, Color.Red);
            }
        }

        // --- Produkt aus Übersicht entfernen
        private async void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (GridViewProducts.SelectedRows.Count >= 1)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ProductDelete");

                // Liste für die zu löschenden Produkte
                List<string> deletedProducts = new List<string>();

                foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                {
                    string productName = row.Cells["products_name"].Value.ToString();
                    deletedProducts.Add(productName);
                }

                // Maximale Anzahl an angezeigten Produkten
                int maxDisplayedProducts = 10;

                // Anzahl der weiteren Produkte, die nicht angezeigt werden
                int additionalProductsCount = deletedProducts.Count - maxDisplayedProducts;

                // Produkte zur MessageBox hinzufügen
                for (int i = 0; i < Math.Min(deletedProducts.Count, maxDisplayedProducts); i++)
                {
                    string productName = deletedProducts[i];
                    messsageBox.LabelMessageContent.Text += "'" + productName + "'\n";
                }

                // "und x-amount mehr.." anzeigen, wenn es weitere Produkte gibt
                if (additionalProductsCount > 0)
                {
                    messsageBox.LabelMessageContent.Text += MessageForm.ResourceManager.GetString(userLanguageKey + "_ProductDelete2") + additionalProductsCount + MessageForm.ResourceManager.GetString(userLanguageKey + "_ProductDelete3");
                }

                messsageBox.LabelMessageContent.Text += MessageForm.ResourceManager.GetString(userLanguageKey + "_ProductDelete4");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                    {
                        GridViewProducts.Rows.Remove(row);
                    }

                    await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_ProductDeleteSuccess"), IconChar.Check, Color.Green);
                }
            }
        }

        // --- SetAll coeff --- //
        private void ButtonCoefficent_Click(object sender, EventArgs e)
        {
            if (GridViewProducts.SelectedRows.Count == 1)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_SetAllWarning");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    string selectedCategory = GridViewProducts.SelectedRows[0].Cells["products_category"].Value.ToString();

                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value.ToString() == selectedCategory)
                        {
                            row.Cells["products_coefficient"].Value = TextBoxCoefficent.Text;

                            IsChangedEntry = true;
                        }
                    }
                }
            }
            else if (GridViewProducts.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                {
                    row.Cells["products_coefficient"].Value = TextBoxCoefficent.Text;

                    IsChangedEntry = true;
                }
            }
        }

        // --- SetAll maxStock --- //
        private void ButtonMaxStock_Click(object sender, EventArgs e)
        {
            if (GridViewProducts.SelectedRows.Count == 1)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_SetAllWarning");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    string selectedCategory = GridViewProducts.SelectedRows[0].Cells["products_category"].Value.ToString();

                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value.ToString() == selectedCategory)
                        {
                            row.Cells["products_maxstock"].Value = TextBoxMaxStock.Text;

                            IsChangedEntry = true;
                        }
                    }
                }
            }
            else if (GridViewProducts.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                {
                    row.Cells["products_maxstock"].Value = TextBoxMaxStock.Text;

                    IsChangedEntry = true;
                }
            }
        }

        // --- SetAll qty --- //
        private void ButtonTradeQuantity_Click(object sender, EventArgs e)
        {
            if (GridViewProducts.SelectedRows.Count == 1)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_SetAllWarning");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    string selectedCategory = GridViewProducts.SelectedRows[0].Cells["products_category"].Value.ToString();

                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value.ToString() == selectedCategory)
                        {
                            row.Cells["products_tradeqty"].Value = TextBoxTradeQuantity.Text;

                            IsChangedEntry = true;
                        }
                    }
                }
            }
            else if (GridViewProducts.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                {
                    row.Cells["products_tradeqty"].Value = TextBoxTradeQuantity.Text;

                    IsChangedEntry = true;
                }
            }
        }

        // --- SetAll EK --- //
        private void ButtonBuyPrice_Click(object sender, EventArgs e)
        {
            if (GridViewProducts.SelectedRows.Count == 1)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_SetAllWarning");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    string selectedCategory = GridViewProducts.SelectedRows[0].Cells["products_category"].Value.ToString();

                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value.ToString() == selectedCategory)
                        {
                            row.Cells["products_buyprice"].Value = TextBoxBuyPrice.Text;

                            IsChangedEntry = true;
                        }
                    }
                }
            }
            else if (GridViewProducts.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                {
                    row.Cells["products_buyprice"].Value = TextBoxBuyPrice.Text;

                    IsChangedEntry = true;
                }
            }
        }

        // --- SetAll VK --- //
        private void ButtonSellPrice_Click(object sender, EventArgs e)
        {
            if (GridViewProducts.SelectedRows.Count == 1)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_SetAllWarning");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {
                    string selectedCategory = GridViewProducts.SelectedRows[0].Cells["products_category"].Value.ToString();

                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value.ToString() == selectedCategory)
                        {
                            row.Cells["products_sellPrice"].Value = TextBoxSellPrice.Text;

                            IsChangedEntry = true;
                        }
                    }
                }
            }
            else if (GridViewProducts.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                {
                    row.Cells["products_sellPrice"].Value = TextBoxSellPrice.Text;

                    IsChangedEntry = true;
                }
            }
        }

        // --- SetAll Destock --- //
        private void ButtonDestockCoefficent_Click(object sender, EventArgs e)
        {
            if (GridViewProducts.SelectedRows.Count == 1)
            {
                CustomMessage messsageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messsageBox.ButtonOkay.Visible = false;
                messsageBox.IconPictureBox.IconChar = IconChar.Warning;
                messsageBox.IconPictureBox.ForeColor = Color.Yellow;
                messsageBox.LabelMessageContent.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_SetAllWarning");
                messsageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleWarning");
                messsageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messsageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messsageBox.ButtonNo.Visible = true;
                messsageBox.ButtonYes.Visible = true;

                if (messsageBox.ShowDialog() == DialogResult.Yes)
                {

                    string selectedCategory = GridViewProducts.SelectedRows[0].Cells["products_category"].Value.ToString();

                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells["products_category"].Value.ToString() == selectedCategory)
                        {
                            row.Cells["products_destock"].Value = TextBoxDestockCoefficent.Text;

                            IsChangedEntry = true;
                        }
                    }
                }
            }
            else if (GridViewProducts.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in GridViewProducts.SelectedRows)
                {
                    row.Cells["products_destock"].Value = TextBoxDestockCoefficent.Text;

                    IsChangedEntry = true;
                }
            }
        }

        // --- Zellen von ungültigen Zeichen bereinigen --- // 
        private async void GridViewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string columnName = GridViewProducts.Columns[e.ColumnIndex].Name;
                string cellValue = GridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(cellValue))
                {
                    if (columnName == "products_name")
                    {
                        // Bereinigen des Zellwerts
                        string newValue = Regex.Replace(cellValue, @"[^a-zA-Z0-9_-]", "");
                        GridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;

                        string deletedCharacters = string.Join("", cellValue.Except(newValue));
                        if (!string.IsNullOrEmpty(deletedCharacters))
                        {
                            await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidCharacters") + deletedCharacters + Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidCharacters2"), IconChar.Xmark, Color.Red);
                        }
                    }
                    else if (columnName == "products_coefficient" || columnName == "products_maxstock" ||
                             columnName == "products_tradeqty" || columnName == "products_buyprice" ||
                             columnName == "products_sellPrice" || columnName == "products_destock")
                    {
                        // Überprüfen auf zulässige Formate
                        bool isValidFormat = false;

                        if (cellValue == "0")
                        {
                            isValidFormat = true;
                        }
                        else if (cellValue == "-1")
                        {
                            isValidFormat = true;
                        }
                        else if (Regex.IsMatch(cellValue, @"^[0-9]+(\.[0-9]+)?$"))
                        {
                            isValidFormat = true;
                        }
                        else if (cellValue == string.Empty)
                        {
                            isValidFormat = false;
                        }

                        if (isValidFormat)
                        {
                            // Bereinigen des Zellwerts
                            string newValue = Regex.Replace(cellValue, @"[^0-9.-]", "");
                            GridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;

                            string deletedCharacters = string.Join("", cellValue.Except(newValue));
                            if (!string.IsNullOrEmpty(deletedCharacters))
                            {
                                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidCharacters") + deletedCharacters + Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidCharacters2"), IconChar.Xmark, Color.Red);
                            }

                            // Setzen Sie den IsErrorEntry-Wert auf false, da der Wert gültig ist
                            IsErrorEntry = false;
                        }
                        else
                        {
                            string newValue = "ERROR";
                            GridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
                            await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidNumberFormat"), IconChar.Xmark, Color.Red);

                            IsErrorEntry = true;
                        }
                    }
                    else if (columnName == "products_destock")
                    {
                        // Überprüfen auf zulässige Formate
                        bool isValidFormat = false;

                        if (cellValue == "-1")
                        {
                            isValidFormat = true;
                        }
                        else if (cellValue == "")
                        {
                            isValidFormat = true;
                        }
                        else if (Regex.IsMatch(cellValue, @"^[0-9](\.[0-9])$"))
                        {
                            isValidFormat = true;
                        }

                        if (isValidFormat)
                        {
                            // Bereinigen des Zellwerts
                            string newValue = Regex.Replace(cellValue, @"[^0-9.-]", "");
                            GridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;

                            string deletedCharacters = string.Join("", cellValue.Except(newValue));
                            if (!string.IsNullOrEmpty(deletedCharacters))
                            {
                                await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidCharacters") + deletedCharacters + Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidCharacters2"), IconChar.Xmark, Color.Red);
                            }

                            // Setzen Sie den IsErrorEntry-Wert auf false, da der Wert gültig ist
                            IsErrorEntry = false;
                        }
                        else
                        {
                            string newValue = "ERROR";
                            GridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
                            await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidNumberFormat"), IconChar.Xmark, Color.Red);

                            IsErrorEntry = true;
                        }
                    }

                    // ToDo: Nachricht anzeigen, wenn keine Fehler gefunden wurden.
                    await Instance.ShowNotification("Value saved!", IconChar.Check, Color.Green);
                }
                else // Wenn Zelle leer
                {
                    if (columnName == "products_destock")
                    {
                        // Nichts. Der Wert darf leer sein!
                    }
                    else
                    {
                        string newValue = "ERROR";
                        GridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
                        await Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_InvalidEmptyValue"), IconChar.Xmark, Color.Red);

                        IsErrorEntry = true;
                    }
                }
            }
        }

        // --- Black TitleBar --- //
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }
    }
}