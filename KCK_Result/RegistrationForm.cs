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
    public partial class RegistrationForm : Form
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFNm.Text == "") { MessageBox.Show("Required !!! Please Enter Name"); }
            else if (txtLNm.Text == "") { MessageBox.Show("Required !!! Please Enter Last Name"); }
            else if (dateTimePicker1.Text == "") { MessageBox.Show("Required !!! Please Enter Date of Birth "); }
            else if (txtPwd.Text == "") { MessageBox.Show("Required !!! Please Enter Password"); }
            else if (txtConfirmPwd.Text == "") { MessageBox.Show("Required !!! Please Enter Confirm Password"); }
            else if (txtPwdHint.Text == "") { MessageBox.Show("Required !!! Please Enter Password"); }
            else if (txtSecurityQue1.Text == "") { MessageBox.Show("Required !!! Please Enter Birth place"); }
            else if (txtSecurityQue2.Text == "") { MessageBox.Show("Required !!! Please Enter your nick name"); }
            else if (txtSecurityQue3.Text == "") { MessageBox.Show("Required !!! Please Enter your mother's name"); }
            else
            {



                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("RegisterAdmin", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@UserName", txtUNm.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFNm.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLNm.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DateOfBirth ", dateTimePicker1.Value);
                    sqlCmd.Parameters.AddWithValue("@ContactInfo", txtContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPwd.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ConfirmPassword", txtConfirmPwd.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PasswordHint", txtPwdHint.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SecurityQue1", txtSecurityQue1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SecurityQue2", txtSecurityQue2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SecurityQue3", txtSecurityQue3.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Registered successfully");
                    Clear();
                    this.Hide();
                    Login1 login = new Login1();
                    login.Show();

                }
            }
        }

        public void Clear()
        {
            txtFNm.Text = txtLNm.Text = dateTimePicker1.Text = txtContact.Text = txtPwd.Text = txtConfirmPwd.Text = txtPwdHint.Text = txtSecurityQue1.Text = txtSecurityQue2.Text = txtSecurityQue3.Text = "";
        }

        private void lblRegisterAdmin_Click(object sender, EventArgs e)
        {

        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

           
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (e.KeyChar < 48 | e.KeyChar > 57)
                    e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFNm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLNm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLNm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSecurityQue1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSecurityQue2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSecurityQue3_KeyPress(object sender, KeyPressEventArgs e)
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
