using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSorting
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
            string[] strArr = input.Split(',');

            MessageBox.Show(String.Join(",", InitiateSort(strArr)));


        }

        private int[] InitiateSort(string[] strArr)
        {
            int[] A = new int[strArr.Length];

            try
            {
                A = Array.ConvertAll(strArr, int.Parse); ;
            }
            catch (Exception)
            {
                MessageBox.Show("It looks like you did not type a number after the coma");
                return null;
            }

            for (int i = strArr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int tmp = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = tmp;
                    }
                }
            }

            return A;
        }
    }
}
