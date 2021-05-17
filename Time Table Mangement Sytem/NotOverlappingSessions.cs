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
    public partial class NotOverlappingSessions : Form
    {
        public NotOverlappingSessions()
        {
            InitializeComponent();
            populate();
        }

        //Connection String 
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TImeTableDB;Integrated Security=True");

        private void NotOverlappingSessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tImeTableDBDataSet2.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.tImeTableDBDataSet2.Session);

            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            OverDGV.Columns.Insert(0, chkbox);
        }

        private void OverDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TImeTableDB;Integrated Security=True");

            foreach (DataGridViewRow dr in OverDGV.Rows)
            {
                bool chkboxSelected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxSelected)
                {
                    string sqlquery = "Insert into NotOverlapping values (@Lec01,@Lec02,@Code,@Subject,@GroupID,@Tag,@Duration)";
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
            ManageNotOverlappingSessions mo = new ManageNotOverlappingSessions();
            mo.Show();
            this.Hide();
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
