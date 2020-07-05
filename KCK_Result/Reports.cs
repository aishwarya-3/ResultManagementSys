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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            timerDateTime.Start();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login1 login1 = new Login1();
            login1.Show();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            String dt = DateTime.Now.ToShortDateString();
            String dy = DateTime.Now.ToShortTimeString();
            label1.Text = dy + "\n" + dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'DbExamDataSet.tbl_ClassMaster' table. You can move, or remove it, as needed.
            //this.tbl_ClassMasterTableAdapter.Fill(this.DbExamDataSet.tbl_ClassMaster);
            lblLogOut.Text = Login1.Role + ":Logout";
            //this.reportViewer1.RefreshReport();
        }

        private void btnConsolated_Click(object sender, EventArgs e)
        {
            ResultRpt rr = new ResultRpt();
            rr.Show();
        }
        public void showControl(Control control)
        {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel1.Controls.Add(control);
        }

        private void btnDisResult_Click(object sender, EventArgs e)
        {
            StudRpt sr = new StudRpt();
            sr.Show();
        }
    }
}
