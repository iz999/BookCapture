using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BookCapture
{
    public partial class SelectCaptureTargetForm : Form
    {
        
        private string currentWindowName;
        private string currentWindowPID;    
        
        public string selectedWindowName
        {
            get
            {
                return currentWindowName;
            }
            set
            {
                currentWindowName = selectedWindowName;
            }
        }

        public string selectedWindowPID
        {
            get
            {
                return currentWindowPID;
            }
            set
            {
                currentWindowPID = selectedWindowPID;
            }
        }

        public SelectCaptureTargetForm()
        {
            InitializeComponent();

            ViewGridData();
        }

        private void ViewGridData()
        {
            DgvOpenWindowList.ColumnCount = 2;

            CurrentOpenWindow currentOpenWindow = new CurrentOpenWindow();

            ArrayList gridHeaders = new ArrayList();

            gridHeaders.Add("윈도우 이름");
            gridHeaders.Add("프로세스ID");

            for(int i = 0; i < DgvOpenWindowList.ColumnCount; i++)
            {
                DgvOpenWindowList.Columns[i].HeaderText = gridHeaders[i].ToString();
            }

            ArrayList windowList = currentOpenWindow.GetOpenWindowList();

            for(int i = 0; i < windowList.Count; i++)
            {
                string windowName = ((Dictionary<string, string>)windowList[i])["WindowName"];
                string processID = ((Dictionary<string, string>)windowList[i])["ProcessID"];

                DgvOpenWindowList.Rows.Add(windowName,  processID);
            }
        }

        private void DgvOpenWindowList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentWindowName = (string)DgvOpenWindowList.CurrentRow.Cells[0].Value;
            currentWindowPID = (string)DgvOpenWindowList.CurrentRow.Cells[1].Value;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
