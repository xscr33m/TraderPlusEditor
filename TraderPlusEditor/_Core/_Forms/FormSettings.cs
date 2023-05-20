using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor.Properties;
using TraderPlusEditor._Core._Engine;

namespace TraderPlusEditor._Core._Forms
{
    public partial class FormSettings : Form
    {
        private readonly string[] languages = { "Deutsch", "English", "Francais" };
        private readonly string[] languageCodes = { "de", "en", "fr" };
        public string userLanguageKey = Settings.Default.LanguageKey;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
            ApplySettings();
            ButtonApply.Enabled = false;
        }

        // --- Apply Language Variables --- //
        private void ApplyLanguage()
        {
            Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_SettingsTitle");

            GroupBoxLanguage.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_GroupBoxLanguage");

            GroupBoxCategories.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_GroupBoxCategories");
            if (Settings.Default.ShowCategories == true)
            {
                CheckBoxShowCategories.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxShowCategoriesDisable");
            }
            else
            {
                CheckBoxShowCategories.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxShowCategoriesEnable");
            }

            GroupBoxOptions.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_GroupBoxOptions");
            if (Settings.Default.ShowPreview == true)
            {
                CheckBoxPreview.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxPreviewDisable");
            }
            else
            {
                CheckBoxPreview.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxPreviewEnable");
            }

            GroupBoxEULA.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_GroupBoxEULA");
        }

        // --- Apply Settings --- //
        private void ApplySettings()
        {
            // Fülle die ComboBox mit den verfügbaren Sprachen
            ComboBoxLanguage.Items.AddRange(languages);
            // Finde den Index des aktuell in den Properties gespeicherten Sprachkürzels
            int selectedLanguageIndex = Array.IndexOf(languageCodes, Settings.Default.LanguageKey);
            // Setze die ComboBox auf die gespeicherte Sprache
            ComboBoxLanguage.SelectedIndex = selectedLanguageIndex;

            CheckBoxPreview.Checked = Settings.Default.ShowPreview;

            CheckBoxShowCategories.Checked = Settings.Default.ShowCategories;
        }

        // --- Sprache einstellen --- //
        private void ComboBoxLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Speichere die ausgewählte Sprache in den Einstellungen
            int selectedLanguageIndex = ComboBoxLanguage.SelectedIndex;
            if (selectedLanguageIndex >= 0 && selectedLanguageIndex < languageCodes.Length)
            {
                string selectedLanguage = languageCodes[selectedLanguageIndex];
                Settings.Default.LanguageKey = selectedLanguage;
            }

            ButtonApply.Enabled = true;
        }

        // --- Produktvorschau anzeigen&ausblenden --- //
        private void CheckBoxPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPreview.Checked)
            {
                Settings.Default.ShowPreview = true;
                CheckBoxPreview.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxPreviewDisable");
            }
            else
            {
                Settings.Default.ShowPreview = false;
                CheckBoxPreview.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxPreviewEnable");
            }

            ButtonApply.Enabled = true;
        }

        private void CheckBoxShowCategories_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowCategories.Checked)
            {
                Settings.Default.ShowCategories = true;
                CheckBoxShowCategories.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxShowCategoriesDisable");
            }
            else
            {
                Settings.Default.ShowCategories = false;
                CheckBoxShowCategories.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_CheckBoxShowCategoriesEnable");
            }

            ButtonApply.Enabled = true;
        }

        private void ButtonEULA_Click(object sender, EventArgs e)
        {
            EULADialog messageBoxForm = new EULADialog();
            messageBoxForm.LabelTitle.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_ReviewTitle");
            messageBoxForm.TextBoxContent.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_EULAText");
            messageBoxForm.ButtonDeny.Visible = false;
            messageBoxForm.ButtonAccept.Visible = true;
            DialogResult result = messageBoxForm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                messageBoxForm.Close();
            }
        }

        private async void Button_Update_Click(object sender, EventArgs e)
        {
            await UpdateCheck.ForceCheckForUpdates();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Close();
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
