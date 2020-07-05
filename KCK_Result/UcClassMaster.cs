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
    public partial class UcClassMaster : UserControl
    {
        public int classId;
        public UcClassMaster()
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
                    SqlCommand sqlCmd = new SqlCommand("ClassMaster", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@ClassId", 0);
                    sqlCmd.Parameters.AddWithValue("@ClassName", txtClassName.Text.Trim());
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {



                try

                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ClassMaster", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@ClassId", classId);
                    sqlCmd.Parameters.AddWithValue("@ClassName", txtClassName.Text.Trim());
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

        private void dgvClassMaster_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClassMaster.CurrentRow.Index != -1)
            {

                classId = Convert.ToInt32(dgvClassMaster.CurrentRow.Cells[0].Value.ToString());
                txtClassName.Text = dgvClassMaster.CurrentRow.Cells[1].Value.ToString();

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
                    SqlCommand sqlCmd = new SqlCommand("ClassMaster", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Delete");
                    sqlCmd.Parameters.AddWithValue("@ClassId", classId);
                    sqlCmd.Parameters.AddWithValue("@ClassName", txtClassName.Text.Trim());
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
        private void showdata()
        { string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlAdpt = new SqlDataAdapter("select * from tbl_ClassMaster", sqlCon);
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.Fill(dt);
                dgvClassMaster.DataSource = dt;
                sqlCon.Close();
            }
        }
        private void UcClassMaster_Load(object sender, EventArgs e)
        {
            showdata();

        }

        private void dgvClassMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classId = Convert.ToInt32(dgvClassMaster.CurrentRow.Cells[0].Value.ToString());
            txtClassName.Text = dgvClassMaster.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
