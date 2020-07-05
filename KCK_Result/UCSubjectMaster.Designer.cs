namespace KCK_Result
{
    partial class UCSubjectMaster
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.lblClassId = new System.Windows.Forms.Label();
            this.dgvSubMaster = new System.Windows.Forms.DataGridView();
            this.SubId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGrpId = new System.Windows.Forms.Label();
            this.cmbGrpId = new System.Windows.Forms.ComboBox();
            this.cmbClassId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(664, 159);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(526, 159);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(390, 159);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightGray;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(250, 159);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 34);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSem
            // 
            this.txtSem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSem.Location = new System.Drawing.Point(382, 61);
            this.txtSem.Margin = new System.Windows.Forms.Padding(4);
            this.txtSem.Name = "txtSem";
            this.txtSem.Size = new System.Drawing.Size(148, 26);
            this.txtSem.TabIndex = 2;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(260, 64);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(65, 19);
            this.lblSemester.TabIndex = 9;
            this.lblSemester.Text = "Semester";
            this.lblSemester.Click += new System.EventHandler(this.lblSemester_Click);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(260, 113);
            this.lblSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(55, 19);
            this.lblSub.TabIndex = 15;
            this.lblSub.Text = "Subject";
            // 
            // txtSub
            // 
            this.txtSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.Location = new System.Drawing.Point(382, 106);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(148, 26);
            this.txtSub.TabIndex = 3;
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassId.Location = new System.Drawing.Point(260, 19);
            this.lblClassId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(55, 19);
            this.lblClassId.TabIndex = 18;
            this.lblClassId.Text = "ClassId";
            // 
            // dgvSubMaster
            // 
            this.dgvSubMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubId,
            this.ClassId,
            this.GrpId,
            this.Sem,
            this.Subject});
            this.dgvSubMaster.Location = new System.Drawing.Point(250, 214);
            this.dgvSubMaster.Name = "dgvSubMaster";
            this.dgvSubMaster.Size = new System.Drawing.Size(549, 330);
            this.dgvSubMaster.TabIndex = 19;
            this.dgvSubMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubMaster_CellContentClick_1);
            // 
            // SubId
            // 
            this.SubId.DataPropertyName = "SubId";
            this.SubId.HeaderText = "Subject Id";
            this.SubId.Name = "SubId";
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "Class Id";
            this.ClassId.Name = "ClassId";
            // 
            // GrpId
            // 
            this.GrpId.DataPropertyName = "GroupId";
            this.GrpId.HeaderText = "Group Id";
            this.GrpId.Name = "GrpId";
            // 
            // Sem
            // 
            this.Sem.DataPropertyName = "Semester";
            this.Sem.HeaderText = "Semester";
            this.Sem.Name = "Sem";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "SubjectName";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // lblGrpId
            // 
            this.lblGrpId.AutoSize = true;
            this.lblGrpId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrpId.Location = new System.Drawing.Point(583, 77);
            this.lblGrpId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrpId.Name = "lblGrpId";
            this.lblGrpId.Size = new System.Drawing.Size(65, 19);
            this.lblGrpId.TabIndex = 20;
            this.lblGrpId.Text = "Group Id";
            // 
            // cmbGrpId
            // 
            this.cmbGrpId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrpId.FormattingEnabled = true;
            this.cmbGrpId.Location = new System.Drawing.Point(711, 74);
            this.cmbGrpId.Name = "cmbGrpId";
            this.cmbGrpId.Size = new System.Drawing.Size(121, 27);
            this.cmbGrpId.TabIndex = 4;
            this.cmbGrpId.SelectedIndexChanged += new System.EventHandler(this.cmbGrpId_SelectedIndexChanged);
            // 
            // cmbClassId
            // 
            this.cmbClassId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassId.FormattingEnabled = true;
            this.cmbClassId.Location = new System.Drawing.Point(382, 11);
            this.cmbClassId.Name = "cmbClassId";
            this.cmbClassId.Size = new System.Drawing.Size(148, 27);
            this.cmbClassId.TabIndex = 1;
            // 
            // UCSubjectMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.cmbClassId);
            this.Controls.Add(this.cmbGrpId);
            this.Controls.Add(this.lblGrpId);
            this.Controls.Add(this.dgvSubMaster);
            this.Controls.Add(this.lblClassId);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSem);
            this.Controls.Add(this.lblSemester);
            this.Name = "UCSubjectMaster";
            this.Size = new System.Drawing.Size(1027, 547);
            this.Load += new System.EventHandler(this.UCSubjectMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.DataGridView dgvSubMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.Label lblGrpId;
        private System.Windows.Forms.ComboBox cmbGrpId;
        private System.Windows.Forms.ComboBox cmbClassId;
    }
}
