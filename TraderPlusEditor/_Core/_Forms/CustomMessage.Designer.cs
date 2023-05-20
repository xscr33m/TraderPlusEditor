namespace TraderPlusEditor._Core._Forms
{
    partial class CustomMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessage));
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.ButtonOkay = new System.Windows.Forms.Button();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.PanelIcon = new System.Windows.Forms.Panel();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.PanelTopBar = new System.Windows.Forms.Panel();
            this.PanelMessageContent = new System.Windows.Forms.Panel();
            this.LabelMessageContent = new System.Windows.Forms.Label();
            this.PanelButtons.SuspendLayout();
            this.PanelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.PanelMessageContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.Color.Transparent;
            this.PanelButtons.Controls.Add(this.ButtonOkay);
            this.PanelButtons.Controls.Add(this.ButtonNo);
            this.PanelButtons.Controls.Add(this.ButtonYes);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(85, 59);
            this.PanelButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(267, 61);
            this.PanelButtons.TabIndex = 4;
            // 
            // ButtonOkay
            // 
            this.ButtonOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOkay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOkay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOkay.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.ButtonOkay.Location = new System.Drawing.Point(134, 8);
            this.ButtonOkay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonOkay.Name = "ButtonOkay";
            this.ButtonOkay.Size = new System.Drawing.Size(120, 42);
            this.ButtonOkay.TabIndex = 2;
            this.ButtonOkay.Text = "OKAY";
            this.ButtonOkay.UseVisualStyleBackColor = false;
            // 
            // ButtonNo
            // 
            this.ButtonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ButtonNo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonNo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNo.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.ButtonNo.Location = new System.Drawing.Point(133, 8);
            this.ButtonNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(120, 42);
            this.ButtonNo.TabIndex = 1;
            this.ButtonNo.Text = "NO";
            this.ButtonNo.UseVisualStyleBackColor = true;
            // 
            // ButtonYes
            // 
            this.ButtonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonYes.BackColor = System.Drawing.Color.Transparent;
            this.ButtonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ButtonYes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYes.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.ButtonYes.Location = new System.Drawing.Point(6, 8);
            this.ButtonYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(120, 42);
            this.ButtonYes.TabIndex = 9;
            this.ButtonYes.Text = "YES";
            this.ButtonYes.UseVisualStyleBackColor = false;
            // 
            // PanelIcon
            // 
            this.PanelIcon.BackColor = System.Drawing.Color.Transparent;
            this.PanelIcon.Controls.Add(this.IconPictureBox);
            this.PanelIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIcon.Location = new System.Drawing.Point(0, 0);
            this.PanelIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelIcon.Name = "PanelIcon";
            this.PanelIcon.Size = new System.Drawing.Size(85, 120);
            this.PanelIcon.TabIndex = 6;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.IconPictureBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconPictureBox.IconColor = System.Drawing.Color.White;
            this.IconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureBox.IconSize = 58;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 29);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(58, 66);
            this.IconPictureBox.TabIndex = 1;
            this.IconPictureBox.TabStop = false;
            // 
            // PanelTopBar
            // 
            this.PanelTopBar.BackColor = System.Drawing.Color.Transparent;
            this.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopBar.Location = new System.Drawing.Point(85, 0);
            this.PanelTopBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelTopBar.Name = "PanelTopBar";
            this.PanelTopBar.Size = new System.Drawing.Size(267, 24);
            this.PanelTopBar.TabIndex = 5;
            // 
            // PanelMessageContent
            // 
            this.PanelMessageContent.AutoSize = true;
            this.PanelMessageContent.BackColor = System.Drawing.Color.Transparent;
            this.PanelMessageContent.Controls.Add(this.LabelMessageContent);
            this.PanelMessageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMessageContent.Location = new System.Drawing.Point(85, 24);
            this.PanelMessageContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelMessageContent.MaximumSize = new System.Drawing.Size(362, 1046);
            this.PanelMessageContent.Name = "PanelMessageContent";
            this.PanelMessageContent.Padding = new System.Windows.Forms.Padding(0, 0, 18, 14);
            this.PanelMessageContent.Size = new System.Drawing.Size(267, 35);
            this.PanelMessageContent.TabIndex = 7;
            // 
            // LabelMessageContent
            // 
            this.LabelMessageContent.AutoSize = true;
            this.LabelMessageContent.BackColor = System.Drawing.Color.Transparent;
            this.LabelMessageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMessageContent.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.LabelMessageContent.Location = new System.Drawing.Point(0, 0);
            this.LabelMessageContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMessageContent.MaximumSize = new System.Drawing.Size(338, 1046);
            this.LabelMessageContent.Name = "LabelMessageContent";
            this.LabelMessageContent.Padding = new System.Windows.Forms.Padding(0, 0, 18, 14);
            this.LabelMessageContent.Size = new System.Drawing.Size(73, 36);
            this.LabelMessageContent.TabIndex = 0;
            this.LabelMessageContent.Text = "label1";
            this.LabelMessageContent.UseMnemonic = false;
            // 
            // CustomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImage = global::TraderPlusEditor.Properties.Resources.xscr33mLabs_Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ButtonNo;
            this.ClientSize = new System.Drawing.Size(352, 120);
            this.ControlBox = false;
            this.Controls.Add(this.PanelMessageContent);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.PanelTopBar);
            this.Controls.Add(this.PanelIcon);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 800);
            this.MinimizeBox = false;
            this.Name = "CustomMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.TopMost = true;
            this.PanelButtons.ResumeLayout(false);
            this.PanelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.PanelMessageContent.ResumeLayout(false);
            this.PanelMessageContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelButtons;
        public System.Windows.Forms.Button ButtonOkay;
        public System.Windows.Forms.Button ButtonNo;
        public System.Windows.Forms.Button ButtonYes;
        public System.Windows.Forms.Panel PanelIcon;
        public System.Windows.Forms.Panel PanelTopBar;
        public System.Windows.Forms.Panel PanelMessageContent;
        public System.Windows.Forms.Label LabelMessageContent;
        public FontAwesome.Sharp.IconPictureBox IconPictureBox;
    }
}