using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCK_Result
{
    public partial class Login1 : Form
    {
        public static string Role = "";
        public Login1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }


        private void Login1_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlAdpt = new SqlDataAdapter("select * from tbl_RegisterAdmin where UserName='Admin'", sqlCon);
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                    RegistrationForm registrationform = new RegistrationForm();
                    registrationform.Show();
                    registrationform.Focus();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlAdpt = new SqlDataAdapter("select UserName,Password from tbl_RegisterAdmin where UserName='" + txtUName.Text + "'" +"and Password ='" + txtPwd.Text + "'", sqlCon);
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.Fill(dt);
                string unm = txtUName.Text.ToString(), ps = txtPwd.Text.ToString();
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][0].ToString() == unm & dt.Rows[0][1].ToString() == ps)
                        {
                            Role = txtUName.Text.Trim();
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("enter valid input");
                        }


                    }
                    else
                    {
                        MessageBox.Show("enter valid input");
                    }

                }
                catch (Exception ex) {
                    MessageBox.Show("Error" + ex);
                }

            }
        }

        private void llblForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPwd1 forgetPwd = new ForgetPwd1();
            forgetPwd.Show();
        }

        private void lblUName_Click(object sender, EventArgs e)
        {

        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8))
            {
                if (!(e.KeyChar >= 97 & e.KeyChar <= 122 | e.KeyChar >= 65 & e.KeyChar <= 90))
                {
                    e.KeyChar = (char)0;
                    e.Handled = true;
                }
            }
        }
    }
}
