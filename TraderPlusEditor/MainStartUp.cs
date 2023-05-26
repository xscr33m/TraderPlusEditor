using Octokit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraderPlusEditor.Properties;

namespace TraderPlusEditor
{
    internal class MainStartUp
    {
        static public string editorFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TraderPlusEditor", "EXPORTS");

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        private const int SW_SHOWNORMAL = 1;

        public static async Task CheckForInstance()
        {
            Process[] processes = Process.GetProcessesByName("TraderPlusEditor");
            if (processes.Length > 1)
            {
                for (int i = 0; i < processes.Length; i++)
                {
                    Process runningProcess = processes[i];
                    if (runningProcess.MainWindowHandle == GetForegroundWindow())
                    {
                        continue;
                    }
                    else
                    {
                        ShowWindow(runningProcess.MainWindowHandle, SW_SHOWNORMAL);
                        SetForegroundWindow(runningProcess.MainWindowHandle);
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
            await Task.Delay(200);
        }

        public static async Task GENERATEPATH()
        {
            if (!Directory.Exists(editorFolderPath))
            {
                Directory.CreateDirectory(editorFolderPath);
            }
            await Task.Delay(200);
        }

        public static async Task CheckForUpdates(F_Main mainForm)
        {
            try
            {
                // Erzeuge eine GitHubClient-Instanz
                var github = new GitHubClient(new Octokit.ProductHeaderValue("TraderPlusEditor"));

                // Setze den Benutzer und das Repository deines öffentlichen GitHub-Repos
                string owner = "xscr33m";
                string repo = "TraderPlusEditor";

                // Rufe die Liste der neuesten Releases ab
                var releases = await github.Repository.Release.GetAll(owner, repo);

                // Sortiere die Releases absteigend nach dem Veröffentlichungsdatum
                var sortedReleases = releases.OrderByDescending(r => r.PublishedAt);

                // Vergleiche die AssemblyVersion mit dem neuesten Tag
                Version currentVersion = Assembly.GetEntryAssembly().GetName().Version;
                Version latestVersion = new Version(sortedReleases.FirstOrDefault()?.TagName.TrimStart('v'));

                if (latestVersion != null && latestVersion > currentVersion)
                {
                    // Eine neuere Version wurde gefunden, zeige eine entsprechende Benachrichtigung an
                    F_Msg messageBoxForm = new F_Msg();
                    SystemSounds.Exclamation.Play();
                    messageBoxForm.button3.Visible = false;
                    messageBoxForm.pictureBox1.Image = Resources.question_50;
                    messageBoxForm.label1.Text = "A newer version is available! \n\r \n\rDo you want to download it now?";
                    messageBoxForm.Text = "Update available!";
                    messageBoxForm.button2.Visible = true;
                    messageBoxForm.button1.Visible = true;

                    if (messageBoxForm.ShowDialog() == DialogResult.Yes)
                    {
                        string downloadUrl = string.Format("https://github.com/{0}/{1}/releases/download/{2}/xscr33m.s.TraderPlusEditor.zip", owner, repo, sortedReleases.FirstOrDefault()?.TagName);

                        try
                        {
                            Process.Start(downloadUrl);
                        }
                        catch
                        {
                            await mainForm.ShowNotification("Browser could not be started.", Resources.warn, Color.LightCoral);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Behandle Fehler bei der Verbindung zur GitHub-API
                await mainForm.ShowNotification("Error while checking for updates: " + ex.Message, Resources.warn, Color.LightCoral);
            }
        }
    }
}
