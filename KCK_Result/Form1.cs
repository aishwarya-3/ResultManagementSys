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
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if(_obj==null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Form1()
        {
            InitializeComponent();

            timerDateTime.Start();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Master master = new Master();
            master.Show();
        }

        private void lblPreResult_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUtility_Click(object sender, EventArgs e)
        {

        }

        private void btnBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PrepareResult preresult = new PrepareResult();
            preresult.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
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

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Utilities utilities = new Utilities();
            utilities.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLogOut.Text = Login1.Role + ":Logout";
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Abouts abt = new Abouts();
            abt.Show();
        }
    }
}
