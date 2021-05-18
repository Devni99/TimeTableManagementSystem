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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\Itpm\Itpm\ITPM.mdf;Integrated Security=True;Connect Timeout=30");
        public Form4()
        {
            InitializeComponent();
        }
        //submit button
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Time4_Table VALUES('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Data Sucessfully");
            con.Close();
        }
        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = comboBox1.Text =  "";
            MessageBox.Show("Clear Data Successfully");
        }
        //Next button
        private void button14_Click(object sender, EventArgs e)
        {
            Form5 f4 = new Form5();
            f4.Show();
        }
    }
}
