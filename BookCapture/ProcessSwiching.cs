using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NLog;

namespace BookCapture
{
    public class ProcessSwiching
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        /*[DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;*/

        //private Process mainProcess;
        //private int targetProcessId;

        /*public ProcessSwiching(Process currentProcess)
        {
            this.mainProcess = currentProcess;
        }*/

        public static void Swiching(string targetProcessHandle)
        {
            logger.Info("Enter Swiching process");

            IntPtr hWnd = (IntPtr)Int32.Parse(targetProcessHandle);

            if (!hWnd.Equals(IntPtr.Zero))
            {
                // 윈도우 창크기 변경
                //ShowWindowAsync(hWnd, SW_SHOWNORMAL);

                // 윈도우 최상위로 만든다
                SetForegroundWindow(hWnd);                

                logger.Info("Current Active Window : " + GetCaptionOfActiveWindow());
            }
        }

        /*public void Rollback()
        {
            logger.Info("Enter Rollback Process");

            IntPtr hWnd = mainProcess.MainWindowHandle;

            if (!hWnd.Equals(IntPtr.Zero))
            {
                // 윈도우 창크기 변경
                //ShowWindowAsync(hWnd, SW_SHOWNORMAL);

                // 윈도우 최상위로 만든다
                SetForegroundWindow(hWnd);

                logger.Info("Current Active Window : " + GetCaptionOfActiveWindow());
            }
        }*/

        private static string GetCaptionOfActiveWindow()
        {
            var strTitle = string.Empty;
            var handle = GetForegroundWindow();
            // Obtain the length of the text   
            var intLength = GetWindowTextLength(handle) + 1;
            var stringBuilder = new StringBuilder(intLength);
            if (GetWindowText(handle, stringBuilder, intLength) > 0)
            {
                strTitle = stringBuilder.ToString();
            }
            return strTitle;
        }
    }
}
