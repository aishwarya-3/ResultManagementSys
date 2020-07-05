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
    public partial class UCSubjectMaster : UserControl
    {
        public int Subjid;
        public UCSubjectMaster()
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
                    SqlCommand sqlCmd = new SqlCommand("SubjectMaster", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Insert");
                    sqlCmd.Parameters.AddWithValue("@SubId", 0);
                    sqlCmd.Parameters.AddWithValue("@ClassId", cmbClassId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@GroupId", cmbGrpId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@Semester", txtSem.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SubjectName", txtSub.Text.Trim());
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
                SqlDataAdapter sqlAdpt = new SqlDataAdapter("select * from tbl_SubjectMaster", sqlCon);
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.Fill(dt);
                dgvSubMaster.DataSource = dt;

                sqlCon.Close();
            }
        }

        private void UCSubjectMaster_Load(object sender, EventArgs e)
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

                SqlDataAdapter sqlAdpt1 = new SqlDataAdapter("select * from tbl_SubjectGroup", sqlCon);
                DataTable dt1 = new System.Data.DataTable();
                sqlAdpt1.Fill(dt1);
                cmbGrpId.DataSource = dt1;
                cmbGrpId.ValueMember = "GroupId";
                cmbGrpId.DisplayMember = "GroupName";


                sqlCon.Close();
            }
        }

        //private void dgvSubMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        //private void dgvSubMaster_DoubleClick(object sender, EventArgs e)
        //{
            
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {



                try

                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SubjectMaster", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Delete");
                    sqlCmd.Parameters.AddWithValue("@SubId", Subjid);
                    sqlCmd.Parameters.AddWithValue("@ClassId", cmbClassId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@GroupId", cmbGrpId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@Semester", txtSem.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SubjectName", txtSub.Text.Trim());
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

        private void lblSemester_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {



                try

                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SubjectMaster", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@SubId", Subjid);
                    sqlCmd.Parameters.AddWithValue("@ClassId", cmbClassId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@GroupId", cmbGrpId.SelectedValue.ToString());
                    sqlCmd.Parameters.AddWithValue("@Semester", txtSem.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SubjectName", txtSub.Text.Trim());
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
            cmbGrpId.Text = "";
            txtSem.Text = "";
            txtSub.Text = "";


        }

        private void dgvSubMaster_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubMaster.CurrentRow.Index != -1)
            {
                Subjid = Convert.ToInt32(dgvSubMaster.CurrentRow.Cells[0].Value.ToString());
                cmbClassId.SelectedValue = dgvSubMaster.CurrentRow.Cells[1].Value.ToString();
                cmbGrpId.SelectedValue = dgvSubMaster.CurrentRow.Cells[4].Value.ToString();
                txtSem.Text = dgvSubMaster.CurrentRow.Cells[2].Value.ToString();
                txtSub.Text = dgvSubMaster.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void cmbGrpId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
