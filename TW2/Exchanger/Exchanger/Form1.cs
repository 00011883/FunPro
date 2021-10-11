using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btn_convert_Click(object sender, EventArgs e)
		{
            decimal amount = num_amount.Value;
            decimal rate = num_rate.Value;

            decimal result = amount / rate;

            MessageBox.Show("You will get: " + Math.Round(result, 2));
		}
	}
}
