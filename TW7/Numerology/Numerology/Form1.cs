using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerology
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
            string[] inputList = input.Split('/');
            string birthday = String.Join("", inputList);

            int sum = 0;
            int number = 0;

            for (int i = 0; i < birthday.Length; i++)
            {
                if (int.TryParse(birthday[i].ToString(), out number))
                {
                    sum += number;
                }
            }

            MessageBox.Show(sum.ToString());
        }
    }
}