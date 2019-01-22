namespace BookCapture
{
    partial class BookCaptureMainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtKeyValue = new System.Windows.Forms.TextBox();
            this.TxtDelayTime = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TxtRepeatTime = new System.Windows.Forms.TextBox();
            this.TxtCaptureProgram = new System.Windows.Forms.TextBox();
            this.BtnSetKey = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PbCapturedImg = new System.Windows.Forms.PictureBox();
            this.PbCaptureBox = new System.Windows.Forms.PictureBox();
            this.BtnStartCapture = new System.Windows.Forms.Button();
            this.BtnCaptureProgram = new System.Windows.Forms.Button();
            this.BtnSaveFolder = new System.Windows.Forms.Button();
            this.TxtSaveFolder = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtRepeatCnt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbCapturedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCaptureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKeyValue
            // 
            this.TxtKeyValue.Enabled = false;
            this.TxtKeyValue.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtKeyValue.Location = new System.Drawing.Point(95, 17);
            this.TxtKeyValue.Name = "TxtKeyValue";
            this.TxtKeyValue.ReadOnly = true;
            this.TxtKeyValue.Size = new System.Drawing.Size(173, 22);
            this.TxtKeyValue.TabIndex = 1;
            // 
            // TxtDelayTime
            // 
            this.TxtDelayTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtDelayTime.Location = new System.Drawing.Point(95, 103);
            this.TxtDelayTime.Name = "TxtDelayTime";
            this.TxtDelayTime.Size = new System.Drawing.Size(123, 22);
            this.TxtDelayTime.TabIndex = 13;
            this.TxtDelayTime.Text = "1000";
            this.TxtDelayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDelayTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDelayTime_KeyPress);
            // 
            // BtnStart
            // 
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStart.Location = new System.Drawing.Point(140, 159);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(128, 22);
            this.BtnStart.TabIndex = 14;
            this.BtnStart.Text = "매크로시작";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TxtRepeatTime
            // 
            this.TxtRepeatTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtRepeatTime.Location = new System.Drawing.Point(189, 46);
            this.TxtRepeatTime.Name = "TxtRepeatTime";
            this.TxtRepeatTime.Size = new System.Drawing.Size(79, 22);
            this.TxtRepeatTime.TabIndex = 16;
            this.TxtRepeatTime.Text = "1";
            this.TxtRepeatTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRepeatTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRepeatTime_KeyPress);
            // 
            // TxtCaptureProgram
            // 
            this.TxtCaptureProgram.Enabled = false;
            this.TxtCaptureProgram.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtCaptureProgram.Location = new System.Drawing.Point(95, 131);
            this.TxtCaptureProgram.Name = "TxtCaptureProgram";
            this.TxtCaptureProgram.ReadOnly = true;
            this.TxtCaptureProgram.Size = new System.Drawing.Size(173, 22);
            this.TxtCaptureProgram.TabIndex = 18;
            // 
            // BtnSetKey
            // 
            this.BtnSetKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSetKey.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSetKey.Location = new System.Drawing.Point(14, 17);
            this.BtnSetKey.Name = "BtnSetKey";
            this.BtnSetKey.Size = new System.Drawing.Size(75, 22);
            this.BtnSetKey.TabIndex = 22;
            this.BtnSetKey.TabStop = false;
            this.BtnSetKey.Text = "키 등록";
            this.BtnSetKey.UseVisualStyleBackColor = true;
            this.BtnSetKey.Click += new System.EventHandler(this.BtnSetKey_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(14, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 23;
            this.button2.TabStop = false;
            this.button2.Text = "지연시간";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(14, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 24;
            this.button3.TabStop = false;
            this.button3.Text = "반복횟수";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PbCapturedImg
            // 
            this.PbCapturedImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbCapturedImg.Location = new System.Drawing.Point(278, 17);
            this.PbCapturedImg.Name = "PbCapturedImg";
            this.PbCapturedImg.Size = new System.Drawing.Size(122, 164);
            this.PbCapturedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCapturedImg.TabIndex = 28;
            this.PbCapturedImg.TabStop = false;
            // 
            // PbCaptureBox
            // 
            this.PbCaptureBox.Location = new System.Drawing.Point(292, 25);
            this.PbCaptureBox.Name = "PbCaptureBox";
            this.PbCaptureBox.Size = new System.Drawing.Size(20, 14);
            this.PbCaptureBox.TabIndex = 29;
            this.PbCaptureBox.TabStop = false;
            this.PbCaptureBox.Visible = false;
            this.PbCaptureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCaptureBox_Paint);
            this.PbCaptureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbCaptureBox_MouseDown);
            this.PbCaptureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbCaptureBox_MouseMove);
            this.PbCaptureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbCaptureBox_MouseUp);
            // 
            // BtnStartCapture
            // 
            this.BtnStartCapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStartCapture.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStartCapture.Location = new System.Drawing.Point(14, 159);
            this.BtnStartCapture.Name = "BtnStartCapture";
            this.BtnStartCapture.Size = new System.Drawing.Size(120, 22);
            this.BtnStartCapture.TabIndex = 30;
            this.BtnStartCapture.Text = "캡처영역지정";
            this.BtnStartCapture.UseVisualStyleBackColor = true;
            this.BtnStartCapture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnStartCapture_MouseClick);
            // 
            // BtnCaptureProgram
            // 
            this.BtnCaptureProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCaptureProgram.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCaptureProgram.Location = new System.Drawing.Point(14, 131);
            this.BtnCaptureProgram.Name = "BtnCaptureProgram";
            this.BtnCaptureProgram.Size = new System.Drawing.Size(75, 22);
            this.BtnCaptureProgram.TabIndex = 31;
            this.BtnCaptureProgram.Text = "캡처대상";
            this.BtnCaptureProgram.UseVisualStyleBackColor = true;
            this.BtnCaptureProgram.Click += new System.EventHandler(this.BtnCaptureProgram_Click);
            // 
            // BtnSaveFolder
            // 
            this.BtnSaveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSaveFolder.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSaveFolder.Location = new System.Drawing.Point(14, 75);
            this.BtnSaveFolder.Name = "BtnSaveFolder";
            this.BtnSaveFolder.Size = new System.Drawing.Size(75, 22);
            this.BtnSaveFolder.TabIndex = 32;
            this.BtnSaveFolder.Text = "저장경로";
            this.BtnSaveFolder.UseVisualStyleBackColor = true;
            this.BtnSaveFolder.Click += new System.EventHandler(this.BtnSaveFolder_Click);
            // 
            // TxtSaveFolder
            // 
            this.TxtSaveFolder.Enabled = false;
            this.TxtSaveFolder.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtSaveFolder.Location = new System.Drawing.Point(95, 75);
            this.TxtSaveFolder.Name = "TxtSaveFolder";
            this.TxtSaveFolder.ReadOnly = true;
            this.TxtSaveFolder.Size = new System.Drawing.Size(173, 22);
            this.TxtSaveFolder.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(241, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 15);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "ms";
            // 
            // TxtRepeatCnt
            // 
            this.TxtRepeatCnt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtRepeatCnt.Location = new System.Drawing.Point(95, 46);
            this.TxtRepeatCnt.Name = "TxtRepeatCnt";
            this.TxtRepeatCnt.ReadOnly = true;
            this.TxtRepeatCnt.Size = new System.Drawing.Size(76, 22);
            this.TxtRepeatCnt.TabIndex = 35;
            this.TxtRepeatCnt.TabStop = false;
            this.TxtRepeatCnt.Text = "0";
            this.TxtRepeatCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(177, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 15);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "/";
            // 
            // BookCaptureMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(420, 195);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtRepeatCnt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtSaveFolder);
            this.Controls.Add(this.BtnSaveFolder);
            this.Controls.Add(this.BtnCaptureProgram);
            this.Controls.Add(this.BtnStartCapture);
            this.Controls.Add(this.PbCaptureBox);
            this.Controls.Add(this.PbCapturedImg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSetKey);
            this.Controls.Add(this.TxtCaptureProgram);
            this.Controls.Add(this.TxtRepeatTime);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtDelayTime);
            this.Controls.Add(this.TxtKeyValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookCaptureMainForm";
            this.Text = "Capture Macro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookCaptureMainForm_FormClosing);
            this.Load += new System.EventHandler(this.BookCaptureMainForm_Load);
            this.LocationChanged += new System.EventHandler(this.BookCaptureMainForm_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PbCapturedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCaptureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtKeyValue;
        private System.Windows.Forms.TextBox TxtDelayTime;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox TxtRepeatTime;
        private System.Windows.Forms.TextBox TxtCaptureProgram;
        private System.Windows.Forms.Button BtnSetKey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox PbCapturedImg;
        private System.Windows.Forms.PictureBox PbCaptureBox;
        private System.Windows.Forms.Button BtnStartCapture;
        private System.Windows.Forms.Button BtnCaptureProgram;
        private System.Windows.Forms.Button BtnSaveFolder;
        private System.Windows.Forms.TextBox TxtSaveFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtRepeatCnt;
        private System.Windows.Forms.TextBox textBox2;
    }
}

