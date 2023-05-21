﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraderPlusEditor
{
    public partial class F_Main : Form
    {
        static public string editorFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TraderPlusEditor", "EXPORTS");
        private string filePath;
        private JsonData loadedJsonData;

        public F_Main()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        private const int SW_SHOWNORMAL = 1;

        private void F_Main_Load(object sender, EventArgs e)
        {
            CHECKFORINSTANCE();
            GENERATEPATH();
            // menuStrip1.Renderer = new CustomMenuRenderer();
            ShowNotification("xscr33m's TraderPlusEditor successfully started!", Properties.Resources.okay, Color.Beige);
        }

        private async void CHECKFORINSTANCE()
        {
            Process[] processes = Process.GetProcessesByName("TraderPlusEditor");
            if (processes.Length > 1)
            {
                for (int i = 0; i < processes.Length; i++)
                {
                    Process runningProcess = processes[i];
                    if (runningProcess.MainWindowHandle == GetForegroundWindow())
                    {
                        continue;
                    }
                    else
                    {
                        ShowWindow(runningProcess.MainWindowHandle, SW_SHOWNORMAL);
                        SetForegroundWindow(runningProcess.MainWindowHandle);
                        Application.Exit();
                    }
                }
            }
            await Task.Delay(2000);
        }

        private void GENERATEPATH()
        {
            if (!Directory.Exists(editorFolderPath))
            {
                Directory.CreateDirectory(editorFolderPath);
            }
        }

        private async Task ShowNotification(string text, Image image, Color panelColor)
        {
            // Setze den Text des Labels
            lbl_pushNotifications.Text = text;

            // Setze das Bild des Labels
            lbl_pushNotifications.Image = image;

            // Setze die Farbe des Panels
            pnl_pushNotifications.BackColor = panelColor;

            // Warte für 1 Sekunden
            await Task.Delay(1000);

            // Mache das Panel und das Label sichtbar
            pnl_pushNotifications.Visible = true;
            lbl_pushNotifications.Visible = true;

            // Warte für 5 Sekunden
            await Task.Delay(5000);

            // Blende das Panel und das Label aus
            pnl_pushNotifications.Visible = false;
            lbl_pushNotifications.Visible = false;
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (TraderPlusPriceConfig.json)|TraderPlusPriceConfig.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dateipfad speichern
                filePath = openFileDialog.FileName;

                // JSON-Datei lesen und deserialisieren
                string json = File.ReadAllText(filePath);
                loadedJsonData = JsonConvert.DeserializeObject<JsonData>(json);

                // Grundlegende Informationen anzeigen
                tb_version.Text = loadedJsonData.Version;
                cb_autoCalculation.Checked = Convert.ToBoolean(loadedJsonData.EnableAutoCalculation);
                cb_autoDestockAtRestart.Checked = Convert.ToBoolean(loadedJsonData.EnableAutoDestockAtRestart);
                cb_defaultTraderStock.Checked = Convert.ToBoolean(loadedJsonData.EnableDefaultTraderStock);

                // Kategorien und Produkte in den ListViews anzeigen
                lv_categories.Items.Clear();
                lv_products.Items.Clear();

                foreach (var category in loadedJsonData.TraderCategories)
                {
                    // Kategorie zur Kategorien-ListView hinzufügen
                    lv_categories.Items.Add(category.CategoryName);

                    // ListView-Gruppe für die Kategorie erstellen
                    ListViewGroup group = new ListViewGroup(category.CategoryName);
                    lv_products.Groups.Add(group);

                    foreach (var product in category.Products)
                    {
                        // Produktinformationen aus der Datenzeichenkette extrahieren
                        string[] productData = product.Split(',');

                        if (productData.Length == 6)
                        {
                            string productName = productData[0];
                            string productCoefficient = productData[1];
                            string maxStock = productData[2];
                            string tradeQuantity = productData[3];
                            string buyPrice = productData[4];
                            string sellPrice = productData[5];

                            // Produktobjekt erstellen und mit den Daten füllen
                            Product productObj = new Product
                            {
                                Name = productName,
                                Category = category.CategoryName,
                                Coefficient = productCoefficient,
                                MaxStock = maxStock,
                                TradeQuantity = tradeQuantity,
                                BuyPrice = buyPrice,
                                SellPrice = sellPrice
                            };

                            // ListViewItem erstellen und zur Produkte-ListView hinzufügen
                            ListViewItem item = new ListViewItem(productName);
                            item.SubItems.Add(productCoefficient);
                            item.SubItems.Add(maxStock);
                            item.SubItems.Add(tradeQuantity);
                            item.SubItems.Add(buyPrice);
                            item.SubItems.Add(sellPrice);
                            item.Group = group;
                            item.Tag = productObj; // Produktobjekt als Tag speichern
                            lv_products.Items.Add(item);
                        }
                    }
                }

                cb_autoCalculation.Enabled = true;
                cb_autoDestockAtRestart.Enabled = true;
                cb_defaultTraderStock.Enabled = true;

                btn_closeFile.Visible = true;

                lv_categories.Enabled = true; 
                tb_newCategoryName.Enabled = true;

                btn_exportFile.Enabled = false;
                btn_loadFile.Visible = false;

                ShowNotification("PriceConfig successfully importet!", Properties.Resources.okay, Color.Beige);
            }
        }

        private void btn_exportFile_Click(object sender, EventArgs e)
        {
            if (loadedJsonData != null)
            {
                // Übertrage die Änderungen aus den ListViews zurück in die loadedJsonData-Instanz

                // Kategorien aktualisieren
                loadedJsonData.TraderCategories.Clear();
                foreach (ListViewGroup group in lv_products.Groups)
                {
                    string categoryName = group.Header;
                    List<string> products = new List<string>();

                    // Produkte für die Kategorie sammeln
                    foreach (ListViewItem item in group.Items)
                    {
                        string productName = item.SubItems[0].Text;
                        string productCoefficient = item.SubItems[1].Text;
                        string maxStock = item.SubItems[2].Text;
                        string tradeQuantity = item.SubItems[3].Text;
                        string buyPrice = item.SubItems[4].Text;
                        string sellPrice = item.SubItems[5].Text;

                        string productData = $"{productName},{productCoefficient},{maxStock},{tradeQuantity},{buyPrice},{sellPrice}";
                        products.Add(productData);
                    }

                    Category category = new Category
                    {
                        CategoryName = categoryName,
                        Products = products
                    };

                    loadedJsonData.TraderCategories.Add(category);
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

                ShowNotification("Data successfully saved!", Properties.Resources.okay, Color.Beige);

                btn_exportFile.Enabled = false;
            }
        }

        private void btn_closeFile_Click(object sender, EventArgs e)
        {
            // Daten zurücksetzen
            loadedJsonData = null;
            filePath = string.Empty;

            Application.Restart();
        } 

        private void lv_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                lv_products.Enabled = true;

                btn_addProduct.Enabled = true;
                btn_deleteCategory.Enabled = true;
                btn_deleteProduct.Enabled = true;
                btn_saveProduct.Enabled = true;
                btn_prevEntry.Enabled = true;
                btn_nextEntry.Enabled = true;
                btn_search.Enabled = true;
                btn_setToAllProducts.Enabled = false;
                btn_search.Enabled = true;

                tb_productName.Enabled = true;
                tb_buyPrice.Enabled = true;
                tb_sellPrice.Enabled = true;
                tb_productCoefficient.Enabled = true;
                tb_maxStock.Enabled = true;
                tb_tradeQuantity.Enabled = true;
                tb_searchBar.Enabled = true;

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

                if (selectedGroup != null)
                {
                    // Scrollen zur Gruppe
                    if (selectedGroup.Items.Count > 0)
                        lv_products.EnsureVisible(lv_products.Items.IndexOf(selectedGroup.Items[0]));

                    else
                    {
                        ShowNotification("No products in category. Add products first!", Properties.Resources.error, Color.Beige);
                    }
                }
            }
        }

        private void lv_products_SelectedIndexChanged(object sender, EventArgs e)
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

                foreach (ListViewItem categoryItem in lv_categories.Items)
                {
                    if (categoryItem.Text == categoryName)
                    {
                        categoryItem.Selected = true;
                        categoryItem.EnsureVisible();
                        break;
                    }
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
            }
        }

        private void btn_saveProduct_Click(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_products.SelectedItems[0];

                selectedItem.SubItems[0].Text = tb_productName.Text;
                selectedItem.SubItems[1].Text = tb_productCoefficient.Text;
                selectedItem.SubItems[2].Text = tb_maxStock.Text;
                selectedItem.SubItems[3].Text = tb_tradeQuantity.Text;
                selectedItem.SubItems[4].Text = tb_buyPrice.Text;
                selectedItem.SubItems[5].Text = tb_sellPrice.Text;
                selectedItem.BackColor = Color.LightPink;

                ShowNotification("Product successfully saved!", Properties.Resources.okay, Color.Beige);

                btn_exportFile.Enabled = true;
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
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

                    Product productObj = new Product
                    {
                        Name = productName,
                        Category = categoryName,
                        Coefficient = productCoefficient,
                        MaxStock = maxStock,
                        TradeQuantity = tradeQuantity,
                        BuyPrice = buyPrice,
                        SellPrice = sellPrice
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

                    // Erstellen eines neuen ListViewItems mit den Werten aus den Textboxen
                    string[] productData = new string[]
                    {
                        productName,
                        productCoefficient,
                        maxStock,
                        tradeQuantity,
                        buyPrice,
                        sellPrice
                    };
                    ListViewItem newItem = new ListViewItem(productData);
                    newItem.Group = categoryGroup;
                    newItem.Tag = productObj;

                    // Hinzufügen des neuen Eintrags zur lv_products
                    lv_products.Items.Add(newItem);

                    // Markieren und Anzeigen des neuen Eintrags
                    newItem.Selected = true;
                    newItem.Focused = true;
                    lv_products.Focus();
                    newItem.EnsureVisible();

                    // Zurücksetzen der Textboxen
                    tb_productName.Clear();
                    tb_productCoefficient.Clear();
                    tb_maxStock.Clear();
                    tb_tradeQuantity.Clear();
                    tb_buyPrice.Clear();
                    tb_sellPrice.Clear();

                    ShowNotification("Product successfully added!", Properties.Resources.okay, Color.Beige);

                    btn_exportFile.Enabled = true;
                }
                else
                {
                    ShowNotification("Fill all the boxes!", Properties.Resources.error, Color.LightCoral);
                }
            }
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_products.SelectedItems[0];
                lv_products.Items.Remove(selectedItem);

                ShowNotification("Product successfully deleted!", Properties.Resources.warn, Color.Beige);

                btn_exportFile.Enabled = true;
            }
        }

        private void btn_setToAllProducts_Click(object sender, EventArgs e)
        {
            // COMING_SOON
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
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

                    ShowNotification("Category successfully added!", Properties.Resources.okay, Color.Beige);

                    btn_exportFile.Enabled = true;
                }
                else
                {
                    ShowNotification("Category already exists!", Properties.Resources.error, Color.LightCoral);
                }
            }
        }

        private void btn_deleteCategory_Click(object sender, EventArgs e)
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

                ShowNotification("Category successfully deleted!", Properties.Resources.warn, Color.LightCoral);

                btn_exportFile.Enabled = true;
            }
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

        private void tb_newCategoryName_TextChanged(object sender, EventArgs e)
        {
            ENABLENEWCATEGORYBUTTON();
        }

        private void btn_prevEntry_Click(object sender, EventArgs e)
        {
            if (lv_products.Items.Count > 0)
            {
                int selectedIndex = lv_products.SelectedIndices.Count > 0 ? lv_products.SelectedIndices[0] : -1;
                int previousIndex = selectedIndex - 1;
                if (previousIndex < 0)
                    previousIndex = lv_products.Items.Count - 1;

                lv_products.Items[previousIndex].Selected = true;
                lv_products.Items[previousIndex].EnsureVisible();
            }
        }

        private void btn_nextEntry_Click(object sender, EventArgs e)
        {
            if (lv_products.Items.Count > 0)
            {
                int selectedIndex = lv_products.SelectedIndices.Count > 0 ? lv_products.SelectedIndices[0] : -1;
                int nextIndex = selectedIndex + 1;
                if (nextIndex >= lv_products.Items.Count)
                    nextIndex = 0;

                lv_products.Items[nextIndex].Selected = true;
                lv_products.Items[nextIndex].EnsureVisible();
            }
        }

        private void btn_searchProduct_Click(object sender, EventArgs e)
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
                    ShowNotification("No products found!", Properties.Resources.okay, Color.Beige);
                }
            }
            else
            {
                ShowNotification("Please enter a search term.", Properties.Resources.warn, Color.LightCoral);
            }
        }

        private void btn_openExports_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(editorFolderPath))
            {
                Process.Start("explorer.exe", editorFolderPath);
            }
            else
            {
                ShowNotification("The folder does not exist!", Properties.Resources.warn, Color.LightCoral);
            }
        }
    }
}
