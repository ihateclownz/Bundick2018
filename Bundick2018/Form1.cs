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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void job_sheetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.job_sheetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bundickDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bundickDataSet.job_sheet' table. You can move, or remove it, as needed.
            this.job_sheetTableAdapter.Fill(this.bundickDataSet.job_sheet);

        }
    }
}
