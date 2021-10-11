using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string input = tbx_input.Text;
            decimal myNum = 0;
            if (decimal.TryParse(input, out myNum))
            {
                decimal d = myNum / 2;

                if (myNum % myNum == 0)
                {
                    for (int i = 1; i <= d; i++)
                    {
                        if (myNum % i == 0)
                        {
                            MessageBox.Show("Not a prime number!");
                            break;
                        } else
                        {
                            MessageBox.Show("A prime number!");
                            break;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Enter another value, type should be number");
            }
        }
    }
}
