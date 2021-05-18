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
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\Itpm\Itpm\ITPM.mdf;Integrated Security=True;Connect Timeout=30");
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTPMDataSet.Time3_Table' table. You can move, or remove it, as needed.
            this.time3_TableTableAdapter.Fill(this.iTPMDataSet.Time3_Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Registerd_Lectures";
            chart1.Series[0].YValueMembers = "Registerd_Lectures";

            chart1.Series[0].XValueMember = "Registerd_Students";
            chart1.Series[0].YValueMembers = "Registerd_Students";

            chart1.Series[0].XValueMember = "Registerd_Subjects";
            chart1.Series[0].YValueMembers = "Registerd_Subjects";

            chart1.Series[0].XValueMember = "Registerd_Rooms";
            chart1.Series[0].YValueMembers = "Registerd_Rooms";

            chart1.DataSource = iTPMDataSet.Time3_Table;
            chart1.DataBind();
        }
        //next button
        private void button14_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
        }
    }
}
