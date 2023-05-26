using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraderPlusEditor.Properties;

namespace TraderPlusEditor
{
    public class WebsiteLauncher
    {
        public static void OpenWebsite(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                F_Msg messageBoxForm = new F_Msg();
                SystemSounds.Exclamation.Play();
                messageBoxForm.button3.Visible = true;
                messageBoxForm.pictureBox1.Image = Resources.error_50;
                messageBoxForm.label1.Text = "Browser could not be started.";
                messageBoxForm.Text = "Error!";
                messageBoxForm.button2.Visible = false;
                messageBoxForm.button1.Visible = false;
            }
        }
    }
}
