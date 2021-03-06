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

namespace Time_Table_Mangement_Sytem
{
    public partial class ParallelSessions : Form
    {
        public ParallelSessions()
        {
            InitializeComponent();
            populate();
        }

        //Connection String 
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TImeTableDB;Integrated Security=True");

        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TImeTableDB;Integrated Security=True");

            foreach (DataGridViewRow dr in ParaDGV.Rows)
            {
                bool chkboxSelected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxSelected)
                {
                    string sqlquery = "Insert into ParallelSession values (@Lec01,@Lec02,@Code,@Subject,@GroupID,@Tag,@Duration)";
                    SqlCommand sqlComm = new SqlCommand(sqlquery, Con);
                    sqlComm.Parameters.AddWithValue("@Lec01", dr.Cells[2].Value);
                    sqlComm.Parameters.AddWithValue("@Lec02", dr.Cells[3].Value);
                    sqlComm.Parameters.AddWithValue("@Code", dr.Cells[4].Value);
                    sqlComm.Parameters.AddWithValue("@Subject", dr.Cells[5].Value);
                    sqlComm.Parameters.AddWithValue("@GroupID", dr.Cells[6].Value);
                    sqlComm.Parameters.AddWithValue("@Tag", dr.Cells[7].Value);
                    sqlComm.Parameters.AddWithValue("@Duration", dr.Cells[8].Value);
                    Con.Open();
                    sqlComm.ExecuteNonQuery();
                    Con.Close();
                }
                label2.Text = "Selected Recordes Inserted Successfully";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageParallel mp = new ManageParallel();
            mp.Show();
            this.Hide();
        }

        private void ParaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Addstudents Ob = new Addstudents();
            Ob.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Session_ManagementDashboard sd = new Session_ManagementDashboard();
            sd.Show();
            this.Hide();
        }

        private void populate()
        {
            Con.Open();
            string query = "Select * From Session";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();
        }

        private void ParallelSessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tImeTableDBDataSet1.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.tImeTableDBDataSet1.Session);

            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            ParaDGV.Columns.Insert(0, chkbox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsecutiveSessions cs = new ConsecutiveSessions();
            cs.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ParallelSessions ps = new ParallelSessions();
            ps.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NotOverlappingSessions os = new NotOverlappingSessions();
            os.Show();
            this.Hide();
        }
    }
}
