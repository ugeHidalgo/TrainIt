namespace TrainIt
{
    partial class FSessions
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
            System.Windows.Forms.Label sessionIDLabel;
            System.Windows.Forms.Label trainIDLabel;
            System.Windows.Forms.Label sportTypeIDLabel;
            System.Windows.Forms.Label distanceLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label medHRLabel;
            System.Windows.Forms.Label maxHRLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label competitionLabel1;
            System.Windows.Forms.Label transitionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSessions));
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.SessionsTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.sessionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSessionID = new System.Windows.Forms.TextBox();
            this.txtTrainID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtSportTypeID = new System.Windows.Forms.TextBox();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtMedHR = new System.Windows.Forms.TextBox();
            this.txtMaxHR = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chbxComp = new System.Windows.Forms.CheckBox();
            this.chBxTrns = new System.Windows.Forms.CheckBox();
            this.trainingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.TrainingsTableAdapter();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.sportTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportTypesTableAdapter = new TrainIt.TrainITDataSetTableAdapters.SportTypesTableAdapter();
            this.txtSportTypeName = new System.Windows.Forms.TextBox();
            this.btnFindTrain = new System.Windows.Forms.Button();
            this.btnFindSportType = new System.Windows.Forms.Button();
            sessionIDLabel = new System.Windows.Forms.Label();
            trainIDLabel = new System.Windows.Forms.Label();
            sportTypeIDLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            medHRLabel = new System.Windows.Forms.Label();
            maxHRLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            competitionLabel1 = new System.Windows.Forms.Label();
            transitionLabel = new System.Windows.Forms.Label();
            this.statusS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingNavigator)).BeginInit();
            this.sessionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionIDLabel
            // 
            sessionIDLabel.AutoSize = true;
            sessionIDLabel.Location = new System.Drawing.Point(12, 39);
            sessionIDLabel.Name = "sessionIDLabel";
            sessionIDLabel.Size = new System.Drawing.Size(61, 13);
            sessionIDLabel.TabIndex = 8;
            sessionIDLabel.Text = "Session ID:";
            // 
            // trainIDLabel
            // 
            trainIDLabel.AutoSize = true;
            trainIDLabel.Location = new System.Drawing.Point(25, 65);
            trainIDLabel.Name = "trainIDLabel";
            trainIDLabel.Size = new System.Drawing.Size(48, 13);
            trainIDLabel.TabIndex = 10;
            trainIDLabel.Text = "Train ID:";
            // 
            // sportTypeIDLabel
            // 
            sportTypeIDLabel.AutoSize = true;
            sportTypeIDLabel.Location = new System.Drawing.Point(-3, 91);
            sportTypeIDLabel.Name = "sportTypeIDLabel";
            sportTypeIDLabel.Size = new System.Drawing.Size(76, 13);
            sportTypeIDLabel.TabIndex = 14;
            sportTypeIDLabel.Text = "Sport Type ID:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new System.Drawing.Point(375, 101);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(52, 13);
            distanceLabel.TabIndex = 20;
            distanceLabel.Text = "Distance:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(391, 127);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 22;
            timeLabel.Text = "Time:";
            // 
            // medHRLabel
            // 
            medHRLabel.AutoSize = true;
            medHRLabel.Location = new System.Drawing.Point(375, 153);
            medHRLabel.Name = "medHRLabel";
            medHRLabel.Size = new System.Drawing.Size(50, 13);
            medHRLabel.TabIndex = 24;
            medHRLabel.Text = "Med HR:";
            // 
            // maxHRLabel
            // 
            maxHRLabel.AutoSize = true;
            maxHRLabel.Location = new System.Drawing.Point(375, 179);
            maxHRLabel.Name = "maxHRLabel";
            maxHRLabel.Size = new System.Drawing.Size(49, 13);
            maxHRLabel.TabIndex = 26;
            maxHRLabel.Text = "Max HR:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(387, 205);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 28;
            valueLabel.Text = "Value:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(104, 243);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 30;
            memoLabel.Text = "Memo:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(394, 36);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 32;
            dateLabel.Text = "Date:";
            // 
            // competitionLabel1
            // 
            competitionLabel1.AutoSize = true;
            competitionLabel1.Location = new System.Drawing.Point(69, 151);
            competitionLabel1.Name = "competitionLabel1";
            competitionLabel1.Size = new System.Drawing.Size(65, 13);
            competitionLabel1.TabIndex = 33;
            competitionLabel1.Text = "Competition:";
            // 
            // transitionLabel
            // 
            transitionLabel.AutoSize = true;
            transitionLabel.Location = new System.Drawing.Point(78, 181);
            transitionLabel.Name = "transitionLabel";
            transitionLabel.Size = new System.Drawing.Size(56, 13);
            transitionLabel.TabIndex = 34;
            transitionLabel.Text = "Transition:";
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 672);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(753, 22);
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
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "Sessions";
            this.sessionsBindingSource.DataSource = this.trainITDataSet;
            // 
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = this.sessionsTableAdapter;
            this.tableAdapterManager.SportTypesTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // sessionsBindingNavigator
            // 
            this.sessionsBindingNavigator.AddNewItem = this.tsBtnNew;
            this.sessionsBindingNavigator.BindingSource = this.sessionsBindingSource;
            this.sessionsBindingNavigator.CountItem = null;
            this.sessionsBindingNavigator.DeleteItem = this.tsBtnDelete;
            this.sessionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFirst,
            this.tsBtnPrevious,
            this.tsBtnNext,
            this.tsBtnLast,
            this.bindingNavigatorSeparator2,
            this.tsBtnNew,
            this.tsBtnEdit,
            this.tsBtnCancel,
            this.tsBtnSave,
            this.tsBtnDelete});
            this.sessionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sessionsBindingNavigator.MoveFirstItem = this.tsBtnFirst;
            this.sessionsBindingNavigator.MoveLastItem = this.tsBtnLast;
            this.sessionsBindingNavigator.MoveNextItem = this.tsBtnNext;
            this.sessionsBindingNavigator.MovePreviousItem = this.tsBtnPrevious;
            this.sessionsBindingNavigator.Name = "sessionsBindingNavigator";
            this.sessionsBindingNavigator.PositionItem = null;
            this.sessionsBindingNavigator.Size = new System.Drawing.Size(753, 25);
            this.sessionsBindingNavigator.TabIndex = 8;
            this.sessionsBindingNavigator.Text = "bindingNavigator1";
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
            // tsBtnDelete
            // 
            this.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.RightToLeftAutoMirrorImage = true;
            this.tsBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelete.Text = "Borrar registro";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // tsBtnFirst
            // 
            this.tsBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFirst.Image")));
            this.tsBtnFirst.Name = "tsBtnFirst";
            this.tsBtnFirst.RightToLeftAutoMirrorImage = true;
            this.tsBtnFirst.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFirst.Text = "Primer registro";
            // 
            // tsBtnPrevious
            // 
            this.tsBtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrevious.Image")));
            this.tsBtnPrevious.Name = "tsBtnPrevious";
            this.tsBtnPrevious.RightToLeftAutoMirrorImage = true;
            this.tsBtnPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrevious.Text = "Registro anterior";
            // 
            // tsBtnNext
            // 
            this.tsBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNext.Image")));
            this.tsBtnNext.Name = "tsBtnNext";
            this.tsBtnNext.RightToLeftAutoMirrorImage = true;
            this.tsBtnNext.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNext.Text = "Registro siguiente";
            // 
            // tsBtnLast
            // 
            this.tsBtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLast.Image")));
            this.tsBtnLast.Name = "tsBtnLast";
            this.tsBtnLast.RightToLeftAutoMirrorImage = true;
            this.tsBtnLast.Size = new System.Drawing.Size(23, 22);
            this.tsBtnLast.Text = "Último registro";
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
            this.tsBtnEdit.Text = "Modificar registro";
            this.tsBtnEdit.Click += new System.EventHandler(this.tsBtnEdit_Click);
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancel.Image")));
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCancel.Text = "Cancelar edición";
            this.tsBtnCancel.Click += new System.EventHandler(this.tsBtnCancel_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "Grabar registro";
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.AllowUserToOrderColumns = true;
            this.dgvSessions.AutoGenerateColumns = false;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SportTypeName,
            this.TrainName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dgvSessions.DataSource = this.sessionsBindingSource;
            this.dgvSessions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSessions.Location = new System.Drawing.Point(0, 361);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.RowHeadersVisible = false;
            this.dgvSessions.Size = new System.Drawing.Size(753, 311);
            this.dgvSessions.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SessionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SessionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SportTypeName
            // 
            this.SportTypeName.DataPropertyName = "SportTypeName";
            this.SportTypeName.HeaderText = "Column1";
            this.SportTypeName.Name = "SportTypeName";
            this.SportTypeName.ReadOnly = true;
            // 
            // TrainName
            // 
            this.TrainName.DataPropertyName = "TrainName";
            this.TrainName.HeaderText = "Column1";
            this.TrainName.Name = "TrainName";
            this.TrainName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TrainID";
            this.dataGridViewTextBoxColumn2.HeaderText = "TrainID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SportTypeID";
            this.dataGridViewTextBoxColumn4.HeaderText = "SportTypeID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Competition";
            this.dataGridViewTextBoxColumn5.HeaderText = "Competition";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Transition";
            this.dataGridViewTextBoxColumn6.HeaderText = "Transition";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Distance";
            this.dataGridViewTextBoxColumn7.HeaderText = "Distance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn8.HeaderText = "Time";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MedHR";
            this.dataGridViewTextBoxColumn9.HeaderText = "MedHR";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaxHR";
            this.dataGridViewTextBoxColumn10.HeaderText = "MaxHR";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn11.HeaderText = "Value";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // txtSessionID
            // 
            this.txtSessionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSessionID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "SessionID", true));
            this.txtSessionID.Location = new System.Drawing.Point(79, 36);
            this.txtSessionID.Name = "txtSessionID";
            this.txtSessionID.ReadOnly = true;
            this.txtSessionID.Size = new System.Drawing.Size(29, 20);
            this.txtSessionID.TabIndex = 9;
            // 
            // txtTrainID
            // 
            this.txtTrainID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "TrainID", true));
            this.txtTrainID.Location = new System.Drawing.Point(79, 62);
            this.txtTrainID.Name = "txtTrainID";
            this.txtTrainID.ReadOnly = true;
            this.txtTrainID.Size = new System.Drawing.Size(29, 20);
            this.txtTrainID.TabIndex = 11;
            this.txtTrainID.TextChanged += new System.EventHandler(this.txtTrainID_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "UserID", true));
            this.txtUserID.Location = new System.Drawing.Point(107, 36);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(32, 20);
            this.txtUserID.TabIndex = 13;
            // 
            // txtSportTypeID
            // 
            this.txtSportTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSportTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "SportTypeID", true));
            this.txtSportTypeID.Location = new System.Drawing.Point(79, 88);
            this.txtSportTypeID.Name = "txtSportTypeID";
            this.txtSportTypeID.ReadOnly = true;
            this.txtSportTypeID.Size = new System.Drawing.Size(29, 20);
            this.txtSportTypeID.TabIndex = 15;
            this.txtSportTypeID.TextChanged += new System.EventHandler(this.txtSportTypeID_TextChanged);
            // 
            // txtDist
            // 
            this.txtDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Distance", true));
            this.txtDist.Location = new System.Drawing.Point(433, 99);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(200, 20);
            this.txtDist.TabIndex = 21;
            this.txtDist.Validating += new System.ComponentModel.CancelEventHandler(this.txtDist_Validating);
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "T"));
            this.txtTime.Location = new System.Drawing.Point(433, 125);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 20);
            this.txtTime.TabIndex = 23;
            this.txtTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtTime_Validating);
            // 
            // txtMedHR
            // 
            this.txtMedHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedHR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "MedHR", true));
            this.txtMedHR.Location = new System.Drawing.Point(433, 151);
            this.txtMedHR.Name = "txtMedHR";
            this.txtMedHR.Size = new System.Drawing.Size(66, 20);
            this.txtMedHR.TabIndex = 25;
            this.txtMedHR.Validating += new System.ComponentModel.CancelEventHandler(this.txtMedHR_Validating);
            // 
            // txtMaxHR
            // 
            this.txtMaxHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxHR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "MaxHR", true));
            this.txtMaxHR.Location = new System.Drawing.Point(433, 177);
            this.txtMaxHR.Name = "txtMaxHR";
            this.txtMaxHR.Size = new System.Drawing.Size(66, 20);
            this.txtMaxHR.TabIndex = 27;
            this.txtMaxHR.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaxHR_Validating);
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Value", true));
            this.txtValue.Location = new System.Drawing.Point(433, 203);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(66, 20);
            this.txtValue.TabIndex = 29;
            this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
            // 
            // txtMemo
            // 
            this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Memo", true));
            this.txtMemo.Location = new System.Drawing.Point(151, 241);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(311, 92);
            this.txtMemo.TabIndex = 31;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sessionsBindingSource, "Date", true));
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Date", true));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(433, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(84, 20);
            this.dtpDate.TabIndex = 33;
            this.dtpDate.Value = new System.DateTime(2013, 10, 31, 10, 21, 49, 0);
            // 
            // chbxComp
            // 
            this.chbxComp.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sessionsBindingSource, "Competition", true));
            this.chbxComp.Location = new System.Drawing.Point(140, 146);
            this.chbxComp.Name = "chbxComp";
            this.chbxComp.Size = new System.Drawing.Size(17, 24);
            this.chbxComp.TabIndex = 34;
            this.chbxComp.UseVisualStyleBackColor = true;
            // 
            // chBxTrns
            // 
            this.chBxTrns.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sessionsBindingSource, "Transition", true));
            this.chBxTrns.Location = new System.Drawing.Point(140, 176);
            this.chBxTrns.Name = "chBxTrns";
            this.chBxTrns.Size = new System.Drawing.Size(17, 24);
            this.chBxTrns.TabIndex = 35;
            this.chBxTrns.UseVisualStyleBackColor = true;
            // 
            // trainingsBindingSource
            // 
            this.trainingsBindingSource.DataMember = "Trainings";
            this.trainingsBindingSource.DataSource = this.trainITDataSet;
            // 
            // trainingsTableAdapter
            // 
            this.trainingsTableAdapter.ClearBeforeFill = true;
            // 
            // txtTrainName
            // 
            this.txtTrainName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingsBindingSource, "TrainName", true));
            this.txtTrainName.Location = new System.Drawing.Point(133, 62);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.ReadOnly = true;
            this.txtTrainName.Size = new System.Drawing.Size(196, 20);
            this.txtTrainName.TabIndex = 36;
            // 
            // sportTypesBindingSource
            // 
            this.sportTypesBindingSource.DataMember = "SportTypes";
            this.sportTypesBindingSource.DataSource = this.trainITDataSet;
            // 
            // sportTypesTableAdapter
            // 
            this.sportTypesTableAdapter.ClearBeforeFill = true;
            // 
            // txtSportTypeName
            // 
            this.txtSportTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSportTypeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sportTypesBindingSource, "SportTypeName", true));
            this.txtSportTypeName.Location = new System.Drawing.Point(133, 88);
            this.txtSportTypeName.Name = "txtSportTypeName";
            this.txtSportTypeName.ReadOnly = true;
            this.txtSportTypeName.Size = new System.Drawing.Size(196, 20);
            this.txtSportTypeName.TabIndex = 37;
            // 
            // btnFindTrain
            // 
            this.btnFindTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnFindTrain.Image")));
            this.btnFindTrain.Location = new System.Drawing.Point(109, 60);
            this.btnFindTrain.Name = "btnFindTrain";
            this.btnFindTrain.Size = new System.Drawing.Size(23, 23);
            this.btnFindTrain.TabIndex = 38;
            this.btnFindTrain.UseVisualStyleBackColor = true;
            this.btnFindTrain.Click += new System.EventHandler(this.btnFindTrain_Click);
            // 
            // btnFindSportType
            // 
            this.btnFindSportType.Image = ((System.Drawing.Image)(resources.GetObject("btnFindSportType.Image")));
            this.btnFindSportType.Location = new System.Drawing.Point(109, 86);
            this.btnFindSportType.Name = "btnFindSportType";
            this.btnFindSportType.Size = new System.Drawing.Size(23, 23);
            this.btnFindSportType.TabIndex = 39;
            this.btnFindSportType.UseVisualStyleBackColor = true;
            this.btnFindSportType.Click += new System.EventHandler(this.btnFindSportType_Click);
            // 
            // FSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 694);
            this.Controls.Add(this.btnFindSportType);
            this.Controls.Add(this.btnFindTrain);
            this.Controls.Add(this.txtSportTypeName);
            this.Controls.Add(this.txtTrainName);
            this.Controls.Add(transitionLabel);
            this.Controls.Add(this.chBxTrns);
            this.Controls.Add(competitionLabel1);
            this.Controls.Add(this.chbxComp);
            this.Controls.Add(sessionIDLabel);
            this.Controls.Add(this.txtSessionID);
            this.Controls.Add(trainIDLabel);
            this.Controls.Add(this.txtTrainID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(sportTypeIDLabel);
            this.Controls.Add(this.txtSportTypeID);
            this.Controls.Add(distanceLabel);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(medHRLabel);
            this.Controls.Add(this.txtMedHR);
            this.Controls.Add(maxHRLabel);
            this.Controls.Add(this.txtMaxHR);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.sessionsBindingNavigator);
            this.Controls.Add(this.statusS1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FSessions";
            this.Text = "Sesiones de Entrenamiento";
            this.Load += new System.EventHandler(this.FSessions_Load);
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingNavigator)).EndInit();
            this.sessionsBindingNavigator.ResumeLayout(false);
            this.sessionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusS1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslConnString;
        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private TrainITDataSetTableAdapters.SessionsTableAdapter sessionsTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sessionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnPrevious;
        private System.Windows.Forms.ToolStripButton tsBtnNext;
        private System.Windows.Forms.ToolStripButton tsBtnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.TextBox txtSessionID;
        private System.Windows.Forms.TextBox txtTrainID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtSportTypeID;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtMedHR;
        private System.Windows.Forms.TextBox txtMaxHR;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chbxComp;
        private System.Windows.Forms.CheckBox chBxTrns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource trainingsBindingSource;
        private TrainITDataSetTableAdapters.TrainingsTableAdapter trainingsTableAdapter;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.BindingSource sportTypesBindingSource;
        private TrainITDataSetTableAdapters.SportTypesTableAdapter sportTypesTableAdapter;
        private System.Windows.Forms.TextBox txtSportTypeName;
        private System.Windows.Forms.Button btnFindTrain;
        private System.Windows.Forms.Button btnFindSportType;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
    }
}