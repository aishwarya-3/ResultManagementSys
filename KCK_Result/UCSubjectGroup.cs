using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KCK_Result
{
    public partial class UCSubjectGroup : UserControl
    {
        public int Grpid;
        public UCSubjectGroup()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {



                try

                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SubjectGroup", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Insert");
                    sqlCmd.Parameters.AddWithValue("@GroupId", 0);
                   
                    sqlCmd.Parameters.AddWithValue("@ClassId", cmbClassId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@GroupName", txtGrpName.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Inserted successfully");




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error message");
                }
                finally
                {


                    showdata();
                }
            }
        }

        private void showdata()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlAdpt = new SqlDataAdapter("select * from tbl_SubjectGroup", sqlCon);
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.Fill(dt);
                dgvSubGrp.DataSource = dt;
                sqlCon.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {



                try

                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SubjectGroup", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Delete");
                    sqlCmd.Parameters.AddWithValue("@GroupId", Grpid);
                    
                    sqlCmd.Parameters.AddWithValue("@ClassId", cmbClassId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@GroupName", txtGrpName.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Deleted successfully");




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error message");
                }
                finally
                {
                    showdata();

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {



                try

                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SubjectGroup", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@GroupId", Grpid);
                
                    sqlCmd.Parameters.AddWithValue("@ClassId", cmbClassId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@GroupName", txtGrpName.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Updated successfully");




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error message");
                }
                finally
                {

                    showdata();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbClassId.Text = "";
           
            txtGrpName.Text = "";
        }

        //private void dgvSubGrp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvSubGrp.CurrentRow.Index != -1)
        //    {
        //        Grpid = Convert.ToInt32(dgvSubGrp.CurrentRow.Cells[0].Value.ToString());
        //        cmbClassId.Text = dgvSubGrp.CurrentRow.Cells[2].Value.ToString();
        //        cmbSubId.Text = dgvSubGrp.CurrentRow.Cells[1].Value.ToString();
        //        txtGrpName.Text = dgvSubGrp.CurrentRow.Cells[3].Value.ToString();
        //    }
        //}

        private void txtSubId_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCSubjectGroup_Load(object sender, EventArgs e)
        {
            showdata();


            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlAdpt = new SqlDataAdapter("select * from tbl_ClassMaster", sqlCon);
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.Fill(dt);
                cmbClassId.DataSource = dt;
                cmbClassId.ValueMember = "ClassId";
                cmbClassId.DisplayMember = "ClassName";

              
                sqlCon.Close();


            }
        }

        private void dgvSubGrp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubGrp.CurrentRow.Index != -1)
            {
                Grpid = Convert.ToInt32(dgvSubGrp.CurrentRow.Cells[0].Value.ToString());
                
               
                cmbClassId.SelectedValue = dgvSubGrp.CurrentRow.Cells[1].Value.ToString();
                txtGrpName.Text = dgvSubGrp.CurrentRow.Cells[2].Value.ToString();
            }
    }
    }
}
