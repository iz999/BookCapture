namespace BookCapture
{
    partial class CaptureBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnCaptureBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnCaptureBox
            // 
            this.PnCaptureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PnCaptureBox.Location = new System.Drawing.Point(12, 12);
            this.PnCaptureBox.Name = "PnCaptureBox";
            this.PnCaptureBox.Size = new System.Drawing.Size(18, 10);
            this.PnCaptureBox.TabIndex = 0;
            // 
            // CaptureBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(42, 32);
            this.Controls.Add(this.PnCaptureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureBoxForm";
            this.ShowInTaskbar = false;
            this.Text = "CaptureBoxForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnCaptureBox;
    }
}