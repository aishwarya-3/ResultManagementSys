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
    public partial class Update : UserControl
    {
        public Update()
        {
            InitializeComponent();
        }

        private void lblSubGrp_Click(object sender, EventArgs e)
        {

        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSem_Click(object sender, EventArgs e)
        {

        }

        private void lblCN_Click(object sender, EventArgs e)
        {

        }

        private void cmbSubGrp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InternalMarks_Load(object sender, EventArgs e)
        {

            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlAdpt = new SqlDataAdapter("select * from tbl_ClassMaster", sqlCon);
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.Fill(dt);
                cmbCN.DataSource = dt;
                cmbCN.ValueMember = "ClassId";
                cmbCN.DisplayMember = "ClassName";
                sqlCon.Close();
            }
        }

        private void cmbCN_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbSem.Items.Clear();
            if (cmbCN.Text == "F.Y.B.A.")
            {

                cmbSem.Items.Add("I");
                cmbSem.Items.Add("II");
            }
            else if (cmbCN.Text == "S.Y.B.A.")
            {
                cmbSem.Items.Add("III");
                cmbSem.Items.Add("IV");
            }


            else if (cmbCN.Text == "F.Y.B.Sc.(Comp Sci)")
            {
                cmbSem.Items.Add("I");
                cmbSem.Items.Add("II");
            }
            else if (cmbCN.Text == "S.Y.B.Sc.(Comp Sci)")
            {
                cmbSem.Items.Add("III");
                cmbSem.Items.Add("IV");
            }
            if (cmbCN.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter sqlAdpt1 = new SqlDataAdapter("select * from tbl_SubjectGroup WHERE ClassId=" + cmbCN.SelectedValue.ToString(), sqlCon);

                    DataTable dt1 = new System.Data.DataTable();
                    sqlAdpt1.Fill(dt1);
                    cmbSubGrp.DataSource = dt1;
                    cmbSubGrp.ValueMember = "GroupId";
                    cmbSubGrp.DisplayMember = "GroupName";
                    sqlCon.Close();
                }
            }

        }

        private void cmbSubGrp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSubGrp.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter sqlAdpt1 = new SqlDataAdapter("select * from tbl_SubjectMaster WHERE GroupId=" + cmbSubGrp.SelectedValue.ToString(), sqlCon);

                    DataTable dt1 = new System.Data.DataTable();
                    sqlAdpt1.Fill(dt1);
                    cmbSubNm.DataSource = dt1;
                    cmbSubNm.ValueMember = "SubId";
                    cmbSubNm.DisplayMember = "SubjectName";
                    sqlCon.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = "select * from tbl_ResultDetail where Class=@Class and Sem=@Sem and SubjectName=@SubjectName ";
                cmd.Parameters.AddWithValue("Class", cmbCN.Text.Trim());
                cmd.Parameters.AddWithValue("Sem", cmbSem.Text.Trim());
                cmd.Parameters.AddWithValue("SubjectName", cmbSubNm.Text.Trim());

                SqlDataAdapter sqlAdpt2 = new SqlDataAdapter();
                DataTable dt2 = new System.Data.DataTable();
                sqlAdpt2.SelectCommand = cmd;
                sqlAdpt2.Fill(dt2);
                dgvUpdate.DataSource = dt2;
                sqlCon.Close();



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUpdate.Rows)
            {

                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Update  tbl_ResultDetail set ExternalMarks=@ExternalMarks , InternalMarks=@InternalMarks , ExtraMarks=@ExtraMarks ,TotalMarks=@TotalMarks ,Status=@Status where DetailId=@DetailId", sqlCon))
                    {
                        int ttl = 0;
                        String sts = "";
                        ttl = Convert.ToInt32(row.Cells["ExtMarks"].Value) + Convert.ToInt32(row.Cells["InMarks"].Value) + Convert.ToInt32(row.Cells["ExtraMarks"].Value);
                        if (ttl < 35)
                            sts = "Fail";
                        else
                            sts = "Pass";
                        cmd.Parameters.AddWithValue("@DetailId", row.Cells["Id"].Value);
                        cmd.Parameters.AddWithValue("@ExternalMarks", row.Cells["ExtMarks"].Value);
                        cmd.Parameters.AddWithValue("@InternalMarks", row.Cells["InMarks"].Value);
                        cmd.Parameters.AddWithValue("@ExtraMarks", row.Cells["ExtraMarks"].Value);
                        cmd.Parameters.AddWithValue("@Status", sts);
                        cmd.Parameters.AddWithValue("@TotalMarks", ttl);

                        row.Cells["TotalMarks"].Value = ttl;
                        row.Cells["Status"].Value = sts;

                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                    }
                }

            }
            MessageBox.Show("Updated Successfully");
        }
    }
}
