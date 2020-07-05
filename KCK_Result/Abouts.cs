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
    public partial class Abouts : Form
    {
        public Abouts()
        {
            InitializeComponent();
            timerDateTime.Start();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
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

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            String dt = DateTime.Now.ToShortDateString();
            String dy = DateTime.Now.ToShortTimeString();
            label1.Text = dy + "\n" + dt;
        }
        public void showControl(Control control)
        {
            pnlright.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            pnlright.Controls.Add(control);
        }

        private void Abouts_Load(object sender, EventArgs e)
        {
            lblLogOut.Text = Login1.Role + ":Logout";
        }
    }
}
