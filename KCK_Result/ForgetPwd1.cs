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
    public partial class ForgetPwd1 : Form
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";

        public ForgetPwd1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (txtPwd.Text == "") { MessageBox.Show("Required !!! Please Enter Password"); }
            else if (txtConfirmPwd.Text == "") { MessageBox.Show("Required !!! Please Enter Confirm Password"); }

            else if (txtSecurityQue1.Text == "") { MessageBox.Show("Required !!! Please Enter Birth place"); }
            else if (txtSecurityQue2.Text == "") { MessageBox.Show("Required !!! Please Enter your nick name"); }
            else if (txtSecurityQue3.Text == "") { MessageBox.Show("Required !!! Please Enter your mother's name"); }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter sqlAdpt = new SqlDataAdapter("select UserName,SecurityQue1,SecurityQue2,SecurityQue3 from tbl_RegisterAdmin where UserName='" + txtUNm.Text + "'", sqlCon);
                    DataTable dt = new System.Data.DataTable();
                    sqlAdpt.Fill(dt);
                    string unm = txtUNm.Text.ToString(), sq1 = txtSecurityQue1.Text.ToString(), sq2 = txtSecurityQue2.Text.ToString(),
                    sq3 = txtSecurityQue3.Text.ToString();
                    {
                        try
                        {
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows[0][0].ToString() == unm & dt.Rows[0][1].ToString() == sq1 & dt.Rows[0][2].ToString() == sq2 & dt.Rows[0][3].ToString() == sq3)
                                {
                                    sqlCon.Open();
                                    SqlCommand sqlCmd = new SqlCommand("ResetPassword", sqlCon);
                                    sqlCmd.CommandType = CommandType.StoredProcedure;
                                    sqlCmd.Parameters.AddWithValue("@UserName", txtUNm.Text.Trim());
                                    sqlCmd.Parameters.AddWithValue("@Password", txtPwd.Text.Trim());
                                    sqlCmd.Parameters.AddWithValue("@ConfirmPassword", txtConfirmPwd.Text.Trim());
                                    sqlCmd.ExecuteNonQuery();
                                    sqlCon.Close();
                                    MessageBox.Show("Password reset successfully");
                                    this.Hide();
                                    Login1 login = new Login1();
                                    login.Show();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter correct Answer");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error", ex.Message);
                        }
                    }

                }
            }
        }

            private void btnClear_Click(object sender, EventArgs e)
            {
                txtSecurityQue1.Text = txtSecurityQue2.Text = txtSecurityQue3.Text = txtPwd.Text = txtConfirmPwd.Text = "";
            }

            private void lblConfirmPwd_Click(object sender, EventArgs e)
            {

            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                Environment.Exit(0);
            }
        
    } }
