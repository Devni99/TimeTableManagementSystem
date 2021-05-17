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
    public partial class ManageParallel : Form
    {
        public ManageParallel()
        {
            InitializeComponent();
            populate();
        }
        //Connection String 
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TImeTableDB;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ParDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populate()
        {
            Con.Open();
            string query = "Select * From ParallelSession";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ParDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        //Update
        private void button15_Click(object sender, EventArgs e)
        {
            if (lec01.Text == "" || code.Text == "" || subject.Text == "" || groupID.Text == "" || tag.Text == "" || duration.Text == "")
            {
                MessageBox.Show("Please Select a Session Detail do be Updated !");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Update ParallelSession set Lec01 ='" + lec01.Text + "', Lec02='" + lec02.Text + "', Code ='" + code.Text + "', Subject = '" + subject.Text + "', GroupID ='" + groupID.Text + "', Tag ='" + tag.Text + "' , Duration ='" + duration.Text + "' where SessionID =" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Session Details Updated Successfully .");
                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //clear method
        private void Clear()
        {
            lec01.Text = "";
            lec02.Text = "";
            code.Text = "";
            subject.Text = "";
            groupID.Text = "";
            tag.Text = "";
            duration.Text = "";

        }



        //Data Grid View Onclick
        int key = 0;
        private void ParDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TagID = Convert.ToInt32(TagDGV.Rows[0].Cells[0].Value);
            lec01.Text = ParDGV.SelectedRows[0].Cells[1].Value.ToString();
            lec02.Text = ParDGV.SelectedRows[0].Cells[2].Value.ToString();
            code.Text = ParDGV.SelectedRows[0].Cells[3].Value.ToString();
            subject.Text = ParDGV.SelectedRows[0].Cells[4].Value.ToString();
            groupID.Text = ParDGV.SelectedRows[0].Cells[5].Value.ToString();
            tag.Text = ParDGV.SelectedRows[0].Cells[6].Value.ToString();
            duration.Text = ParDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (lec01.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ParDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Session to be Deleted !");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from ParallelSession where SessionID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted Successfully ");
                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParallelSessions ps = new ParallelSessions();
            ps.Show();
            this.Hide();
        }
    }
}
