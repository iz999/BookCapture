namespace BookCapture
{
    partial class SelectCaptureTargetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvOpenWindowList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpenWindowList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvOpenWindowList
            // 
            this.DgvOpenWindowList.AllowUserToAddRows = false;
            this.DgvOpenWindowList.AllowUserToDeleteRows = false;
            this.DgvOpenWindowList.AllowUserToResizeColumns = false;
            this.DgvOpenWindowList.AllowUserToResizeRows = false;
            this.DgvOpenWindowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOpenWindowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOpenWindowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOpenWindowList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvOpenWindowList.Location = new System.Drawing.Point(12, 12);
            this.DgvOpenWindowList.MultiSelect = false;
            this.DgvOpenWindowList.Name = "DgvOpenWindowList";
            this.DgvOpenWindowList.ReadOnly = true;
            this.DgvOpenWindowList.RowHeadersVisible = false;
            this.DgvOpenWindowList.RowTemplate.Height = 23;
            this.DgvOpenWindowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOpenWindowList.Size = new System.Drawing.Size(331, 323);
            this.DgvOpenWindowList.TabIndex = 0;
            this.DgvOpenWindowList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOpenWindowList_CellDoubleClick);
            // 
            // SelectCaptureTargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 347);
            this.Controls.Add(this.DgvOpenWindowList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectCaptureTargetForm";
            this.Text = "캡쳐 대상 선택";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpenWindowList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOpenWindowList;
    }
}