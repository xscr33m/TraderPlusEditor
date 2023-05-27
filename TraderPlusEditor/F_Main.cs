////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///                                                                                                                                              ///
/// © 2023 by xscr33m   (Discord: xscr33m#4443)                                                                                                  ///
///                                                                                                                                              ///
/// **** Disclaimer: ****                                                                                                                        ///
///                                                                                                                                              ///
/// This code is provided as-is without any warranty.                                                                                            ///
/// xscr33m is not responsible for any issues, damages, or consequences arising from the use of this code or the tool developed using this code. ///
/// It is recommended to review and understand the code before making any modifications or using it in a production environment.                 ///
///                                                                                                                                              ///
/// **** Feedback and Contributions: ****                                                                                                        ///
/// Feedback and suggestions to improve the code or the tool are welcome.                                                                        /// 
/// Feel free to reach out to xscr33m#4443 on Discord with any feedback or to contribute to the development of the tool.                         ///
///                                                                                                                                              ///
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraderPlusEditor.Properties;

namespace TraderPlusEditor
{
    public partial class F_Main : Form
    {
        readonly string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        static public string editorFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TraderPlusEditor", "EXPORTS");
        private string filePath;
        private int currentEntryIndex = -1;
        private JsonData loadedJsonData;
        private readonly Timer notificationTimer = new Timer();

        public F_Main()
        {
            InitializeComponent();
        }

        private async void F_Main_Load(object sender, EventArgs e)
        {
            Text = "xscr33m'S TraderPlusEditor - v." + version;
            ContextMenu_products.Renderer = new CustomMenuRenderer();
            await MainStartUp.CheckForInstance();
            await MainStartUp.GENERATEPATH();
            await MainStartUp.CheckForUpdates(this);

            await ShowNotification("xscr33m's TraderPlusEditor successfully started!", Resources.okay, Color.LightGreen);
        }

        // --- Benachrichtigungen --- //
        public async Task ShowNotification(string text, Image image, Color panelColor)
        {
            // Setze den Text des Labels
            lbl_pushNotifications.Text = text;

            // Setze das Bild des Labels
            lbl_pushNotifications.Image = image;

            // Setze die Farbe des Panels
            pnl_pushNotifications.BackColor = panelColor;

            // Mache das Panel und das Label sichtbar
            pnl_pushNotifications.Visible = true;
            lbl_pushNotifications.Visible = true;

            // Stoppe den aktuellen Timer, falls einer läuft
            notificationTimer.Stop();

            // Starte einen neuen Timer mit einer Verzögerung von 5 Sekunden
            notificationTimer.Interval = 5000;
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            // Blende das Panel und das Label aus
            pnl_pushNotifications.Visible = false;
            lbl_pushNotifications.Visible = false;

            // Stoppe den Timer
            notificationTimer.Stop();
        }

        // --- Import-Button --- //
        private async void Btn_loadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON Files (TraderPlusPriceConfig.json)|TraderPlusPriceConfig.json"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dateipfad speichern
                filePath = openFileDialog.FileName;

                // Datei mit Hilfe der FileHelper-Klasse laden
                loadedJsonData = FileHelper.LoadFile(filePath);

                UpdateUIAfterFileLoad();

