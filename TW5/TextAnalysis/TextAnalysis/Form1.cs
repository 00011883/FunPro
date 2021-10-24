using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalysis
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
            int wordsCount = 0;
            int vowelCount = 0;
            int consonantCount = 0;

            wordsCount = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

            char[] consonants = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };

            input = input.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowelCount++;
                }
                else if (consonants.Contains(input[i]))
                {
                    consonantCount++;
                }
            }

            string answer = "Number of vowels: " + vowelCount.ToString()
            + "\n Number of Consonants: " + consonantCount.ToString()
            + "\n Number of words: " + wordsCount.ToString();

            MessageBox.Show(answer);
        }
    }
}
