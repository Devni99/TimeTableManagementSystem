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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            populate();
        }

        //Connection String

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-91TGPQV\SQLEXPRESS;Initial Catalog=TimeTable DB1;Integrated Security=True");



        //Update  Query//
        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (OfferedYear.SelectedIndex == -1 || OfferSem.SelectedIndex == -1 || NOOfLecHour.Value == 0 || NoOFTuteHour.Value == -0 || NoOfLabHour.Value == -0 || NoOfEvaluHour.Value == -0 || SubName.Text == "" || SubCode.Text == "")
                {
                    MessageBox.Show("Please Select a Subjects Detail do be Updated !");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string Query = "Update Subject set  Name ='" + SubName.Text + "', OfferedYear ='" + OfferedYear.SelectedItem.ToString() + "', OfferedSemester ='" + OfferSem.SelectedItem.ToString() + "', NOOfLecHour ='" + NOOfLecHour.Text.ToString() + "', NOOfTuteHour  = '" + NoOFTuteHour.Text.ToString() + "',  NoOFLabHour = '" + NoOfLabHour.Text.ToString() + "',  NoOFEvaluHour  = '" + NoOfEvaluHour.Text.ToString() + "'  where SubCodeID =" + key + ";";
                        SqlCommand cmd = new SqlCommand(Query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Subjects Details Updated Successfully .");
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
        }
            
       

        private void Subjects_Load(object sender, EventArgs e)
        {

        }


        //Save Query
        private void button13_Click(object sender, EventArgs e)
        {
            {
                if (OfferedYear.SelectedIndex == -1 || OfferSem.SelectedIndex == -1 || NOOfLecHour.Value == 0 || NoOFTuteHour.Value == -0 || NoOfLabHour.Value == -0 || NoOfEvaluHour.Value == -0 || SubName.Text == "" || SubCode.Text == "")
                {
                    MessageBox.Show("Please Fill All Fields !");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string Query = "insert into Subject values ('" + OfferedYear.SelectedItem.ToString() + "','" + OfferSem.SelectedItem.ToString() + "','" + SubName.Text + "','" + SubCode.Text + "','" + NOOfLecHour.Value.ToString() + "','" + NoOFTuteHour.Value.ToString() + "','" + NoOfLabHour.Value.ToString() + "','" + NoOfEvaluHour.Value.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(Query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Subjects Details Saved Successfully .");
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

        }
            //populate method

            private void populate()
            {
                Con.Open();
                string query = "Select * From Subject";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                SubDGV.DataSource = ds.Tables[0];
                Con.Close();

            }

        
        //Delete Query
        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (key == 0)
                {
                    MessageBox.Show("Select a Subjects Details to be Deleted !");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string Query = "Delete from Subject where SubCode=" + key + ";";
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
        }


        //Clear method
        private void Clear()
        {
            OfferedYear.Text = "";
            OfferSem.Text = "";
            SubName.Text = "";
            SubCode.Text = "";
            NOOfLecHour.Text = "";
            NoOFTuteHour.Text = "";
            NoOfLabHour.Text = "";
            NoOfEvaluHour.Text = "";
            
        }
        //Calling the method clear
        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Subjects sub = new Subjects();
            sub.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
          Lecturer lec = new Lecturer();
            lec.Show();
            this.Hide();
        }

        private void OfferedYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Data Grid View Onclick
        int key = 0;

        private void SubDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OfferedYear.SelectedItem = SubDGV.SelectedRows[0].Cells[0].Value.ToString();
            OfferSem.SelectedItem = SubDGV.SelectedRows[0].Cells[1].Value.ToString();
            SubName.Text = SubDGV.SelectedRows[0].Cells[2].Value.ToString();
            SubCode.Text= SubDGV.SelectedRows[0].Cells[3].Value.ToString();
            NOOfLecHour.Text = SubDGV.SelectedRows[0].Cells[4].Value.ToString();
            NoOFTuteHour.Text = SubDGV.SelectedRows[0].Cells[5].Value.ToString();
            NoOfLabHour.Text = SubDGV.SelectedRows[0].Cells[6].Value.ToString();
            NoOfEvaluHour.Text = SubDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (SubName.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(SubDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NoOfEvaluHour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OfferSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
