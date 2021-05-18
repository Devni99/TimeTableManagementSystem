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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ITPMnew.mdf;Integrated Security=True;Connect Timeout=30");
        public Form5()
        {
            InitializeComponent();
        }
        //Add data
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        //Delete data
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTPMDataSet2.Time5_Table' table. You can move, or remove it, as needed.
            this.time5_TableTableAdapter.Fill(this.iTPMDataSet2.Time5_Table);
            // TODO: This line of code loads data into the 'iTPMDataSet1.Time4_Table' table. You can move, or remove it, as needed.
            this.time4_TableTableAdapter.Fill(this.iTPMDataSet1.Time4_Table);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form6 f5 = new Form6();
            f5.Show();
        }
    }
}
