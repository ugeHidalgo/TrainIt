namespace TrainIt.Search_Forms
{
    partial class FSBioRegsTypes
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
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.bioRegTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioRegTypesTableAdapter = new TrainIt.TrainITDataSetTableAdapters.BioRegTypesTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.dgvBioRegType = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioRegTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBioRegType)).BeginInit();
            this.SuspendLayout();
            // 
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bioRegTypesBindingSource
            // 
            this.bioRegTypesBindingSource.DataMember = "BioRegTypes";
            this.bioRegTypesBindingSource.DataSource = this.trainITDataSet;
            // 
            // bioRegTypesTableAdapter
            // 
            this.bioRegTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BioRegTypesTableAdapter = this.bioRegTypesTableAdapter;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = null;
            this.tableAdapterManager.SportTypesTableAdapter = null;
            this.tableAdapterManager.TempBioRegTypesTableAdapter = null;
            this.tableAdapterManager.TempMaterialTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // dgvBioRegType
            // 
            this.dgvBioRegType.AllowUserToAddRows = false;
            this.dgvBioRegType.AllowUserToDeleteRows = false;
            this.dgvBioRegType.AllowUserToOrderColumns = true;
            this.dgvBioRegType.AutoGenerateColumns = false;
            this.dgvBioRegType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBioRegType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvBioRegType.DataSource = this.bioRegTypesBindingSource;
            this.dgvBioRegType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBioRegType.Location = new System.Drawing.Point(0, 0);
            this.dgvBioRegType.Name = "dgvBioRegType";
            this.dgvBioRegType.ReadOnly = true;
            this.dgvBioRegType.RowHeadersVisible = false;
            this.dgvBioRegType.Size = new System.Drawing.Size(534, 384);
            this.dgvBioRegType.TabIndex = 1;
            this.dgvBioRegType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bioRegTypesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BioRegTypeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BioRegName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // FSBioRegsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 384);
            this.Controls.Add(this.dgvBioRegType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FSBioRegsTypes";
            this.Text = "Registros Personales";
            this.Load += new System.EventHandler(this.FSBioRegsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioRegTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBioRegType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.BindingSource bioRegTypesBindingSource;
        private TrainITDataSetTableAdapters.BioRegTypesTableAdapter bioRegTypesTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvBioRegType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}