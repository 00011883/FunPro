using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelayRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string time1 = tbx_time1.Text;
            string time2 = tbx_time2.Text;

            TimeSpan t1 = TimeSpan.Parse(time1);
            TimeSpan t2 = TimeSpan.Parse(time2);

            TimeSpan total = t1 + t2;

            string find = ":00";
            string replace = "";

            string t1_con = ReplaceLastOccurrence(t1.ToString(), find, replace);
            string t2_con = ReplaceLastOccurrence(t2.ToString(), find, replace);
            string total_s = ReplaceLastOccurrence(total.ToString(), find, replace);

            lbl_time1.Text = "Time 1: " + t1_con;
            lbl_time2.Text = "Time 2: " + t2_con;
            lbl_total.Text = "Total time is - " + total_s;



        }
        public static string ReplaceLastOccurrence(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }
    }
}
