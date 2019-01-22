using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCapture
{
    public partial class CaptureBoxForm : Form
    {
        public CaptureBoxForm()
        {
            InitializeComponent();
        }

        public Panel GetCaptureBox()
        {
            return PnCaptureBox;
        }

        public Bitmap CaptureImg()
        {
            Bitmap bitMap = new Bitmap(PnCaptureBox.Width, PnCaptureBox.Height);
            Graphics graphics = Graphics.FromImage(bitMap);

            graphics.CopyFromScreen(PointToScreen(PnCaptureBox.Location), new Point(0, 0), PnCaptureBox.Size);

            return bitMap;
        }
    }
}
