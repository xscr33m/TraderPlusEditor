/// © 2023 by xscr33m   (Discord: xscr33m#4443)  
using System;
using System.Windows.Forms;

namespace TraderPlusEditor
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Main());
        }
    }
}
