using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            decimal dep = num_dep.Value;
            decimal year = num_year.Value;
            decimal percent = num_percent.Value;

            decimal result = 0;
            decimal interest = 0;

            for (int i = 1; i <= year; i++)
            {
                interest = 1 + (percent / 100);
                result = dep * (1 + percent / 100);
                dep = result;
            }

            lbl_result.Text = "Your bank account have: " + result + " $";
        }
    }
}
