namespace TraderPlusEditor._Core._Forms
{
    partial class EULADialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EULADialog));
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.PanelLabel = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelIcon = new System.Windows.Forms.Panel();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.Label_Copied = new System.Windows.Forms.Label();
            this.ButtonAccept = new FontAwesome.Sharp.IconButton();
            this.ButtonDeny = new FontAwesome.Sharp.IconButton();
            this.Button_CopyToClipboard = new FontAwesome.Sharp.IconButton();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.TextBoxContent = new System.Windows.Forms.RichTextBox();
            this.PanelTitle.SuspendLayout();
            this.PanelLabel.SuspendLayout();
            this.PanelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.PanelBottom.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackgroundImage = global::TraderPlusEditor.Properties.Resources.xscr33mLabs_Tile_S;
            this.PanelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTitle.Controls.Add(this.PanelLabel);
            this.PanelTitle.Controls.Add(this.PanelIcon);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.ForeColor = System.Drawing.Color.White;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(494, 50);
            this.PanelTitle.TabIndex = 0;
            // 
            // PanelLabel
            // 
            this.PanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.PanelLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLabel.Controls.Add(this.LabelTitle);
            this.PanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLabel.Location = new System.Drawing.Point(65, 0);
            this.PanelLabel.Name = "PanelLabel";
            this.PanelLabel.Size = new System.Drawing.Size(429, 50);
            this.PanelLabel.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTitle.MaximumSize = new System.Drawing.Size(394, 1207);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.LabelTitle.Size = new System.Drawing.Size(128, 27);
            this.LabelTitle.TabIndex = 10;
            this.LabelTitle.Text = "EULA Hinweis";
            this.LabelTitle.UseMnemonic = false;
            // 
            // PanelIcon
            // 
            this.PanelIcon.BackColor = System.Drawing.Color.Transparent;
            this.PanelIcon.Controls.Add(this.IconPictureBox);
            this.PanelIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIcon.Location = new System.Drawing.Point(0, 0);
            this.PanelIcon.Name = "PanelIcon";
            this.PanelIcon.Size = new System.Drawing.Size(65, 50);
            this.PanelIcon.TabIndex = 0;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.IconPictureBox.ForeColor = System.Drawing.Color.Honeydew;
            this.IconPictureBox.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.IconPictureBox.IconColor = System.Drawing.Color.Honeydew;
            this.IconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureBox.IconSize = 45;
            this.IconPictureBox.Location = new System.Drawing.Point(9, 7);
            this.IconPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(45, 45);
            this.IconPictureBox.TabIndex = 11;
            this.IconPictureBox.TabStop = false;
            this.IconPictureBox.WaitOnLoad = true;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.Label_Copied);
            this.PanelBottom.Controls.Add(this.ButtonAccept);
            this.PanelBottom.Controls.Add(this.ButtonDeny);
            this.PanelBottom.Controls.Add(this.Button_CopyToClipboard);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.ForeColor = System.Drawing.Color.White;
            this.PanelBottom.Location = new System.Drawing.Point(0, 429);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.PanelBottom.Size = new System.Drawing.Size(494, 65);
            this.PanelBottom.TabIndex = 1;
            // 
            // Label_Copied
            // 
            this.Label_Copied.AutoSize = true;
            this.Label_Copied.Location = new System.Drawing.Point(61, 27);
            this.Label_Copied.Name = "Label_Copied";
            this.Label_Copied.Size = new System.Drawing.Size(87, 17);
            this.Label_Copied.TabIndex = 18;
            this.Label_Copied.Text = "CopyMessage";
            this.Label_Copied.Visible = false;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAccept.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ButtonAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonAccept.FlatAppearance.BorderSize = 0;
            this.ButtonAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccept.ForeColor = System.Drawing.Color.White;
            this.ButtonAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ButtonAccept.IconColor = System.Drawing.Color.Green;
            this.ButtonAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAccept.IconSize = 50;
            this.ButtonAccept.Location = new System.Drawing.Point(294, 5);
            this.ButtonAccept.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(100, 60);
            this.ButtonAccept.TabIndex = 17;
            this.ButtonAccept.TabStop = false;
            this.ButtonAccept.UseVisualStyleBackColor = false;
            // 
            // ButtonDeny
            // 
            this.ButtonDeny.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDeny.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ButtonDeny.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonDeny.FlatAppearance.BorderSize = 0;
            this.ButtonDeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonDeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeny.ForeColor = System.Drawing.Color.White;
            this.ButtonDeny.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ButtonDeny.IconColor = System.Drawing.Color.Red;
            this.ButtonDeny.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeny.IconSize = 50;
            this.ButtonDeny.Location = new System.Drawing.Point(394, 5);
            this.ButtonDeny.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDeny.Name = "ButtonDeny";
            this.ButtonDeny.Size = new System.Drawing.Size(100, 60);
            this.ButtonDeny.TabIndex = 16;
            this.ButtonDeny.TabStop = false;
            this.ButtonDeny.UseVisualStyleBackColor = false;
            // 
            // Button_CopyToClipboard
            // 
            this.Button_CopyToClipboard.BackColor = System.Drawing.Color.Transparent;
            this.Button_CopyToClipboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_CopyToClipboard.FlatAppearance.BorderSize = 0;
            this.Button_CopyToClipboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_CopyToClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_CopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.Button_CopyToClipboard.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.Button_CopyToClipboard.IconColor = System.Drawing.Color.White;
            this.Button_CopyToClipboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_CopyToClipboard.IconSize = 30;
            this.Button_CopyToClipboard.Location = new System.Drawing.Point(0, 5);
            this.Button_CopyToClipboard.Margin = new System.Windows.Forms.Padding(0);
            this.Button_CopyToClipboard.Name = "Button_CopyToClipboard";
            this.Button_CopyToClipboard.Size = new System.Drawing.Size(58, 60);
            this.Button_CopyToClipboard.TabIndex = 15;
            this.Button_CopyToClipboard.TabStop = false;
            this.Button_CopyToClipboard.UseVisualStyleBackColor = false;
            this.Button_CopyToClipboard.Click += new System.EventHandler(this.Button_CopyToClipboard_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.TextBoxContent);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.ForeColor = System.Drawing.Color.White;
            this.PanelContent.Location = new System.Drawing.Point(0, 50);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Padding = new System.Windows.Forms.Padding(5);
            this.PanelContent.Size = new System.Drawing.Size(494, 379);
            this.PanelContent.TabIndex = 2;
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TextBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxContent.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.TextBoxContent.ForeColor = System.Drawing.Color.White;
            this.TextBoxContent.Location = new System.Drawing.Point(5, 5);
            this.TextBoxContent.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.ReadOnly = true;
            this.TextBoxContent.Size = new System.Drawing.Size(484, 369);
            this.TextBoxContent.TabIndex = 0;
            this.TextBoxContent.TabStop = false;
            this.TextBoxContent.Text = "";
            // 
            // EULADialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CancelButton = this.ButtonDeny;
            this.ClientSize = new System.Drawing.Size(494, 494);
            this.ControlBox = false;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "EULADialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EULA";
            this.Load += new System.EventHandler(this.EULADialog_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelLabel.ResumeLayout(false);
            this.PanelLabel.PerformLayout();
            this.PanelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelContent;
        public System.Windows.Forms.Label LabelTitle;
        public FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private FontAwesome.Sharp.IconButton Button_CopyToClipboard;
        public FontAwesome.Sharp.IconButton ButtonAccept;
        public FontAwesome.Sharp.IconButton ButtonDeny;
        public System.Windows.Forms.RichTextBox TextBoxContent;
        private System.Windows.Forms.Panel PanelLabel;
        private System.Windows.Forms.Panel PanelIcon;
        private System.Windows.Forms.Label Label_Copied;
    }
}