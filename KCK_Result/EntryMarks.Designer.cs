namespace KCK_Result
{
    partial class EntryMarks
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
            this.cmbSubGrp = new System.Windows.Forms.ComboBox();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.lblSubGrp = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubNm = new System.Windows.Forms.Label();
            this.cmbSubNm = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.StudNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIM
            // 
            this.dgvIM.AllowUserToAddRows = false;
            this.dgvIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudNm,
            this.SeatNo,
            this.ClassNm,
            this.Sem,
            this.SubNm,
            this.ExtMarks,
            this.InMarks,
            this.Extra,
            this.TotalMarks,
            this.Status});
            this.dgvIM.Location = new System.Drawing.Point(3, 315);
            this.dgvIM.Name = "dgvIM";
            this.dgvIM.Size = new System.Drawing.Size(1118, 249);
            this.dgvIM.TabIndex = 15;
            this.dgvIM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIM_CellContentClick);
            // 
            // cmbSubGrp
            // 
            this.cmbSubGrp.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSubGrp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubGrp.FormattingEnabled = true;
            this.cmbSubGrp.Location = new System.Drawing.Point(507, 139);
            this.cmbSubGrp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubGrp.Name = "cmbSubGrp";
            this.cmbSubGrp.Size = new System.Drawing.Size(193, 27);
            this.cmbSubGrp.TabIndex = 3;
            this.cmbSubGrp.SelectedIndexChanged += new System.EventHandler(this.cmbSubGrp_SelectedIndexChanged);
            // 
            // cmbSem
            // 
            this.cmbSem.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Location = new System.Drawing.Point(507, 102);
            this.cmbSem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(193, 27);
            this.cmbSem.TabIndex = 12;
            this.cmbSem.SelectedIndexChanged += new System.EventHandler(this.cmbSem_SelectedIndexChanged);
            // 
            // cmbCN
            // 
            this.cmbCN.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(507, 64);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(193, 27);
            this.cmbCN.TabIndex = 1;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
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
            this.lblSubGrp.TabIndex = 11;
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
            this.lblSem.TabIndex = 10;
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
            this.lblCN.TabIndex = 9;
            this.lblCN.Text = "Class Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(448, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 22);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Entry Of  Marks";
            // 
            // lblSubNm
            // 
            this.lblSubNm.AutoSize = true;
            this.lblSubNm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubNm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNm.Location = new System.Drawing.Point(379, 186);
            this.lblSubNm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubNm.Name = "lblSubNm";
            this.lblSubNm.Size = new System.Drawing.Size(114, 21);
            this.lblSubNm.TabIndex = 16;
            this.lblSubNm.Text = "Subject Name";
            // 
            // cmbSubNm
            // 
            this.cmbSubNm.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSubNm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubNm.FormattingEnabled = true;
            this.cmbSubNm.Location = new System.Drawing.Point(507, 180);
            this.cmbSubNm.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubNm.Name = "cmbSubNm";
            this.cmbSubNm.Size = new System.Drawing.Size(193, 27);
            this.cmbSubNm.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(637, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(535, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // StudNm
            // 
            this.StudNm.DataPropertyName = "StudName";
            this.StudNm.HeaderText = "Student Name";
            this.StudNm.Name = "StudNm";
            this.StudNm.Width = 200;
            // 
            // SeatNo
            // 
            this.SeatNo.HeaderText = "Seat No.";
            this.SeatNo.Name = "SeatNo";
            // 
            // ClassNm
            // 
            this.ClassNm.HeaderText = "Class";
            this.ClassNm.Name = "ClassNm";
            // 
            // Sem
            // 
            this.Sem.DataPropertyName = "Sem";
            this.Sem.HeaderText = "Semester";
            this.Sem.Name = "Sem";
            // 
            // SubNm
            // 
            this.SubNm.HeaderText = "Subject Name";
            this.SubNm.Name = "SubNm";
            // 
            // ExtMarks
            // 
            this.ExtMarks.HeaderText = "External Marks";
            this.ExtMarks.Name = "ExtMarks";
            // 
            // InMarks
            // 
            this.InMarks.HeaderText = "Internal Marks";
            this.InMarks.Name = "InMarks";
            // 
            // Extra
            // 
            this.Extra.HeaderText = "Extra Marks";
            this.Extra.Name = "Extra";
            // 
            // TotalMarks
            // 
            this.TotalMarks.DataPropertyName = "TotalMarks";
            this.TotalMarks.HeaderText = "Total Marks";
            this.TotalMarks.Name = "TotalMarks";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // EntryMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSubNm);
            this.Controls.Add(this.lblSubNm);
            this.Controls.Add(this.dgvIM);
            this.Controls.Add(this.cmbSubGrp);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.cmbCN);
            this.Controls.Add(this.lblSubGrp);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblTitle);
            this.Name = "EntryMarks";
            this.Size = new System.Drawing.Size(1027, 549);
            this.Load += new System.EventHandler(this.ExternalMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIM;
        private System.Windows.Forms.ComboBox cmbSubGrp;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.Label lblSubGrp;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubNm;
        private System.Windows.Forms.ComboBox cmbSubNm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn InMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
