using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveLast();
        }

        private void DisableEnableButtons()
        {
            if (tbTeacherBindingSource.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }

            if (tbTeacherBindingSource.Position
                == tbTeacherBindingSource.Count - 1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }

        private void tbTeacherBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DisableEnableButtons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbTeacherBindingSource.Count > 0)
            {
                if (MessageBox
                    .Show("Sure?", "Delete", 
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tbTeacherBindingSource.RemoveCurrent();

                }
            }
            else
                MessageBox.Show("Nothing to delete");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void tbTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                    if (MessageBox
                        .Show("Save?", "Exit", MessageBoxButtons.YesNo) 
                            == DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            }
            else
                e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var selectedCounrtry = ((DataRowView)cbxNewCountry.SelectedItem).Row;

            dbDataSet.tbTeacher.AddtbTeacherRow(
                tbxNewFirstName.Text,
                tbxNewLastName.Text,
                dtpNewDob.Value,
                tbxNewPhone.Text,
                (int)nudNewGrade.Value,
                chbNewIsActive.Checked,
                (dbDataSet.tbCountryRow)selectedCounrtry);
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tbTeacherBindingSource.Filter = $"lastName LIKE '{tbxFilter.Text}%'";
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("First name cannot be empty");
                e.Cancel = true;
            }
        }
    }
}
