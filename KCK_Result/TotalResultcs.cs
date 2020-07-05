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
    public partial class TotalResultcs : UserControl
    {
        public TotalResultcs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TotalResultcs_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlAdpt1 = new SqlDataAdapter("select * from tbl_ClassMaster", sqlCon);
                DataTable dt1 = new System.Data.DataTable();
                sqlAdpt1.Fill(dt1);
                cmbClass.DataSource = dt1;
                cmbClass.ValueMember = "ClassId";
                cmbClass.DisplayMember = "ClassName";


                sqlCon.Close();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                //cmd.CommandText = "select StudName,Class, SeatNo,Sem,sum(TotalMarks) as Total,slect (case when count(Status)>0 then 'Fail' else  'Pass' end as Status from tbl_ResultDetail group by SeatNo,Sem,Class,StudName having Class=@Class and Sem=@Sem";

               cmd.CommandText= "select StudName, Class, SeatNo, Sem, sum(TotalMarks) as Total,Status = isnull((select case when count(Status) > 0 then 'Fail' else  'Pass' end as Status"+
                 " from tbl_ResultDetail td where Status = 'Fail' and tr.SeatNo = td.SeatNo group by SeatNo) ,'Pass') from tbl_ResultDetail tr group by SeatNo,Sem,Class,StudName having Class = @Class and Sem = @Sem"; 



                cmd.Parameters.AddWithValue("Class", cmbClass.Text.Trim());
                cmd.Parameters.AddWithValue("Sem", txtseat.Text.Trim());

                SqlDataAdapter sqlAdpt = new SqlDataAdapter();
                DataTable dt = new System.Data.DataTable();
                sqlAdpt.SelectCommand = cmd;
                sqlAdpt.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();



            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\KCK_Result\KCK_Result\DbExam.mdf;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Result(StudName,SeatNo,Class,Sem,Total,Status) VALUES(@StudName,@SeatNo,@Class,@Sem,@Total ,@Status)",sqlCon))
                    {
                        

                        cmd.Parameters.AddWithValue("@StudName", row.Cells["StudNm"].Value);
                        cmd.Parameters.AddWithValue("@SeatNo", row.Cells["SeatNo"].Value);
                        cmd.Parameters.AddWithValue("@Class", row.Cells["Class"].Value);
                        cmd.Parameters.AddWithValue("@Sem", row.Cells["Sem"].Value);
                        cmd.Parameters.AddWithValue("@Status", row.Cells["Status"].Value);
                        cmd.Parameters.AddWithValue("@Total", row.Cells["Total"].Value);
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                    }
                }

            }
            MessageBox.Show("Records saved.");
        }
    }
    }

