namespace TraderPlusEditor._Core._Forms
{
    partial class FormSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.IconPictureBoxLoading = new FontAwesome.Sharp.IconPictureBox();
            this.LabelLoading = new System.Windows.Forms.Label();
            this.PanelLoadingInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBoxLoading)).BeginInit();
            this.PanelLoadingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLogo.Image = global::TraderPlusEditor.Properties.Resources.xscr33mLabs_Logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(13, 13);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(225, 100);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // IconPictureBoxLoading
            // 
            this.IconPictureBoxLoading.BackColor = System.Drawing.Color.Transparent;
            this.IconPictureBoxLoading.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconPictureBoxLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.IconPictureBoxLoading.IconChar = FontAwesome.Sharp.IconChar.Hourglass;
            this.IconPictureBoxLoading.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.IconPictureBoxLoading.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureBoxLoading.IconSize = 60;
            this.IconPictureBoxLoading.Location = new System.Drawing.Point(390, 0);
            this.IconPictureBoxLoading.Margin = new System.Windows.Forms.Padding(0);
            this.IconPictureBoxLoading.Name = "IconPictureBoxLoading";
            this.IconPictureBoxLoading.Padding = new System.Windows.Forms.Padding(6, 7, 0, 0);
            this.IconPictureBoxLoading.Size = new System.Drawing.Size(60, 60);
            this.IconPictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconPictureBoxLoading.TabIndex = 1;
            this.IconPictureBoxLoading.TabStop = false;
            // 
            // LabelLoading
            // 
            this.LabelLoading.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLoading.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.LabelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(196)))));
            this.LabelLoading.Location = new System.Drawing.Point(0, 0);
            this.LabelLoading.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLoading.Name = "LabelLoading";
            this.LabelLoading.Padding = new System.Windows.Forms.Padding(12, 7, 6, 13);
            this.LabelLoading.Size = new System.Drawing.Size(390, 60);
            this.LabelLoading.TabIndex = 2;
            this.LabelLoading.Text = "Loading ... ";
            this.LabelLoading.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PanelLoadingInfo
            // 
            this.PanelLoadingInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelLoadingInfo.Controls.Add(this.LabelLoading);
            this.PanelLoadingInfo.Controls.Add(this.IconPictureBoxLoading);
            this.PanelLoadingInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelLoadingInfo.Location = new System.Drawing.Point(0, 190);
            this.PanelLoadingInfo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelLoadingInfo.Name = "PanelLoadingInfo";
            this.PanelLoadingInfo.Size = new System.Drawing.Size(450, 60);
            this.PanelLoadingInfo.TabIndex = 3;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TraderPlusEditor.Properties.Resources.xscr33mLabs_Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.PanelLoadingInfo);
            this.Controls.Add(this.PictureBoxLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SplashScreen_FormClosed);
            this.Load += new System.EventHandler(this.FormSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBoxLoading)).EndInit();
            this.PanelLoadingInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private FontAwesome.Sharp.IconPictureBox IconPictureBoxLoading;
        private System.Windows.Forms.Label LabelLoading;
        private System.Windows.Forms.Panel PanelLoadingInfo;
    }
}