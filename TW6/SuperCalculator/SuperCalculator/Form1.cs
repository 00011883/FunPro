using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string inputOne = tbx_one.Text;
            string inputTwo = tbx_two.Text;

            int a = 0;
            int b = 0; 
            int result = 0;
            

            string[] array = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            for (int i = 0; i < array.Length; i++)
            {
                if (inputTwo == array[i])
                {
                    b = i;
                }

                if (inputOne == array[i])
                {
                    a = i;
                }

                result = a + b;
            }
            lbl_result.Text = result.ToString();
        }
    }
}
