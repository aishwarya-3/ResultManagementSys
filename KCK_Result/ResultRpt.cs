using System;
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
    public partial class ResultRpt : Form
    {
        public ResultRpt()
        {
            InitializeComponent();
        }

        private void ResultRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbExamDataSet.tbl_Result' table. You can move, or remove it, as needed.
            this.tbl_ResultTableAdapter.Fill(this.DbExamDataSet.tbl_Result);

            this.reportViewer1.RefreshReport();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_ResultTableAdapter.FillBy(this.DbExamDataSet.tbl_Result, classToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