                await ShowNotification("PriceConfig successfully imported!", Resources.okay, Color.LightGreen);
            }
        }

        // --- Export-Button --- //
        private void Btn_exportFile_Click(object sender, EventArgs e)
        {
            if (loadedJsonData != null)
            {
                // Datei mit Hilfe der FileHelper-Klasse exportieren
                FileHelper.ExportFile(filePath, loadedJsonData, lv_products, editorFolderPath);

                ShowNotification("New PriceConfig.json successfully exported!", Resources.okay, Color.LightGreen);

                btn_exportFile.Enabled = false;
            }
        }

        // --- Schließen-Button --- //
        private void Btn_closeFile_Click(object sender, EventArgs e)
        {
            bool hasLightPinkEntries = false;

            foreach (ListViewItem item in lv_products.Items)
            {
                if (item.BackColor == Color.LightPink)
                {
                    hasLightPinkEntries = true;
                    break;
                }
            }
            // Eintrag Hat Änderungen
            if (hasLightPinkEntries)
            {
                F_Msg messageBoxForm = new F_Msg();
                SystemSounds.Exclamation.Play();
                messageBoxForm.button3.Visible = false;
                messageBoxForm.pictureBox1.Image = Resources.warning_50;
                messageBoxForm.label1.Text = "There are unsaved changes! \n\r \n\rAre you sure you want to close the file without exporting it?";
                messageBoxForm.Text = "WARNING: Unsafed changes!";
                messageBoxForm.button2.Visible = true;
                messageBoxForm.button1.Visible = true;

                if (messageBoxForm.ShowDialog() == DialogResult.Yes)
                {
                    // Daten zurücksetzen
                    loadedJsonData = null;
                    filePath = string.Empty;

                    Application.Restart();
                }
            }
            else
            {
                // Daten zurücksetzen
                loadedJsonData = null;
                filePath = string.Empty;

                Application.Restart();
            }
        }

        // --- Export-öffnen-Button --- //
        private async void Btn_openExports_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(editorFolderPath))
            {
                Process.Start("explorer.exe", editorFolderPath);
            }
            else
            {
                await ShowNotification("The folder does not exist!", Properties.Resources.warn, Color.LightCoral);
            }
        }

        // --- Info Buttons --- //
        private void Btn_donate_Click(object sender, EventArgs e)
        {
            string url = "https://www.paypal.me/dheil53";
            WebsiteLauncher.OpenWebsite(url);
        }

        private void Btn_gitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/xscr33m/TraderPlusEditor";
            WebsiteLauncher.OpenWebsite(url);
        }

        private void Btn_discord_Click(object sender, EventArgs e)
        {
            string url = "https://discord.com/invite/K9mkHyuGG8";
            WebsiteLauncher.OpenWebsite(url);
        }

        private void Btn_wiki_Click(object sender, EventArgs e)
        {
            string url = "https://traderpluswiki.notion.site/TraderPlusPriceConfig-json-bafb5261d89349f1ac68f82e53eb3b46";
            WebsiteLauncher.OpenWebsite(url);
        }

        // --- UI Laden nach Start --- //
        private void UpdateUIAfterFileLoad()
        {
            // Grundlegende Informationen anzeigen
            tb_version.Text = loadedJsonData.Version;
            cb_autoCalculation.Checked = Convert.ToBoolean(loadedJsonData.EnableAutoCalculation);
            cb_autoDestockAtRestart.Checked = Convert.ToBoolean(loadedJsonData.EnableAutoDestockAtRestart);
            cb_defaultTraderStock.Checked = Convert.ToBoolean(loadedJsonData.EnableDefaultTraderStock);

            // Kategorien und Produkte in den ListViews anzeigen
            lv_products.Items.Clear();
            lv_products.Groups.Clear();

            foreach (var category in loadedJsonData.TraderCategories)
            {
                // ListView-Gruppe für die Kategorie erstellen
                ListViewGroup group = new ListViewGroup(category.CategoryName);
                lv_products.Groups.Add(group);

                foreach (var product in category.Products)
                {
                    // Produktinformationen aus der Datenzeichenkette extrahieren
                    string[] productData = product.Split(',');

                    if (productData.Length >= 6)
                    {
                        string productName = productData[0];
                        string productCoefficient = productData[1];
                        string maxStock = productData[2];
                        string tradeQuantity = productData[3];
                        string buyPrice = productData[4];
                        string sellPrice = productData[5];
                        string destockCoefficient = productData.Length >= 7 ? productData[6] : string.Empty;

                        // Produktobjekt erstellen und mit den Daten füllen
                        Product productObj = new Product
                        {
                            Name = productName,
                            Category = category.CategoryName,
                            Coefficient = productCoefficient,
                            MaxStock = maxStock,
                            TradeQuantity = tradeQuantity,
                            BuyPrice = buyPrice,
                            SellPrice = sellPrice,
                            DestockCoefficient = destockCoefficient
                        };

                        // ListViewItem erstellen und zur Produkte-ListView hinzufügen
                        ListViewItem item = new ListViewItem(productName);
                        item.SubItems.Add(productCoefficient);
                        item.SubItems.Add(maxStock);
                        item.SubItems.Add(tradeQuantity);
                        item.SubItems.Add(buyPrice);
                        item.SubItems.Add(sellPrice);
                        item.SubItems.Add(destockCoefficient);
                        item.SubItems.Add(string.Empty); // Platzhalter für die ID-Spalte
                        item.Group = group;
                        item.Tag = productObj; // Produktobjekt als Tag speichern
                        lv_products.Items.Add(item);
                    }
                }
            }

            lv_products.Enabled = true;

            btn_addProduct.Enabled = true;
            btn_deleteCategory.Enabled = true;
            btn_deleteProduct.Enabled = true;
            btn_search.Enabled = true;
            btn_searchCategory.Enabled = true;
            btn_setAll_sellPrice.Enabled = true;
            btn_setAll_buyPrice.Enabled = true;
            btn_setAll_quantity.Enabled = true;
            btn_setAll_maxStock.Enabled = true;
            btn_setAll_coefficient.Enabled = true;
            btn_setAll_destock.Enabled = true;
            btn_nextEntry.Enabled = true;
            //btn_productUp.Enabled = true; // Coming soon
            //btn_productDown.Enabled = true; // Coming soon
            //btn_categoryUp.Enabled = true; // Coming soon
            //btn_categoryDown.Enabled = true; // Coming soon

            tb_productName.Enabled = true;
            tb_buyPrice.Enabled = true;
            tb_sellPrice.Enabled = true;
            tb_productCoefficient.Enabled = true;
            tb_maxStock.Enabled = true;
            tb_tradeQuantity.Enabled = true;
            tb_destock.Enabled = true;
            tb_searchBar.Enabled = true;
            tb_searchCategory.Enabled = true;

            cb_autoCalculation.Enabled = true;
            cb_autoDestockAtRestart.Enabled = true;
            cb_defaultTraderStock.Enabled = true;

            btn_closeFile.Visible = true;

            lv_categories.Enabled = true;
            tb_newCategoryName.Enabled = true;

            btn_exportFile.Enabled = false;
            btn_loadFile.Visible = false;

            UpdateCategoryListView();

            CreateProductIDs();
        }

        // --- ID erstellen --- //
        private void CreateProductIDs()
        {
            foreach (ListViewGroup group in lv_products.Groups)
            {
                int productID = 1;

                foreach (ListViewItem item in group.Items)
                {
                    item.SubItems[item.SubItems.Count - 1].Text = productID.ToString();
                    productID++;
                }
            }
        }

        // --- Kategorien in eigene Listview übernehmen --- //
        private void UpdateCategoryListView()
        {
            // Vorhandene Kategorien in der Reihenfolge der lv_products sichern
            List<string> existingCategories = new List<string>();
            foreach (ListViewGroup group in lv_products.Groups)
            {
                string groupName = group.Header;
                existingCategories.Add(groupName);
            }

            // Vorhandene Kategorien entfernen
            lv_categories.Items.Clear();

            // Kategorien in der Reihenfolge der lv_products in lv_categories übernehmen
            foreach (string category in existingCategories)
            {
                lv_categories.Items.Add(category);
            }
        }

        // --- Kategorien markieren --- //
        private void Lv_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_categories.SelectedItems[0];

                tb_newCategoryName.Text = selectedItem.SubItems[0].Text;
            }
        }

        // --- Zur Kategorie springen --- //
        private void Lv_categories_DoubleClick(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_categories.SelectedItems[0];

                tb_newCategoryName.Text = selectedItem.SubItems[0].Text;

                string categoryName = lv_categories.SelectedItems[0].Text;

                // Suchen der entsprechenden ListView-Gruppe in lv_products
                ListViewGroup selectedGroup = null;
                foreach (ListViewGroup group in lv_products.Groups)
                {
                    if (group.Header == categoryName)
                    {
                        selectedGroup = group;
                        break;
                    }
                }

                // Markieren und Anzeigen der Gruppe in lv_products
                lv_products.SelectedItems.Clear();
                lv_products.Focus();

                if (selectedGroup != null && selectedGroup.Items.Count > 0)
                {
                    // Den ersten Eintrag in der Gruppe markieren
                    selectedGroup.Items[0].Selected = true;
                    selectedGroup.Items[0].EnsureVisible();
                }
                else
                {
                    ShowNotification("No products in category. Add products first!", Resources.error, Color.LightCoral);

                    // Den doppelt geklickten Eintrag wieder markieren
                    selectedItem.Selected = true;
                    selectedItem.EnsureVisible();
                }
            }
        }

        // --- Kategorie hinzufügen --- //
        private void Btn_addCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_newCategoryName.Text))
            {
                string categoryName = tb_newCategoryName.Text;

                // Überprüfen, ob die Kategorie bereits vorhanden ist
                bool categoryExists = false;
                foreach (ListViewItem item in lv_categories.Items)
                {
                    if (item.Text == categoryName)
                    {
                        categoryExists = true;
                        break;
                    }
                }

                if (!categoryExists)
                {
                    // Erstellen eines neuen ListViewItem mit dem Wert aus der Textbox
                    string[] categoryData = new string[]
                    {
                        categoryName
                    };
                    ListViewItem newCategoryItem = new ListViewItem(categoryData);

                    // Hinzufügen des neuen Eintrags zur lv_categories
                    lv_categories.Items.Add(newCategoryItem);

                    // Markieren des neuen Eintrags
                    newCategoryItem.Selected = true;
                    newCategoryItem.Focused = true;
                    lv_categories.Focus();
                    newCategoryItem.EnsureVisible();

                    // Zurücksetzen der Textbox
                    tb_newCategoryName.Clear();

                    // Erstellen einer neuen ListView-Gruppe in lv_products
                    ListViewGroup newCategoryGroup = new ListViewGroup(categoryName);
                    lv_products.Groups.Add(newCategoryGroup);

                    ShowNotification("Category successfully added!", Resources.okay, Color.LightGreen);

                    btn_exportFile.Enabled = true;
                }
                else
                {
                    ShowNotification("Category already exists!", Resources.error, Color.LightCoral);
                }
            }
        }

        // --- Kategorie löschen --- //
        private void Btn_deleteCategory_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_categories.SelectedItems[0];

                // ListView-Gruppe für die ausgewählte Kategorie finden und entfernen
                string categoryName = selectedItem.Text;
                ListViewGroup categoryGroup = lv_products.Groups.Cast<ListViewGroup>()
                    .FirstOrDefault(group => group.Header == categoryName);

                if (categoryGroup != null)
                {
                    // Produkte der Kategorie aus der lv_products entfernen
                    List<ListViewItem> itemsToRemove = new List<ListViewItem>();
                    foreach (ListViewItem item in categoryGroup.Items)
                    {
                        itemsToRemove.Add(item);
                    }

                    foreach (ListViewItem itemToRemove in itemsToRemove)
                    {
                        lv_products.Items.Remove(itemToRemove);
                    }

                    // ListView-Gruppe entfernen
                    lv_products.Groups.Remove(categoryGroup);
                }

                // Kategorie aus lv_categories entfernen
                lv_categories.Items.Remove(selectedItem);

                ShowNotification("Category successfully deleted!", Resources.warn, Color.LightCoral);

                btn_exportFile.Enabled = true;
            }
        }

        // --- Neue Kategorie Button aktivieren --- //
        private void Tb_newCategoryName_TextChanged(object sender, EventArgs e)
        {
            ENABLENEWCATEGORYBUTTON();
        }

        private void ENABLENEWCATEGORYBUTTON()
        {
            if (tb_newCategoryName.Text == string.Empty)
            {
                btn_addCategory.Enabled = false;
            }
            else
            {
                btn_addCategory.Enabled = true;
            }
        }

        // --- Produkt markieren --- //
        private void Lv_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_products.SelectedItems[0];

                tb_productName.Text = selectedItem.SubItems[0].Text;
                tb_productCoefficient.Text = selectedItem.SubItems[1].Text;
                tb_maxStock.Text = selectedItem.SubItems[2].Text;
                tb_tradeQuantity.Text = selectedItem.SubItems[3].Text;
                tb_buyPrice.Text = selectedItem.SubItems[4].Text;
                tb_sellPrice.Text = selectedItem.SubItems[5].Text;

                ListViewGroup selectedGroup = selectedItem.Group;
                string categoryName = selectedGroup.Header;

                tb_newCategoryName.Text = categoryName; // Eintragen des Kategorienamens in tb_newCategory

                foreach (ListViewItem categoryItem in lv_categories.Items)
                {
                    if (categoryItem.Text == categoryName)
                    {
                        categoryItem.Selected = true;
                        categoryItem.EnsureVisible();
                        break;
                    }
                }

                // Aktualisiere den aktuellen Eintrag
                currentEntryIndex = selectedItem.Index;

                // Überprüfe, ob ein Destock-Koeffizient vorhanden ist und aktualisiere das Textfeld tb_destock entsprechend
                if (selectedItem.SubItems.Count >= 7)
                {
                    string destockCoefficient = selectedItem.SubItems[6].Text;
                    tb_destock.Text = destockCoefficient;
                }
                else
                {
                    tb_destock.Text = string.Empty;
                }
            }
            else
            {
                tb_productName.Text = string.Empty;
                tb_productCoefficient.Text = string.Empty;
                tb_maxStock.Text = string.Empty;
                tb_tradeQuantity.Text = string.Empty;
                tb_buyPrice.Text = string.Empty;
                tb_sellPrice.Text = string.Empty;
                tb_newCategoryName.Text = string.Empty; // Zurücksetzen des Kategorienamens
                tb_destock.Text = string.Empty; // Zurücksetzen des Destock-Koeffizienten

                // Kein Eintrag ausgewählt, setze den aktuellen Eintrag auf -1
                currentEntryIndex = -1;
            }
        }

        // --- Produkt speichern --- //
        private void SaveProduct_Click(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_products.SelectedItems[0];

                string originalProductName = selectedItem.SubItems[0].Text;
                string originalProductCoefficient = selectedItem.SubItems[1].Text;
                string originalMaxStock = selectedItem.SubItems[2].Text;
                string originalTradeQuantity = selectedItem.SubItems[3].Text;
                string originalBuyPrice = selectedItem.SubItems[4].Text;
                string originalSellPrice = selectedItem.SubItems[5].Text;
                string originalDestockCoefficient = selectedItem.SubItems[6].Text;

                string newProductName = tb_productName.Text;
                string newProductCoefficient = tb_productCoefficient.Text;
                string newMaxStock = tb_maxStock.Text;
                string newTradeQuantity = tb_tradeQuantity.Text;
                string newBuyPrice = tb_buyPrice.Text;
                string newSellPrice = tb_sellPrice.Text;
                string newDestockCoefficient = tb_destock.Text;

                // Überprüfen, ob sich die Werte geändert haben
                bool isModified = (originalProductName != newProductName) ||
                    (originalProductCoefficient != newProductCoefficient) ||
                    (originalMaxStock != newMaxStock) ||
                    (originalTradeQuantity != newTradeQuantity) ||
                    (originalBuyPrice != newBuyPrice) ||
                    (originalSellPrice != newSellPrice) ||
                    (originalDestockCoefficient != newDestockCoefficient);

                if (isModified)
                {
                    selectedItem.SubItems[0].Text = newProductName;
                    selectedItem.SubItems[1].Text = newProductCoefficient;
                    selectedItem.SubItems[2].Text = newMaxStock;
                    selectedItem.SubItems[3].Text = newTradeQuantity;
                    selectedItem.SubItems[4].Text = newBuyPrice;
                    selectedItem.SubItems[5].Text = newSellPrice;
                    selectedItem.SubItems[6].Text = newDestockCoefficient;
                    selectedItem.BackColor = Color.LightPink;

                    ShowNotification("Product successfully saved!", Resources.okay, Color.LightGreen);

                    btn_exportFile.Enabled = true;
                }
            }

            if (lv_products.Items.Count > 0)
            {
                if (currentEntryIndex == -1)
                {
                    // Wenn kein Eintrag markiert ist, mit dem ersten Eintrag starten
                    if (lv_products.SelectedItems.Count > 0)
                    {
                        currentEntryIndex = lv_products.SelectedItems[0].Index;
                    }
                    else
                    {
                        currentEntryIndex = 0;
                    }
                }
                else
                {
                    // Den nächsten Eintrag markieren und anzeigen
                    currentEntryIndex++;
                    if (currentEntryIndex >= lv_products.Items.Count)
                    {
                        currentEntryIndex = 0; // Falls das Ende erreicht ist, zurück zum Anfang gehen
                    }
                }

                lv_products.Items[currentEntryIndex].Selected = true;
                lv_products.Items[currentEntryIndex].EnsureVisible();
            }
        }

        // --- Produkt hinzufügen --- //
        private void Btn_addProduct_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;

                if (!string.IsNullOrWhiteSpace(tb_productName.Text) && !string.IsNullOrWhiteSpace(tb_productCoefficient.Text) &&
                    !string.IsNullOrWhiteSpace(tb_maxStock.Text) && !string.IsNullOrWhiteSpace(tb_tradeQuantity.Text) &&
                    !string.IsNullOrWhiteSpace(tb_buyPrice.Text) && !string.IsNullOrWhiteSpace(tb_sellPrice.Text))
                {
                    // Erstellen eines neuen Product-Objekts mit den Werten aus den Textboxen
                    string productName = tb_productName.Text;
                    string productCoefficient = tb_productCoefficient.Text;
                    string maxStock = tb_maxStock.Text;
                    string tradeQuantity = tb_tradeQuantity.Text;
                    string buyPrice = tb_buyPrice.Text;
                    string sellPrice = tb_sellPrice.Text;

                    string destockCoefficient = string.Empty; // Standardwert für den Destock-Koeffizienten

                    if (!string.IsNullOrWhiteSpace(tb_destock.Text))
                    {
                        destockCoefficient = tb_destock.Text; // Wert aus der Textbox nur verwenden, wenn sie nicht leer ist
                    }

                    Product productObj = new Product
                    {
                        Name = productName,
                        Category = categoryName,
                        Coefficient = productCoefficient,
                        MaxStock = maxStock,
                        TradeQuantity = tradeQuantity,
                        BuyPrice = buyPrice,
                        SellPrice = sellPrice,
                        DestockCoefficient = destockCoefficient
                    };

                    // Überprüfen, ob die Kategorie-Gruppe bereits vorhanden ist, sonst erstellen
                    ListViewGroup categoryGroup = null;
                    foreach (ListViewGroup group in lv_products.Groups)
                    {
                        if (group.Header == categoryName)
                        {
                            categoryGroup = group;
                            break;
                        }
                    }

                    if (categoryGroup == null)
                    {
                        categoryGroup = new ListViewGroup(categoryName);
                        lv_products.Groups.Add(categoryGroup);
                    }

                    // Bestimme die ID für den neuen Eintrag
                    int productID = 1;

                    // Prüfe den letzten Eintrag der ausgewählten ListView-Gruppe
                    if (lv_products.SelectedItems.Count > 0)
                    {
                        ListViewGroup selectedGroup = lv_products.SelectedItems[0].Group;
                        if (selectedGroup.Items.Count > 0)
                        {
                            ListViewItem lastItemInGroup = selectedGroup.Items[selectedGroup.Items.Count - 1];
                            if (int.TryParse(lastItemInGroup.SubItems[lastItemInGroup.SubItems.Count - 1].Text, out int lastItemID))
                            {
                                productID = lastItemID + 1;
                            }
                        }
                    }

                    // Erstellen eines neuen ListViewItems mit den Werten aus den Textboxen
                    string[] productData = new string[]
                    {
                        productName,
                        productCoefficient,
                        maxStock,
                        tradeQuantity,
                        buyPrice,
                        sellPrice,
                        destockCoefficient,
                        productID.ToString()
                    };

                    ListViewItem newItem = new ListViewItem(productData)
                    {
                        Group = categoryGroup,
                        Tag = productObj,
                        BackColor = Color.LightPink
                    };

                    // Hinzufügen des neuen Eintrags zur lv_products
                    lv_products.Items.Add(newItem);

                    // Markieren und Anzeigen des neuen Eintrags
                    newItem.Selected = true;
                    newItem.Focused = true;
                    lv_products.Focus();
                    newItem.EnsureVisible();

                    ShowNotification("Product successfully added!", Resources.okay, Color.LightGreen);

                    btn_exportFile.Enabled = true;
                }
                else
                {
                    ShowNotification("Fill all the boxes!", Resources.error, Color.LightCoral);
                }
            }
        }

        // --- Produkt löschen --- //
        private void Btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_products.SelectedItems[0];
                lv_products.Items.Remove(selectedItem);

                ShowNotification("Product successfully deleted!", Resources.warn, Color.Beige);

                btn_exportFile.Enabled = true;
            }
        }

        // --- Produkt Suche Button--- //
        private void Btn_search_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // --- Produkt Suche Enter --- //
        private void Tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // --- Produkt Suche Methode --- //
        private async void PerformSearch()
        {
            string searchText = tb_searchBar.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                ListViewItem foundItem = lv_products.Items.Cast<ListViewItem>()
                    .FirstOrDefault(item => item.SubItems
                        .Cast<ListViewItem.ListViewSubItem>()
                        .Any(subItem => subItem.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0));

                if (foundItem != null)
                {
                    lv_products.SelectedItems.Clear();
                    foundItem.Selected = true;
                    foundItem.EnsureVisible();
                }
                else
                {
                    await ShowNotification("No product found!", Properties.Resources.okay, Color.LightGreen);
                }
            }
            else
            {
                await ShowNotification("Please enter a search term.", Properties.Resources.warn, Color.LightCoral);
            }
        }

        // --- SetAll coeff --- //
        private void Btn_setAll_coefficient_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;
                string newCoefficient = tb_productCoefficient.Text;
                bool isAnyValueChanged = false;

                foreach (ListViewItem item in lv_products.Items)
                {
                    if (item.Group.Header == categoryName)
                    {
                        string currentCoefficient = item.SubItems[1].Text;

                        if (currentCoefficient != newCoefficient)
                        {
                            item.SubItems[1].Text = newCoefficient;
                            item.BackColor = Color.LightPink;
                            isAnyValueChanged = true;
                        }
                    }
                }

                if (isAnyValueChanged)
                {
                    btn_exportFile.Enabled = true;

                    ShowNotification("Coefficient updated for applicable products in the category.", Resources.okay, Color.LightGreen);
                }
                else if (!isAnyValueChanged)
                {
                    ShowNotification("All Product already have the same coefficient value.", Resources.warn, Color.Beige);
                }
            }
            else
            {
                ShowNotification("No category selected. Please select a category first.", Resources.error, Color.LightCoral);
            }
        }

        // --- SetAll maxStock --- //
        private void Btn_setAll_maxStock_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;
                string newMaxStock = tb_maxStock.Text;
                bool isAnyValueChanged = false;

                foreach (ListViewItem item in lv_products.Items)
                {
                    if (item.Group.Header == categoryName)
                    {
                        string currentMaxStock = item.SubItems[2].Text;

                        if (currentMaxStock != newMaxStock)
                        {
                            item.SubItems[2].Text = newMaxStock;
                            item.BackColor = Color.LightPink;
                            isAnyValueChanged = true;
                        }
                    }
                }

                if (isAnyValueChanged)
                {
                    btn_exportFile.Enabled = true;

                    ShowNotification("Max stock updated for applicable products in the category.", Resources.okay, Color.LightGreen);
                }
                else if (!isAnyValueChanged)
                {
                    ShowNotification("All Product already have the same max stock value.", Resources.warn, Color.Beige);
                }
            }
            else
            {
                ShowNotification("No category selected. Please select a category first.", Resources.error, Color.LightCoral);
            }
        }

        // --- SetAll qty --- //
        private void Btn_setAll_quantity_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;
                string newTradeQuantity = tb_tradeQuantity.Text;
                bool isAnyValueChanged = false;

                foreach (ListViewItem item in lv_products.Items)
                {
                    if (item.Group.Header == categoryName)
                    {
                        string currentTradeQuantity = item.SubItems[3].Text;

                        if (currentTradeQuantity != newTradeQuantity)
                        {
                            item.SubItems[3].Text = newTradeQuantity;
                            item.BackColor = Color.LightPink;
                            isAnyValueChanged = true;
                        }
                    }
                }

                if (isAnyValueChanged)
                {
                    btn_exportFile.Enabled = true;

                    ShowNotification("Trade quantity updated for applicable products in the category.", Resources.okay, Color.LightGreen);
                }
                else if (!isAnyValueChanged)
                {
                    ShowNotification("All Product already have the same trade quantity value.", Resources.warn, Color.Beige);
                }
            }
            else
            {
                ShowNotification("No category selected. Please select a category first.", Resources.error, Color.LightCoral);
            }
        }

        // --- SetAll EK --- //
        private void Btn_setAll_buyPrice_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;
                string newBuyPrice = tb_buyPrice.Text;
                bool isAnyValueChanged = false;

                foreach (ListViewItem item in lv_products.Items)
                {
                    if (item.Group.Header == categoryName)
                    {
                        string currentBuyPrice = item.SubItems[4].Text;

                        if (currentBuyPrice != newBuyPrice)
                        {
                            item.SubItems[4].Text = newBuyPrice;
                            item.BackColor = Color.LightPink;
                            isAnyValueChanged = true;
                        }
                    }
                }

                if (isAnyValueChanged)
                {
                    btn_exportFile.Enabled = true;

                    ShowNotification("Buy price updated for applicable products in the category.", Resources.okay, Color.LightGreen);
                }
                else if (!isAnyValueChanged)
                {
                    ShowNotification("All Product already have the same buy price value.", Resources.warn, Color.Beige);
                }
            }
            else
            {
                ShowNotification("No category selected. Please select a category first.", Resources.error, Color.LightCoral);
            }
        }

        // --- SetAll VK --- //
        private void Btn_setAll_sellPrice_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;
                string newSellPrice = tb_sellPrice.Text;
                bool isAnyValueChanged = false;

                foreach (ListViewItem item in lv_products.Items)
                {
                    if (item.Group.Header == categoryName)
                    {
                        string currentSellPrice = item.SubItems[5].Text;

                        if (currentSellPrice != newSellPrice)
                        {
                            item.SubItems[5].Text = newSellPrice;
                            item.BackColor = Color.LightPink;
                            isAnyValueChanged = true;
                        }
                    }
                }

                if (isAnyValueChanged)
                {
                    btn_exportFile.Enabled = true;

                    ShowNotification("Sell price updated for applicable products in the category.", Resources.okay, Color.LightGreen);
                }
                else if (!isAnyValueChanged)
                {
                    ShowNotification("All Product already have the same sell price value.", Resources.warn, Color.Beige);
                }
            }
            else
            {
                ShowNotification("No category selected. Please select a category first.", Resources.error, Color.LightCoral);
            }
        }

        // --- SetAll Destock --- //
        private void Btn_setAll_destock_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;
                string newDestockCoefficient = tb_destock.Text;
                bool isAnyValueChanged = false;

                foreach (ListViewItem item in lv_products.Items)
                {
                    if (item.Group.Header == categoryName)
                    {
                        string currentDestockCoefficient = item.SubItems[6].Text;

                        if (currentDestockCoefficient != newDestockCoefficient)
                        {
                            item.SubItems[6].Text = newDestockCoefficient;
                            item.BackColor = Color.LightPink;
                            isAnyValueChanged = true;
                        }
                    }
                }

                if (isAnyValueChanged)
                {
                    btn_exportFile.Enabled = true;
                    ShowNotification("Destock coefficient updated for applicable products in the category.", Resources.okay, Color.LightGreen);
                }
                else if (!isAnyValueChanged)
                {
                    ShowNotification("All Product already have the same destock coefficient value.", Resources.warn, Color.Beige);
                }
            }
            else
            {
                ShowNotification("No category selected. Please select a category first.", Resources.error, Color.LightCoral);
            }
        }

        // --- KontextMenü Switch ID --- //
        private void toggleProductIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleProductIdToolStripMenuItem.Checked)
            {
                lv_products.Columns[7].Width = 50;
                lv_products.Columns[0].Width = 240;
            }
            else
            {
                lv_products.Columns[7].Width = 0;
                lv_products.Columns[0].Width = 290;
            }
        }
    }
}
