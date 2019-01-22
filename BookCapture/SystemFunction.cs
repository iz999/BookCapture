using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Input;
using NLog;

namespace BookCapture
{
    public class SystemFunction
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int hkId, LowLevelKeyboardProc callbackFn, IntPtr hkInstance, uint threadId); //훅 프로세스 등록

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr hkId, int nCode, IntPtr wParam, IntPtr lParam); //다음 훅에 메세지 전달

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hkInstance); //훅 프로세스 종료

        [DllImport("kernel32.dll")]
        static extern IntPtr GetModuleHandle(string moduleName); //핸들러

        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo); //키보드 이벤트

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static BookCaptureMainForm mainForm;

        private static Keys pressedKey;

        private const int WH_KEYBOARD_LL = 13;

        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;

        private static LowLevelKeyboardProc callbackFn = new LowLevelKeyboardProc(HookCallBackFn);
        private static IntPtr hkId = IntPtr.Zero;
        
        private static IntPtr HookCallBackFn(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vKeyCode = Marshal.ReadInt32(lParam);

                pressedKey = (Keys)vKeyCode;

                logger.Info("Key Pressed : " + pressedKey.ToString());

                if (mainForm.IsSetKey())
                {
                    mainForm.SetPressedKey();
                }

                if ((Keys)vKeyCode == Keys.Escape && mainForm.IsCaptureBoxDrawing())
                {
                    mainForm.StopCapturing();
                }

                if ((Keys)vKeyCode == Keys.Escape && mainForm.IsCaptureMacroRunning())
                {
                    mainForm.TimerStop();
                }
            }

            return CallNextHookEx(hkId, nCode, wParam, lParam);
        }

        public static void KeyHookingStart(BookCaptureMainForm bookCapture)
        {
            mainForm = bookCapture;

            string curProcModuleNm = Process.GetCurrentProcess().MainModule.ModuleName;

            hkId = SetWindowsHookEx(WH_KEYBOARD_LL, callbackFn, GetModuleHandle(curProcModuleNm), 0);
            
        }

        public static void KeyHookingStop()
        {
            UnhookWindowsHookEx(hkId);
        }

        public static Keys GetPressedKey()
        {
            return pressedKey;
        }

        public static void VKeyPress(string keyValue)
        {
            Keys vKey;
            Enum.TryParse<Keys>(keyValue, out vKey);

            //Key Press 효과
            //keybd_event((uint)vKey, 0, WM_KEYDOWN, 0);
            keybd_event((uint)vKey, 0, WM_KEYUP, 0);
        }
    }
}
