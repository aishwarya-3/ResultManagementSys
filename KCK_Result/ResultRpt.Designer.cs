namespace KCK_Result
{
    partial class ResultRpt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbExamDataSet = new KCK_Result.DbExamDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblPreResult = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.classToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.classToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tbl_ResultTableAdapter = new KCK_Result.DbExamDataSetTableAdapters.tbl_ResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbExamDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_ResultBindingSource
            // 
            this.tbl_ResultBindingSource.DataMember = "tbl_Result";
            this.tbl_ResultBindingSource.DataSource = this.DbExamDataSet;
            // 
            // DbExamDataSet
            // 
            this.DbExamDataSet.DataSetName = "DbExamDataSet";
            this.DbExamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KCK_Result.Results.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 270);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblPreResult
            // 
            this.lblPreResult.AutoSize = true;
            this.lblPreResult.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreResult.Location = new System.Drawing.Point(316, 39);
            this.lblPreResult.Name = "lblPreResult";
            this.lblPreResult.Size = new System.Drawing.Size(206, 73);
            this.lblPreResult.TabIndex = 45;
            this.lblPreResult.Text = "Result";
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
            this.fillByToolStrip.TabIndex = 48;
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
            this.classToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tbl_ResultTableAdapter
            // 
            this.tbl_ResultTableAdapter.ClearBeforeFill = true;
            // 
            // ResultRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.lblPreResult);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ResultRpt";
            this.Text = "ResultRpt";
            this.Load += new System.EventHandler(this.ResultRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbExamDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_ResultBindingSource;
        private DbExamDataSet DbExamDataSet;
        private DbExamDataSetTableAdapters.tbl_ResultTableAdapter tbl_ResultTableAdapter;
        private System.Windows.Forms.Label lblPreResult;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel classToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox classToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}