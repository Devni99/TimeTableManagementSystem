using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Mangement_Sytem
{
    public partial class TimeTable_Location : Form
    {
        public TimeTable_Location()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            TimeTable_Lec tm = new TimeTable_Lec();
            tm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            TimeTable_Lec tm = new TimeTable_Lec();
            tm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeTable_Student tm = new TimeTable_Student();
            tm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeTable_Location tm = new TimeTable_Location();
            tm.Show();
            this.Hide();
        }
    }
}
