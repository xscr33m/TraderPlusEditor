using FontAwesome.Sharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using TraderPlusEditor._Core._Forms;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor.Properties;

namespace TraderPlusEditor._Core._Engine
{
    internal class JSONValidator
    {
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string LogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        public string userLanguageKey = Settings.Default.LanguageKey;
        private bool IsInvalid = false;

        public string FilePath { get; private set; }
        public string FileContent { get; private set; }

        public JSONValidator(string filePath)
        {
            FilePath = filePath;
            FileContent = ReadFile(filePath);
        }

        private string ReadFile(string filePath)
        {
            try
            {
                string fileExtension = Path.GetExtension(filePath);
                string fileContent = "";

                switch (fileExtension)
                {
                    case ".json":
                        if (ValidateJsonFile(filePath))
                            fileContent = File.ReadAllText(filePath);
                        else
                            throw new Exception(JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ExeptionJSON"));
                        break;
                    default:
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }
                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ExeptionNoSup") + "\n");
                        throw new NotSupportedException(JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ExeptionNoSup"));
                }

                Task.Delay(1000);

                return fileContent;
            }
            catch (Exception ex)
            {
                if (!Directory.Exists(LogFolderPath))
                {
                    Directory.CreateDirectory(LogFolderPath);
                }

                File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ReadError") + $"{ex.Message}\n");
                return null;
            }
        }

        private bool ValidateJsonFile(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                JsonSerializer serializer = new JsonSerializer();
                using (JsonTextReader reader = new JsonTextReader(new StringReader(jsonContent)))
                {
                    while (reader.Read())
                    {
                        // Prüfe auf Fehler beim Lesen
                        //if (reader.TokenType == JsonToken.Comment)
                        //    continue; // Kommentare werden ignoriert
                        //if (reader.TokenType == JsonToken.None)
                        //    continue; // Token 'None' wird ignoriert
                        if (reader.TokenType == JsonToken.Undefined)
                            return false; // 'Undefined' zeigt auf ungültigen JSON-Inhalt
                    }
                }

                return true;
            }
            catch (JsonException ex)
            {
                IsInvalid = true;

                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ValidJsonError") + $"{ex.Message}";
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ValidJsonError") + $"{ex.Message}\n");
                }

                return false;
            }
        }

        public async void BeautifyFile()
        {
            switch (Path.GetExtension(FilePath))
            {
                case ".json":
                    BeautifyJson(FilePath);
                    break;
                default:
                    await FormMain.Instance.ShowNotification(JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ReadError"), IconChar.Xmark, Color.Red);
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }
                    File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ReadError") + "\n");
                    throw new NotSupportedException(JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_ReadError"));
            }
            if (!IsInvalid)
            {
                await FormMain.Instance.ShowNotification(JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_Success"), IconChar.Check, Color.LightGreen);
            }
            else
            {
                await FormMain.Instance.ShowNotification(JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_Invalid"), IconChar.Xmark, Color.Red);
            }
        }

        private void BeautifyJson(string filePath)
        {
            if (!IsInvalid)
            {
                try
                {
                    string jsonContent = File.ReadAllText(filePath);
                    JObject parsedJson = JObject.Parse(jsonContent);
                    string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(filePath, formattedJson);
                }
                catch (JsonException ex)
                {
                    CustomMessage popUpMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    popUpMessage.ButtonOkay.Visible = true;
                    popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                    popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    popUpMessage.IconPictureBox.IconColor = Color.Red;
                    popUpMessage.LabelMessageContent.Text = JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_BeautifyError1") + $"{ex.Message}";
                    popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    popUpMessage.ButtonNo.Visible = false;
                    popUpMessage.ButtonYes.Visible = false;
                    if (popUpMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + JSONValidatorRes.ResourceManager.GetString(userLanguageKey + "_BeautifyError1") + $"{ex.Message}\n");
                    }
                }
            }
        }
    }
}
