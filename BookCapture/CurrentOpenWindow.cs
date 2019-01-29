using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace BookCapture
{
    public class CurrentOpenWindow
    {
        private delegate bool EnumWindowCallback(int hwnd, int lParam);

        [DllImport("user32.dll")]
        private static extern int EnumWindows(EnumWindowCallback callback, int y);

        [DllImport("user32.dll")]
        private static extern int GetParent(int hWnd);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern long GetWindowLong(int hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(int hwnd);

        //[DllImport("user32.dll")]
        //private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        private const int GWL_STYLE = -16;

        private ArrayList openWindowList = new ArrayList();

        public CurrentOpenWindow()
        {
            EnumWindowCallback callback = new EnumWindowCallback(EnumWindowsProc);

            EnumWindows(callback, 0);
        }

        public ArrayList GetOpenWindowList()
        {            
            return openWindowList;
        }


        private bool EnumWindowsProc(int hWnd, int lParam)
        {
            //윈도우 스타일 확인
            //UInt32 style = (UInt32)GetWindowLong(hWnd, GWL_STYLE);

            //해당 윈도우 캡션 확인
            //if ((style & 0x10000000L) == 0x10000000L && (style & 0x00C00000L) == 0x00C00000L)
            //{
            //바탕화면이 부모인지 확인
            //if (GetParent(hWnd) == 0)
            if (IsWindowVisible(hWnd))
            {
                StringBuilder pName = new StringBuilder(256);
                //프로그램 타이틀 확인

                if (GetWindowText(hWnd, pName, 256) > 0)
                {
                    //uint pId;

                    //GetWindowThreadProcessId((IntPtr)hWnd, out pId);

                    Dictionary<string, string> windowData = new Dictionary<string, string>();
                    windowData.Add("WindowName", pName.ToString());
                    windowData.Add("HandlePointer", hWnd.ToString());

                    openWindowList.Add(windowData);
                }
 //               }
            }
            return true;
        }
    }
}
