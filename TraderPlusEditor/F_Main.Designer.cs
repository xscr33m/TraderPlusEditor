namespace TraderPlusEditor
{
    partial class F_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lv_products = new System.Windows.Forms.ListView();
            this.product_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_coeffcient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_maxStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_tradeQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_buyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_sellPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_searchBar = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_setAll_coefficient = new System.Windows.Forms.Button();
            this.btn_setAll_maxStock = new System.Windows.Forms.Button();
            this.btn_setAll_quantity = new System.Windows.Forms.Button();
            this.btn_setAll_buyPrice = new System.Windows.Forms.Button();
            this.btn_nextEntry = new System.Windows.Forms.Button();
            this.btn_setAll_sellPrice = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_sellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_buyPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tradeQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_maxStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_productCoefficient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_donate = new System.Windows.Forms.Button();
            this.btn_openExports = new System.Windows.Forms.Button();
            this.btn_closeFile = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_defaultTraderStock = new System.Windows.Forms.CheckBox();
            this.cb_autoDestockAtRestart = new System.Windows.Forms.CheckBox();
            this.cb_autoCalculation = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.btn_exportFile = new System.Windows.Forms.Button();
            this.btn_loadFile = new System.Windows.Forms.Button();
            this.pnl_pushNotifications = new System.Windows.Forms.Panel();
            this.lbl_pushNotifications = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_newCategoryName = new System.Windows.Forms.TextBox();
            this.btn_deleteCategory = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_categories = new System.Windows.Forms.ListView();
            this.categories_Categories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_pushNotifications.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(223, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Size = new System.Drawing.Size(926, 678);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lv_products);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(5, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(916, 557);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // lv_products
            // 
            this.lv_products.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product_class,
            this.product_coeffcient,
            this.product_maxStock,
            this.product_tradeQuantity,
            this.product_buyPrice,
            this.product_sellPrice});
            this.lv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_products.Enabled = false;
            this.lv_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lv_products.FullRowSelect = true;
            this.lv_products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(5, 66);
            this.lv_products.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lv_products.MultiSelect = false;
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(906, 487);
            this.lv_products.TabIndex = 1;
            this.lv_products.TabStop = false;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            this.lv_products.SelectedIndexChanged += new System.EventHandler(this.lv_products_SelectedIndexChanged);
            // 
            // product_class
            // 
            this.product_class.Text = "Product name";
            this.product_class.Width = 378;
            // 
            // product_coeffcient
            // 
            this.product_coeffcient.Text = "Coefficient";
            this.product_coeffcient.Width = 110;
            // 
            // product_maxStock
            // 
            this.product_maxStock.Text = "Max stock";
            this.product_maxStock.Width = 100;
            // 
            // product_tradeQuantity
            // 
            this.product_tradeQuantity.Text = "Trade quantity";
            this.product_tradeQuantity.Width = 100;
            // 
            // product_buyPrice
            // 
            this.product_buyPrice.Text = "Buy price";
            this.product_buyPrice.Width = 100;
            // 
            // product_sellPrice
            // 
            this.product_sellPrice.Text = "Sell Price";
            this.product_sellPrice.Width = 100;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(906, 46);
            this.panel4.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_searchBar);
            this.groupBox6.Controls.Add(this.btn_search);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(0, -8);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(906, 54);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // tb_searchBar
            // 
            this.tb_searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_searchBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_searchBar.Enabled = false;
            this.tb_searchBar.Location = new System.Drawing.Point(2, 19);
            this.tb_searchBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_searchBar.Name = "tb_searchBar";
            this.tb_searchBar.Size = new System.Drawing.Size(786, 23);
            this.tb_searchBar.TabIndex = 25;
            this.tb_searchBar.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Enabled = false;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_search.Image = global::TraderPlusEditor.Properties.Resources.search;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(792, 10);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 41);
            this.btn_search.TabIndex = 24;
            this.btn_search.TabStop = false;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_searchProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_setAll_coefficient);
            this.groupBox5.Controls.Add(this.btn_setAll_maxStock);
            this.groupBox5.Controls.Add(this.btn_setAll_quantity);
            this.groupBox5.Controls.Add(this.btn_setAll_buyPrice);
            this.groupBox5.Controls.Add(this.btn_nextEntry);
            this.groupBox5.Controls.Add(this.btn_setAll_sellPrice);
            this.groupBox5.Controls.Add(this.btn_deleteProduct);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tb_sellPrice);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.tb_buyPrice);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tb_tradeQuantity);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tb_maxStock);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.tb_productCoefficient);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.tb_productName);
            this.groupBox5.Controls.Add(this.btn_addProduct);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(5, 561);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 4);
            this.groupBox5.Size = new System.Drawing.Size(916, 113);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // btn_setAll_coefficient
            // 
            this.btn_setAll_coefficient.Enabled = false;
            this.btn_setAll_coefficient.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_setAll_coefficient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_setAll_coefficient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btn_setAll_coefficient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setAll_coefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setAll_coefficient.Location = new System.Drawing.Point(409, 65);
            this.btn_setAll_coefficient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_setAll_coefficient.Name = "btn_setAll_coefficient";
            this.btn_setAll_coefficient.Size = new System.Drawing.Size(97, 46);
            this.btn_setAll_coefficient.TabIndex = 29;
            this.btn_setAll_coefficient.TabStop = false;
            this.btn_setAll_coefficient.Text = "Set all in category";
            this.btn_setAll_coefficient.UseVisualStyleBackColor = true;
            this.btn_setAll_coefficient.Click += new System.EventHandler(this.btn_setAll_coefficient_Click);
            // 
            // btn_setAll_maxStock
            // 
            this.btn_setAll_maxStock.Enabled = false;
            this.btn_setAll_maxStock.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_setAll_maxStock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_setAll_maxStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btn_setAll_maxStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setAll_maxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setAll_maxStock.Location = new System.Drawing.Point(511, 65);
            this.btn_setAll_maxStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_setAll_maxStock.Name = "btn_setAll_maxStock";
            this.btn_setAll_maxStock.Size = new System.Drawing.Size(97, 46);
            this.btn_setAll_maxStock.TabIndex = 28;
            this.btn_setAll_maxStock.TabStop = false;
            this.btn_setAll_maxStock.Text = "Set all in category";
            this.btn_setAll_maxStock.UseVisualStyleBackColor = true;
            this.btn_setAll_maxStock.Click += new System.EventHandler(this.btn_setAll_maxStock_Click);
            // 
            // btn_setAll_quantity
            // 
            this.btn_setAll_quantity.Enabled = false;
            this.btn_setAll_quantity.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_setAll_quantity.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_setAll_quantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btn_setAll_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setAll_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setAll_quantity.Location = new System.Drawing.Point(613, 65);
            this.btn_setAll_quantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_setAll_quantity.Name = "btn_setAll_quantity";
            this.btn_setAll_quantity.Size = new System.Drawing.Size(97, 46);
            this.btn_setAll_quantity.TabIndex = 27;
            this.btn_setAll_quantity.TabStop = false;
            this.btn_setAll_quantity.Text = "Set all in category";
            this.btn_setAll_quantity.UseVisualStyleBackColor = true;
            this.btn_setAll_quantity.Click += new System.EventHandler(this.btn_setAll_quantity_Click);
            // 
            // btn_setAll_buyPrice
            // 
            this.btn_setAll_buyPrice.Enabled = false;
            this.btn_setAll_buyPrice.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_setAll_buyPrice.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_setAll_buyPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btn_setAll_buyPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setAll_buyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setAll_buyPrice.Location = new System.Drawing.Point(715, 65);
            this.btn_setAll_buyPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_setAll_buyPrice.Name = "btn_setAll_buyPrice";
            this.btn_setAll_buyPrice.Size = new System.Drawing.Size(97, 46);
            this.btn_setAll_buyPrice.TabIndex = 26;
            this.btn_setAll_buyPrice.TabStop = false;
            this.btn_setAll_buyPrice.Text = "Set all in category";
            this.btn_setAll_buyPrice.UseVisualStyleBackColor = true;
            this.btn_setAll_buyPrice.Click += new System.EventHandler(this.btn_setAll_buyPrice_Click);
            // 
            // btn_nextEntry
            // 
            this.btn_nextEntry.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_nextEntry.Enabled = false;
            this.btn_nextEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_nextEntry.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_nextEntry.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_nextEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_nextEntry.Location = new System.Drawing.Point(1, 8);
            this.btn_nextEntry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_nextEntry.Name = "btn_nextEntry";
            this.btn_nextEntry.Size = new System.Drawing.Size(68, 58);
            this.btn_nextEntry.TabIndex = 7;
            this.btn_nextEntry.Text = "Next Entry";
            this.btn_nextEntry.UseVisualStyleBackColor = false;
            this.btn_nextEntry.Click += new System.EventHandler(this.btn_nextEntry_Click);
            // 
            // btn_setAll_sellPrice
            // 
            this.btn_setAll_sellPrice.Enabled = false;
            this.btn_setAll_sellPrice.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_setAll_sellPrice.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_setAll_sellPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btn_setAll_sellPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setAll_sellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setAll_sellPrice.Location = new System.Drawing.Point(817, 65);
            this.btn_setAll_sellPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_setAll_sellPrice.Name = "btn_setAll_sellPrice";
            this.btn_setAll_sellPrice.Size = new System.Drawing.Size(98, 46);
            this.btn_setAll_sellPrice.TabIndex = 22;
            this.btn_setAll_sellPrice.TabStop = false;
            this.btn_setAll_sellPrice.Text = "Set all in category";
            this.btn_setAll_sellPrice.UseVisualStyleBackColor = true;
            this.btn_setAll_sellPrice.Click += new System.EventHandler(this.btn_setAll_sellPrice_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Enabled = false;
            this.btn_deleteProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_deleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_deleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_deleteProduct.Location = new System.Drawing.Point(125, 65);
            this.btn_deleteProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(126, 46);
            this.btn_deleteProduct.TabIndex = 17;
            this.btn_deleteProduct.TabStop = false;
            this.btn_deleteProduct.Text = "Delete selected";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(814, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sell price:";
            // 
            // tb_sellPrice
            // 
            this.tb_sellPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_sellPrice.Enabled = false;
            this.tb_sellPrice.Location = new System.Drawing.Point(817, 33);
            this.tb_sellPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_sellPrice.Name = "tb_sellPrice";
            this.tb_sellPrice.Size = new System.Drawing.Size(97, 21);
            this.tb_sellPrice.TabIndex = 6;
            this.tb_sellPrice.Leave += new System.EventHandler(this.saveProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(712, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Buy price:";
            // 
            // tb_buyPrice
            // 
            this.tb_buyPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_buyPrice.Enabled = false;
            this.tb_buyPrice.Location = new System.Drawing.Point(715, 33);
            this.tb_buyPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_buyPrice.Name = "tb_buyPrice";
            this.tb_buyPrice.Size = new System.Drawing.Size(97, 21);
            this.tb_buyPrice.TabIndex = 5;
            this.tb_buyPrice.Leave += new System.EventHandler(this.saveProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(610, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trade quantity:";
            // 
            // tb_tradeQuantity
            // 
            this.tb_tradeQuantity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_tradeQuantity.Enabled = false;
            this.tb_tradeQuantity.Location = new System.Drawing.Point(613, 33);
            this.tb_tradeQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_tradeQuantity.Name = "tb_tradeQuantity";
            this.tb_tradeQuantity.Size = new System.Drawing.Size(97, 21);
            this.tb_tradeQuantity.TabIndex = 4;
            this.tb_tradeQuantity.Leave += new System.EventHandler(this.saveProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(511, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max stock:";
            // 
            // tb_maxStock
            // 
            this.tb_maxStock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_maxStock.Enabled = false;
            this.tb_maxStock.Location = new System.Drawing.Point(511, 33);
            this.tb_maxStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_maxStock.Name = "tb_maxStock";
            this.tb_maxStock.Size = new System.Drawing.Size(97, 21);
            this.tb_maxStock.TabIndex = 3;
            this.tb_maxStock.Leave += new System.EventHandler(this.saveProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(406, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Coefficient:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_productCoefficient
            // 
            this.tb_productCoefficient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_productCoefficient.Enabled = false;
            this.tb_productCoefficient.Location = new System.Drawing.Point(409, 33);
            this.tb_productCoefficient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_productCoefficient.Name = "tb_productCoefficient";
            this.tb_productCoefficient.Size = new System.Drawing.Size(97, 21);
            this.tb_productCoefficient.TabIndex = 2;
            this.tb_productCoefficient.Leave += new System.EventHandler(this.saveProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(73, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product class name:";
            // 
            // tb_productName
            // 
            this.tb_productName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_productName.Enabled = false;
            this.tb_productName.Location = new System.Drawing.Point(73, 33);
            this.tb_productName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(332, 21);
            this.tb_productName.TabIndex = 1;
            this.tb_productName.Leave += new System.EventHandler(this.saveProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Enabled = false;
            this.btn_addProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_addProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_addProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_addProduct.Location = new System.Drawing.Point(1, 65);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(125, 46);
            this.btn_addProduct.TabIndex = 8;
            this.btn_addProduct.TabStop = false;
            this.btn_addProduct.Text = "Add product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_donate);
            this.panel2.Controls.Add(this.btn_openExports);
            this.panel2.Controls.Add(this.btn_closeFile);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btn_exportFile);
            this.panel2.Controls.Add(this.btn_loadFile);
            this.panel2.Controls.Add(this.pnl_pushNotifications);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 0);
            this.panel2.Size = new System.Drawing.Size(1149, 83);
            this.panel2.TabIndex = 0;
            // 
            // btn_donate
            // 
            this.btn_donate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_donate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_donate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_donate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_donate.Image = global::TraderPlusEditor.Properties.Resources.donate;
            this.btn_donate.Location = new System.Drawing.Point(1087, 34);
            this.btn_donate.Margin = new System.Windows.Forms.Padding(5);
            this.btn_donate.Name = "btn_donate";
            this.btn_donate.Size = new System.Drawing.Size(57, 48);
            this.btn_donate.TabIndex = 23;
            this.btn_donate.TabStop = false;
            this.btn_donate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_donate.UseVisualStyleBackColor = true;
            this.btn_donate.Click += new System.EventHandler(this.btn_donate_Click);
            // 
            // btn_openExports
            // 
            this.btn_openExports.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_openExports.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_openExports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btn_openExports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openExports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_openExports.Image = global::TraderPlusEditor.Properties.Resources.export;
            this.btn_openExports.Location = new System.Drawing.Point(937, 34);
            this.btn_openExports.Margin = new System.Windows.Forms.Padding(5);
            this.btn_openExports.Name = "btn_openExports";
            this.btn_openExports.Size = new System.Drawing.Size(151, 48);
            this.btn_openExports.TabIndex = 22;
            this.btn_openExports.TabStop = false;
            this.btn_openExports.Text = "Open exports";
            this.btn_openExports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_openExports.UseVisualStyleBackColor = true;
            this.btn_openExports.Click += new System.EventHandler(this.btn_openExports_Click);
            // 
            // btn_closeFile
            // 
            this.btn_closeFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_closeFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_closeFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_closeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_closeFile.Location = new System.Drawing.Point(5, 34);
            this.btn_closeFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_closeFile.Name = "btn_closeFile";
            this.btn_closeFile.Size = new System.Drawing.Size(107, 48);
            this.btn_closeFile.TabIndex = 21;
            this.btn_closeFile.TabStop = false;
            this.btn_closeFile.Text = "Close File";
            this.btn_closeFile.UseVisualStyleBackColor = true;
            this.btn_closeFile.Visible = false;
            this.btn_closeFile.Click += new System.EventHandler(this.btn_closeFile_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Location = new System.Drawing.Point(228, 33);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(705, 50);
            this.panel6.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_defaultTraderStock);
            this.groupBox1.Controls.Add(this.cb_autoDestockAtRestart);
            this.groupBox1.Controls.Add(this.cb_autoCalculation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_version);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Settings";
            // 
            // cb_defaultTraderStock
            // 
            this.cb_defaultTraderStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_defaultTraderStock.AutoSize = true;
            this.cb_defaultTraderStock.Enabled = false;
            this.cb_defaultTraderStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_defaultTraderStock.Location = new System.Drawing.Point(524, 18);
            this.cb_defaultTraderStock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_defaultTraderStock.Name = "cb_defaultTraderStock";
            this.cb_defaultTraderStock.Size = new System.Drawing.Size(179, 19);
            this.cb_defaultTraderStock.TabIndex = 4;
            this.cb_defaultTraderStock.TabStop = false;
            this.cb_defaultTraderStock.Text = "Enable Default Trader Stock";
            this.cb_defaultTraderStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_defaultTraderStock.UseVisualStyleBackColor = true;
            // 
            // cb_autoDestockAtRestart
            // 
            this.cb_autoDestockAtRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_autoDestockAtRestart.AutoSize = true;
            this.cb_autoDestockAtRestart.Enabled = false;
            this.cb_autoDestockAtRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_autoDestockAtRestart.Location = new System.Drawing.Point(320, 19);
            this.cb_autoDestockAtRestart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_autoDestockAtRestart.Name = "cb_autoDestockAtRestart";
            this.cb_autoDestockAtRestart.Size = new System.Drawing.Size(194, 19);
            this.cb_autoDestockAtRestart.TabIndex = 3;
            this.cb_autoDestockAtRestart.TabStop = false;
            this.cb_autoDestockAtRestart.Text = "Enable Auto Destock At Restart";
            this.cb_autoDestockAtRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_autoDestockAtRestart.UseVisualStyleBackColor = true;
            // 
            // cb_autoCalculation
            // 
            this.cb_autoCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_autoCalculation.AutoSize = true;
            this.cb_autoCalculation.Enabled = false;
            this.cb_autoCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_autoCalculation.Location = new System.Drawing.Point(154, 19);
            this.cb_autoCalculation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_autoCalculation.Name = "cb_autoCalculation";
            this.cb_autoCalculation.Size = new System.Drawing.Size(156, 19);
            this.cb_autoCalculation.TabIndex = 2;
            this.cb_autoCalculation.TabStop = false;
            this.cb_autoCalculation.Text = "Enable Auto Calculation";
            this.cb_autoCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_autoCalculation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version:";
            // 
            // tb_version
            // 
            this.tb_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_version.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_version.Enabled = false;
            this.tb_version.Location = new System.Drawing.Point(65, 20);
            this.tb_version.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_version.Name = "tb_version";
            this.tb_version.ReadOnly = true;
            this.tb_version.Size = new System.Drawing.Size(60, 23);
            this.tb_version.TabIndex = 0;
            this.tb_version.TabStop = false;
            // 
            // btn_exportFile
            // 
            this.btn_exportFile.Enabled = false;
            this.btn_exportFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_exportFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_exportFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_exportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_exportFile.Location = new System.Drawing.Point(111, 34);
            this.btn_exportFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_exportFile.Name = "btn_exportFile";
            this.btn_exportFile.Size = new System.Drawing.Size(107, 48);
            this.btn_exportFile.TabIndex = 18;
            this.btn_exportFile.TabStop = false;
            this.btn_exportFile.Text = "Export File";
            this.btn_exportFile.UseVisualStyleBackColor = true;
            this.btn_exportFile.Click += new System.EventHandler(this.btn_exportFile_Click);
            // 
            // btn_loadFile
            // 
            this.btn_loadFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_loadFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_loadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_loadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_loadFile.Location = new System.Drawing.Point(5, 34);
            this.btn_loadFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_loadFile.Name = "btn_loadFile";
            this.btn_loadFile.Size = new System.Drawing.Size(107, 48);
            this.btn_loadFile.TabIndex = 17;
            this.btn_loadFile.TabStop = false;
            this.btn_loadFile.Text = "Load File";
            this.btn_loadFile.UseVisualStyleBackColor = true;
            this.btn_loadFile.Click += new System.EventHandler(this.btn_loadFile_Click);
            // 
            // pnl_pushNotifications
            // 
            this.pnl_pushNotifications.AutoSize = true;
            this.pnl_pushNotifications.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_pushNotifications.Controls.Add(this.lbl_pushNotifications);
            this.pnl_pushNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_pushNotifications.Location = new System.Drawing.Point(0, 1);
            this.pnl_pushNotifications.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_pushNotifications.Name = "pnl_pushNotifications";
            this.pnl_pushNotifications.Size = new System.Drawing.Size(1149, 32);
            this.pnl_pushNotifications.TabIndex = 1;
            this.pnl_pushNotifications.Visible = false;
            // 
            // lbl_pushNotifications
            // 
            this.lbl_pushNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pushNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pushNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_pushNotifications.Location = new System.Drawing.Point(0, 0);
            this.lbl_pushNotifications.Name = "lbl_pushNotifications";
            this.lbl_pushNotifications.Size = new System.Drawing.Size(1149, 32);
            this.lbl_pushNotifications.TabIndex = 0;
            this.lbl_pushNotifications.Text = "PUSH_NOTIFICATIONS";
            this.lbl_pushNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pushNotifications.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Size = new System.Drawing.Size(223, 678);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_newCategoryName);
            this.groupBox2.Controls.Add(this.btn_deleteCategory);
            this.groupBox2.Controls.Add(this.btn_addCategory);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(5, 561);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(213, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(8, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "New category name:";
            // 
            // tb_newCategoryName
            // 
            this.tb_newCategoryName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_newCategoryName.Enabled = false;
            this.tb_newCategoryName.Location = new System.Drawing.Point(7, 33);
            this.tb_newCategoryName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_newCategoryName.Name = "tb_newCategoryName";
            this.tb_newCategoryName.Size = new System.Drawing.Size(201, 21);
            this.tb_newCategoryName.TabIndex = 10;
            this.tb_newCategoryName.TabStop = false;
            this.tb_newCategoryName.TextChanged += new System.EventHandler(this.tb_newCategoryName_TextChanged);
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.Enabled = false;
            this.btn_deleteCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_deleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_deleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_deleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_deleteCategory.Location = new System.Drawing.Point(106, 65);
            this.btn_deleteCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(106, 46);
            this.btn_deleteCategory.TabIndex = 1;
            this.btn_deleteCategory.TabStop = false;
            this.btn_deleteCategory.Text = "Remove category";
            this.btn_deleteCategory.UseVisualStyleBackColor = true;
            this.btn_deleteCategory.Click += new System.EventHandler(this.btn_deleteCategory_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Enabled = false;
            this.btn_addCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_addCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_addCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_addCategory.Location = new System.Drawing.Point(1, 65);
            this.btn_addCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(106, 46);
            this.btn_addCategory.TabIndex = 0;
            this.btn_addCategory.TabStop = false;
            this.btn_addCategory.Text = "Add new category";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_categories);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(213, 557);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categories";
            // 
            // lv_categories
            // 
            this.lv_categories.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categories_Categories});
            this.lv_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_categories.Enabled = false;
            this.lv_categories.FullRowSelect = true;
            this.lv_categories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_categories.HideSelection = false;
            this.lv_categories.Location = new System.Drawing.Point(5, 20);
            this.lv_categories.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lv_categories.MultiSelect = false;
            this.lv_categories.Name = "lv_categories";
            this.lv_categories.Size = new System.Drawing.Size(203, 533);
            this.lv_categories.TabIndex = 0;
            this.lv_categories.TabStop = false;
            this.lv_categories.UseCompatibleStateImageBehavior = false;
            this.lv_categories.View = System.Windows.Forms.View.Details;
            this.lv_categories.SelectedIndexChanged += new System.EventHandler(this.lv_categories_SelectedIndexChanged);
            // 
            // categories_Categories
            // 
            this.categories_Categories.Text = "Categories";
            this.categories_Categories.Width = 175;
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1149, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xscr33m\'s TraderPlusEditor";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_pushNotifications.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_categories;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ColumnHeader categories_Categories;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader product_class;
        private System.Windows.Forms.ColumnHeader product_coeffcient;
        private System.Windows.Forms.ColumnHeader product_maxStock;
        private System.Windows.Forms.ColumnHeader product_tradeQuantity;
        private System.Windows.Forms.ColumnHeader product_buyPrice;
        private System.Windows.Forms.ColumnHeader product_sellPrice;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_deleteCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Button btn_setAll_sellPrice;
        public System.Windows.Forms.TextBox tb_sellPrice;
        public System.Windows.Forms.TextBox tb_buyPrice;
        public System.Windows.Forms.TextBox tb_tradeQuantity;
        public System.Windows.Forms.TextBox tb_maxStock;
        public System.Windows.Forms.TextBox tb_productCoefficient;
        public System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tb_newCategoryName;
        private System.Windows.Forms.Panel pnl_pushNotifications;
        private System.Windows.Forms.Label lbl_pushNotifications;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_loadFile;
        private System.Windows.Forms.Button btn_exportFile;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_defaultTraderStock;
        private System.Windows.Forms.CheckBox cb_autoDestockAtRestart;
        private System.Windows.Forms.CheckBox cb_autoCalculation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.Button btn_closeFile;
        private System.Windows.Forms.TextBox tb_searchBar;
        private System.Windows.Forms.Button btn_openExports;
        private System.Windows.Forms.Button btn_donate;
        private System.Windows.Forms.Button btn_nextEntry;
        private System.Windows.Forms.Button btn_setAll_coefficient;
        private System.Windows.Forms.Button btn_setAll_maxStock;
        private System.Windows.Forms.Button btn_setAll_quantity;
        private System.Windows.Forms.Button btn_setAll_buyPrice;
    }
}

