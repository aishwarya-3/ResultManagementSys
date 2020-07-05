﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCK_Result
{
    public partial class StudRpt : Form
    {
        public StudRpt()
        {
            InitializeComponent();
        }

        private void StudRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbExamDataSet.tbl_StudentDetails' table. You can move, or remove it, as needed.
            this.tbl_StudentDetailsTableAdapter.Fill(this.DbExamDataSet.tbl_StudentDetails);

            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_StudentDetailsTableAdapter.FillBy(this.DbExamDataSet.tbl_StudentDetails, classToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
