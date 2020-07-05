namespace KCK_Result
{
    partial class UnitMarks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvIM = new System.Windows.Forms.DataGridView();
            this.StuNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSubGrp = new System.Windows.Forms.ComboBox();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.lblSubGrp = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIM
            // 
            this.dgvIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuNm,
            this.SeatNo});
            this.dgvIM.Location = new System.Drawing.Point(6, 223);
            this.dgvIM.Name = "dgvIM";
            this.dgvIM.Size = new System.Drawing.Size(1007, 70);
            this.dgvIM.TabIndex = 31;
            // 
            // StuNm
            // 
            this.StuNm.HeaderText = "Student Name";
            this.StuNm.Name = "StuNm";
            // 
            // SeatNo
            // 
            this.SeatNo.HeaderText = "Seat No.";
            this.SeatNo.Name = "SeatNo";
            // 
            // cmbSubGrp
            // 
            this.cmbSubGrp.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSubGrp.FormattingEnabled = true;
            this.cmbSubGrp.Location = new System.Drawing.Point(507, 139);
            this.cmbSubGrp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubGrp.Name = "cmbSubGrp";
            this.cmbSubGrp.Size = new System.Drawing.Size(193, 21);
            this.cmbSubGrp.TabIndex = 30;
            // 
            // cmbSem
            // 
            this.cmbSem.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Location = new System.Drawing.Point(507, 102);
            this.cmbSem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(193, 21);
            this.cmbSem.TabIndex = 29;
            // 
            // cmbCN
            // 
            this.cmbCN.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(507, 64);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(193, 21);
            this.cmbCN.TabIndex = 28;
            // 
            // lblSubGrp
            // 
            this.lblSubGrp.AutoSize = true;
            this.lblSubGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubGrp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGrp.Location = new System.Drawing.Point(379, 141);
            this.lblSubGrp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubGrp.Name = "lblSubGrp";
            this.lblSubGrp.Size = new System.Drawing.Size(120, 21);
            this.lblSubGrp.TabIndex = 27;
            this.lblSubGrp.Text = "Subject Group";
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(421, 108);
            this.lblSem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(78, 21);
            this.lblSem.TabIndex = 26;
            this.lblSem.Text = "Semester";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCN.Location = new System.Drawing.Point(400, 70);
            this.lblCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(99, 21);
            this.lblCN.TabIndex = 25;
            this.lblCN.Text = "Class Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(400, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 22);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Entry Of Unit Test Marks";
            // 
            // UnitMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.dgvIM);
            this.Controls.Add(this.cmbSubGrp);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.cmbCN);
            this.Controls.Add(this.lblSubGrp);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblTitle);
            this.Name = "UnitMarks";
            this.Size = new System.Drawing.Size(1027, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatNo;
        private System.Windows.Forms.ComboBox cmbSubGrp;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.Label lblSubGrp;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label lblTitle;
    }
}
