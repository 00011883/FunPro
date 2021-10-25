using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal depositNum = Convert.ToDecimal(tbx_deposit.Text);
            decimal interestNum = Convert.ToDecimal(tbx_interest.Text);
            decimal resultNum = ((depositNum * interestNum) / 100) + depositNum;

            string dateTime = DateTime.Now.ToString();
            string strDeposit = string.Format("{0:N2}", depositNum);
            string strInterest = string.Format("{0:N1}%", interestNum);
            string strResult = string.Format("{0:N2}", resultNum);

            MessageBox.Show("The Date and Time is " + dateTime + "\n" + "Your Deposit is: " + strDeposit + "\n" + "Your Interest is: " + strInterest + "\n" + "Your Result is: " + strResult);
        }
    }
}
