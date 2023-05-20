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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lv_products = new System.Windows.Forms.ListView();
            this.product_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_coeffcient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_maxStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_tradeQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_buyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_sellPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_autoSaveFile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_defaultTraderStock = new System.Windows.Forms.CheckBox();
            this.cb_autoDestockAtRestart = new System.Windows.Forms.CheckBox();
            this.cb_autoCalculation = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_categories = new System.Windows.Forms.ListView();
            this.lvCategories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(864, 409);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lv_products);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox4.Location = new System.Drawing.Point(5, 60);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(854, 344);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Settings";
            // 
            // lv_products
            // 
            this.lv_products.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product_class,
            this.product_coeffcient,
            this.product_maxStock,
            this.product_tradeQuantity,
            this.product_buyPrice,
            this.product_sellPrice});
            this.lv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(5, 19);
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(844, 320);
            this.lv_products.TabIndex = 1;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            // 
            // product_class
            // 
            this.product_class.Text = "Product name";
            this.product_class.Width = 350;
            // 
            // product_coeffcient
            // 
            this.product_coeffcient.Text = "Coefficient";
            this.product_coeffcient.Width = 100;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(854, 55);
            this.panel6.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_autoSaveFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(708, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(146, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc Settings";
            // 
            // cb_autoSaveFile
            // 
            this.cb_autoSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_autoSaveFile.AutoSize = true;
            this.cb_autoSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_autoSaveFile.Location = new System.Drawing.Point(10, 25);
            this.cb_autoSaveFile.Margin = new System.Windows.Forms.Padding(5);
            this.cb_autoSaveFile.Name = "cb_autoSaveFile";
            this.cb_autoSaveFile.Size = new System.Drawing.Size(122, 19);
            this.cb_autoSaveFile.TabIndex = 5;
            this.cb_autoSaveFile.Text = "Enable Auto Save";
            this.cb_autoSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_autoSaveFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_defaultTraderStock);
            this.groupBox1.Controls.Add(this.cb_autoDestockAtRestart);
            this.groupBox1.Controls.Add(this.cb_autoCalculation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_version);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(708, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General File Settings";
            // 
            // cb_defaultTraderStock
            // 
            this.cb_defaultTraderStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_defaultTraderStock.AutoSize = true;
            this.cb_defaultTraderStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_defaultTraderStock.Location = new System.Drawing.Point(524, 25);
            this.cb_defaultTraderStock.Margin = new System.Windows.Forms.Padding(5);
            this.cb_defaultTraderStock.Name = "cb_defaultTraderStock";
            this.cb_defaultTraderStock.Size = new System.Drawing.Size(179, 19);
            this.cb_defaultTraderStock.TabIndex = 4;
            this.cb_defaultTraderStock.Text = "Enable Default Trader Stock";
            this.cb_defaultTraderStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_defaultTraderStock.UseVisualStyleBackColor = true;
            // 
            // cb_autoDestockAtRestart
            // 
            this.cb_autoDestockAtRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_autoDestockAtRestart.AutoSize = true;
            this.cb_autoDestockAtRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_autoDestockAtRestart.Location = new System.Drawing.Point(320, 26);
            this.cb_autoDestockAtRestart.Margin = new System.Windows.Forms.Padding(5);
            this.cb_autoDestockAtRestart.Name = "cb_autoDestockAtRestart";
            this.cb_autoDestockAtRestart.Size = new System.Drawing.Size(194, 19);
            this.cb_autoDestockAtRestart.TabIndex = 3;
            this.cb_autoDestockAtRestart.Text = "Enable Auto Destock At Restart";
            this.cb_autoDestockAtRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_autoDestockAtRestart.UseVisualStyleBackColor = true;
            // 
            // cb_autoCalculation
            // 
            this.cb_autoCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_autoCalculation.AutoSize = true;
            this.cb_autoCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_autoCalculation.Location = new System.Drawing.Point(154, 26);
            this.cb_autoCalculation.Margin = new System.Windows.Forms.Padding(5);
            this.cb_autoCalculation.Name = "cb_autoCalculation";
            this.cb_autoCalculation.Size = new System.Drawing.Size(156, 19);
            this.cb_autoCalculation.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version:";
            // 
            // tb_version
            // 
            this.tb_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_version.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_version.Location = new System.Drawing.Point(65, 25);
            this.tb_version.Name = "tb_version";
            this.tb_version.Size = new System.Drawing.Size(60, 21);
            this.tb_version.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1064, 52);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(200, 409);
            this.panel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_categories);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(190, 399);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categories";
            // 
            // lv_categories
            // 
            this.lv_categories.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvCategories});
            this.lv_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_categories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_categories.HideSelection = false;
            this.lv_categories.Location = new System.Drawing.Point(5, 19);
            this.lv_categories.Name = "lv_categories";
            this.lv_categories.Size = new System.Drawing.Size(180, 375);
            this.lv_categories.TabIndex = 0;
            this.lv_categories.UseCompatibleStateImageBehavior = false;
            this.lv_categories.View = System.Windows.Forms.View.Details;
            // 
            // lvCategories
            // 
            this.lvCategories.Text = "Categories";
            this.lvCategories.Width = 250;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 461);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(1064, 100);
            this.panel5.TabIndex = 0;
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1080, 600);
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lv_categories;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_defaultTraderStock;
        private System.Windows.Forms.CheckBox cb_autoDestockAtRestart;
        private System.Windows.Forms.CheckBox cb_autoCalculation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_autoSaveFile;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ColumnHeader lvCategories;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader product_class;
        private System.Windows.Forms.ColumnHeader product_coeffcient;
        private System.Windows.Forms.ColumnHeader product_maxStock;
        private System.Windows.Forms.ColumnHeader product_tradeQuantity;
        private System.Windows.Forms.ColumnHeader product_buyPrice;
        private System.Windows.Forms.ColumnHeader product_sellPrice;
    }
}

