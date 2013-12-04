namespace TrainIt
{
    partial class FBioRegs
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
            System.Windows.Forms.Label bioRegIDLabel;
            System.Windows.Forms.Label bioRegTypeIDLabel;
            System.Windows.Forms.Label bioRegDateLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label memoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBioRegs));
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnFindBioRegType = new System.Windows.Forms.Button();
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.bioRegsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioRegsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.BioRegsTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.dgvBioRegs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBioRegID = new System.Windows.Forms.TextBox();
            this.txtBioRegTypeID = new System.Windows.Forms.TextBox();
            this.dtpBioRegDate = new System.Windows.Forms.DateTimePicker();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.bioRegsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.txtBioRegName = new System.Windows.Forms.TextBox();
            bioRegIDLabel = new System.Windows.Forms.Label();
            bioRegTypeIDLabel = new System.Windows.Forms.Label();
            bioRegDateLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            this.statusS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioRegsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBioRegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioRegsBindingNavigator)).BeginInit();
            this.bioRegsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bioRegIDLabel
            // 
            bioRegIDLabel.AutoSize = true;
            bioRegIDLabel.Location = new System.Drawing.Point(12, 43);
            bioRegIDLabel.Name = "bioRegIDLabel";
            bioRegIDLabel.Size = new System.Drawing.Size(62, 13);
            bioRegIDLabel.TabIndex = 22;
            bioRegIDLabel.Text = "Bio Reg ID:";
            // 
            // bioRegTypeIDLabel
            // 
            bioRegTypeIDLabel.AutoSize = true;
            bioRegTypeIDLabel.Location = new System.Drawing.Point(12, 69);
            bioRegTypeIDLabel.Name = "bioRegTypeIDLabel";
            bioRegTypeIDLabel.Size = new System.Drawing.Size(89, 13);
            bioRegTypeIDLabel.TabIndex = 24;
            bioRegTypeIDLabel.Text = "Bio Reg Type ID:";
            // 
            // bioRegDateLabel
            // 
            bioRegDateLabel.AutoSize = true;
            bioRegDateLabel.Location = new System.Drawing.Point(12, 96);
            bioRegDateLabel.Name = "bioRegDateLabel";
            bioRegDateLabel.Size = new System.Drawing.Size(74, 13);
            bioRegDateLabel.TabIndex = 26;
            bioRegDateLabel.Text = "Bio Reg Date:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(12, 121);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 28;
            valueLabel.Text = "Value:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(12, 147);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 30;
            memoLabel.Text = "Memo:";
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 608);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(523, 22);
            this.statusS1.TabIndex = 7;
            this.statusS1.Text = "statusStrip1";
            // 
            // tslUser
            // 
            this.tslUser.Name = "tslUser";
            this.tslUser.Size = new System.Drawing.Size(53, 17);
            this.tslUser.Text = "Usuario :";
            // 
            // tslConnString
            // 
            this.tslConnString.Name = "tslConnString";
            this.tslConnString.Size = new System.Drawing.Size(79, 17);
            this.tslConnString.Text = "Conn String : ";
            // 
            // btnFindBioRegType
            // 
            this.btnFindBioRegType.Image = ((System.Drawing.Image)(resources.GetObject("btnFindBioRegType.Image")));
            this.btnFindBioRegType.Location = new System.Drawing.Point(155, 66);
            this.btnFindBioRegType.Name = "btnFindBioRegType";
            this.btnFindBioRegType.Size = new System.Drawing.Size(24, 24);
            this.btnFindBioRegType.TabIndex = 21;
            this.btnFindBioRegType.UseVisualStyleBackColor = true;
            this.btnFindBioRegType.Click += new System.EventHandler(this.btnFindSportType_Click);
            // 
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bioRegsBindingSource
            // 
            this.bioRegsBindingSource.DataMember = "BioRegs";
            this.bioRegsBindingSource.DataSource = this.trainITDataSet;
            // 
            // bioRegsTableAdapter
            // 
            this.bioRegsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BioRegsTableAdapter = this.bioRegsTableAdapter;
            this.tableAdapterManager.BioRegTypesTableAdapter = null;
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
            // dgvBioRegs
            // 
            this.dgvBioRegs.AutoGenerateColumns = false;
            this.dgvBioRegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBioRegs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvBioRegs.DataSource = this.bioRegsBindingSource;
            this.dgvBioRegs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBioRegs.Location = new System.Drawing.Point(0, 248);
            this.dgvBioRegs.Name = "dgvBioRegs";
            this.dgvBioRegs.ReadOnly = true;
            this.dgvBioRegs.RowHeadersVisible = false;
            this.dgvBioRegs.Size = new System.Drawing.Size(523, 360);
            this.dgvBioRegs.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BioRegID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BioRegID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BioRegTypeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BioRegTypeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BioRegDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "BioRegDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn6.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // txtBioRegID
            // 
            this.txtBioRegID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bioRegsBindingSource, "BioRegID", true));
            this.txtBioRegID.Location = new System.Drawing.Point(107, 40);
            this.txtBioRegID.Name = "txtBioRegID";
            this.txtBioRegID.Size = new System.Drawing.Size(42, 20);
            this.txtBioRegID.TabIndex = 23;
            // 
            // txtBioRegTypeID
            // 
            this.txtBioRegTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bioRegsBindingSource, "BioRegTypeID", true));
            this.txtBioRegTypeID.Location = new System.Drawing.Point(107, 66);
            this.txtBioRegTypeID.Name = "txtBioRegTypeID";
            this.txtBioRegTypeID.Size = new System.Drawing.Size(42, 20);
            this.txtBioRegTypeID.TabIndex = 25;
            // 
            // dtpBioRegDate
            // 
            this.dtpBioRegDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bioRegsBindingSource, "BioRegDate", true));
            this.dtpBioRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBioRegDate.Location = new System.Drawing.Point(107, 92);
            this.dtpBioRegDate.Name = "dtpBioRegDate";
            this.dtpBioRegDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBioRegDate.TabIndex = 27;
            // 
            // txtValue
            // 
            this.txtValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bioRegsBindingSource, "Value", true));
            this.txtValue.Location = new System.Drawing.Point(107, 118);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(42, 20);
            this.txtValue.TabIndex = 29;
            // 
            // txtMemo
            // 
            this.txtMemo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bioRegsBindingSource, "Memo", true));
            this.txtMemo.Location = new System.Drawing.Point(107, 144);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(200, 20);
            this.txtMemo.TabIndex = 31;
            // 
            // txtUserID
            // 
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bioRegsBindingSource, "UserID", true));
            this.txtUserID.Location = new System.Drawing.Point(155, 40);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(30, 20);
            this.txtUserID.TabIndex = 33;
            // 
            // bioRegsBindingNavigator
            // 
            this.bioRegsBindingNavigator.AddNewItem = this.tsBtnNew;
            this.bioRegsBindingNavigator.BindingSource = this.bioRegsBindingSource;
            this.bioRegsBindingNavigator.CountItem = null;
            this.bioRegsBindingNavigator.DeleteItem = null;
            this.bioRegsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFirst,
            this.tsBtnPrevious,
            this.tsBtnNext,
            this.tsBtnLast,
            this.bindingNavigatorSeparator2,
            this.tsBtnNew,
            this.tsBtnEdit,
            this.tsBtnCancel,
            this.tsBtnSave,
            this.tsBtnDel});
            this.bioRegsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bioRegsBindingNavigator.MoveFirstItem = this.tsBtnFirst;
            this.bioRegsBindingNavigator.MoveLastItem = this.tsBtnLast;
            this.bioRegsBindingNavigator.MoveNextItem = this.tsBtnNext;
            this.bioRegsBindingNavigator.MovePreviousItem = this.tsBtnPrevious;
            this.bioRegsBindingNavigator.Name = "bioRegsBindingNavigator";
            this.bioRegsBindingNavigator.PositionItem = null;
            this.bioRegsBindingNavigator.Size = new System.Drawing.Size(523, 25);
            this.bioRegsBindingNavigator.TabIndex = 34;
            this.bioRegsBindingNavigator.Text = "bindingNavigator1";
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNew.Image")));
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.RightToLeftAutoMirrorImage = true;
            this.tsBtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNew.Text = "Nuevo registro";
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
            // 
            // tsBtnFirst
            // 
            this.tsBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFirst.Image")));
            this.tsBtnFirst.Name = "tsBtnFirst";
            this.tsBtnFirst.RightToLeftAutoMirrorImage = true;
            this.tsBtnFirst.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFirst.Text = "Primer Registro";
            // 
            // tsBtnPrevious
            // 
            this.tsBtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrevious.Image")));
            this.tsBtnPrevious.Name = "tsBtnPrevious";
            this.tsBtnPrevious.RightToLeftAutoMirrorImage = true;
            this.tsBtnPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrevious.Text = "Registro Anterior";
            // 
            // tsBtnNext
            // 
            this.tsBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNext.Image")));
            this.tsBtnNext.Name = "tsBtnNext";
            this.tsBtnNext.RightToLeftAutoMirrorImage = true;
            this.tsBtnNext.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNext.Text = "Siguiente Registro";
            // 
            // tsBtnLast
            // 
            this.tsBtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLast.Image")));
            this.tsBtnLast.Name = "tsBtnLast";
            this.tsBtnLast.RightToLeftAutoMirrorImage = true;
            this.tsBtnLast.Size = new System.Drawing.Size(23, 22);
            this.tsBtnLast.Text = "Último Registro";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnEdit
            // 
            this.tsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEdit.Image")));
            this.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEdit.Name = "tsBtnEdit";
            this.tsBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tsBtnEdit.Text = "Editar registro";
            this.tsBtnEdit.Click += new System.EventHandler(this.tsBtnEdit_Click);
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancel.Image")));
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCancel.Text = "Cancelar Edición";
            this.tsBtnCancel.Click += new System.EventHandler(this.tsBtnCancel_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "Grabar Registro";
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // tsBtnDel
            // 
            this.tsBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDel.Image")));
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.RightToLeftAutoMirrorImage = true;
            this.tsBtnDel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDel.Text = "Borrar registro";
            // 
            // txtBioRegName
            // 
            this.txtBioRegName.Location = new System.Drawing.Point(186, 66);
            this.txtBioRegName.Name = "txtBioRegName";
            this.txtBioRegName.Size = new System.Drawing.Size(100, 20);
            this.txtBioRegName.TabIndex = 35;
            // 
            // FBioRegs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 630);
            this.Controls.Add(this.txtBioRegName);
            this.Controls.Add(this.bioRegsBindingNavigator);
            this.Controls.Add(bioRegIDLabel);
            this.Controls.Add(this.txtBioRegID);
            this.Controls.Add(bioRegTypeIDLabel);
            this.Controls.Add(this.txtBioRegTypeID);
            this.Controls.Add(bioRegDateLabel);
            this.Controls.Add(this.dtpBioRegDate);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.dgvBioRegs);
            this.Controls.Add(this.btnFindBioRegType);
            this.Controls.Add(this.statusS1);
            this.Name = "FBioRegs";
            this.Text = "Registro Datos";
            this.Load += new System.EventHandler(this.FBioRegs_Load);
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioRegsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBioRegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioRegsBindingNavigator)).EndInit();
            this.bioRegsBindingNavigator.ResumeLayout(false);
            this.bioRegsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusS1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslConnString;
        private System.Windows.Forms.Button btnFindBioRegType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.BindingSource bioRegsBindingSource;
        private TrainITDataSetTableAdapters.BioRegsTableAdapter bioRegsTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvBioRegs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtBioRegID;
        private System.Windows.Forms.TextBox txtBioRegTypeID;
        private System.Windows.Forms.DateTimePicker dtpBioRegDate;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.BindingNavigator bioRegsBindingNavigator;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnPrevious;
        private System.Windows.Forms.ToolStripButton tsBtnNext;
        private System.Windows.Forms.ToolStripButton tsBtnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnDel;
        private System.Windows.Forms.TextBox txtBioRegName;
    }
}