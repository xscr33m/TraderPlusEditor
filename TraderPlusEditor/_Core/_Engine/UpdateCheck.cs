using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using TraderPlusEditor.Properties;
using Octokit;
using System.Linq;
using FontAwesome.Sharp;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor._Core._Forms;

namespace TraderPlusEditor._Core._Engine
{
    internal class UpdateCheck
    {
        public static string userLanguageKey = Settings.Default.LanguageKey;
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string ErrorLogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");

        public static async Task CheckForUpdates()
        {
            try
            {
                var github = new GitHubClient(new ProductHeaderValue("TraderPlusEditor"));

                string owner = "xscr33m";
                string repo = "TraderPlusEditor";

                try
                {
                    var releases = await github.Repository.Release.GetAll(owner, repo);

                    var sortedReleases = releases.OrderByDescending(r => r.PublishedAt);

                    Version currentVersion = Assembly.GetEntryAssembly().GetName().Version;
                    Version latestVersion = new Version(sortedReleases.FirstOrDefault()?.TagName.TrimStart('v'));

                    if (latestVersion != null && latestVersion > currentVersion)
                    {
                        CustomMessage popUpMessage = new CustomMessage();
                        SystemSounds.Exclamation.Play();
                        popUpMessage.ButtonOkay.Visible = false;
                        popUpMessage.IconPictureBox.IconChar = IconChar.Warning;
                        popUpMessage.IconPictureBox.IconColor = Color.Yellow;
                        popUpMessage.LabelMessageContent.Text = UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_NewVersion");
                        popUpMessage.Text = UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateTitle");
                        popUpMessage.ButtonNo.Visible = true;
                        popUpMessage.ButtonYes.Visible = true;
                        popUpMessage.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                        popUpMessage.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                        DialogResult updateDialog = popUpMessage.ShowDialog();

                        if (updateDialog == DialogResult.Yes)
                        {
                            string downloadUrl = string.Format("https://github.com/{0}/{1}/releases/download/{2}/xscr33mLabs_TraderPlusEditor.zip", owner, repo, sortedReleases.FirstOrDefault()?.TagName);
                            string changelogUrl = string.Format("https://github.com/{0}/{1}/releases/", owner, repo);

                            try
                            {
                                Process.Start(downloadUrl);
                                Process.Start(changelogUrl);
                            }
                            catch (Exception ex)
                            {
                                if (!Directory.Exists(LogFolderPath))
                                {
                                    Directory.CreateDirectory(LogFolderPath);
                                }

                                File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_BrowserError") + $"{ex.Message}\n");

                                await FormMain.Instance.ShowNotification(UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_BrowserError"), IconChar.Xmark, Color.Red);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateError") + $"{ex.Message}\n");
                }
            }
            catch (Exception ex)
            {
                string userLanguageKey = Settings.Default.LanguageKey;

                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateError") + ex.Message;
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateError") + $"{ex.Message}\n");
                }
            }
        }

        public static async Task ForceCheckForUpdates()
        {
            try
            {
                string userLanguageKey = Settings.Default.LanguageKey;

                var github = new GitHubClient(new ProductHeaderValue("TraderPlusEditor"));

                // Setze den Benutzer und das Repository deines öffentlichen GitHub-Repos
                string owner = "xscr33m";
                string repo = "TraderPlusEditor";

                try
                {
                    var releases = await github.Repository.Release.GetAll(owner, repo);

                    var sortedReleases = releases.OrderByDescending(r => r.PublishedAt);

                    Version currentVersion = Assembly.GetEntryAssembly().GetName().Version;
                    Version latestVersion = new Version(sortedReleases.FirstOrDefault()?.TagName.TrimStart('v'));

                    if (latestVersion != null && latestVersion > currentVersion)
                    {
                        CustomMessage popUpMessage = new CustomMessage();
                        SystemSounds.Exclamation.Play();
                        popUpMessage.ButtonOkay.Visible = false;
                        popUpMessage.IconPictureBox.IconChar = IconChar.Warning;
                        popUpMessage.IconPictureBox.IconColor = Color.Yellow;
                        popUpMessage.LabelMessageContent.Text = UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_NewVersion");
                        popUpMessage.Text = UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateTitle");
                        popUpMessage.ButtonNo.Visible = true;
                        popUpMessage.ButtonYes.Visible = true;
                        popUpMessage.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                        popUpMessage.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                        DialogResult updateDialog = popUpMessage.ShowDialog();

                        if (updateDialog == DialogResult.Yes)
                        {
                            string downloadUrl = string.Format("https://github.com/{0}/{1}/releases/download/{2}/xscr33mLabs_TraderPlusEditor.zip", owner, repo, sortedReleases.FirstOrDefault()?.TagName);
                            string changelogUrl = string.Format("https://github.com/{0}/{1}/releases/", owner, repo);

                            try
                            {
                                Process.Start(downloadUrl);
                                Process.Start(changelogUrl);
                            }
                            catch (Exception ex)
                            {
                                if (!Directory.Exists(LogFolderPath))
                                {
                                    Directory.CreateDirectory(LogFolderPath);
                                }

                                File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_BrowserError") + $"{ex.Message}\n");

                                await FormMain.Instance.ShowNotification(UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_BrowserError"), IconChar.Xmark, Color.Red);
                            }
                        }
                    }
                    else
                    {
                        CustomMessage popUpMessage = new CustomMessage();
                        SystemSounds.Exclamation.Play();
                        popUpMessage.ButtonOkay.Visible = true;
                        popUpMessage.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                        popUpMessage.IconPictureBox.IconChar = IconChar.Check;
                        popUpMessage.IconPictureBox.IconColor = Color.Green;
                        popUpMessage.LabelMessageContent.Text = UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_NoUpdate"); 
                        popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleInfo");
                        popUpMessage.ButtonNo.Visible = false;
                        popUpMessage.ButtonYes.Visible = false;
                        popUpMessage.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateError") + $"{ex.Message}\n");

                    await FormMain.Instance.ShowNotification(UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateError") + ex.Message, IconChar.Xmark, Color.Red);
                }
            }
            catch (Exception ex)
            {
                string userLanguageKey = Settings.Default.LanguageKey;

                // Behandle Fehler bei der Verbindung zur GitHub-API
                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateError") + ex.Message;
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + UpdateCheckRes.ResourceManager.GetString(userLanguageKey + "_UpdateError") + $"{ex.Message}\n");
                }
            }
        }
    }
}
