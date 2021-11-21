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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            double kurs = 1.3170;
            string input = tbx_input.Text;
                
            if (int.TryParse(input, out int euro))
            {
                if (euro > 2)
                {
                    lbl_euro.Text = "Euro: " + input.ToString();

                    double rate = 0.0125;
                    lbl_rate.Text = "Exchange rate: " + (rate * 100) + "%";

                    double exchangedUSD = Math.Round(kurs * euro, 2);
                    lbl_usd.Text = "Exchanged USD: " + exchangedUSD.ToString();

                    double fee = Math.Round(exchangedUSD * rate, 2);
                    lbl_fee.Text = "Exchanged fee: " + fee;

                    double payable = exchangedUSD - fee;
                    lbl_payable.Text = "Payable USD: " + payable.ToString();
                } else
                {
                    MessageBox.Show("Enter a valid amount of Euro to Exchange to USD \nExample: 100");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid amount of Euro to Exchange to USD \nExample: 100");
            }
        }
    }
}
