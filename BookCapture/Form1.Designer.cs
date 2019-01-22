namespace BookCapture
{
    partial class Form1
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
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.txtXStart = new System.Windows.Forms.TextBox();
            this.txtYStart = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYEnd = new System.Windows.Forms.TextBox();
            this.txtXEnd = new System.Windows.Forms.TextBox();
            this.txtDelayTime = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtRepeatTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.btnPostion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(131, 19);
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.Size = new System.Drawing.Size(139, 21);
            this.txtKeyValue.TabIndex = 1;
            this.txtKeyValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyValue_KeyDown);
            // 
            // txtXStart
            // 
            this.txtXStart.Location = new System.Drawing.Point(155, 66);
            this.txtXStart.Name = "txtXStart";
            this.txtXStart.Size = new System.Drawing.Size(43, 21);
            this.txtXStart.TabIndex = 3;
            // 
            // txtYStart
            // 
            this.txtYStart.Location = new System.Drawing.Point(227, 66);
            this.txtYStart.Name = "txtYStart";
            this.txtYStart.Size = new System.Drawing.Size(43, 21);
            this.txtYStart.TabIndex = 4;
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.x1.Location = new System.Drawing.Point(131, 67);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(18, 17);
            this.x1.TabIndex = 5;
            this.x1.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(204, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(204, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(131, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // txtYEnd
            // 
            this.txtYEnd.Location = new System.Drawing.Point(227, 113);
            this.txtYEnd.Name = "txtYEnd";
            this.txtYEnd.Size = new System.Drawing.Size(43, 21);
            this.txtYEnd.TabIndex = 8;
            // 
            // txtXEnd
            // 
            this.txtXEnd.Location = new System.Drawing.Point(155, 113);
            this.txtXEnd.Name = "txtXEnd";
            this.txtXEnd.Size = new System.Drawing.Size(43, 21);
            this.txtXEnd.TabIndex = 7;
            // 
            // txtDelayTime
            // 
            this.txtDelayTime.Location = new System.Drawing.Point(131, 153);
            this.txtDelayTime.Name = "txtDelayTime";
            this.txtDelayTime.Size = new System.Drawing.Size(139, 21);
            this.txtDelayTime.TabIndex = 13;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(103, 272);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtRepeatTime
            // 
            this.txtRepeatTime.Location = new System.Drawing.Point(131, 192);
            this.txtRepeatTime.Name = "txtRepeatTime";
            this.txtRepeatTime.Size = new System.Drawing.Size(139, 21);
            this.txtRepeatTime.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "반복횟수";
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Location = new System.Drawing.Point(131, 229);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(139, 21);
            this.txtSaveFolder.TabIndex = 18;
            // 
            // btnPostion
            // 
            this.btnPostion.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPostion.Location = new System.Drawing.Point(19, 67);
            this.btnPostion.Name = "btnPostion";
            this.btnPostion.Size = new System.Drawing.Size(75, 23);
            this.btnPostion.TabIndex = 20;
            this.btnPostion.Text = "좌표지정";
            this.btnPostion.UseVisualStyleBackColor = true;
            this.btnPostion.Click += new System.EventHandler(this.btnPostion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(19, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "지연시간";
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSaveFolder.Location = new System.Drawing.Point(19, 229);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFolder.TabIndex = 21;
            this.btnSaveFolder.Text = "저장경로";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(19, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "키 등록";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(292, 315);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveFolder);
            this.Controls.Add(this.btnPostion);
            this.Controls.Add(this.txtSaveFolder);
            this.Controls.Add(this.txtRepeatTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDelayTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYEnd);
            this.Controls.Add(this.txtXEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.txtYStart);
            this.Controls.Add(this.txtXStart);
            this.Controls.Add(this.txtKeyValue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "eBook Capture Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.TextBox txtXStart;
        private System.Windows.Forms.TextBox txtYStart;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYEnd;
        private System.Windows.Forms.TextBox txtXEnd;
        private System.Windows.Forms.TextBox txtDelayTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtRepeatTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.Button btnPostion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.Label label6;
    }
}

