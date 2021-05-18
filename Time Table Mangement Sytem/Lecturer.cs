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
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-91TGPQV\SQLEXPRESS;Initial Catalog=TimeTable DB1;Integrated Security=True");

        private void label21_Click(object sender, EventArgs e)
        {

        }

        //Generate Rank
        private void button4_Click(object sender, EventArgs e)
        {
            string Empid = EmpID.Text;
            string level = Level.SelectedItem.ToString();


            Rank.Text = level + "." + Empid;
        }

        //Insert Query
        private void button13_Click(object sender, EventArgs e)
        {
            if (Faculty.SelectedIndex == -1 || Center.SelectedIndex == -1 || Dept.SelectedIndex == -1 || Center.SelectedIndex == -1 || EmpID.Text == "" || LecName.Text == "")
            {
                MessageBox.Show("Please Fill All Fields !");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into Lecturer values ('" + EmpID.Text + "','" + LecName.Text + "','" + Faculty.SelectedItem.ToString() + "','" + Dept.SelectedItem.ToString() + "','" + Center.SelectedItem.ToString() + "','" + Building.SelectedItem.ToString() + "','" + Level.SelectedItem + "','" + NoOfDays.SelectedItem + "','" + NoOfHours.SelectedItem + "' ,'" + Rank.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lectures Details Saved Successfully .");
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

        //populate method
        private void populate()
        {
            Con.Open();
            string query = "Select * From Lecturer";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LecDGV.DataSource = ds.Tables[0];
            Con.Close();

        }




        


        //Data Grid View Onclick
        int key = 0;
        private void LecDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.Text = LecDGV.SelectedRows[0].Cells[0].Value.ToString();
            LecName.Text = LecDGV.SelectedRows[0].Cells[1].Value.ToString();
            Faculty.SelectedItem = LecDGV.SelectedRows[0].Cells[2].Value.ToString();
            Dept.SelectedItem = LecDGV.SelectedRows[0].Cells[3].Value.ToString();
            Center.SelectedItem = LecDGV.SelectedRows[0].Cells[4].Value.ToString();
            Building.SelectedItem = LecDGV.SelectedRows[0].Cells[5].Value.ToString();
            Level.SelectedItem = LecDGV.SelectedRows[0].Cells[6].Value.ToString();
            NoOfDays.SelectedItem = LecDGV.SelectedRows[0].Cells[7].Value.ToString();
            NoOfHours.SelectedItem = LecDGV.SelectedRows[0].Cells[8].Value.ToString();
            Rank.Text = LecDGV.SelectedRows[0].Cells[9].Value.ToString();


            if (LecName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LecDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        //Update Query
        private void button1_Click(object sender, EventArgs e)
        {
            if (Faculty.SelectedIndex == -1 || Center.SelectedIndex == -1 || Dept.SelectedIndex == -1 || Center.SelectedIndex == -1 || EmpID.Text == "" || LecName.Text == "")
            {
                MessageBox.Show("Please Select a Lecturer Detail do be Updated !");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Update Lecturer set  Name ='" + LecName.Text + "', Faculty ='" + Faculty.SelectedItem.ToString() + "', Department ='" + Dept.SelectedItem.ToString() + "', Center ='" + Center.SelectedItem.ToString() + "', Building  = '" + Building.SelectedItem.ToString() + "',  Level = '" + Level.SelectedItem.ToString() + "',  NoDays  = '" + NoOfDays.SelectedItem.ToString() + "', NoHours  = '" + NoOfHours.SelectedItem.ToString() + "', Rank ='" + Rank.Text + "'  where EMPID =" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lecturer Details Updated Successfully .");
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

        //Delete Query
        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Lecturer Detail to be Deleted !");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from Lecturer where EMPID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lecturer Deleted Successfully ");
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

        //Clear method
        private void Clear()
        {
            EmpID.Text = "";
            LecName.Text = "";
            Faculty.Text = "";
            Dept.Text = "";
            Center.Text = "";
            Building.Text = "";
           Level.Text = "";
           NoOfDays.Text = "";
           NoOfHours.Text = "";
            Rank.Text = "";

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Lecturer lec = new Lecturer();
            lec.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Subjects sub = new Subjects();
            sub.Show();
            this.Hide();
        }

        //Calling the method clear

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LecDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
