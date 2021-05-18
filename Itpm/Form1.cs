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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\Itpm\Itpm\ITPM.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }
        // save button
        private void button1_Click(object sender, EventArgs e)
        {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Time1_Table VALUES('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Data Sucessfully");
                con.Close();
        }
        //Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = comboBox1.Text = comboBox3.Text = "";
            MessageBox.Show("Clear Data Successfully");
        }
        // Next button
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }
    }
}
