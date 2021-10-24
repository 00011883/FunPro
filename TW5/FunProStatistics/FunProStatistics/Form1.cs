using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunProStatistics
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
            string[] strArray = input.Split(',');

            int noOfMarksLess30 = 0;
            int noOfMarks30To40 = 0;
            int noOfMarks40To100 = 0;

            for (int i = 0; i < strArray.Length; i++)
            {
                int arrayNum = Convert.ToInt32(strArray[i]);

                if (arrayNum < 30)
                {
                    noOfMarksLess30++;
                }
                else if (arrayNum >= 30 && arrayNum < 40)
                {
                    noOfMarks30To40++;
                }
                else if (arrayNum >= 40 && arrayNum < 100)
                {
                    noOfMarks40To100++;
                } else
                {
                    MessageBox.Show("Enter numbers from 0 to 100");
                }
            }

            MessageBox.Show("Result: " + noOfMarksLess30 + " " + noOfMarks30To40 + " " + noOfMarks40To100);
        }
    }
}
