namespace TraderPlusEditor._Core._Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.GroupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.PanelLanguage = new System.Windows.Forms.Panel();
            this.PanelPreview = new System.Windows.Forms.Panel();
            this.GroupBoxOptions = new System.Windows.Forms.GroupBox();
            this.CheckBoxShowCategories = new System.Windows.Forms.CheckBox();
            this.CheckBoxPreview = new System.Windows.Forms.CheckBox();
            this.ButtonApply = new FontAwesome.Sharp.IconButton();
            this.PanelCategories = new System.Windows.Forms.Panel();
            this.GroupBoxCategories = new System.Windows.Forms.GroupBox();
            this.Button_Update = new FontAwesome.Sharp.IconButton();
            this.ButtonDeny = new FontAwesome.Sharp.IconButton();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.PanelEULA = new System.Windows.Forms.Panel();
            this.GroupBoxEULA = new System.Windows.Forms.GroupBox();
            this.ButtonEULA = new FontAwesome.Sharp.IconButton();
            this.GroupBoxLanguage.SuspendLayout();
            this.PanelLanguage.SuspendLayout();
            this.PanelPreview.SuspendLayout();
            this.GroupBoxOptions.SuspendLayout();
            this.PanelCategories.SuspendLayout();
            this.GroupBoxCategories.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.PanelEULA.SuspendLayout();
            this.GroupBoxEULA.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxLanguage
            // 
            this.GroupBoxLanguage.Controls.Add(this.ComboBoxLanguage);
            this.GroupBoxLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxLanguage.ForeColor = System.Drawing.Color.White;
            this.GroupBoxLanguage.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBoxLanguage.Name = "GroupBoxLanguage";
            this.GroupBoxLanguage.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.GroupBoxLanguage.Size = new System.Drawing.Size(374, 75);
            this.GroupBoxLanguage.TabIndex = 0;
            this.GroupBoxLanguage.TabStop = false;
            this.GroupBoxLanguage.Text = "Language";
            // 
            // ComboBoxLanguage
            // 
            this.ComboBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxLanguage.ForeColor = System.Drawing.Color.White;
            this.ComboBoxLanguage.FormattingEnabled = true;
            this.ComboBoxLanguage.Location = new System.Drawing.Point(9, 35);
            this.ComboBoxLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLanguage.Name = "ComboBoxLanguage";
            this.ComboBoxLanguage.Size = new System.Drawing.Size(356, 25);
            this.ComboBoxLanguage.TabIndex = 0;
            this.ComboBoxLanguage.TabStop = false;
            this.ComboBoxLanguage.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxLanguage_SelectionChangeCommitted);
            // 
            // PanelLanguage
            // 
            this.PanelLanguage.BackColor = System.Drawing.Color.Transparent;
            this.PanelLanguage.Controls.Add(this.GroupBoxLanguage);
            this.PanelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLanguage.Location = new System.Drawing.Point(5, 5);
            this.PanelLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLanguage.Name = "PanelLanguage";
            this.PanelLanguage.Size = new System.Drawing.Size(374, 75);
            this.PanelLanguage.TabIndex = 2;
            // 
            // PanelPreview
            // 
            this.PanelPreview.BackColor = System.Drawing.Color.Transparent;
            this.PanelPreview.Controls.Add(this.GroupBoxOptions);
            this.PanelPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPreview.Location = new System.Drawing.Point(5, 80);
            this.PanelPreview.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPreview.Name = "PanelPreview";
            this.PanelPreview.Size = new System.Drawing.Size(374, 75);
            this.PanelPreview.TabIndex = 3;
            // 
            // GroupBoxOptions
            // 
            this.GroupBoxOptions.Controls.Add(this.CheckBoxShowCategories);
            this.GroupBoxOptions.Controls.Add(this.CheckBoxPreview);
            this.GroupBoxOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxOptions.ForeColor = System.Drawing.Color.White;
            this.GroupBoxOptions.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxOptions.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBoxOptions.Name = "GroupBoxOptions";
            this.GroupBoxOptions.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.GroupBoxOptions.Size = new System.Drawing.Size(374, 75);
            this.GroupBoxOptions.TabIndex = 0;
            this.GroupBoxOptions.TabStop = false;
            this.GroupBoxOptions.Text = "Options";
            // 
            // CheckBoxShowCategories
            // 
            this.CheckBoxShowCategories.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBoxShowCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.CheckBoxShowCategories.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CheckBoxShowCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CheckBoxShowCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CheckBoxShowCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxShowCategories.ForeColor = System.Drawing.Color.White;
            this.CheckBoxShowCategories.Location = new System.Drawing.Point(187, 31);
            this.CheckBoxShowCategories.Name = "CheckBoxShowCategories";
            this.CheckBoxShowCategories.Size = new System.Drawing.Size(178, 30);
            this.CheckBoxShowCategories.TabIndex = 7;
            this.CheckBoxShowCategories.TabStop = false;
            this.CheckBoxShowCategories.Text = "Show Column Categories";
            this.CheckBoxShowCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxShowCategories.UseVisualStyleBackColor = true;
            this.CheckBoxShowCategories.CheckedChanged += new System.EventHandler(this.CheckBoxShowCategories_CheckedChanged);
            // 
            // CheckBoxPreview
            // 
            this.CheckBoxPreview.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBoxPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.CheckBoxPreview.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CheckBoxPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CheckBoxPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxPreview.ForeColor = System.Drawing.Color.White;
            this.CheckBoxPreview.Location = new System.Drawing.Point(9, 31);
            this.CheckBoxPreview.Name = "CheckBoxPreview";
            this.CheckBoxPreview.Size = new System.Drawing.Size(178, 30);
            this.CheckBoxPreview.TabIndex = 7;
            this.CheckBoxPreview.TabStop = false;
            this.CheckBoxPreview.Text = "Enable Product Preview";
            this.CheckBoxPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxPreview.UseVisualStyleBackColor = true;
            this.CheckBoxPreview.CheckedChanged += new System.EventHandler(this.CheckBoxPreview_CheckedChanged);
            // 
            // ButtonApply
            // 
            this.ButtonApply.BackColor = System.Drawing.Color.Transparent;
            this.ButtonApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonApply.Enabled = false;
            this.ButtonApply.FlatAppearance.BorderSize = 0;
            this.ButtonApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApply.ForeColor = System.Drawing.Color.White;
            this.ButtonApply.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ButtonApply.IconColor = System.Drawing.Color.Green;
            this.ButtonApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonApply.IconSize = 50;
            this.ButtonApply.Location = new System.Drawing.Point(0, 0);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(187, 50);
            this.ButtonApply.TabIndex = 18;
            this.ButtonApply.TabStop = false;
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // PanelCategories
            // 
            this.PanelCategories.BackColor = System.Drawing.Color.Transparent;
            this.PanelCategories.Controls.Add(this.GroupBoxCategories);
            this.PanelCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCategories.Location = new System.Drawing.Point(5, 155);
            this.PanelCategories.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCategories.Name = "PanelCategories";
            this.PanelCategories.Size = new System.Drawing.Size(374, 75);
            this.PanelCategories.TabIndex = 19;
            // 
            // GroupBoxCategories
            // 
            this.GroupBoxCategories.Controls.Add(this.Button_Update);
            this.GroupBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxCategories.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategories.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxCategories.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBoxCategories.Name = "GroupBoxCategories";
            this.GroupBoxCategories.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.GroupBoxCategories.Size = new System.Drawing.Size(374, 75);
            this.GroupBoxCategories.TabIndex = 0;
            this.GroupBoxCategories.TabStop = false;
            this.GroupBoxCategories.Text = "Check for Upates";
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.Transparent;
            this.Button_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Update.FlatAppearance.BorderSize = 0;
            this.Button_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.ForeColor = System.Drawing.Color.White;
            this.Button_Update.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.Button_Update.IconColor = System.Drawing.Color.White;
            this.Button_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Update.IconSize = 40;
            this.Button_Update.Location = new System.Drawing.Point(10, 22);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(354, 43);
            this.Button_Update.TabIndex = 20;
            this.Button_Update.TabStop = false;
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // ButtonDeny
            // 
            this.ButtonDeny.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDeny.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ButtonDeny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDeny.FlatAppearance.BorderSize = 0;
            this.ButtonDeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonDeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeny.ForeColor = System.Drawing.Color.White;
            this.ButtonDeny.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ButtonDeny.IconColor = System.Drawing.Color.Red;
            this.ButtonDeny.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeny.IconSize = 50;
            this.ButtonDeny.Location = new System.Drawing.Point(187, 0);
            this.ButtonDeny.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDeny.Name = "ButtonDeny";
            this.ButtonDeny.Size = new System.Drawing.Size(187, 50);
            this.ButtonDeny.TabIndex = 20;
            this.ButtonDeny.TabStop = false;
            this.ButtonDeny.UseVisualStyleBackColor = false;
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.Color.Transparent;
            this.PanelButtons.Controls.Add(this.ButtonDeny);
            this.PanelButtons.Controls.Add(this.ButtonApply);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(5, 311);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(374, 50);
            this.PanelButtons.TabIndex = 21;
            // 
            // PanelEULA
            // 
            this.PanelEULA.BackColor = System.Drawing.Color.Transparent;
            this.PanelEULA.Controls.Add(this.GroupBoxEULA);
            this.PanelEULA.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEULA.Location = new System.Drawing.Point(5, 230);
            this.PanelEULA.Margin = new System.Windows.Forms.Padding(0);
            this.PanelEULA.Name = "PanelEULA";
            this.PanelEULA.Size = new System.Drawing.Size(374, 75);
            this.PanelEULA.TabIndex = 22;
            // 
            // GroupBoxEULA
            // 
            this.GroupBoxEULA.Controls.Add(this.ButtonEULA);
            this.GroupBoxEULA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxEULA.ForeColor = System.Drawing.Color.White;
            this.GroupBoxEULA.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxEULA.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBoxEULA.Name = "GroupBoxEULA";
            this.GroupBoxEULA.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.GroupBoxEULA.Size = new System.Drawing.Size(374, 75);
            this.GroupBoxEULA.TabIndex = 0;
            this.GroupBoxEULA.TabStop = false;
            this.GroupBoxEULA.Text = "Review EULA";
            // 
            // ButtonEULA
            // 
            this.ButtonEULA.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEULA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEULA.FlatAppearance.BorderSize = 0;
            this.ButtonEULA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonEULA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonEULA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEULA.ForeColor = System.Drawing.Color.White;
            this.ButtonEULA.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.ButtonEULA.IconColor = System.Drawing.Color.White;
            this.ButtonEULA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonEULA.IconSize = 40;
            this.ButtonEULA.Location = new System.Drawing.Point(10, 22);
            this.ButtonEULA.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonEULA.Name = "ButtonEULA";
            this.ButtonEULA.Size = new System.Drawing.Size(354, 43);
            this.ButtonEULA.TabIndex = 19;
            this.ButtonEULA.TabStop = false;
            this.ButtonEULA.UseVisualStyleBackColor = false;
            this.ButtonEULA.Click += new System.EventHandler(this.ButtonEULA_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::TraderPlusEditor.Properties.Resources.xscr33mLabs_Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.PanelEULA);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.PanelCategories);
            this.Controls.Add(this.PanelPreview);
            this.Controls.Add(this.PanelLanguage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormSettings";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.GroupBoxLanguage.ResumeLayout(false);
            this.PanelLanguage.ResumeLayout(false);
            this.PanelPreview.ResumeLayout(false);
            this.GroupBoxOptions.ResumeLayout(false);
            this.PanelCategories.ResumeLayout(false);
            this.GroupBoxCategories.ResumeLayout(false);
            this.PanelButtons.ResumeLayout(false);
            this.PanelEULA.ResumeLayout(false);
            this.GroupBoxEULA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxLanguage;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.Panel PanelLanguage;
        private System.Windows.Forms.Panel PanelPreview;
        private System.Windows.Forms.GroupBox GroupBoxOptions;
        public System.Windows.Forms.CheckBox CheckBoxPreview;
        public FontAwesome.Sharp.IconButton ButtonApply;
        private System.Windows.Forms.Panel PanelCategories;
        private System.Windows.Forms.GroupBox GroupBoxCategories;
        public System.Windows.Forms.CheckBox CheckBoxShowCategories;
        public FontAwesome.Sharp.IconButton ButtonDeny;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelEULA;
        private System.Windows.Forms.GroupBox GroupBoxEULA;
        public FontAwesome.Sharp.IconButton ButtonEULA;
        public FontAwesome.Sharp.IconButton Button_Update;
    }
}