using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bundick2018
{
    public partial class CustomerSearch : Form
    {
        public int index, searchfields = 0;
        public Main LogicalParent { get; set; }
        bundickDataSet ds = new bundickDataSet();

        Main CalledFrom;

        public CustomerSearch()
        {
            InitializeComponent();

        }

        public CustomerSearch(Main viaParameter) : this()
        {
            CalledFrom = viaParameter;
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bundickDataSet.job_sheet' table. You can move, or remove it, as needed.
            this.job_sheetTableAdapter.Fill(this.bundickDataSet.job_sheet);
            this.job_sheetDataGridView.ClearSelection();
            //this.dataGridView1.ClearSelection();
            AutoComplete();


        }

        private void job_sheetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.job_sheetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bundickDataSet);

        }

        private void job_sheetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CalledFrom.ChangeFormPosition(this.job_sheetDataGridView.CurrentCell.RowIndex);
            this.Visible = false;
        }

        private void nameSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            addressSearchTxtBox.Text = "";
            taxIdTxtBox.Text = "";
            this.job_sheetTableAdapter.FillByName(bundickDataSet.job_sheet, nameSearchTxtBox.Text + "%");

            this.job_sheetDataGridView.ClearSelection();
        }

        private void AutoComplete()
        {
            Console.WriteLine("Autocomplete Method");
            DataSet ds = bundickDataSet;

            AutoCompleteStringCollection nameAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection addressAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection joblocationAutoComplete = new AutoCompleteStringCollection();

            int databaseRowCount = ds.Tables[0].Rows.Count;
            Console.WriteLine(databaseRowCount);

            this.nameSearchTxtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.nameSearchTxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.addressSearchTxtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.addressSearchTxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            

            ///Name AutoComplete
            for (int i = 0; i < databaseRowCount; i++)
            {
                nameAutoComplete.Add(ds.Tables[0].Rows[i]["name"].ToString());
                Console.WriteLine("Name: " + ds.Tables[0].Rows[i]["name"].ToString());
            }
            ///Address AutoComplete
            for (int i = 0; i < databaseRowCount; i++)
            {
                addressAutoComplete.Add(ds.Tables[0].Rows[i]["address"].ToString());
            }
            for(int i = 0; i < databaseRowCount; i++)
            {

            }


            // this.nameToolStripTextBox.AutoCompleteCustomSource = data;
            this.nameSearchTxtBox.AutoCompleteCustomSource = nameAutoComplete;
        }

        private void jobLocationSearchBox_TextChanged(object sender, EventArgs e)
        {
            nameSearchTxtBox.Text = "";
            taxIdTxtBox.Text = "";
            addressSearchTxtBox.Text = "";

            this.job_sheetTableAdapter.FillByJobLocation(bundickDataSet.job_sheet, jobLocationSearchBox.Text + "%");
            this.job_sheetDataGridView.ClearSelection();
        }

        private void addressSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            nameSearchTxtBox.Text = "";
            taxIdTxtBox.Text = "";
            this.job_sheetTableAdapter.FillByAddress(bundickDataSet.job_sheet, addressSearchTxtBox.Text + "%");

            this.job_sheetDataGridView.ClearSelection();
        }
        
    }
}
