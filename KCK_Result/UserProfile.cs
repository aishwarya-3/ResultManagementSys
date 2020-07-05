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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            timerDateTime.Start();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            String dt = DateTime.Now.ToShortDateString();
            String dy = DateTime.Now.ToShortTimeString();
            label1.Text = dy + "\n" + dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                if (Login1.Role != "Admin")
                {
                    MessageBox.Show("Please login as admin");
                }
                else
                {
                    SqlDataAdapter sqlAdpt = new SqlDataAdapter("select * from tbl_RegisterAdmin ", sqlCon);
                    DataTable dt = new System.Data.DataTable();
                    sqlAdpt.Fill(dt);
                    string unm = txtUNm.Text.ToString(), ps = txtPwd.Text.ToString();
                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            txtUNm.Text = dt.Rows[0][1].ToString();
                            txtFNm.Text = dt.Rows[0][2].ToString();
                            txtLNm.Text = dt.Rows[0][3].ToString();
                            dateTimePicker1.Text = dt.Rows[0][4].ToString();
                            txtContact.Text = dt.Rows[0][5].ToString();
                            txtPwd.Text = dt.Rows[0][6].ToString();
                            txtPwdHint.Text = dt.Rows[0][8].ToString();
                            txtSecurityQue1.Text = dt.Rows[0][9].ToString();
                            txtSecurityQue2.Text = dt.Rows[0][10].ToString();
                            txtSecurityQue3.Text = dt.Rows[0][11].ToString();
                        }




                    }




                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

            }
                
                
            }

        private void pnlright_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {

        }

        private void lblPwdHint_Click(object sender, EventArgs e)
        {

        }
    }
        }

