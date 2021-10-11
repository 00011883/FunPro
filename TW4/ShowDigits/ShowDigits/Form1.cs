using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDigits
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
            string result = "";
            
            char[] array = input.ToCharArray();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i].ToString();
            }

            MessageBox.Show(result);
        }
    }
}
