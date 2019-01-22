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
        private ArrayList openWindowList = new ArrayList();

        private ArrayList SetOpenWindowList()
        {
            Process[] processList = Process.GetProcesses();

            foreach(Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle)) //윈도우 캡션이 존재
                {
                    Dictionary<string, string> windowData = new Dictionary<string, string>();
                    windowData.Add("WindowName", process.MainWindowTitle);
                    windowData.Add("ProcessID", process.Id.ToString());

                    openWindowList.Add(windowData);
                }
            }


            return openWindowList;                
        }

        public ArrayList GetOpenWindowList()
        {            
            return SetOpenWindowList();
        }
    }
}
