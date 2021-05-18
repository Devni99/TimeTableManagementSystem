using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Itpm
{
    
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\Itpm\Itpm\ITPM.mdf;Integrated Security=True;Connect Timeout=30");
        public Form6()
        {
            InitializeComponent();
        }
        //submit
        private void button1_Click(object sender, EventArgs e)
        {
          
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Time6_Table VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Data Sucessfully");
                con.Close();
          
        }
        //clear
        private void button3_Click(object sender, EventArgs e)
        {
             comboBox1.Text = comboBox2.Text = textBox1.Text = "";
            MessageBox.Show("Clear Data Successfully");
        }
        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Time6_Table where ID='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Data Successfully");
        }
    }
}
