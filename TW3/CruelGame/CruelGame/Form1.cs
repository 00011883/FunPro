using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruelGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rdb_21.Checked == true)
            {
                MessageBox.Show("Sorry, you are too young for the Cruel Game");
            } else if (rdb_21to35.Checked == true)
            {
                MessageBox.Show("Let's rock");
            } else
            {
                MessageBox.Show("You are too old, grandpa");
            }
            
        }
    }
}
