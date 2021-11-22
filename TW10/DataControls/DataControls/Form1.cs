using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbDataSet.tbCountry' table. You can move, or remove it, as needed.
                this.tbCountryTableAdapter.Fill(this.dbDataSet.tbCountry);
                // TODO: This line of code loads data into the 'dbDataSet.tbTeacher' table. You can move, or remove it, as needed.
                this.tbTeacherTableAdapter.Fill(this.dbDataSet.tbTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveFirst();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MovePrevious();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveLast();
        }

        private void EnableDisableButtons()
        {
            //enable and disable navigation buttons
            if (tbTeacherBindingSource.Position == 0)
            {
                btn_first.Enabled = false;
                btn_previous.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_previous.Enabled = true;
            }

            if (tbTeacherBindingSource.Position == tbTeacherBindingSource.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }

        private void tbTeacherBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tbTeacherBindingSource.Count > 0)
            {
                if (MessageBox.Show("Sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    tbTeacherBindingSource.RemoveCurrent();
                }
            }
            else
            {
                MessageBox.Show("Nothing to delete");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (this.Validate())
            {
                this.tbTeacherBindingSource.EndEdit();
                try
                {
                    this.tableAdapterManager.UpdateAll(this.dbDataSet);
                    MessageBox.Show("Saved");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validate())
            {
                this.tbTeacherBindingSource.EndEdit();

                if (dbDataSet.HasChanges())
                {
                    if (MessageBox.Show("Would you like save changes", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            }
            else
                e.Cancel = true;
        }
    }
}
