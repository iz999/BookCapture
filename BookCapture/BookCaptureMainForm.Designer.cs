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
            this.BtnSetMouseXY = new System.Windows.Forms.Button();
            this.TxtMousePosX = new System.Windows.Forms.TextBox();
            this.TxtMousePosY = new System.Windows.Forms.TextBox();
            this.RdbModeSelect1 = new System.Windows.Forms.RadioButton();
            this.RdbModeSelect2 = new System.Windows.Forms.RadioButton();
            this.GrbModeSelection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbCapturedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCaptureBox)).BeginInit();
            this.GrbModeSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtKeyValue
            // 
            this.TxtKeyValue.Enabled = false;
            this.TxtKeyValue.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtKeyValue.Location = new System.Drawing.Point(96, 78);
            this.TxtKeyValue.Name = "TxtKeyValue";
            this.TxtKeyValue.ReadOnly = true;
            this.TxtKeyValue.Size = new System.Drawing.Size(173, 22);
            this.TxtKeyValue.TabIndex = 1;
            // 
            // TxtDelayTime
            // 
            this.TxtDelayTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtDelayTime.Location = new System.Drawing.Point(96, 164);
            this.TxtDelayTime.Name = "TxtDelayTime";
            this.TxtDelayTime.Size = new System.Drawing.Size(123, 22);
            this.TxtDelayTime.TabIndex = 13;
            this.TxtDelayTime.Text = "1000";
            this.TxtDelayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDelayTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDelayTime_KeyPress);
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStart.Location = new System.Drawing.Point(141, 220);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(128, 22);
            this.BtnStart.TabIndex = 14;
            this.BtnStart.Text = "매크로시작";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // TxtRepeatTime
            // 
            this.TxtRepeatTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtRepeatTime.Location = new System.Drawing.Point(190, 107);
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
            this.TxtCaptureProgram.Location = new System.Drawing.Point(96, 192);
            this.TxtCaptureProgram.Name = "TxtCaptureProgram";
            this.TxtCaptureProgram.ReadOnly = true;
            this.TxtCaptureProgram.Size = new System.Drawing.Size(173, 22);
            this.TxtCaptureProgram.TabIndex = 18;
            this.TxtCaptureProgram.Visible = false;
            // 
            // BtnSetKey
            // 
            this.BtnSetKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSetKey.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSetKey.Location = new System.Drawing.Point(15, 78);
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
            this.button2.Location = new System.Drawing.Point(15, 164);
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
            this.button3.Location = new System.Drawing.Point(15, 107);
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
            this.PbCapturedImg.Location = new System.Drawing.Point(279, 8);
            this.PbCapturedImg.Name = "PbCapturedImg";
            this.PbCapturedImg.Size = new System.Drawing.Size(170, 235);
            this.PbCapturedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCapturedImg.TabIndex = 28;
            this.PbCapturedImg.TabStop = false;
            // 
            // PbCaptureBox
            // 
            this.PbCaptureBox.Location = new System.Drawing.Point(279, 21);
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
            this.BtnStartCapture.Location = new System.Drawing.Point(15, 220);
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
            this.BtnCaptureProgram.Location = new System.Drawing.Point(15, 192);
            this.BtnCaptureProgram.Name = "BtnCaptureProgram";
            this.BtnCaptureProgram.Size = new System.Drawing.Size(75, 22);
            this.BtnCaptureProgram.TabIndex = 31;
            this.BtnCaptureProgram.Text = "캡처대상";
            this.BtnCaptureProgram.UseVisualStyleBackColor = true;
            this.BtnCaptureProgram.Visible = false;
            this.BtnCaptureProgram.Click += new System.EventHandler(this.BtnCaptureProgram_Click);
            // 
            // BtnSaveFolder
            // 
            this.BtnSaveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSaveFolder.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSaveFolder.Location = new System.Drawing.Point(15, 136);
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
            this.TxtSaveFolder.Location = new System.Drawing.Point(96, 136);
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
            this.textBox1.Location = new System.Drawing.Point(242, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 15);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "ms";
            // 
            // TxtRepeatCnt
            // 
            this.TxtRepeatCnt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtRepeatCnt.Location = new System.Drawing.Point(96, 107);
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
            this.textBox2.Location = new System.Drawing.Point(178, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 15);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "/";
            // 
            // BtnSetMouseXY
            // 
            this.BtnSetMouseXY.Enabled = false;
            this.BtnSetMouseXY.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSetMouseXY.Location = new System.Drawing.Point(15, 50);
            this.BtnSetMouseXY.Name = "BtnSetMouseXY";
            this.BtnSetMouseXY.Size = new System.Drawing.Size(75, 22);
            this.BtnSetMouseXY.TabIndex = 37;
            this.BtnSetMouseXY.TabStop = false;
            this.BtnSetMouseXY.Text = "마우스";
            this.BtnSetMouseXY.UseVisualStyleBackColor = true;
            this.BtnSetMouseXY.Click += new System.EventHandler(this.BtnSetMouseXY_Click);
            // 
            // TxtMousePosX
            // 
            this.TxtMousePosX.Enabled = false;
            this.TxtMousePosX.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtMousePosX.Location = new System.Drawing.Point(96, 50);
            this.TxtMousePosX.Name = "TxtMousePosX";
            this.TxtMousePosX.ReadOnly = true;
            this.TxtMousePosX.Size = new System.Drawing.Size(76, 22);
            this.TxtMousePosX.TabIndex = 38;
            this.TxtMousePosX.TabStop = false;
            this.TxtMousePosX.Text = "0";
            this.TxtMousePosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtMousePosY
            // 
            this.TxtMousePosY.Enabled = false;
            this.TxtMousePosY.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtMousePosY.Location = new System.Drawing.Point(193, 50);
            this.TxtMousePosY.Name = "TxtMousePosY";
            this.TxtMousePosY.ReadOnly = true;
            this.TxtMousePosY.Size = new System.Drawing.Size(76, 22);
            this.TxtMousePosY.TabIndex = 39;
            this.TxtMousePosY.TabStop = false;
            this.TxtMousePosY.Text = "0";
            this.TxtMousePosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RdbModeSelect1
            // 
            this.RdbModeSelect1.AutoSize = true;
            this.RdbModeSelect1.Checked = true;
            this.RdbModeSelect1.Location = new System.Drawing.Point(38, 20);
            this.RdbModeSelect1.Name = "RdbModeSelect1";
            this.RdbModeSelect1.Size = new System.Drawing.Size(83, 16);
            this.RdbModeSelect1.TabIndex = 40;
            this.RdbModeSelect1.TabStop = true;
            this.RdbModeSelect1.Tag = "KeyMode";
            this.RdbModeSelect1.Text = "키보드모드";
            this.RdbModeSelect1.UseVisualStyleBackColor = true;
            this.RdbModeSelect1.CheckedChanged += new System.EventHandler(this.RdbModeSelect1_CheckedChanged);
            // 
            // RdbModeSelect2
            // 
            this.RdbModeSelect2.AutoSize = true;
            this.RdbModeSelect2.Location = new System.Drawing.Point(136, 20);
            this.RdbModeSelect2.Name = "RdbModeSelect2";
            this.RdbModeSelect2.Size = new System.Drawing.Size(83, 16);
            this.RdbModeSelect2.TabIndex = 41;
            this.RdbModeSelect2.TabStop = true;
            this.RdbModeSelect2.Tag = "MouseMode";
            this.RdbModeSelect2.Text = "마우스모드";
            this.RdbModeSelect2.UseVisualStyleBackColor = true;
            this.RdbModeSelect2.Visible = false;
            this.RdbModeSelect2.CheckedChanged += new System.EventHandler(this.RdbModeSelect2_CheckedChanged);
            // 
            // GrbModeSelection
            // 
            this.GrbModeSelection.Controls.Add(this.RdbModeSelect2);
            this.GrbModeSelection.Controls.Add(this.RdbModeSelect1);
            this.GrbModeSelection.Location = new System.Drawing.Point(15, 1);
            this.GrbModeSelection.Name = "GrbModeSelection";
            this.GrbModeSelection.Size = new System.Drawing.Size(254, 43);
            this.GrbModeSelection.TabIndex = 42;
            this.GrbModeSelection.TabStop = false;
            // 
            // BookCaptureMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(461, 252);
            this.Controls.Add(this.GrbModeSelection);
            this.Controls.Add(this.TxtMousePosY);
            this.Controls.Add(this.TxtMousePosX);
            this.Controls.Add(this.BtnSetMouseXY);
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
            this.Text = "Capture Macro - Press Control Key to Start";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookCaptureMainForm_FormClosing);
            this.Load += new System.EventHandler(this.BookCaptureMainForm_Load);
            this.LocationChanged += new System.EventHandler(this.BookCaptureMainForm_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PbCapturedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCaptureBox)).EndInit();
            this.GrbModeSelection.ResumeLayout(false);
            this.GrbModeSelection.PerformLayout();
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
        private System.Windows.Forms.Button BtnSetMouseXY;
        private System.Windows.Forms.TextBox TxtMousePosX;
        private System.Windows.Forms.TextBox TxtMousePosY;
        private System.Windows.Forms.RadioButton RdbModeSelect1;
        private System.Windows.Forms.RadioButton RdbModeSelect2;
        private System.Windows.Forms.GroupBox GrbModeSelection;
    }
}

