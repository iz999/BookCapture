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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKeyValue_KeyDown(object sender, KeyEventArgs e)
        {
            txtKeyValue.ResetText();

            KeysConverter kc = new KeysConverter();

            txtKeyValue.Text = kc.ConvertToString(e.KeyCode);

            MessageBox.Show(txtKeyValue.Text);
        }

        private void btnPostion_Click(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(Form1_makeRect);
        }

        private void Form1_makeRect(object sender, MouseEventArgs e)
        {
            Point firstPoint = e.Location;
            Size sz = new Size(100, 100);
            Graphics g = this.CreateGraphics();

            Rectangle rt = new Rectangle(firstPoint, sz);
            g.DrawRectangle(Pens.Red, rt);
            //g.DrawLine(Pens.Black, firstPoint, e.Location);
        }
    }
}
