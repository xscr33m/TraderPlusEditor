using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraderPlusEditor
{
    public partial class F_Main : Form
    {
        static public string editorFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TraderPlusEditor");
        private string filePath;
        private JsonData jsonData;

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
            menuStrip1.Renderer = new CustomMenuRenderer();
            ShowNotification("xscr33m's TraderPlusEditor successfully startet!", Properties.Resources.okay, Color.Beige);
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

        private async void ShowNotification(string text, Image image, Color panelColor)
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

            // Warte für 5 Sekunden
            await Task.Delay(5000);

            // Blende das Panel und das Label aus
            pnl_pushNotifications.Visible = false;
            lbl_pushNotifications.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (*.json)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lv_categories.Items.Clear();
                lv_products.Items.Clear();

                filePath = openFileDialog.FileName;

                // Originaldatei sichern //
                //string backupFileName = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}_{Path.GetFileName(filePath)}";
                //string backupFolderPath = editorFolderPath;
                //string backupFilePath = Path.Combine(backupFolderPath, backupFileName);
                //File.Copy(filePath, backupFilePath);

                string json = File.ReadAllText(filePath);
                jsonData = JsonConvert.DeserializeObject<JsonData>(json);

                tb_version.Text = jsonData.Version;
                cb_autoCalculation.Checked = Convert.ToBoolean(jsonData.EnableAutoCalculation);
                cb_autoDestockAtRestart.Checked = Convert.ToBoolean(jsonData.EnableAutoDestockAtRestart);
                cb_defaultTraderStock.Checked = Convert.ToBoolean(jsonData.EnableDefaultTraderStock);

                lv_categories.Items.Clear();
                lv_products.Items.Clear();
                foreach (var category in jsonData.TraderCategories)
                {
                    lv_categories.Items.Add(category.CategoryName);
                }

                cb_autoCalculation.Enabled = true;
                cb_autoDestockAtRestart.Enabled = true;
                cb_defaultTraderStock.Enabled = true;
                btn_addProduct.Enabled = true;
                // btn_addCategory.Enabled = true; 
                btn_deleteCategory.Enabled = true;
                btn_deleteProduct.Enabled = true;
                btn_saveProduct.Enabled = true;
                // btn_setToAllProducts.Enabled = true;  
                btn_prevEntry.Enabled = true;
                btn_nextEntry.Enabled = true;
                lv_categories.Enabled = true;
                lv_products.Enabled = true;
                tb_version.Enabled = true;
                tb_productName.Enabled = true;
                tb_newCategoryName.Enabled = true;
                tb_buyPrice.Enabled = true;
                tb_sellPrice.Enabled = true;
                tb_productCoefficient.Enabled = true;
                tb_maxStock.Enabled = true;
                tb_tradeQuantity.Enabled = true;

                ShowNotification("PriceConfig successfully importet!", Properties.Resources.okay, Color.Beige);
            }
        }

        private void lv_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_products.Items.Clear();

            if (lv_categories.SelectedItems.Count > 0)
            {
                string categoryName = lv_categories.SelectedItems[0].Text;

                foreach (var category in jsonData.TraderCategories)
                {
                    if (category.CategoryName == categoryName)
                    {
                        foreach (var product in category.Products)
                        {
                            string[] productData = product.Split(',');
                            ListViewItem item = new ListViewItem(productData);
                            lv_products.Items.Add(item);
                        }
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
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob alle Textboxen Werte enthalten
            if (!string.IsNullOrWhiteSpace(tb_productName.Text) && !string.IsNullOrWhiteSpace(tb_productCoefficient.Text) &&
                !string.IsNullOrWhiteSpace(tb_maxStock.Text) && !string.IsNullOrWhiteSpace(tb_tradeQuantity.Text) &&
                !string.IsNullOrWhiteSpace(tb_buyPrice.Text) && !string.IsNullOrWhiteSpace(tb_sellPrice.Text))
            {
                // Erstellen eines neuen ListViewItem mit den Werten aus den Textboxen
                string[] productData = new string[]
                {
                    tb_productName.Text,
                    tb_productCoefficient.Text,
                    tb_maxStock.Text,
                    tb_tradeQuantity.Text,
                    tb_buyPrice.Text,
                    tb_sellPrice.Text
                };
                ListViewItem newItem = new ListViewItem(productData);

                // Hinzufügen des neuen Eintrags zur lv_products
                lv_products.Items.Add(newItem);

                // Markieren des neuen Eintrags
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
            }
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_products.SelectedItems[0];
                lv_products.Items.Remove(selectedItem);

                ShowNotification("Product successfully deleted!", Properties.Resources.warn, Color.Orange);
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
                // Erstellen eines neuen ListViewItem mit dem Wert aus der Textbox
                string[] productData = new string[]
                {
                    tb_newCategoryName.Text
                };
                ListViewItem newItem = new ListViewItem(productData);

                // Hinzufügen des neuen Eintrags zur lv_categories
                lv_categories.Items.Add(newItem);

                // Markieren des neuen Eintrags
                newItem.Selected = true;
                newItem.Focused = true;
                lv_categories.Focus();
                newItem.EnsureVisible();

                // Zurücksetzen der Textbox
                tb_newCategoryName.Clear();

                ShowNotification("Category successfully added!", Properties.Resources.okay, Color.Beige);
            }
        }

        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            if (lv_categories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_categories.SelectedItems[0];
                lv_categories.Items.Remove(selectedItem);

                ShowNotification("Category successfully deleted!", Properties.Resources.warn, Color.Orange);
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Daten aus den Steuerelementen lesen
                string version = tb_version.Text;
                int enableAutoCalculation = Convert.ToInt32(cb_autoCalculation.Checked);
                int enableAutoDestock = Convert.ToInt32(cb_autoDestockAtRestart.Checked);
                int enableDefaultTraderStock = Convert.ToInt32(cb_defaultTraderStock.Checked);

                List<Category> traderCategories = new List<Category>();
                foreach (ListViewItem categoryItem in lv_categories.Items)
                {
                    string categoryName = categoryItem.Text;
                    List<string> products = new List<string>();

                    // Produkte für die aktuelle Kategorie aus der lv_products ListView lesen
                    foreach (ListViewItem productItem in lv_products.Items)
                    {
                        if (productItem.Group.Header == categoryName)
                        {
                            string product = productItem.Text;
                            products.Add(product);
                        }
                    }

                    // Category-Objekt erstellen und zur Liste hinzufügen
                    Category category = new Category
                    {
                        CategoryName = categoryName,
                        Products = products
                    };
                    traderCategories.Add(category);
                }

                // JsonData-Objekt erstellen
                JsonData jsonData = new JsonData
                {
                    Version = version,
                    EnableAutoCalculation = enableAutoCalculation,
                    EnableAutoDestockAtRestart = enableAutoDestock,
                    EnableDefaultTraderStock = enableDefaultTraderStock,
                    TraderCategories = traderCategories
                };

                // JSON-Datei speichern
                string json = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
        }
    }
}
