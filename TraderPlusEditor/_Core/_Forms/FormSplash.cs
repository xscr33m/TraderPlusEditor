using FontAwesome.Sharp;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using TraderPlusEditor.Properties;
using TraderPlusEditor._Core._Engine;
using System.Drawing;
using TraderPlusEditor._Core._Language._Stringtables;
using TraderPlusEditor._Core._Language;

namespace TraderPlusEditor._Core._Forms
{
    public partial class FormSplash : Form
    {
        private readonly Timer rotationTimer = new Timer();
        private const int rotationStep = 2;
        private int currentRotation = 0;
        static public string userLanguageKey;

        public FormSplash()
        {
            InitializeComponent();

            rotationTimer.Interval = 1; // Setze die Zeit in Millisekunden für die Aktualisierung
            rotationTimer.Tick += RotationTimer_Tick;
            rotationTimer.Start();
        }

        private async void FormSplash_Load(object sender, EventArgs e)
        {
            await LanguageCore.GetnSetLanguage();

            Settings.Default.Reload();
            userLanguageKey = Settings.Default.LanguageKey;

            UpdateLoadingLabel("_Initializing");
            await Task.Delay(300);

            if (Settings.Default.EULA == false)
            {
                UpdateLoadingLabel("_WaitForEula");

                EULADialog messageBoxForm = new EULADialog();
                messageBoxForm.ButtonDeny.Visible = true;
                messageBoxForm.ButtonAccept.Visible = true;
                DialogResult result = messageBoxForm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Settings.Default.EULA = true;
                    Settings.Default.Save();

                    await Task.Run(async () =>
                    {
                        UpdateLoadingLabel("_CheckInstance");
                        await InstanceCheck.CheckForInstance();
                        UpdateLoadingLabel("_CheckUpdate");
                        await UpdateCheck.CheckForUpdates();
                        UpdateLoadingLabel("_GeneratePath");
                        await PathGenerator.GeneratePath();
                        await PathGenerator.GeneratePreviewFolder();
                    });

                    UpdateLoadingLabel("_Finishing");
                    await Task.Delay(300);
                    FormMain mainForm = new FormMain();
                    mainForm.Show();
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    Settings.Default.EULA = false;
                    Settings.Default.Save();
                    Settings.Default.LanguageKey = "en";
                    Settings.Default.Save();

                    Close();
                    Application.Exit();
                }
            }
            else
            {
                await Task.Run(async () =>
                {
                    UpdateLoadingLabel("_CheckInstance");
                    await InstanceCheck.CheckForInstance();
                    UpdateLoadingLabel("_CheckUpdate");
                    await UpdateCheck.CheckForUpdates();
                    UpdateLoadingLabel("_GeneratePath");
                    await PathGenerator.GeneratePath();
                    await PathGenerator.GeneratePreviewFolder();
                });

                UpdateLoadingLabel("_Finishing");
                await Task.Delay(300);
                FormMain mainForm = new FormMain();
                mainForm.Show();
                Close();
            }
        }

        private void UpdateLoadingLabel(string keyValue)
        {
            if (keyValue != null)
            {
                if (LabelLoading.InvokeRequired)
                {
                    LabelLoading.Invoke(new Action(() =>
                    {
                        LabelLoading.Text = SplashForm.ResourceManager.GetString(userLanguageKey + $"{keyValue}");
                    }));
                }
                else
                {
                    LabelLoading.Text = SplashForm.ResourceManager.GetString(userLanguageKey + $"{keyValue}");
                }
            }
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            // Setze den Rotationswert nach jeder vollen Umdrehung zurück
            currentRotation += rotationStep;
            if (currentRotation >= 360)
            {
                currentRotation -= 360;
            }

            IconPictureBoxLoading.Rotation += 2;

            // Aktualisiere das Icon
            IconPictureBoxLoading.IconChar = IconChar.Hourglass;
            IconPictureBoxLoading.IconSize = 40;
            IconPictureBoxLoading.IconColor = GetGradientColor();

            // Zeichne das Icon neu
            IconPictureBoxLoading.Invalidate();
        }

        private Color GetGradientColor()
        {
            // Berechne die Farbe basierend auf der aktuellen Rotation
            int red = (int)(Math.Sin(Math.PI * currentRotation / 180) * 127 + 128);
            int green = (int)(Math.Sin(Math.PI * (currentRotation + 120) / 180) * 127 + 128);
            int blue = (int)(Math.Sin(Math.PI * (currentRotation + 240) / 180) * 127 + 128);

            return Color.FromArgb(red, green, blue);
        }

        private void SplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
