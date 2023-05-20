using System.Windows.Forms;

namespace TraderPlusEditor._Core._Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.TextboxSearch = new System.Windows.Forms.TextBox();
            this.PanelProductControls = new System.Windows.Forms.Panel();
            this.ButtonDeleteProduct = new FontAwesome.Sharp.IconButton();
            this.ButtonProductUp = new FontAwesome.Sharp.IconButton();
            this.ButtonProductDown = new FontAwesome.Sharp.IconButton();
            this.PanelFileSettings = new System.Windows.Forms.Panel();
            this.CheckBoxDefaultTraderStock = new System.Windows.Forms.CheckBox();
            this.TextBoxVersion = new System.Windows.Forms.TextBox();
            this.CheckBoxAutoCalculation = new System.Windows.Forms.CheckBox();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.CheckBoxAutoDestock = new System.Windows.Forms.CheckBox();
            this.PanelFileControls = new System.Windows.Forms.Panel();
            this.ButtonOpenExports = new FontAwesome.Sharp.IconButton();
            this.ButtonFileClose = new FontAwesome.Sharp.IconButton();
            this.Button_Info = new FontAwesome.Sharp.IconButton();
            this.ButtonSettings = new FontAwesome.Sharp.IconButton();
            this.ButtonSaveFile = new FontAwesome.Sharp.IconButton();
            this.ButtonOpenFile = new FontAwesome.Sharp.IconButton();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.PanelCategories = new System.Windows.Forms.Panel();
            this.ListViewCategories = new System.Windows.Forms.ListView();
            this.categories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelCategories = new System.Windows.Forms.Label();
            this.PanelCategoriesBottom = new System.Windows.Forms.Panel();
            this.ButtonEditCategory = new FontAwesome.Sharp.IconButton();
            this.ButtonDeleteCategory = new FontAwesome.Sharp.IconButton();
            this.LabelNewCategory = new System.Windows.Forms.Label();
            this.TextBoxCategoryName = new System.Windows.Forms.TextBox();
            this.ButtonAddCategory = new FontAwesome.Sharp.IconButton();
            this.PanelPreview = new System.Windows.Forms.Panel();
            this.PictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.PanelProductsMain = new System.Windows.Forms.Panel();
            this.GridViewProducts = new System.Windows.Forms.DataGridView();
            this.products_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_maxstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_tradeqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_buyprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_destock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowPanelProductControl = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelNewProduct = new System.Windows.Forms.Panel();
            this.LabelNewProductName = new System.Windows.Forms.Label();
            this.TextBoxNewProductName = new System.Windows.Forms.TextBox();
            this.ButtonAddNewProduct = new FontAwesome.Sharp.IconButton();
            this.PanelCoefficent = new System.Windows.Forms.Panel();
            this.LabelCoefficent = new System.Windows.Forms.Label();
            this.TextBoxCoefficent = new System.Windows.Forms.TextBox();
            this.ButtonCoefficent = new FontAwesome.Sharp.IconButton();
            this.PanelMaxStock = new System.Windows.Forms.Panel();
            this.LabelMaxStock = new System.Windows.Forms.Label();
            this.TextBoxMaxStock = new System.Windows.Forms.TextBox();
            this.ButtonMaxStock = new FontAwesome.Sharp.IconButton();
            this.PanelTradeQuantity = new System.Windows.Forms.Panel();
            this.LabelTradeQuantity = new System.Windows.Forms.Label();
            this.TextBoxTradeQuantity = new System.Windows.Forms.TextBox();
            this.ButtonTradeQuantity = new FontAwesome.Sharp.IconButton();
            this.PanelBuyPrice = new System.Windows.Forms.Panel();
            this.LabelBuyPrice = new System.Windows.Forms.Label();
            this.TextBoxBuyPrice = new System.Windows.Forms.TextBox();
            this.ButtonBuyPrice = new FontAwesome.Sharp.IconButton();
            this.PanelSellPrice = new System.Windows.Forms.Panel();
            this.LabelSellPrice = new System.Windows.Forms.Label();
            this.TextBoxSellPrice = new System.Windows.Forms.TextBox();
            this.ButtonSellPrice = new FontAwesome.Sharp.IconButton();
            this.PanelDestockCoefficent = new System.Windows.Forms.Panel();
            this.LabelDestockCoefficent = new System.Windows.Forms.Label();
            this.TextBoxDestockCoefficent = new System.Windows.Forms.TextBox();
            this.ButtonDestockCoefficent = new FontAwesome.Sharp.IconButton();
            this.Label_Version = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Dashboard = new System.Windows.Forms.Panel();
            this.PanelNotifications = new System.Windows.Forms.Panel();
            this.LabelNotifications = new System.Windows.Forms.Label();
            this.IconNotification = new FontAwesome.Sharp.IconPictureBox();
            this.PanelTop.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.PanelProductControls.SuspendLayout();
            this.PanelFileSettings.SuspendLayout();
            this.PanelFileControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.PanelCategories.SuspendLayout();
            this.PanelCategoriesBottom.SuspendLayout();
            this.PanelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPreview)).BeginInit();
            this.PanelProductsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProducts)).BeginInit();
            this.FlowPanelProductControl.SuspendLayout();
            this.PanelNewProduct.SuspendLayout();
            this.PanelCoefficent.SuspendLayout();
            this.PanelMaxStock.SuspendLayout();
            this.PanelTradeQuantity.SuspendLayout();
            this.PanelBuyPrice.SuspendLayout();
            this.PanelSellPrice.SuspendLayout();
            this.PanelDestockCoefficent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_Dashboard.SuspendLayout();
            this.PanelNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Transparent;
            this.PanelTop.Controls.Add(this.PanelSearch);
            this.PanelTop.Controls.Add(this.PanelProductControls);
            this.PanelTop.Controls.Add(this.PanelFileSettings);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 60);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1234, 60);
            this.PanelTop.TabIndex = 7;
            // 
            // PanelSearch
            // 
            this.PanelSearch.AutoSize = true;
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Controls.Add(this.TextboxSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSearch.Enabled = false;
            this.PanelSearch.Location = new System.Drawing.Point(613, 0);
            this.PanelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(621, 60);
            this.PanelSearch.TabIndex = 8;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSearch.FlatAppearance.BorderSize = 0;
            this.ButtonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSearch.IconColor = System.Drawing.Color.White;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.IconSize = 30;
            this.ButtonSearch.Location = new System.Drawing.Point(566, 5);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(50, 50);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.TabStop = false;
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextboxSearch
            // 
            this.TextboxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextboxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxSearch.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextboxSearch.ForeColor = System.Drawing.Color.White;
            this.TextboxSearch.Location = new System.Drawing.Point(0, 18);
            this.TextboxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxSearch.Name = "TextboxSearch";
            this.TextboxSearch.Size = new System.Drawing.Size(566, 22);
            this.TextboxSearch.TabIndex = 7;
            this.TextboxSearch.TabStop = false;
            this.TextboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // PanelProductControls
            // 
            this.PanelProductControls.Controls.Add(this.ButtonDeleteProduct);
            this.PanelProductControls.Controls.Add(this.ButtonProductUp);
            this.PanelProductControls.Controls.Add(this.ButtonProductDown);
            this.PanelProductControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelProductControls.Enabled = false;
            this.PanelProductControls.Location = new System.Drawing.Point(454, 0);
            this.PanelProductControls.Margin = new System.Windows.Forms.Padding(0);
            this.PanelProductControls.Name = "PanelProductControls";
            this.PanelProductControls.Size = new System.Drawing.Size(159, 60);
            this.PanelProductControls.TabIndex = 9;
            // 
            // ButtonDeleteProduct
            // 
            this.ButtonDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDeleteProduct.FlatAppearance.BorderSize = 0;
            this.ButtonDeleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteProduct.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDeleteProduct.IconColor = System.Drawing.Color.White;
            this.ButtonDeleteProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeleteProduct.IconSize = 30;
            this.ButtonDeleteProduct.Location = new System.Drawing.Point(104, 5);
            this.ButtonDeleteProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDeleteProduct.Name = "ButtonDeleteProduct";
            this.ButtonDeleteProduct.Size = new System.Drawing.Size(50, 50);
            this.ButtonDeleteProduct.TabIndex = 14;
            this.ButtonDeleteProduct.TabStop = false;
            this.ButtonDeleteProduct.UseVisualStyleBackColor = false;
            this.ButtonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // ButtonProductUp
            // 
            this.ButtonProductUp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonProductUp.FlatAppearance.BorderSize = 0;
            this.ButtonProductUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonProductUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonProductUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProductUp.ForeColor = System.Drawing.Color.White;
            this.ButtonProductUp.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.ButtonProductUp.IconColor = System.Drawing.Color.White;
            this.ButtonProductUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonProductUp.IconSize = 30;
            this.ButtonProductUp.Location = new System.Drawing.Point(4, 5);
            this.ButtonProductUp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonProductUp.Name = "ButtonProductUp";
            this.ButtonProductUp.Size = new System.Drawing.Size(50, 50);
            this.ButtonProductUp.TabIndex = 6;
            this.ButtonProductUp.TabStop = false;
            this.ButtonProductUp.UseVisualStyleBackColor = false;
            this.ButtonProductUp.Click += new System.EventHandler(this.ButtonProductUp_Click);
            // 
            // ButtonProductDown
            // 
            this.ButtonProductDown.BackColor = System.Drawing.Color.Transparent;
            this.ButtonProductDown.FlatAppearance.BorderSize = 0;
            this.ButtonProductDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonProductDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonProductDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProductDown.ForeColor = System.Drawing.Color.White;
            this.ButtonProductDown.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.ButtonProductDown.IconColor = System.Drawing.Color.White;
            this.ButtonProductDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonProductDown.IconSize = 30;
            this.ButtonProductDown.Location = new System.Drawing.Point(54, 5);
            this.ButtonProductDown.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonProductDown.Name = "ButtonProductDown";
            this.ButtonProductDown.Size = new System.Drawing.Size(50, 50);
            this.ButtonProductDown.TabIndex = 7;
            this.ButtonProductDown.TabStop = false;
            this.ButtonProductDown.UseVisualStyleBackColor = false;
            this.ButtonProductDown.Click += new System.EventHandler(this.ButtonProductDown_Click);
            // 
            // PanelFileSettings
            // 
            this.PanelFileSettings.Controls.Add(this.CheckBoxDefaultTraderStock);
            this.PanelFileSettings.Controls.Add(this.TextBoxVersion);
            this.PanelFileSettings.Controls.Add(this.CheckBoxAutoCalculation);
            this.PanelFileSettings.Controls.Add(this.LabelVersion);
            this.PanelFileSettings.Controls.Add(this.CheckBoxAutoDestock);
            this.PanelFileSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelFileSettings.Enabled = false;
            this.PanelFileSettings.Location = new System.Drawing.Point(0, 0);
            this.PanelFileSettings.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFileSettings.Name = "PanelFileSettings";
            this.PanelFileSettings.Size = new System.Drawing.Size(454, 60);
            this.PanelFileSettings.TabIndex = 7;
            // 
            // CheckBoxDefaultTraderStock
            // 
            this.CheckBoxDefaultTraderStock.AutoSize = true;
            this.CheckBoxDefaultTraderStock.ForeColor = System.Drawing.Color.White;
            this.CheckBoxDefaultTraderStock.Location = new System.Drawing.Point(184, 34);
            this.CheckBoxDefaultTraderStock.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxDefaultTraderStock.Name = "CheckBoxDefaultTraderStock";
            this.CheckBoxDefaultTraderStock.Size = new System.Drawing.Size(182, 21);
            this.CheckBoxDefaultTraderStock.TabIndex = 5;
            this.CheckBoxDefaultTraderStock.TabStop = false;
            this.CheckBoxDefaultTraderStock.Text = "Enable Default Trader Stock";
            this.CheckBoxDefaultTraderStock.UseVisualStyleBackColor = true;
            this.CheckBoxDefaultTraderStock.Click += new System.EventHandler(this.CheckBoxDefaultTraderStock_CheckedChanged);
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxVersion.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.TextBoxVersion.ForeColor = System.Drawing.Color.White;
            this.TextBoxVersion.Location = new System.Drawing.Point(68, 11);
            this.TextBoxVersion.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.ReadOnly = true;
            this.TextBoxVersion.Size = new System.Drawing.Size(61, 17);
            this.TextBoxVersion.TabIndex = 1;
            this.TextBoxVersion.TabStop = false;
            // 
            // CheckBoxAutoCalculation
            // 
            this.CheckBoxAutoCalculation.AutoSize = true;
            this.CheckBoxAutoCalculation.ForeColor = System.Drawing.Color.White;
            this.CheckBoxAutoCalculation.Location = new System.Drawing.Point(13, 34);
            this.CheckBoxAutoCalculation.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxAutoCalculation.Name = "CheckBoxAutoCalculation";
            this.CheckBoxAutoCalculation.Size = new System.Drawing.Size(159, 21);
            this.CheckBoxAutoCalculation.TabIndex = 4;
            this.CheckBoxAutoCalculation.TabStop = false;
            this.CheckBoxAutoCalculation.Text = "Enable Auto Calculation";
            this.CheckBoxAutoCalculation.UseVisualStyleBackColor = true;
            this.CheckBoxAutoCalculation.CheckedChanged += new System.EventHandler(this.CheckBoxAutoCalculation_CheckedChanged);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.ForeColor = System.Drawing.Color.White;
            this.LabelVersion.Location = new System.Drawing.Point(13, 10);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(1);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(53, 17);
            this.LabelVersion.TabIndex = 2;
            this.LabelVersion.Text = "Version:";
            // 
            // CheckBoxAutoDestock
            // 
            this.CheckBoxAutoDestock.AutoSize = true;
            this.CheckBoxAutoDestock.ForeColor = System.Drawing.Color.White;
            this.CheckBoxAutoDestock.Location = new System.Drawing.Point(184, 9);
            this.CheckBoxAutoDestock.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxAutoDestock.Name = "CheckBoxAutoDestock";
            this.CheckBoxAutoDestock.Size = new System.Drawing.Size(199, 21);
            this.CheckBoxAutoDestock.TabIndex = 3;
            this.CheckBoxAutoDestock.TabStop = false;
            this.CheckBoxAutoDestock.Text = "Enable Auto Destock at Restart";
            this.CheckBoxAutoDestock.UseVisualStyleBackColor = true;
            this.CheckBoxAutoDestock.CheckedChanged += new System.EventHandler(this.CkeckBoxAutoDestock_CheckedChanged);
            // 
            // PanelFileControls
            // 
            this.PanelFileControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFileControls.BackColor = System.Drawing.Color.Transparent;
            this.PanelFileControls.Controls.Add(this.ButtonOpenExports);
            this.PanelFileControls.Controls.Add(this.ButtonFileClose);
            this.PanelFileControls.Controls.Add(this.Button_Info);
            this.PanelFileControls.Controls.Add(this.ButtonSettings);
            this.PanelFileControls.Controls.Add(this.ButtonSaveFile);
            this.PanelFileControls.Controls.Add(this.ButtonOpenFile);
            this.PanelFileControls.Controls.Add(this.PictureBoxLogo);
            this.PanelFileControls.Location = new System.Drawing.Point(0, 0);
            this.PanelFileControls.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFileControls.Name = "PanelFileControls";
            this.PanelFileControls.Size = new System.Drawing.Size(1234, 60);
            this.PanelFileControls.TabIndex = 6;
            // 
            // ButtonOpenExports
            // 
            this.ButtonOpenExports.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOpenExports.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonOpenExports.FlatAppearance.BorderSize = 0;
            this.ButtonOpenExports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonOpenExports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonOpenExports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOpenExports.ForeColor = System.Drawing.Color.White;
            this.ButtonOpenExports.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            this.ButtonOpenExports.IconColor = System.Drawing.Color.White;
            this.ButtonOpenExports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonOpenExports.IconSize = 42;
            this.ButtonOpenExports.Location = new System.Drawing.Point(394, 0);
            this.ButtonOpenExports.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonOpenExports.Name = "ButtonOpenExports";
            this.ButtonOpenExports.Size = new System.Drawing.Size(60, 60);
            this.ButtonOpenExports.TabIndex = 5;
            this.ButtonOpenExports.TabStop = false;
            this.ButtonOpenExports.UseVisualStyleBackColor = false;
            this.ButtonOpenExports.Click += new System.EventHandler(this.ButtonOpenExport_Click);
            // 
            // ButtonFileClose
            // 
            this.ButtonFileClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFileClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonFileClose.FlatAppearance.BorderSize = 0;
            this.ButtonFileClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonFileClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonFileClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFileClose.ForeColor = System.Drawing.Color.White;
            this.ButtonFileClose.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.ButtonFileClose.IconColor = System.Drawing.Color.White;
            this.ButtonFileClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonFileClose.IconSize = 42;
            this.ButtonFileClose.Location = new System.Drawing.Point(334, 0);
            this.ButtonFileClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFileClose.Name = "ButtonFileClose";
            this.ButtonFileClose.Size = new System.Drawing.Size(60, 60);
            this.ButtonFileClose.TabIndex = 8;
            this.ButtonFileClose.TabStop = false;
            this.ButtonFileClose.UseVisualStyleBackColor = false;
            this.ButtonFileClose.Visible = false;
            this.ButtonFileClose.Click += new System.EventHandler(this.ButtonCloseFile_Click);
            // 
            // Button_Info
            // 
            this.Button_Info.BackColor = System.Drawing.Color.Transparent;
            this.Button_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Info.FlatAppearance.BorderSize = 0;
            this.Button_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Info.ForeColor = System.Drawing.Color.White;
            this.Button_Info.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.Button_Info.IconColor = System.Drawing.Color.White;
            this.Button_Info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Info.IconSize = 42;
            this.Button_Info.Location = new System.Drawing.Point(1114, 0);
            this.Button_Info.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Info.Name = "Button_Info";
            this.Button_Info.Size = new System.Drawing.Size(60, 60);
            this.Button_Info.TabIndex = 12;
            this.Button_Info.TabStop = false;
            this.Button_Info.UseVisualStyleBackColor = false;
            this.Button_Info.Click += new System.EventHandler(this.Button_Info_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ButtonSettings.IconColor = System.Drawing.Color.White;
            this.ButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSettings.IconSize = 42;
            this.ButtonSettings.Location = new System.Drawing.Point(1174, 0);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(60, 60);
            this.ButtonSettings.TabIndex = 7;
            this.ButtonSettings.TabStop = false;
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSaveFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSaveFile.Enabled = false;
            this.ButtonSaveFile.FlatAppearance.BorderSize = 0;
            this.ButtonSaveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonSaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveFile.ForeColor = System.Drawing.Color.White;
            this.ButtonSaveFile.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ButtonSaveFile.IconColor = System.Drawing.Color.White;
            this.ButtonSaveFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSaveFile.IconSize = 42;
            this.ButtonSaveFile.Location = new System.Drawing.Point(274, 0);
            this.ButtonSaveFile.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(60, 60);
            this.ButtonSaveFile.TabIndex = 2;
            this.ButtonSaveFile.TabStop = false;
            this.ButtonSaveFile.UseVisualStyleBackColor = false;
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOpenFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonOpenFile.FlatAppearance.BorderSize = 0;
            this.ButtonOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOpenFile.ForeColor = System.Drawing.Color.White;
            this.ButtonOpenFile.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.ButtonOpenFile.IconColor = System.Drawing.Color.White;
            this.ButtonOpenFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonOpenFile.IconSize = 42;
            this.ButtonOpenFile.Location = new System.Drawing.Point(214, 0);
            this.ButtonOpenFile.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(60, 60);
            this.ButtonOpenFile.TabIndex = 3;
            this.ButtonOpenFile.TabStop = false;
            this.ButtonOpenFile.UseVisualStyleBackColor = false;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBoxLogo.Image = global::TraderPlusEditor.Properties.Resources.xscr33mLabs_Logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(214, 60);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 11;
            this.PictureBoxLogo.TabStop = false;
            this.PictureBoxLogo.Click += new System.EventHandler(this.PictureBox_Logo_DoubleClick);
            // 
            // PanelCategories
            // 
            this.PanelCategories.BackColor = System.Drawing.Color.Transparent;
            this.PanelCategories.Controls.Add(this.ListViewCategories);
            this.PanelCategories.Controls.Add(this.LabelCategories);
            this.PanelCategories.Controls.Add(this.PanelCategoriesBottom);
            this.PanelCategories.Controls.Add(this.PanelPreview);
            this.PanelCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelCategories.Location = new System.Drawing.Point(0, 120);
            this.PanelCategories.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCategories.Name = "PanelCategories";
            this.PanelCategories.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PanelCategories.Size = new System.Drawing.Size(300, 576);
            this.PanelCategories.TabIndex = 8;
            // 
            // ListViewCategories
            // 
            this.ListViewCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ListViewCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categories});
            this.ListViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewCategories.ForeColor = System.Drawing.Color.White;
            this.ListViewCategories.FullRowSelect = true;
            this.ListViewCategories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListViewCategories.HideSelection = false;
            this.ListViewCategories.Location = new System.Drawing.Point(5, 217);
            this.ListViewCategories.MultiSelect = false;
            this.ListViewCategories.Name = "ListViewCategories";
            this.ListViewCategories.Size = new System.Drawing.Size(290, 304);
            this.ListViewCategories.TabIndex = 6;
            this.ListViewCategories.TabStop = false;
            this.ListViewCategories.UseCompatibleStateImageBehavior = false;
            this.ListViewCategories.View = System.Windows.Forms.View.Details;
            this.ListViewCategories.SelectedIndexChanged += new System.EventHandler(this.ListViewCategories_SelectedIndexChanged);
            this.ListViewCategories.DoubleClick += new System.EventHandler(this.ListViewCategories_DoubleClick);
            // 
            // categories
            // 
            this.categories.Text = "Categories";
            this.categories.Width = 265;
            // 
            // LabelCategories
            // 
            this.LabelCategories.AutoSize = true;
            this.LabelCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCategories.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Underline);
            this.LabelCategories.ForeColor = System.Drawing.Color.White;
            this.LabelCategories.Location = new System.Drawing.Point(5, 200);
            this.LabelCategories.Name = "LabelCategories";
            this.LabelCategories.Size = new System.Drawing.Size(69, 17);
            this.LabelCategories.TabIndex = 6;
            this.LabelCategories.Text = "Categories";
            // 
            // PanelCategoriesBottom
            // 
            this.PanelCategoriesBottom.BackColor = System.Drawing.Color.Transparent;
            this.PanelCategoriesBottom.Controls.Add(this.ButtonEditCategory);
            this.PanelCategoriesBottom.Controls.Add(this.ButtonDeleteCategory);
            this.PanelCategoriesBottom.Controls.Add(this.LabelNewCategory);
            this.PanelCategoriesBottom.Controls.Add(this.TextBoxCategoryName);
            this.PanelCategoriesBottom.Controls.Add(this.ButtonAddCategory);
            this.PanelCategoriesBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCategoriesBottom.Enabled = false;
            this.PanelCategoriesBottom.Location = new System.Drawing.Point(5, 521);
            this.PanelCategoriesBottom.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCategoriesBottom.Name = "PanelCategoriesBottom";
            this.PanelCategoriesBottom.Size = new System.Drawing.Size(290, 55);
            this.PanelCategoriesBottom.TabIndex = 5;
            // 
            // ButtonEditCategory
            // 
            this.ButtonEditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditCategory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditCategory.FlatAppearance.BorderSize = 0;
            this.ButtonEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditCategory.ForeColor = System.Drawing.Color.White;
            this.ButtonEditCategory.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonEditCategory.IconColor = System.Drawing.Color.White;
            this.ButtonEditCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonEditCategory.IconSize = 30;
            this.ButtonEditCategory.Location = new System.Drawing.Point(230, 21);
            this.ButtonEditCategory.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonEditCategory.Name = "ButtonEditCategory";
            this.ButtonEditCategory.Size = new System.Drawing.Size(30, 30);
            this.ButtonEditCategory.TabIndex = 14;
            this.ButtonEditCategory.TabStop = false;
            this.ButtonEditCategory.UseVisualStyleBackColor = false;
            this.ButtonEditCategory.Click += new System.EventHandler(this.ButtonEditCategory_Click);
            // 
            // ButtonDeleteCategory
            // 
            this.ButtonDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDeleteCategory.FlatAppearance.BorderSize = 0;
            this.ButtonDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteCategory.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDeleteCategory.IconColor = System.Drawing.Color.White;
            this.ButtonDeleteCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeleteCategory.IconSize = 30;
            this.ButtonDeleteCategory.Location = new System.Drawing.Point(260, 21);
            this.ButtonDeleteCategory.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDeleteCategory.Name = "ButtonDeleteCategory";
            this.ButtonDeleteCategory.Size = new System.Drawing.Size(30, 30);
            this.ButtonDeleteCategory.TabIndex = 13;
            this.ButtonDeleteCategory.TabStop = false;
            this.ButtonDeleteCategory.UseVisualStyleBackColor = false;
            this.ButtonDeleteCategory.Click += new System.EventHandler(this.ButtonDeleteCategory_Click);
            // 
            // LabelNewCategory
            // 
            this.LabelNewCategory.AutoSize = true;
            this.LabelNewCategory.ForeColor = System.Drawing.Color.White;
            this.LabelNewCategory.Location = new System.Drawing.Point(4, 6);
            this.LabelNewCategory.Margin = new System.Windows.Forms.Padding(1);
            this.LabelNewCategory.Name = "LabelNewCategory";
            this.LabelNewCategory.Size = new System.Drawing.Size(127, 17);
            this.LabelNewCategory.TabIndex = 12;
            this.LabelNewCategory.Text = "New Category Name:";
            // 
            // TextBoxCategoryName
            // 
            this.TextBoxCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCategoryName.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxCategoryName.ForeColor = System.Drawing.Color.White;
            this.TextBoxCategoryName.Location = new System.Drawing.Point(4, 24);
            this.TextBoxCategoryName.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxCategoryName.Name = "TextBoxCategoryName";
            this.TextBoxCategoryName.Size = new System.Drawing.Size(196, 22);
            this.TextBoxCategoryName.TabIndex = 11;
            this.TextBoxCategoryName.TabStop = false;
            // 
            // ButtonAddCategory
            // 
            this.ButtonAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddCategory.FlatAppearance.BorderSize = 0;
            this.ButtonAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCategory.ForeColor = System.Drawing.Color.White;
            this.ButtonAddCategory.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ButtonAddCategory.IconColor = System.Drawing.Color.White;
            this.ButtonAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAddCategory.IconSize = 30;
            this.ButtonAddCategory.Location = new System.Drawing.Point(200, 21);
            this.ButtonAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddCategory.Name = "ButtonAddCategory";
            this.ButtonAddCategory.Size = new System.Drawing.Size(30, 30);
            this.ButtonAddCategory.TabIndex = 10;
            this.ButtonAddCategory.TabStop = false;
            this.ButtonAddCategory.UseVisualStyleBackColor = false;
            this.ButtonAddCategory.Click += new System.EventHandler(this.ButtonAddCategory_Click);
            // 
            // PanelPreview
            // 
            this.PanelPreview.BackColor = System.Drawing.Color.Transparent;
            this.PanelPreview.Controls.Add(this.PictureBoxPreview);
            this.PanelPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPreview.Location = new System.Drawing.Point(5, 0);
            this.PanelPreview.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPreview.Name = "PanelPreview";
            this.PanelPreview.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.PanelPreview.Size = new System.Drawing.Size(290, 200);
            this.PanelPreview.TabIndex = 4;
            this.PanelPreview.Visible = false;
            // 
            // PictureBoxPreview
            // 
            this.PictureBoxPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxPreview.Image = global::TraderPlusEditor.Properties.Resources.NoImage;
            this.PictureBoxPreview.InitialImage = null;
            this.PictureBoxPreview.Location = new System.Drawing.Point(40, 0);
            this.PictureBoxPreview.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxPreview.MaximumSize = new System.Drawing.Size(200, 200);
            this.PictureBoxPreview.Name = "PictureBoxPreview";
            this.PictureBoxPreview.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPreview.TabIndex = 0;
            this.PictureBoxPreview.TabStop = false;
            this.PictureBoxPreview.DoubleClick += new System.EventHandler(this.PictureBoxPreview_DoubleClick);
            // 
            // PanelProductsMain
            // 
            this.PanelProductsMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelProductsMain.Controls.Add(this.GridViewProducts);
            this.PanelProductsMain.Controls.Add(this.FlowPanelProductControl);
            this.PanelProductsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProductsMain.Enabled = false;
            this.PanelProductsMain.Location = new System.Drawing.Point(300, 120);
            this.PanelProductsMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelProductsMain.Name = "PanelProductsMain";
            this.PanelProductsMain.Size = new System.Drawing.Size(934, 576);
            this.PanelProductsMain.TabIndex = 5;
            // 
            // GridViewProducts
            // 
            this.GridViewProducts.AllowUserToAddRows = false;
            this.GridViewProducts.AllowUserToResizeRows = false;
            this.GridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.GridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.products_category,
            this.products_name,
            this.products_coefficient,
            this.products_maxstock,
            this.products_tradeqty,
            this.products_buyprice,
            this.products_sellPrice,
            this.products_destock});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewProducts.EnableHeadersVisualStyles = false;
            this.GridViewProducts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.GridViewProducts.Margin = new System.Windows.Forms.Padding(5);
            this.GridViewProducts.Name = "GridViewProducts";
            this.GridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewProducts.RowHeadersVisible = false;
            this.GridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GridViewProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewProducts.Size = new System.Drawing.Size(934, 466);
            this.GridViewProducts.TabIndex = 0;
            this.GridViewProducts.TabStop = false;
            this.GridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProducts_CellClick);
            this.GridViewProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProducts_CellEndEdit);
            this.GridViewProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProducts_CellValueChanged);
            // 
            // products_category
            // 
            this.products_category.HeaderText = "Category";
            this.products_category.Name = "products_category";
            this.products_category.ReadOnly = true;
            this.products_category.Visible = false;
            // 
            // products_name
            // 
            this.products_name.FillWeight = 248.7309F;
            this.products_name.HeaderText = "Product Name";
            this.products_name.Name = "products_name";
            // 
            // products_coefficient
            // 
            this.products_coefficient.FillWeight = 75.21147F;
            this.products_coefficient.HeaderText = "Coefficient";
            this.products_coefficient.Name = "products_coefficient";
            // 
            // products_maxstock
            // 
            this.products_maxstock.FillWeight = 75.21147F;
            this.products_maxstock.HeaderText = "Max stock";
            this.products_maxstock.Name = "products_maxstock";
            // 
            // products_tradeqty
            // 
            this.products_tradeqty.FillWeight = 75.21147F;
            this.products_tradeqty.HeaderText = "Trade Quantity";
            this.products_tradeqty.Name = "products_tradeqty";
            // 
            // products_buyprice
            // 
            this.products_buyprice.FillWeight = 75.21147F;
            this.products_buyprice.HeaderText = "Buy price";
            this.products_buyprice.Name = "products_buyprice";
            // 
            // products_sellPrice
            // 
            this.products_sellPrice.FillWeight = 75.21147F;
            this.products_sellPrice.HeaderText = "Sell price";
            this.products_sellPrice.Name = "products_sellPrice";
            // 
            // products_destock
            // 
            this.products_destock.FillWeight = 75.21147F;
            this.products_destock.HeaderText = "Destock Coefficient";
            this.products_destock.Name = "products_destock";
            // 
            // FlowPanelProductControl
            // 
            this.FlowPanelProductControl.AutoSize = true;
            this.FlowPanelProductControl.Controls.Add(this.PanelNewProduct);
            this.FlowPanelProductControl.Controls.Add(this.PanelCoefficent);
            this.FlowPanelProductControl.Controls.Add(this.PanelMaxStock);
            this.FlowPanelProductControl.Controls.Add(this.PanelTradeQuantity);
            this.FlowPanelProductControl.Controls.Add(this.PanelBuyPrice);
            this.FlowPanelProductControl.Controls.Add(this.PanelSellPrice);
            this.FlowPanelProductControl.Controls.Add(this.PanelDestockCoefficent);
            this.FlowPanelProductControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowPanelProductControl.Location = new System.Drawing.Point(0, 466);
            this.FlowPanelProductControl.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelProductControl.Name = "FlowPanelProductControl";
            this.FlowPanelProductControl.Size = new System.Drawing.Size(934, 110);
            this.FlowPanelProductControl.TabIndex = 1;
            // 
            // PanelNewProduct
            // 
            this.PanelNewProduct.Controls.Add(this.LabelNewProductName);
            this.PanelNewProduct.Controls.Add(this.TextBoxNewProductName);
            this.PanelNewProduct.Controls.Add(this.ButtonAddNewProduct);
            this.PanelNewProduct.Location = new System.Drawing.Point(0, 0);
            this.PanelNewProduct.Margin = new System.Windows.Forms.Padding(0);
            this.PanelNewProduct.Name = "PanelNewProduct";
            this.PanelNewProduct.Size = new System.Drawing.Size(195, 55);
            this.PanelNewProduct.TabIndex = 0;
            // 
            // LabelNewProductName
            // 
            this.LabelNewProductName.AutoSize = true;
            this.LabelNewProductName.ForeColor = System.Drawing.Color.White;
            this.LabelNewProductName.Location = new System.Drawing.Point(10, 6);
            this.LabelNewProductName.Margin = new System.Windows.Forms.Padding(1);
            this.LabelNewProductName.Name = "LabelNewProductName";
            this.LabelNewProductName.Size = new System.Drawing.Size(119, 17);
            this.LabelNewProductName.TabIndex = 9;
            this.LabelNewProductName.Text = "New Product Name:";
            // 
            // TextBoxNewProductName
            // 
            this.TextBoxNewProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNewProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxNewProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNewProductName.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxNewProductName.ForeColor = System.Drawing.Color.White;
            this.TextBoxNewProductName.Location = new System.Drawing.Point(10, 24);
            this.TextBoxNewProductName.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxNewProductName.Name = "TextBoxNewProductName";
            this.TextBoxNewProductName.Size = new System.Drawing.Size(148, 22);
            this.TextBoxNewProductName.TabIndex = 8;
            this.TextBoxNewProductName.TabStop = false;
            // 
            // ButtonAddNewProduct
            // 
            this.ButtonAddNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddNewProduct.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddNewProduct.FlatAppearance.BorderSize = 0;
            this.ButtonAddNewProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonAddNewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonAddNewProduct.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ButtonAddNewProduct.IconColor = System.Drawing.Color.White;
            this.ButtonAddNewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAddNewProduct.IconSize = 30;
            this.ButtonAddNewProduct.Location = new System.Drawing.Point(158, 21);
            this.ButtonAddNewProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddNewProduct.Name = "ButtonAddNewProduct";
            this.ButtonAddNewProduct.Size = new System.Drawing.Size(30, 30);
            this.ButtonAddNewProduct.TabIndex = 7;
            this.ButtonAddNewProduct.TabStop = false;
            this.ButtonAddNewProduct.UseVisualStyleBackColor = false;
            this.ButtonAddNewProduct.Click += new System.EventHandler(this.ButtonAddNewProduct_Click);
            // 
            // PanelCoefficent
            // 
            this.PanelCoefficent.Controls.Add(this.LabelCoefficent);
            this.PanelCoefficent.Controls.Add(this.TextBoxCoefficent);
            this.PanelCoefficent.Controls.Add(this.ButtonCoefficent);
            this.PanelCoefficent.Location = new System.Drawing.Point(195, 0);
            this.PanelCoefficent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCoefficent.Name = "PanelCoefficent";
            this.PanelCoefficent.Size = new System.Drawing.Size(195, 55);
            this.PanelCoefficent.TabIndex = 1;
            // 
            // LabelCoefficent
            // 
            this.LabelCoefficent.AutoSize = true;
            this.LabelCoefficent.ForeColor = System.Drawing.Color.White;
            this.LabelCoefficent.Location = new System.Drawing.Point(10, 6);
            this.LabelCoefficent.Margin = new System.Windows.Forms.Padding(1);
            this.LabelCoefficent.Name = "LabelCoefficent";
            this.LabelCoefficent.Size = new System.Drawing.Size(68, 17);
            this.LabelCoefficent.TabIndex = 9;
            this.LabelCoefficent.Text = "Coefficent:";
            // 
            // TextBoxCoefficent
            // 
            this.TextBoxCoefficent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCoefficent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxCoefficent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCoefficent.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxCoefficent.ForeColor = System.Drawing.Color.White;
            this.TextBoxCoefficent.Location = new System.Drawing.Point(10, 24);
            this.TextBoxCoefficent.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxCoefficent.Name = "TextBoxCoefficent";
            this.TextBoxCoefficent.Size = new System.Drawing.Size(148, 22);
            this.TextBoxCoefficent.TabIndex = 8;
            this.TextBoxCoefficent.TabStop = false;
            // 
            // ButtonCoefficent
            // 
            this.ButtonCoefficent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCoefficent.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCoefficent.FlatAppearance.BorderSize = 0;
            this.ButtonCoefficent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonCoefficent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonCoefficent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCoefficent.ForeColor = System.Drawing.Color.White;
            this.ButtonCoefficent.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonCoefficent.IconColor = System.Drawing.Color.White;
            this.ButtonCoefficent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCoefficent.IconSize = 30;
            this.ButtonCoefficent.Location = new System.Drawing.Point(158, 21);
            this.ButtonCoefficent.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCoefficent.Name = "ButtonCoefficent";
            this.ButtonCoefficent.Size = new System.Drawing.Size(30, 30);
            this.ButtonCoefficent.TabIndex = 7;
            this.ButtonCoefficent.TabStop = false;
            this.ButtonCoefficent.UseVisualStyleBackColor = false;
            this.ButtonCoefficent.Click += new System.EventHandler(this.ButtonCoefficent_Click);
            // 
            // PanelMaxStock
            // 
            this.PanelMaxStock.Controls.Add(this.LabelMaxStock);
            this.PanelMaxStock.Controls.Add(this.TextBoxMaxStock);
            this.PanelMaxStock.Controls.Add(this.ButtonMaxStock);
            this.PanelMaxStock.Location = new System.Drawing.Point(390, 0);
            this.PanelMaxStock.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMaxStock.Name = "PanelMaxStock";
            this.PanelMaxStock.Size = new System.Drawing.Size(195, 55);
            this.PanelMaxStock.TabIndex = 2;
            // 
            // LabelMaxStock
            // 
            this.LabelMaxStock.AutoSize = true;
            this.LabelMaxStock.ForeColor = System.Drawing.Color.White;
            this.LabelMaxStock.Location = new System.Drawing.Point(10, 6);
            this.LabelMaxStock.Margin = new System.Windows.Forms.Padding(1);
            this.LabelMaxStock.Name = "LabelMaxStock";
            this.LabelMaxStock.Size = new System.Drawing.Size(68, 17);
            this.LabelMaxStock.TabIndex = 9;
            this.LabelMaxStock.Text = "Max Stock:";
            // 
            // TextBoxMaxStock
            // 
            this.TextBoxMaxStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMaxStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxMaxStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMaxStock.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxMaxStock.ForeColor = System.Drawing.Color.White;
            this.TextBoxMaxStock.Location = new System.Drawing.Point(10, 24);
            this.TextBoxMaxStock.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxMaxStock.Name = "TextBoxMaxStock";
            this.TextBoxMaxStock.Size = new System.Drawing.Size(148, 22);
            this.TextBoxMaxStock.TabIndex = 8;
            this.TextBoxMaxStock.TabStop = false;
            // 
            // ButtonMaxStock
            // 
            this.ButtonMaxStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaxStock.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMaxStock.FlatAppearance.BorderSize = 0;
            this.ButtonMaxStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonMaxStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonMaxStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMaxStock.ForeColor = System.Drawing.Color.White;
            this.ButtonMaxStock.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonMaxStock.IconColor = System.Drawing.Color.White;
            this.ButtonMaxStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonMaxStock.IconSize = 30;
            this.ButtonMaxStock.Location = new System.Drawing.Point(158, 21);
            this.ButtonMaxStock.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMaxStock.Name = "ButtonMaxStock";
            this.ButtonMaxStock.Size = new System.Drawing.Size(30, 30);
            this.ButtonMaxStock.TabIndex = 7;
            this.ButtonMaxStock.TabStop = false;
            this.ButtonMaxStock.UseVisualStyleBackColor = false;
            this.ButtonMaxStock.Click += new System.EventHandler(this.ButtonMaxStock_Click);
            // 
            // PanelTradeQuantity
            // 
            this.PanelTradeQuantity.Controls.Add(this.LabelTradeQuantity);
            this.PanelTradeQuantity.Controls.Add(this.TextBoxTradeQuantity);
            this.PanelTradeQuantity.Controls.Add(this.ButtonTradeQuantity);
            this.PanelTradeQuantity.Location = new System.Drawing.Point(585, 0);
            this.PanelTradeQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTradeQuantity.Name = "PanelTradeQuantity";
            this.PanelTradeQuantity.Size = new System.Drawing.Size(195, 55);
            this.PanelTradeQuantity.TabIndex = 3;
            // 
            // LabelTradeQuantity
            // 
            this.LabelTradeQuantity.AutoSize = true;
            this.LabelTradeQuantity.ForeColor = System.Drawing.Color.White;
            this.LabelTradeQuantity.Location = new System.Drawing.Point(10, 6);
            this.LabelTradeQuantity.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTradeQuantity.Name = "LabelTradeQuantity";
            this.LabelTradeQuantity.Size = new System.Drawing.Size(93, 17);
            this.LabelTradeQuantity.TabIndex = 9;
            this.LabelTradeQuantity.Text = "Trade Quantity:";
            // 
            // TextBoxTradeQuantity
            // 
            this.TextBoxTradeQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTradeQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxTradeQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTradeQuantity.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxTradeQuantity.ForeColor = System.Drawing.Color.White;
            this.TextBoxTradeQuantity.Location = new System.Drawing.Point(10, 24);
            this.TextBoxTradeQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxTradeQuantity.Name = "TextBoxTradeQuantity";
            this.TextBoxTradeQuantity.Size = new System.Drawing.Size(148, 22);
            this.TextBoxTradeQuantity.TabIndex = 8;
            this.TextBoxTradeQuantity.TabStop = false;
            // 
            // ButtonTradeQuantity
            // 
            this.ButtonTradeQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTradeQuantity.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTradeQuantity.FlatAppearance.BorderSize = 0;
            this.ButtonTradeQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonTradeQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonTradeQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTradeQuantity.ForeColor = System.Drawing.Color.White;
            this.ButtonTradeQuantity.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonTradeQuantity.IconColor = System.Drawing.Color.White;
            this.ButtonTradeQuantity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonTradeQuantity.IconSize = 30;
            this.ButtonTradeQuantity.Location = new System.Drawing.Point(158, 21);
            this.ButtonTradeQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTradeQuantity.Name = "ButtonTradeQuantity";
            this.ButtonTradeQuantity.Size = new System.Drawing.Size(30, 30);
            this.ButtonTradeQuantity.TabIndex = 7;
            this.ButtonTradeQuantity.TabStop = false;
            this.ButtonTradeQuantity.UseVisualStyleBackColor = false;
            this.ButtonTradeQuantity.Click += new System.EventHandler(this.ButtonTradeQuantity_Click);
            // 
            // PanelBuyPrice
            // 
            this.PanelBuyPrice.Controls.Add(this.LabelBuyPrice);
            this.PanelBuyPrice.Controls.Add(this.TextBoxBuyPrice);
            this.PanelBuyPrice.Controls.Add(this.ButtonBuyPrice);
            this.PanelBuyPrice.Location = new System.Drawing.Point(0, 55);
            this.PanelBuyPrice.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBuyPrice.Name = "PanelBuyPrice";
            this.PanelBuyPrice.Size = new System.Drawing.Size(195, 55);
            this.PanelBuyPrice.TabIndex = 4;
            // 
            // LabelBuyPrice
            // 
            this.LabelBuyPrice.AutoSize = true;
            this.LabelBuyPrice.ForeColor = System.Drawing.Color.White;
            this.LabelBuyPrice.Location = new System.Drawing.Point(10, 6);
            this.LabelBuyPrice.Margin = new System.Windows.Forms.Padding(1);
            this.LabelBuyPrice.Name = "LabelBuyPrice";
            this.LabelBuyPrice.Size = new System.Drawing.Size(63, 17);
            this.LabelBuyPrice.TabIndex = 9;
            this.LabelBuyPrice.Text = "Buy Price:";
            // 
            // TextBoxBuyPrice
            // 
            this.TextBoxBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBuyPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxBuyPrice.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxBuyPrice.ForeColor = System.Drawing.Color.White;
            this.TextBoxBuyPrice.Location = new System.Drawing.Point(10, 24);
            this.TextBoxBuyPrice.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxBuyPrice.Name = "TextBoxBuyPrice";
            this.TextBoxBuyPrice.Size = new System.Drawing.Size(148, 22);
            this.TextBoxBuyPrice.TabIndex = 8;
            this.TextBoxBuyPrice.TabStop = false;
            // 
            // ButtonBuyPrice
            // 
            this.ButtonBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBuyPrice.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBuyPrice.FlatAppearance.BorderSize = 0;
            this.ButtonBuyPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonBuyPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonBuyPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBuyPrice.ForeColor = System.Drawing.Color.White;
            this.ButtonBuyPrice.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonBuyPrice.IconColor = System.Drawing.Color.White;
            this.ButtonBuyPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonBuyPrice.IconSize = 30;
            this.ButtonBuyPrice.Location = new System.Drawing.Point(158, 21);
            this.ButtonBuyPrice.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBuyPrice.Name = "ButtonBuyPrice";
            this.ButtonBuyPrice.Size = new System.Drawing.Size(30, 30);
            this.ButtonBuyPrice.TabIndex = 7;
            this.ButtonBuyPrice.TabStop = false;
            this.ButtonBuyPrice.UseVisualStyleBackColor = false;
            this.ButtonBuyPrice.Click += new System.EventHandler(this.ButtonBuyPrice_Click);
            // 
            // PanelSellPrice
            // 
            this.PanelSellPrice.Controls.Add(this.LabelSellPrice);
            this.PanelSellPrice.Controls.Add(this.TextBoxSellPrice);
            this.PanelSellPrice.Controls.Add(this.ButtonSellPrice);
            this.PanelSellPrice.Location = new System.Drawing.Point(195, 55);
            this.PanelSellPrice.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSellPrice.Name = "PanelSellPrice";
            this.PanelSellPrice.Size = new System.Drawing.Size(195, 55);
            this.PanelSellPrice.TabIndex = 5;
            // 
            // LabelSellPrice
            // 
            this.LabelSellPrice.AutoSize = true;
            this.LabelSellPrice.ForeColor = System.Drawing.Color.White;
            this.LabelSellPrice.Location = new System.Drawing.Point(10, 6);
            this.LabelSellPrice.Margin = new System.Windows.Forms.Padding(1);
            this.LabelSellPrice.Name = "LabelSellPrice";
            this.LabelSellPrice.Size = new System.Drawing.Size(62, 17);
            this.LabelSellPrice.TabIndex = 9;
            this.LabelSellPrice.Text = "Sell Price:";
            // 
            // TextBoxSellPrice
            // 
            this.TextBoxSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSellPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxSellPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSellPrice.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxSellPrice.ForeColor = System.Drawing.Color.White;
            this.TextBoxSellPrice.Location = new System.Drawing.Point(10, 24);
            this.TextBoxSellPrice.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxSellPrice.Name = "TextBoxSellPrice";
            this.TextBoxSellPrice.Size = new System.Drawing.Size(148, 22);
            this.TextBoxSellPrice.TabIndex = 8;
            this.TextBoxSellPrice.TabStop = false;
            // 
            // ButtonSellPrice
            // 
            this.ButtonSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSellPrice.FlatAppearance.BorderSize = 0;
            this.ButtonSellPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonSellPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonSellPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSellPrice.ForeColor = System.Drawing.Color.White;
            this.ButtonSellPrice.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonSellPrice.IconColor = System.Drawing.Color.White;
            this.ButtonSellPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSellPrice.IconSize = 30;
            this.ButtonSellPrice.Location = new System.Drawing.Point(158, 21);
            this.ButtonSellPrice.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSellPrice.Name = "ButtonSellPrice";
            this.ButtonSellPrice.Size = new System.Drawing.Size(30, 30);
            this.ButtonSellPrice.TabIndex = 7;
            this.ButtonSellPrice.TabStop = false;
            this.ButtonSellPrice.UseVisualStyleBackColor = false;
            this.ButtonSellPrice.Click += new System.EventHandler(this.ButtonSellPrice_Click);
            // 
            // PanelDestockCoefficent
            // 
            this.PanelDestockCoefficent.Controls.Add(this.LabelDestockCoefficent);
            this.PanelDestockCoefficent.Controls.Add(this.TextBoxDestockCoefficent);
            this.PanelDestockCoefficent.Controls.Add(this.ButtonDestockCoefficent);
            this.PanelDestockCoefficent.Location = new System.Drawing.Point(390, 55);
            this.PanelDestockCoefficent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelDestockCoefficent.Name = "PanelDestockCoefficent";
            this.PanelDestockCoefficent.Size = new System.Drawing.Size(195, 55);
            this.PanelDestockCoefficent.TabIndex = 6;
            // 
            // LabelDestockCoefficent
            // 
            this.LabelDestockCoefficent.AutoSize = true;
            this.LabelDestockCoefficent.ForeColor = System.Drawing.Color.White;
            this.LabelDestockCoefficent.Location = new System.Drawing.Point(10, 6);
            this.LabelDestockCoefficent.Margin = new System.Windows.Forms.Padding(1);
            this.LabelDestockCoefficent.Name = "LabelDestockCoefficent";
            this.LabelDestockCoefficent.Size = new System.Drawing.Size(116, 17);
            this.LabelDestockCoefficent.TabIndex = 9;
            this.LabelDestockCoefficent.Text = "Destock Coefficent:";
            // 
            // TextBoxDestockCoefficent
            // 
            this.TextBoxDestockCoefficent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDestockCoefficent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TextBoxDestockCoefficent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDestockCoefficent.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.TextBoxDestockCoefficent.ForeColor = System.Drawing.Color.White;
            this.TextBoxDestockCoefficent.Location = new System.Drawing.Point(10, 24);
            this.TextBoxDestockCoefficent.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxDestockCoefficent.Name = "TextBoxDestockCoefficent";
            this.TextBoxDestockCoefficent.Size = new System.Drawing.Size(148, 22);
            this.TextBoxDestockCoefficent.TabIndex = 8;
            this.TextBoxDestockCoefficent.TabStop = false;
            // 
            // ButtonDestockCoefficent
            // 
            this.ButtonDestockCoefficent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDestockCoefficent.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDestockCoefficent.FlatAppearance.BorderSize = 0;
            this.ButtonDestockCoefficent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonDestockCoefficent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonDestockCoefficent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDestockCoefficent.ForeColor = System.Drawing.Color.White;
            this.ButtonDestockCoefficent.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonDestockCoefficent.IconColor = System.Drawing.Color.White;
            this.ButtonDestockCoefficent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDestockCoefficent.IconSize = 30;
            this.ButtonDestockCoefficent.Location = new System.Drawing.Point(158, 21);
            this.ButtonDestockCoefficent.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDestockCoefficent.Name = "ButtonDestockCoefficent";
            this.ButtonDestockCoefficent.Size = new System.Drawing.Size(30, 30);
            this.ButtonDestockCoefficent.TabIndex = 7;
            this.ButtonDestockCoefficent.TabStop = false;
            this.ButtonDestockCoefficent.UseVisualStyleBackColor = false;
            this.ButtonDestockCoefficent.Click += new System.EventHandler(this.ButtonDestockCoefficent_Click);
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_Version.Location = new System.Drawing.Point(1149, 0);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(85, 17);
            this.Label_Version.TabIndex = 7;
            this.Label_Version.Text = "Label_Version";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_Version);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 696);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 15);
            this.panel1.TabIndex = 9;
            // 
            // Panel_Dashboard
            // 
            this.Panel_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Panel_Dashboard.BackgroundImage = global::TraderPlusEditor.Properties.Resources.xscr33mLabs_Tile_S;
            this.Panel_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Dashboard.Controls.Add(this.PanelNotifications);
            this.Panel_Dashboard.Controls.Add(this.PanelFileControls);
            this.Panel_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Panel_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Dashboard.Name = "Panel_Dashboard";
            this.Panel_Dashboard.Size = new System.Drawing.Size(1234, 60);
            this.Panel_Dashboard.TabIndex = 6;
            // 
            // PanelNotifications
            // 
            this.PanelNotifications.AutoSize = true;
            this.PanelNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PanelNotifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNotifications.Controls.Add(this.LabelNotifications);
            this.PanelNotifications.Controls.Add(this.IconNotification);
            this.PanelNotifications.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelNotifications.Location = new System.Drawing.Point(0, 0);
            this.PanelNotifications.Margin = new System.Windows.Forms.Padding(0);
            this.PanelNotifications.MinimumSize = new System.Drawing.Size(2, 60);
            this.PanelNotifications.Name = "PanelNotifications";
            this.PanelNotifications.Size = new System.Drawing.Size(139, 60);
            this.PanelNotifications.TabIndex = 10;
            this.PanelNotifications.Visible = false;
            // 
            // LabelNotifications
            // 
            this.LabelNotifications.AutoSize = true;
            this.LabelNotifications.BackColor = System.Drawing.Color.Transparent;
            this.LabelNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelNotifications.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.LabelNotifications.Location = new System.Drawing.Point(60, 0);
            this.LabelNotifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNotifications.MaximumSize = new System.Drawing.Size(1000, 150);
            this.LabelNotifications.Name = "LabelNotifications";
            this.LabelNotifications.Padding = new System.Windows.Forms.Padding(0, 0, 18, 12);
            this.LabelNotifications.Size = new System.Drawing.Size(77, 34);
            this.LabelNotifications.TabIndex = 0;
            this.LabelNotifications.Text = "Label7";
            this.LabelNotifications.UseMnemonic = false;
            // 
            // IconNotification
            // 
            this.IconNotification.BackColor = System.Drawing.Color.Transparent;
            this.IconNotification.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconNotification.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconNotification.IconColor = System.Drawing.Color.White;
            this.IconNotification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconNotification.IconSize = 60;
            this.IconNotification.Location = new System.Drawing.Point(0, 0);
            this.IconNotification.Margin = new System.Windows.Forms.Padding(0);
            this.IconNotification.MaximumSize = new System.Drawing.Size(60, 60);
            this.IconNotification.MinimumSize = new System.Drawing.Size(60, 60);
            this.IconNotification.Name = "IconNotification";
            this.IconNotification.Size = new System.Drawing.Size(60, 60);
            this.IconNotification.TabIndex = 1;
            this.IconNotification.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.PanelProductsMain);
            this.Controls.Add(this.PanelCategories);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.Panel_Dashboard);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(768, 500);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xscr33mLabs - TraderPlusEditor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.PanelProductControls.ResumeLayout(false);
            this.PanelFileSettings.ResumeLayout(false);
            this.PanelFileSettings.PerformLayout();
            this.PanelFileControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.PanelCategories.ResumeLayout(false);
            this.PanelCategories.PerformLayout();
            this.PanelCategoriesBottom.ResumeLayout(false);
            this.PanelCategoriesBottom.PerformLayout();
            this.PanelPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPreview)).EndInit();
            this.PanelProductsMain.ResumeLayout(false);
            this.PanelProductsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProducts)).EndInit();
            this.FlowPanelProductControl.ResumeLayout(false);
            this.PanelNewProduct.ResumeLayout(false);
            this.PanelNewProduct.PerformLayout();
            this.PanelCoefficent.ResumeLayout(false);
            this.PanelCoefficent.PerformLayout();
            this.PanelMaxStock.ResumeLayout(false);
            this.PanelMaxStock.PerformLayout();
            this.PanelTradeQuantity.ResumeLayout(false);
            this.PanelTradeQuantity.PerformLayout();
            this.PanelBuyPrice.ResumeLayout(false);
            this.PanelBuyPrice.PerformLayout();
            this.PanelSellPrice.ResumeLayout(false);
            this.PanelSellPrice.PerformLayout();
            this.PanelDestockCoefficent.ResumeLayout(false);
            this.PanelDestockCoefficent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Dashboard.ResumeLayout(false);
            this.Panel_Dashboard.PerformLayout();
            this.PanelNotifications.ResumeLayout(false);
            this.PanelNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconNotification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Panel_Dashboard;
        public Panel PanelNotifications;
        public Label LabelNotifications;
        private PictureBox PictureBoxLogo;
        public FontAwesome.Sharp.IconPictureBox IconNotification;
        private Panel PanelTop;
        private Panel PanelSearch;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private TextBox TextboxSearch;
        private Panel PanelProductControls;
        private FontAwesome.Sharp.IconButton ButtonDeleteProduct;
        private FontAwesome.Sharp.IconButton ButtonProductUp;
        private FontAwesome.Sharp.IconButton ButtonProductDown;
        private Panel PanelFileSettings;
        private CheckBox CheckBoxDefaultTraderStock;
        private TextBox TextBoxVersion;
        private CheckBox CheckBoxAutoCalculation;
        private Label LabelVersion;
        private CheckBox CheckBoxAutoDestock;
        private Panel PanelFileControls;
        private FontAwesome.Sharp.IconButton ButtonOpenFile;
        private FontAwesome.Sharp.IconButton ButtonOpenExports;
        private FontAwesome.Sharp.IconButton ButtonSaveFile;
        private Panel PanelCategories;
        private ListView ListViewCategories;
        private ColumnHeader categories;
        private Label LabelCategories;
        private Panel PanelCategoriesBottom;
        private FontAwesome.Sharp.IconButton ButtonEditCategory;
        private FontAwesome.Sharp.IconButton ButtonDeleteCategory;
        private Label LabelNewCategory;
        private TextBox TextBoxCategoryName;
        private FontAwesome.Sharp.IconButton ButtonAddCategory;
        private Panel PanelPreview;
        private PictureBox PictureBoxPreview;
        private Panel PanelProductsMain;
        private DataGridView GridViewProducts;
        private FlowLayoutPanel FlowPanelProductControl;
        private Panel PanelNewProduct;
        private Label LabelNewProductName;
        private TextBox TextBoxNewProductName;
        private FontAwesome.Sharp.IconButton ButtonAddNewProduct;
        private Panel PanelCoefficent;
        private Label LabelCoefficent;
        private TextBox TextBoxCoefficent;
        private FontAwesome.Sharp.IconButton ButtonCoefficent;
        private Panel PanelMaxStock;
        private Label LabelMaxStock;
        private TextBox TextBoxMaxStock;
        private FontAwesome.Sharp.IconButton ButtonMaxStock;
        private Panel PanelTradeQuantity;
        private Label LabelTradeQuantity;
        private TextBox TextBoxTradeQuantity;
        private FontAwesome.Sharp.IconButton ButtonTradeQuantity;
        private Panel PanelBuyPrice;
        private Label LabelBuyPrice;
        private TextBox TextBoxBuyPrice;
        private FontAwesome.Sharp.IconButton ButtonBuyPrice;
        private Panel PanelSellPrice;
        private Label LabelSellPrice;
        private TextBox TextBoxSellPrice;
        private FontAwesome.Sharp.IconButton ButtonSellPrice;
        private Panel PanelDestockCoefficent;
        private Label LabelDestockCoefficent;
        private TextBox TextBoxDestockCoefficent;
        private FontAwesome.Sharp.IconButton ButtonDestockCoefficent;
        private FontAwesome.Sharp.IconButton ButtonSettings;
        private FontAwesome.Sharp.IconButton ButtonFileClose;
        private DataGridViewTextBoxColumn products_category;
        private DataGridViewTextBoxColumn products_name;
        private DataGridViewTextBoxColumn products_coefficient;
        private DataGridViewTextBoxColumn products_maxstock;
        private DataGridViewTextBoxColumn products_tradeqty;
        private DataGridViewTextBoxColumn products_buyprice;
        private DataGridViewTextBoxColumn products_sellPrice;
        private DataGridViewTextBoxColumn products_destock;
        private Label Label_Version;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton Button_Info;
    }
}