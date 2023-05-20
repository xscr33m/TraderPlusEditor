using FontAwesome.Sharp;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using TraderPlusEditor._Core._Forms;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor.Properties;

namespace TraderPlusEditor._Core._Engine
{
    internal class WebsiteLauncher
    {
        public static string userLanguageKey = Settings.Default.LanguageKey;

        public static void OpenWebsite(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                CustomMessage PopupMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                PopupMessage.ButtonOkay.Visible = true;
                PopupMessage.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                PopupMessage.IconPictureBox.IconColor = Color.Red;
                PopupMessage.LabelMessageContent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_BrowserError");
                PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                PopupMessage.ButtonNo.Visible = false;
                PopupMessage.ButtonYes.Visible = false;
                PopupMessage.ShowDialog();
            }
        }
    }
}
