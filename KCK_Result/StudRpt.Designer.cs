namespace KCK_Result
{
    partial class StudRpt
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DbExamDataSet = new KCK_Result.DbExamDataSet();
            this.tbl_StudentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StudentDetailsTableAdapter = new KCK_Result.DbExamDataSetTableAdapters.tbl_StudentDetailsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.classToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.classToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DbExamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_StudentDetailsBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbl_StudentDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KCK_Result.StudRpt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 304);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbExamDataSet
            // 
            this.DbExamDataSet.DataSetName = "DbExamDataSet";
            this.DbExamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_StudentDetailsBindingSource
            // 
            this.tbl_StudentDetailsBindingSource.DataMember = "tbl_StudentDetails";
            this.tbl_StudentDetailsBindingSource.DataSource = this.DbExamDataSet;
            // 
            // tbl_StudentDetailsTableAdapter
            // 
            this.tbl_StudentDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripLabel,
            this.classToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // classToolStripLabel
            // 
            this.classToolStripLabel.Name = "classToolStripLabel";
            this.classToolStripLabel.Size = new System.Drawing.Size(37, 22);
            this.classToolStripLabel.Text = "Class:";
            // 
            // classToolStripTextBox
            // 
            this.classToolStripTextBox.Name = "classToolStripTextBox";
            this.classToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 19);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // StudRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StudRpt";
            this.Text = "StudRpt";
            this.Load += new System.EventHandler(this.StudRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbExamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_StudentDetailsBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_StudentDetailsBindingSource;
        private DbExamDataSet DbExamDataSet;
        private DbExamDataSetTableAdapters.tbl_StudentDetailsTableAdapter tbl_StudentDetailsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel classToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox classToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}