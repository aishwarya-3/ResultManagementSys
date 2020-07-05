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
    public partial class PrepareResult : Form
    {
        public PrepareResult()
        {
            InitializeComponent();
            timerDateTime1.Start();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

        }

        private void pnlright_Paint(object sender, PaintEventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void timerDateTime1_Tick(object sender, EventArgs e)
        {
            String dt = DateTime.Now.ToShortDateString();
            String dy = DateTime.Now.ToShortTimeString();
            label1.Text = dy + "\n" + dt;
        }

        private void PrepareResult_Load(object sender, EventArgs e)
        {
            lblLogOut.Text = Login1.Role + ":Logout";
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            EntryMarks em = new EntryMarks();
            showControl(em);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Update update= new Update();
            showControl(update);
        }

        public void showControl(Control control)
        {
            pnlright.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            pnlright.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalResultcs tr = new TotalResultcs();
            showControl(tr);
        }
    }
}
