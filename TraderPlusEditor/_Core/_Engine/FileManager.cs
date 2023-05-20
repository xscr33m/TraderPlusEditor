using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using TraderPlusEditor._Core._Forms;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor.Properties;
using static TraderPlusEditor._Core._Engine.JSONData;

namespace TraderPlusEditor._Core._Engine
{
    internal class FileManager
    {
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string LogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        readonly static string userLanguageKey = Settings.Default.LanguageKey;

        public static JsonData LoadFile(string filePath)
        {
            try
            {
                // JSON-Datei lesen und deserialisieren
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<JsonData>(json);
            }
            catch (Exception ex)
            {
                CustomMessage PopupMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                PopupMessage.ButtonOkay.Visible = true;
                PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                PopupMessage.IconPictureBox.IconColor = Color.Red;
                PopupMessage.LabelMessageContent.Text = FileManagerRes.ResourceManager.GetString(userLanguageKey + "_SerializeError") + $"{ex.Message}";
                PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                PopupMessage.ButtonNo.Visible = false;
                PopupMessage.ButtonYes.Visible = false;
                if (PopupMessage.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + FileManagerRes.ResourceManager.GetString(userLanguageKey + "_SerializeError") + $"{ex.Message}\n");
                }

                return null;
            }
        }
    }
}
