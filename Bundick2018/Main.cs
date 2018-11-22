using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bundick2018
{
    public partial class Main : Form
    {
//      public CustomerSearch LogicalParent { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void job_sheetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.job_sheetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bundickDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bundickDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.bundickDataSet.employees);
            this.employeesTableAdapter.Fill(this.bundickDataSet.employees);
            this.job_sheetTableAdapter.Fill(this.bundickDataSet.job_sheet);

            // this.job_sheetBindingSource.MoveLast();
            NewFormDefaults();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" || job_locationTextBox.Text != "")
            {
                Save();
            }
            else
            {
                this.job_sheetBindingSource.RemoveCurrent();
            }
            //else
            //{
            //    DialogResult dialogResult = MessageBox.Show("You have unsaved changes, Would you like to save?", "Unsaved", MessageBoxButtons.YesNoCancel);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        Save();
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        this.job_sheetBindingSource.RemoveCurrent();

            //    }
            //    else
            //    {
            //        return;
            //    }

            //}
            CustomerSearch customerSearch = new CustomerSearch(this);
            customerSearch.Show();
        }
        public void ChangeFormPosition(int pos)
        {
            this.job_sheetBindingSource.Position = pos;
        }
#region top bar
        private void FirstStripLabel_Click(object sender, EventArgs e)
        {
            Save();
            this.job_sheetBindingSource.MoveFirst();
            //this.job_sheetBindingSource.
        }

        private void PreviousStripLabel_Click(object sender, EventArgs e)
        {
            Save();
            this.job_sheetBindingSource.MovePrevious();
        }

        private void NextStripLabel_Click(object sender, EventArgs e)
        {
            Save();
            this.job_sheetBindingSource.MoveNext();
        }

        private void LastStripLabel_Click(object sender, EventArgs e)
        {
            Save();
            this.job_sheetBindingSource.MoveLast();
        }

        private void SaveStripLabel_Click(object sender, EventArgs e)
        {
            
            if (nameTextBox.Text == "" || job_locationTextBox.Text == "" || cityTextBox.Text == "")
            {   
                
                MessageBox.Show("Form not saved, please check that all required data is accurate.", "Not Saved!");
            }
            else
            {
                Save();
            }

        }


        private void DeleteStripLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this?", "Deletion", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.job_sheetBindingSource.RemoveCurrent();
                Save();
            }
        }
#endregion
        private void Save()
        {
            if(addressTextBox.Text == "" && job_locationTextBox.Text != "")
            {
                addressTextBox.Text = job_locationTextBox.Text;
            }
            if (nameTextBox.Text == "" || job_locationTextBox.Text == "" || cityTextBox.Text == "")
            {

                MessageBox.Show("Form not saved, please check that all required data is accurate.", "Not Saved!");
            }
            else
            {
                this.Validate();
                this.job_sheetBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bundickDataSet);
                this.nameReqAstrLabel.Text = "";
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFormDefaults();
        }

        private void NewFormDefaults()
        {
            job_sheetBindingSource.AddNew();
            this.nameReqAstrLabel.Text = " ";
            this.watertankboolCheckBox.Checked = false;
            this.waterpumpboolCheckBox.Checked = false;
            this.waterlineboolCheckBox.Checked = false;
            this.presswitchboolCheckBox.Checked = false;
            this.hydrantboolCheckBox.Checked = false;
            this.spigotboolCheckBox.Checked = false;
            this.pulledpumpboolCheckBox.Checked = false;
            this.pulledpackerboolCheckBox.Checked = false;
            this.primepumpboolCheckBox.Checked = false;
            this.pres_guageboolCheckBox.Checked = false;
            this.pitlessadapterboolCheckBox.Checked = false;
            this.nippleboolCheckBox.Checked = false;
            this.filterboolCheckBox.Checked = false;
            this.cyclestopboolCheckBox.Checked = false;
            this.chlorinatedboolCheckBox.Checked = false;
            this.checkvalveboolCheckBox.Checked = false;
            this.capboolCheckBox.Checked = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}
