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

        //Connection String 
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TImeTableDB;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        //Generate ID
        private void button3_Click(object sender, EventArgs e)
        {
            string Empid = EmpID.Text;
            string level = Level.SelectedItem.ToString();


            Rank.Text = level + "." + Empid;


        }

        //Save Query
        private void button1_Click(object sender, EventArgs e)
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
                    string Query = "insert into Lecturer values ('"+EmpID.Text + "','" + LecName.Text + "','" + Faculty.SelectedItem.ToString() + "','" + Dept.SelectedItem.ToString() + "','" + Center.SelectedItem.ToString() + "','" + Building.SelectedItem.ToString() + "','" + Level.SelectedItem + "','" + NoOfDays.SelectedItem + "','"+ NoOfHours.SelectedItem +"' ,'" +Rank.Text+ "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lectures Details Saved Successfully .");
                    Con.Close();
                    populate();
                    //Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //to display data to the gridview when page is loaded
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

        private void LecDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        //Delete Query
        private void button10_Click(object sender, EventArgs e)
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
                    //Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        //Update Query
        private void button13_Click(object sender, EventArgs e)
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
                    string Query = "Update Lecturer set  Name ='"+ LecName.Text + "', Faculty ='" + Faculty.SelectedItem.ToString() + "', Department ='" + Dept.SelectedItem.ToString() + "', Center ='" + Center.SelectedItem.ToString() + "', Building  = '" + Building.SelectedItem.ToString() + "',  Level = '" + Level.SelectedItem.ToString() + "',  NoDays  = '" + NoOfDays.SelectedItem.ToString() + "', NoHours  = '" + NoOfHours.SelectedItem.ToString() + "', Rank ='" + Rank.Text + "'  where EMPID =" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Group Details Updated Successfully .");
                    Con.Close();
                    populate();
                    //Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

             
        }

        //Nav bar Btn click
        private void label17_Click(object sender, EventArgs e)
        {
            Lecturer lec = new Lecturer();
            lec.Show();
            this.Hide();
        }
    }
}
