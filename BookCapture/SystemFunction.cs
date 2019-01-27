using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Input;
using System.Drawing;
using NLog;

namespace BookCapture
{
    public class SystemFunction
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int hkId, LowLevelKeyboardProc callbackFn, IntPtr hkInstance, uint threadId); //키보드 후킹 프로세스 등록

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int hkId, LowLevelMouseProc callbackFn, IntPtr hkInstance, uint threadId); //마우스 프로세스 등록

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr hkId, int nCode, IntPtr wParam, IntPtr lParam); //다음 후킹에 메세지 전달

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hkInstance); //후킹 프로세스 종료

        [DllImport("kernel32.dll")]
        static extern IntPtr GetModuleHandle(string moduleName); //핸들러

        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo); //키보드 이벤트

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo); // 마우스 이벤트 실행

        [DllImport("user32.dll")] 
        private static extern int GetCursorPos(ref Point mousePosition); //마우스 포지션 GET

        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y); //마우스 포지션 SET


        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam); //키보드 후킹
        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);  // 마우스 후킹

        private static BookCaptureMainForm mainForm;

        private static Keys pressedKey;

        //키보드 메세지
        private const int WH_KEYBOARD_LL = 13;
        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;


        //마우스 메세지
        private const int WH_MOUSE_LL = 14;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_RBUTTONUP = 0x0205;

        private static LowLevelKeyboardProc callbackKeyboard = new LowLevelKeyboardProc(HookKeyBoadCallBackFn);
        private static LowLevelMouseProc callbackMouse = new LowLevelMouseProc(HookMouseCallBackFn);
        private static IntPtr hkKeyboardId = IntPtr.Zero;
        private static IntPtr hkMouseId = IntPtr.Zero;

        private static IntPtr HookKeyBoadCallBackFn(int nCode, IntPtr wParam, IntPtr lParam)
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
                    logger.Info("Setting Capture Area Stopped");
                    mainForm.StopCapturing();
                }

                if ((Keys)vKeyCode == Keys.LControlKey && !mainForm.IsCaptureMacroRunning())
                {
                    logger.Info("Capture Macro Started");
                    mainForm.MacroTimerStart();
                }

                if ((Keys)vKeyCode == Keys.Escape && mainForm.IsCaptureMacroRunning())
                {
                    logger.Info("Capture Macro Stopped");
                    mainForm.MacroTimerStop();
                }
            }

            return CallNextHookEx(hkKeyboardId, nCode, wParam, lParam);
        }

        private static IntPtr HookMouseCallBackFn(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_MOUSEMOVE)
            {
                if (mainForm.GetMousePostionSetting())
                {
                    Point mousePosition= new Point();

                    GetCursorPos(ref mousePosition);

                    mainForm.SetMousePosition(mousePosition.X, mousePosition.Y);
                }
            }

            if (nCode >= 0 && wParam == (IntPtr)WM_LBUTTONUP)
            {
                
                if (mainForm.GetMousePostionSetting())
                {
                    MouseHookingStop();
                    mainForm.SetMousePostionSetting(false);
                    logger.Info("Mouse Hooker : mouse clicked / " + WM_LBUTTONUP.ToString());
                }
            }

            return CallNextHookEx(hkMouseId, nCode, wParam, lParam);
        }

        public static void KeyboardHookingStart(BookCaptureMainForm bookCapture)
        {
            mainForm = bookCapture;

            string curProcModuleNm = Process.GetCurrentProcess().MainModule.ModuleName;

            hkKeyboardId = SetWindowsHookEx(WH_KEYBOARD_LL, callbackKeyboard, GetModuleHandle(curProcModuleNm), 0);
            //hkMouseId = SetWindowsHookEx(WH_MOUSE_LL, callbackMouse, GetModuleHandle(curProcModuleNm), 0);

        }

        public static void MouseHookingStart()
        {
            string curProcModuleNm = Process.GetCurrentProcess().MainModule.ModuleName;

            hkMouseId = SetWindowsHookEx(WH_MOUSE_LL, callbackMouse, GetModuleHandle(curProcModuleNm), 0);

        }

        public static void KeyboardHookingStop()
        {
            UnhookWindowsHookEx(hkKeyboardId);
        }

        public static void MouseHookingStop()
        {
            UnhookWindowsHookEx(hkMouseId);
        }

        public static Keys GetPressedKey()
        {
            return pressedKey;
        }

        public static void VKeyPress(string keyValue)
        {
            Keys vKey;
            Enum.TryParse<Keys>(keyValue, out vKey);

            keybd_event((uint)vKey, 0, WM_KEYUP, 0);
        }

        public static void VMouseClick(int x, int y)
        {
            SetCursorPos(x, y);
            //mouse_event((int)WM_LBUTTONDOWN, 0, 0, 0, 0);
            mouse_event((int)WM_LBUTTONUP, 0, 0, 0, 0);
        }
    }
}
