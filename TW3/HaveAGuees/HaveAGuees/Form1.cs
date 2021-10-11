using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaveAGuees
{
    public partial class Form1 : Form
    {
        int cpuNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (num_num.Value < cpuNumber)
            {
                MessageBox.Show("Your number is lower than mine!");
            } else if (num_num.Value > cpuNumber)
            {
                MessageBox.Show("Your number is bigger than mine!");
            } else if (num_num.Value == cpuNumber)
            {
                MessageBox.Show("Your number is the same as mine! Hooray!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random randomNum = new Random();
            cpuNumber = randomNum.Next(0, 10);
        }
    }
}
