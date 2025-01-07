using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TraderPlusEditor._Core._Engine;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor.Properties;

namespace TraderPlusEditor._Core._Forms
{
    public partial class FormInfo : Form
    {
        public string userLanguageKey = Settings.Default.LanguageKey;

        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        // --- Apply Language Variables --- //
        private void ApplyLanguage()
        {
            Button_Discord.Text = InfoForm.ResourceManager.GetString(userLanguageKey + "_ButtonDiscord");
            Button_GitHub.Text = InfoForm.ResourceManager.GetString(userLanguageKey + "_ButtonGithub");
            Button_Steam.Text = InfoForm.ResourceManager.GetString(userLanguageKey + "_ButtonSteam");
            Button_PayPal.Text = InfoForm.ResourceManager.GetString(userLanguageKey + "_ButtonPayPal");
        }

        private void Button_TraderPlusWiki_Click(object sender, EventArgs e)
        {
            string url = "https://traderpluswiki.notion.site/TraderPlusPriceConfig-json-bafb5261d89349f1ac68f82e53eb3b46";
            WebsiteLauncher.OpenWebsite(url);
        }

        private void Button_Discord_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/5CrDj8ba6C";
            WebsiteLauncher.OpenWebsite(url);
        }

        private void Button_GitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/xscr33m/";
            WebsiteLauncher.OpenWebsite(url);
        }

        private void Button_Steam_Click(object sender, EventArgs e)
        {
            string url = "https://steamcommunity.com/id/xscr33m/myworkshopfiles/?appid=221100";
            WebsiteLauncher.OpenWebsite(url);
        }

        private void Button_PayPal_Click(object sender, EventArgs e)
        {
            string url = "https://paypal.me/dheil53";
            WebsiteLauncher.OpenWebsite(url);
        }

        // --- Black TitleBar --- //
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }
    }
}
