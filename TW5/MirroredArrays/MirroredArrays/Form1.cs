using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirroredArrays
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
            string[] strNewArray = new string[strArray.Length];

            int j = 0;

            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                strNewArray[j] = strArray[i];
                j++;
                
            }

            MessageBox.Show(String.Join(",", strNewArray));


        }
    }
}
