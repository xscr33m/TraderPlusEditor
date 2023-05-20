using FontAwesome.Sharp;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System;
using TraderPlusEditor._Core._Forms;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor.Properties;
using System.Linq;
using System.Drawing;

namespace TraderPlusEditor._Core._Engine
{
    internal class TPVerif
    {
        public string userLanguageKey = Settings.Default.LanguageKey;
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string ErrorLogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        readonly static string LogFilePath = Path.Combine(LogFolderPath, "TraderPlus_Validator_Log.txt");
        private readonly string filePath;
        public bool IsInvalid = false;

        public TPVerif(string filePath)
        {
            this.filePath = filePath;
        }

        // --- Validierung von TPPC.json nach original-Schema --- //
        public async void VerifyTPPC()
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                JObject traderPlusPriceConfig = JObject.Parse(jsonContent);

                // Überprüfe die Keys im obersten Level
                List<string> requiredKeys = new List<string> { "Version", "EnableAutoCalculation", "EnableAutoDestockAtRestart", "EnableDefaultTraderStock", "TraderCategories" };
                foreach (string key in requiredKeys)
                {
                    if (!traderPlusPriceConfig.ContainsKey(key))
                    {
                        IsInvalid = true;

                        string possibleKey = FindSimilarKey(key, traderPlusPriceConfig.Properties().Select(p => p.Name));

                        CustomMessage requiredKeysMessage = new CustomMessage();
                        SystemSounds.Exclamation.Play();
                        requiredKeysMessage.ButtonOkay.Visible = true;
                        requiredKeysMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                        requiredKeysMessage.IconPictureBox.IconChar = IconChar.Xmark;
                        requiredKeysMessage.IconPictureBox.IconColor = Color.Red;
                        requiredKeysMessage.LabelMessageContent.Text = TPVerifRes.ResourceManager.GetString(userLanguageKey + "_requiredKeysMessage") + $"\n\n\"{key}\"";

                        // Ähnlicher Schlüssel gefunden
                        if (!string.IsNullOrEmpty(possibleKey))
                        {
                            requiredKeysMessage.LabelMessageContent.Text += TPVerifRes.ResourceManager.GetString(userLanguageKey + "_requiredKeysMessage1") + $"\"{possibleKey}\"";
                        }

                        requiredKeysMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                        requiredKeysMessage.ButtonNo.Visible = false;
                        requiredKeysMessage.ButtonYes.Visible = false;
                        if (requiredKeysMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (!Directory.Exists(LogFolderPath))
                            {
                                Directory.CreateDirectory(LogFolderPath);
                            }

                            File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_requiredKeysMessage") + $"\"{key}\"\n");
                            if (!string.IsNullOrEmpty(possibleKey))
                            {
                                File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_requiredKeysMessageLog") + $"\"{possibleKey}\"\n");
                            }
                        }
                    }
                }

                // Überprüfe die TraderCategories
                JArray traderCategories = (JArray)traderPlusPriceConfig["TraderCategories"];
                for (int i = 0; i < traderCategories.Count; i++)
                {
                    JObject category = (JObject)traderCategories[i];

                    // Überprüfe den CategoryName - Key
                    if (!category.ContainsKey("CategoryName"))
                    {
                        IsInvalid = true;

                        string categoryNameContent = (string)category.First;
                        //string categoryNameContent = category.ToString().TrimEnd();

                        CustomMessage categoryMessage = new CustomMessage();
                        SystemSounds.Exclamation.Play();
                        categoryMessage.ButtonOkay.Visible = true;
                        categoryMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                        categoryMessage.IconPictureBox.IconChar = IconChar.Xmark;
                        categoryMessage.IconPictureBox.IconColor = Color.Red;
                        categoryMessage.LabelMessageContent.Text = TPVerifRes.ResourceManager.GetString(userLanguageKey + "_categoryMessage") + $"\n\n\"{categoryNameContent}\"";
                        categoryMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                        categoryMessage.ButtonNo.Visible = false;
                        categoryMessage.ButtonYes.Visible = false;
                        if (categoryMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (!Directory.Exists(LogFolderPath))
                            {
                                Directory.CreateDirectory(LogFolderPath);
                            }

                            File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_categoryMessage") + $"\n\n\"{categoryNameContent}\"\n");
                        }
                    }

                    // Überprüfe den Products - Key
                    if (!category.ContainsKey("Products"))
                    {
                        IsInvalid = true;

                        string categoryNameContent = (string)category.First;
                        //string categoryNameContent = category.ToString().TrimEnd();

                        CustomMessage categoryMessage = new CustomMessage();
                        SystemSounds.Exclamation.Play();
                        categoryMessage.ButtonOkay.Visible = true;
                        categoryMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                        categoryMessage.IconPictureBox.IconChar = IconChar.Xmark;
                        categoryMessage.IconPictureBox.IconColor = Color.Red;
                        categoryMessage.LabelMessageContent.Text = TPVerifRes.ResourceManager.GetString(userLanguageKey + "_categoryMessage1") + $"\n\n\"{categoryNameContent}\"";
                        categoryMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                        categoryMessage.ButtonNo.Visible = false;
                        categoryMessage.ButtonYes.Visible = false;
                        if (categoryMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (!Directory.Exists(LogFolderPath))
                            {
                                Directory.CreateDirectory(LogFolderPath);
                            }

                            File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_categoryMessage1") + $"\n\n\"{categoryNameContent}\"\n");
                        }
                    }
                    else
                    {
                        // Überprüfe die Products
                        JArray products = (JArray)category["Products"];
                        for (int j = 0; j < products.Count; j++)
                        {
                            string[] productData = products[j].ToString().Split(',');

                            // Überprüfe die Anzahl der Werte in einem Produkt
                            if (productData.Length < 6)
                            {
                                IsInvalid = true;

                                string categoryNameContent = (string)category.First;
                                string productContent = productData.GetValue(0).ToString(); // Inhalt der fehlerhaften Zeile

                                CustomMessage ProductMessage = new CustomMessage();
                                SystemSounds.Exclamation.Play();
                                ProductMessage.ButtonOkay.Visible = true;
                                ProductMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                                ProductMessage.IconPictureBox.IconChar = IconChar.Xmark;
                                ProductMessage.IconPictureBox.IconColor = Color.Red;
                                ProductMessage.LabelMessageContent.Text = TPVerifRes.ResourceManager.GetString(userLanguageKey + "_ProductMessage") + $"\n\"{productContent}\"\n\n" + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_ProductMessage1") + $"\n\"{categoryNameContent}\"\n\n" + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_ProductMessage2");
                                ProductMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                                ProductMessage.ButtonNo.Visible = false;
                                ProductMessage.ButtonYes.Visible = false;
                                if (ProductMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    if (!Directory.Exists(LogFolderPath))
                                    {
                                        Directory.CreateDirectory(LogFolderPath);
                                    }

                                    File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_ProductMessage") + $"\"{productContent}\" " + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_ProductMessage1") + $"\"{categoryNameContent}\"\n" + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_ProductMessage2" + "\n"));
                                }
                            }
                        }
                    }
                }

                if (!IsInvalid)
                {
                    await FormMain.Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_TPVerifSuccess"), IconChar.Check, Color.Green);
                }
                else
                {
                    await FormMain.Instance.ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_TPVerifFail"), IconChar.Xmark, Color.Red);
                }

                await Task.Delay(1000);
            }
            catch (Exception ex)
            {
                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = TPVerifRes.ResourceManager.GetString(userLanguageKey + "_TPVerifExept") + $"{ex.Message}";
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + TPVerifRes.ResourceManager.GetString(userLanguageKey + "_TPVerifExept") + $"{ex.Message}\n");
                }
            }
        }

        // --- Levenshtein Distanz um ähnliche Schlüssel zu finden --- //
        private string FindSimilarKey(string incorrectKey, IEnumerable<string> keys)
        {
            return keys.OrderBy(k => LevenshteinDistance(k, incorrectKey)).FirstOrDefault();
        }

        private int LevenshteinDistance(string s1, string s2)
        {
            int[,] distance = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++)
            {
                distance[i, 0] = i;
            }

            for (int j = 0; j <= s2.Length; j++)
            {
                distance[0, j] = j;
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    int cost = (s1[i - 1] == s2[j - 1]) ? 0 : 1;
                    distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
                }
            }

            return distance[s1.Length, s2.Length];
        }
    }
}
