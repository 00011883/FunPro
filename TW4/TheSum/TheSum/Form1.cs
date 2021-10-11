using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_odd_Click(object sender, EventArgs e)
        {
            int sumOdd = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                if (i % 2 == 1)
                {
                    sumOdd += i;
                }
            }

            MessageBox.Show("Your sum of all odd numbers between 1 and 1,000,000 is " + sumOdd);
        }

        private void btn_even_Click(object sender, EventArgs e)
        {
            int sumEven = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
            }

            MessageBox.Show("Your sum of all even numbers between 1 and 1,000,000 is " + sumEven);
        }
    }
}
