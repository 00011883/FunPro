using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountSchema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToInt32(tbx_amount.Text);
            Boolean checkbox = chx_discount.Checked;
            double discount;
            string result;

            if (checkbox == false)
            {
                if (10000 <= amount && amount <= 20000)
                {
                    discount = 0.01 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else if (20000 < amount && amount <= 35000)
                {
                    discount = 0.02 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else if (35000 < amount && amount <= 60000)
                {
                    discount = 0.03 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else if (amount > 60000)
                {
                    discount = 0.04 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Buddy, wtf u r doin");
                };
            }

            if (checkbox == true)
            {
                if (5000 <= amount && amount <= 15000)
                {
                    discount = 0.015 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else if (15000 < amount && amount <= 30000)
                {
                    discount = 0.025 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else if (30000 < amount && amount <= 55000)
                {
                    discount = 0.035 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else if (amount > 55000)
                {
                    discount = 0.045 * amount;
                    result = Convert.ToString(amount - discount);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Buddy, wtf u r doin");
                };

            }
        }
    }   
}
