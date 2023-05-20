using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace TraderPlusEditor._Core._Engine
{
    internal class InstanceCheck
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(int hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(int hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int GetForegroundWindow();

        private const int SW_SHOWNORMAL = 1;

        public static async Task CheckForInstance()
        {
            Process[] processes = Process.GetProcessesByName("DayZ_MAAT");
            if (processes.Length > 1)
            {
                for (int i = 0; i < processes.Length; i++)
                {
                    Process runningProcess = processes[i];
                    if ((int)runningProcess.MainWindowHandle == GetForegroundWindow())
                    {
                        continue;
                    }
                    else
                    {
                        ShowWindow((int)runningProcess.MainWindowHandle, SW_SHOWNORMAL);
                        SetForegroundWindow((int)runningProcess.MainWindowHandle);
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
            await Task.Delay(200);
        }
    }
}
