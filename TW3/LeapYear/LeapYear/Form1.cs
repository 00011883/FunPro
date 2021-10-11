using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (num_year.Value < 1582)
            {
                MessageBox.Show("Leap year was introduced only 15 October 1582.");
            }
            else if ((num_year.Value % 400 == 0) || (num_year.Value % 4 == 0))
            {
                MessageBox.Show("This is a leap year!");
            } else
            {
                MessageBox.Show("This is not a leap year!");
            }
        }
    }
}
