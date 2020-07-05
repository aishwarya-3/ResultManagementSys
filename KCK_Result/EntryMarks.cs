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
    public partial class EntryMarks : UserControl
    {
        public EntryMarks()
        {
            

                InitializeComponent();
        }

        private void ExternalMarks_Load(object sender, EventArgs e)
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

                
            }
           // cmbCN.SelectedIndex = -1;
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
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
            
           
            if(cmbCN.SelectedValue.ToString() != "System.Data.DataRowView")
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

        private void cmbSubGrp_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvIM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection=sqlCon;
                cmd.CommandText = "select StudName from tbl_StudentDetails where Class=@Class";
                cmd.Parameters.AddWithValue("Class", cmbCN.Text.Trim());


                SqlDataAdapter sqlAdpt = new SqlDataAdapter();
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.SelectCommand=cmd;
                sqlAdpt.Fill(dt);
                dgvIM.DataSource = dt;
                sqlCon.Close();



            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvIM.Rows)
            {
                row.Cells["SubNm"].Value = cmbSubNm.Text;
            }
            foreach (DataGridViewRow row in dgvIM.Rows)
            {
                row.Cells["ClassNm"].Value = cmbCN.Text;
            }
            foreach (DataGridViewRow row in dgvIM.Rows)
            {
                row.Cells["Sem"].Value = cmbSem.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvIM.Rows)
            {
               
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_ResultDetail(StudName,SeatNo,Class,Sem, SubjectName, ExternalMarks,InternalMarks,ExtraMarks,Status,TotalMarks) VALUES(@StudName,@SeatNo,@Class,@Sem, @SubjectName, @ExternalMarks,@InternalMarks,@ExtraMarks,@Status,@TotalMarks)", sqlCon))
                    {
                        int ttl = 0;
                        String sts = "";
                        ttl = Convert.ToInt32(row.Cells["ExtMarks"].Value) + Convert.ToInt32(row.Cells["InMarks"].Value) + Convert.ToInt32(row.Cells["Extra"].Value);
                        if (ttl < 35)
                            sts = "Fail";
                        else
                            sts = "Pass";
                        cmd.Parameters.AddWithValue("@StudName", row.Cells["StudNm"].Value);
                        cmd.Parameters.AddWithValue("@SeatNo", row.Cells["SeatNo"].Value);
                        cmd.Parameters.AddWithValue("@SubjectName", row.Cells["SubNm"].Value);
                        cmd.Parameters.AddWithValue("@Class", row.Cells["ClassNm"].Value);
                        cmd.Parameters.AddWithValue("@Sem", row.Cells["Sem"].Value);
                        cmd.Parameters.AddWithValue("@ExternalMarks", row.Cells["ExtMarks"].Value);
                        cmd.Parameters.AddWithValue("@InternalMarks", row.Cells["InMarks"].Value);
                        cmd.Parameters.AddWithValue("@ExtraMarks", row.Cells["Extra"].Value);
                        cmd.Parameters.AddWithValue("@Status", sts);
                        // cmd.Parameters.AddWithValue("@TotalMarks", row.Cells["TotalMarks"].Value);
                        cmd.Parameters.AddWithValue("@TotalMarks", ttl);
                        
                        row.Cells["TotalMarks"].Value = ttl;
                        row.Cells["Status"].Value = sts;

                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                    }
                }
            
            }
            MessageBox.Show("Records saved.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                foreach (DataGridViewRow row in dgvIM.Rows)
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE  tbl_ResultDetail set ExternalMarks=@ExternalMarks,InternalMarks=@InternalMarks,ExtraMarks=@ExtraMarks WHERE DetailId=@DetailId)", sqlCon))
                    {
                        sqlCon.Open();
                        cmd.Parameters.AddWithValue("@SeatNo", row.Cells["SeatNo"].Value);
                        cmd.Parameters.AddWithValue("@SubjectName", row.Cells["SubNm"].Value);
                        cmd.Parameters.AddWithValue("@Class", row.Cells["ClassNm"].Value);
                        cmd.Parameters.AddWithValue("@Sem", row.Cells["Sem"].Value);
                        cmd.Parameters.AddWithValue("@ExternalMarks", row.Cells["ExtMarks"].Value);
                        cmd.Parameters.AddWithValue("@InternalMarks", row.Cells["InMarks"].Value);
                        cmd.Parameters.AddWithValue("@ExtraMarks", row.Cells["Extra"].Value);

                       
                        
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                    }

                }
            }
            MessageBox.Show("Records Saved.");


        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 
}
