namespace Bundick2018
{
    partial class CustomerSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bundickDataSet = new Bundick2018.bundickDataSet();
            this.job_sheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_sheetTableAdapter = new Bundick2018.bundickDataSetTableAdapters.job_sheetTableAdapter();
            this.tableAdapterManager = new Bundick2018.bundickDataSetTableAdapters.TableAdapterManager();
            this.job_sheetDataGridView = new System.Windows.Forms.DataGridView();
            this.nameSearchTxtBox = new System.Windows.Forms.TextBox();
            this.addressSearchTxtBox = new System.Windows.Forms.TextBox();
            this.taxIdTxtBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobLocationSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bundickDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_sheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_sheetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bundickDataSet
            // 
            this.bundickDataSet.DataSetName = "bundickDataSet";
            this.bundickDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // job_sheetBindingSource
            // 
            this.job_sheetBindingSource.DataMember = "job sheet";
            this.job_sheetBindingSource.DataSource = this.bundickDataSet;
            // 
            // job_sheetTableAdapter
            // 
            this.job_sheetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.job_sheetTableAdapter = this.job_sheetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bundick2018.bundickDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // job_sheetDataGridView
            // 
            this.job_sheetDataGridView.AutoGenerateColumns = false;
            this.job_sheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.job_sheetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.job_sheetDataGridView.DataSource = this.job_sheetBindingSource;
            this.job_sheetDataGridView.Location = new System.Drawing.Point(0, 83);
            this.job_sheetDataGridView.Name = "job_sheetDataGridView";
            this.job_sheetDataGridView.Size = new System.Drawing.Size(945, 227);
            this.job_sheetDataGridView.TabIndex = 1;
            this.job_sheetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.job_sheetDataGridView_CellContentClick);
            // 
            // nameSearchTxtBox
            // 
            this.nameSearchTxtBox.Location = new System.Drawing.Point(82, 26);
            this.nameSearchTxtBox.Name = "nameSearchTxtBox";
            this.nameSearchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameSearchTxtBox.TabIndex = 2;
            this.nameSearchTxtBox.TextChanged += new System.EventHandler(this.nameSearchTxtBox_TextChanged);
            // 
            // addressSearchTxtBox
            // 
            this.addressSearchTxtBox.Location = new System.Drawing.Point(82, 53);
            this.addressSearchTxtBox.Name = "addressSearchTxtBox";
            this.addressSearchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.addressSearchTxtBox.TabIndex = 3;
            this.addressSearchTxtBox.TextChanged += new System.EventHandler(this.addressSearchTxtBox_TextChanged);
            // 
            // taxIdTxtBox
            // 
            this.taxIdTxtBox.Location = new System.Drawing.Point(282, 53);
            this.taxIdTxtBox.Name = "taxIdTxtBox";
            this.taxIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.taxIdTxtBox.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn2.HeaderText = "address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn16.HeaderText = "date";
            this.dataGridViewTextBoxColumn16.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "job location";
            this.dataGridViewTextBoxColumn3.HeaderText = "job location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "taxid";
            this.dataGridViewTextBoxColumn9.HeaderText = "taxid";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn4.HeaderText = "city";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "zip";
            this.dataGridViewTextBoxColumn6.HeaderText = "zip";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "altphone";
            this.dataGridViewTextBoxColumn8.HeaderText = "altphone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // jobLocationSearchBox
            // 
            this.jobLocationSearchBox.Location = new System.Drawing.Point(282, 26);
            this.jobLocationSearchBox.Name = "jobLocationSearchBox";
            this.jobLocationSearchBox.Size = new System.Drawing.Size(100, 20);
            this.jobLocationSearchBox.TabIndex = 5;
            this.jobLocationSearchBox.TextChanged += new System.EventHandler(this.jobLocationSearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Job Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tax ID:";
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobLocationSearchBox);
            this.Controls.Add(this.taxIdTxtBox);
            this.Controls.Add(this.addressSearchTxtBox);
            this.Controls.Add(this.nameSearchTxtBox);
            this.Controls.Add(this.job_sheetDataGridView);
            this.Name = "CustomerSearch";
            this.Text = "CustomerSearch";
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bundickDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_sheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_sheetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bundickDataSet bundickDataSet;
        private System.Windows.Forms.BindingSource job_sheetBindingSource;
        private bundickDataSetTableAdapters.job_sheetTableAdapter job_sheetTableAdapter;
        private bundickDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView job_sheetDataGridView;
        private System.Windows.Forms.TextBox nameSearchTxtBox;
        private System.Windows.Forms.TextBox addressSearchTxtBox;
        private System.Windows.Forms.TextBox taxIdTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox jobLocationSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}