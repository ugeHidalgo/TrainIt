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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSessions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.sessionsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.SessionsTableAdapter();
            this.sessionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelSession = new System.Windows.Forms.ToolStripButton();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.chBxTrans = new System.Windows.Forms.CheckBox();
            this.trainingsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.TrainingsTableAdapter();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.trainingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportTypesTableAdapter = new TrainIt.TrainITDataSetTableAdapters.SportTypesTableAdapter();
            this.txtSportTypeName = new System.Windows.Forms.TextBox();
            this.sportTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFindTrain = new System.Windows.Forms.Button();
            this.btnFindSportType = new System.Windows.Forms.Button();
            this.btnFindMaterial = new System.Windows.Forms.Button();
            this.materialsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.MaterialsTableAdapter();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelMat = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.tempMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempMaterialTableAdapter = new TrainIt.TrainITDataSetTableAdapters.TempMaterialTableAdapter();
            this.dgvMats = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms1Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cms1Del = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1DelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelAllMat = new System.Windows.Forms.Button();
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
            label1 = new System.Windows.Forms.Label();
            this.statusS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingNavigator)).BeginInit();
            this.sessionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMats)).BeginInit();
            this.cms1.SuspendLayout();
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
            distanceLabel.Location = new System.Drawing.Point(588, 42);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(52, 13);
            distanceLabel.TabIndex = 20;
            distanceLabel.Text = "Distance:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(604, 68);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 22;
            timeLabel.Text = "Time:";
            // 
            // medHRLabel
            // 
            medHRLabel.AutoSize = true;
            medHRLabel.Location = new System.Drawing.Point(796, 42);
            medHRLabel.Name = "medHRLabel";
            medHRLabel.Size = new System.Drawing.Size(50, 13);
            medHRLabel.TabIndex = 24;
            medHRLabel.Text = "Med HR:";
            // 
            // maxHRLabel
            // 
            maxHRLabel.AutoSize = true;
            maxHRLabel.Location = new System.Drawing.Point(796, 68);
            maxHRLabel.Name = "maxHRLabel";
            maxHRLabel.Size = new System.Drawing.Size(49, 13);
            maxHRLabel.TabIndex = 26;
            maxHRLabel.Text = "Max HR:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(808, 94);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 28;
            valueLabel.Text = "Value:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(12, 131);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 30;
            memoLabel.Text = "Memo:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(237, 39);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 32;
            dateLabel.Text = "Date:";
            // 
            // competitionLabel1
            // 
            competitionLabel1.AutoSize = true;
            competitionLabel1.Location = new System.Drawing.Point(439, 47);
            competitionLabel1.Name = "competitionLabel1";
            competitionLabel1.Size = new System.Drawing.Size(65, 13);
            competitionLabel1.TabIndex = 33;
            competitionLabel1.Text = "Competition:";
            // 
            // transitionLabel
            // 
            transitionLabel.AutoSize = true;
            transitionLabel.Location = new System.Drawing.Point(443, 73);
            transitionLabel.Name = "transitionLabel";
            transitionLabel.Size = new System.Drawing.Size(56, 13);
            transitionLabel.TabIndex = 34;
            transitionLabel.Text = "Transition:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(588, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 44;
            label1.Text = "Distance:";
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 740);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(991, 22);
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
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // sessionsBindingNavigator
            // 
            this.sessionsBindingNavigator.AddNewItem = this.tsBtnNew;
            this.sessionsBindingNavigator.BindingSource = this.sessionsBindingSource;
            this.sessionsBindingNavigator.CountItem = null;
            this.sessionsBindingNavigator.DeleteItem = null;
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
            this.tsBtnDelSession});
            this.sessionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sessionsBindingNavigator.MoveFirstItem = this.tsBtnFirst;
            this.sessionsBindingNavigator.MoveLastItem = this.tsBtnLast;
            this.sessionsBindingNavigator.MoveNextItem = this.tsBtnNext;
            this.sessionsBindingNavigator.MovePreviousItem = this.tsBtnPrevious;
            this.sessionsBindingNavigator.Name = "sessionsBindingNavigator";
            this.sessionsBindingNavigator.PositionItem = null;
            this.sessionsBindingNavigator.Size = new System.Drawing.Size(991, 25);
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
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "Sessions";
            this.sessionsBindingSource.DataSource = this.trainITDataSet;
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
            // tsBtnDelSession
            // 
            this.tsBtnDelSession.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelSession.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelSession.Image")));
            this.tsBtnDelSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelSession.Name = "tsBtnDelSession";
            this.tsBtnDelSession.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelSession.Text = "toolStripButton1";
            this.tsBtnDelSession.Click += new System.EventHandler(this.tsBtnDelSession_Click);
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.AllowUserToOrderColumns = true;
            this.dgvSessions.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.SportTypeName,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.ShortTime,
            this.Speed,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.TrainName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn12});
            this.dgvSessions.DataSource = this.sessionsBindingSource;
            this.dgvSessions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSessions.Location = new System.Drawing.Point(0, 385);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.RowHeadersVisible = false;
            this.dgvSessions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSessions.Size = new System.Drawing.Size(991, 355);
            this.dgvSessions.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SessionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SessionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn13.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 80;
            // 
            // SportTypeName
            // 
            this.SportTypeName.DataPropertyName = "SportTypeName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SportTypeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.SportTypeName.HeaderText = "Deporte";
            this.SportTypeName.Name = "SportTypeName";
            this.SportTypeName.ReadOnly = true;
            this.SportTypeName.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Competition";
            this.dataGridViewTextBoxColumn5.HeaderText = "Comp";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Transition";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tran";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Distance";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "Distancia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // ShortTime
            // 
            this.ShortTime.DataPropertyName = "ShortTime";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ShortTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.ShortTime.HeaderText = "ShortTime";
            this.ShortTime.Name = "ShortTime";
            this.ShortTime.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.DataPropertyName = "Speed";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Speed.DefaultCellStyle = dataGridViewCellStyle6;
            this.Speed.HeaderText = "Velocidad";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MedHR";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn9.HeaderText = "Pulso Medio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaxHR";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn10.HeaderText = "Pulso Máximo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Value";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn11.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 40;
            // 
            // TrainName
            // 
            this.TrainName.DataPropertyName = "TrainName";
            this.TrainName.HeaderText = "Column1";
            this.TrainName.Name = "TrainName";
            this.TrainName.ReadOnly = true;
            this.TrainName.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TrainID";
            this.dataGridViewTextBoxColumn2.HeaderText = "TrainID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SportTypeID";
            this.dataGridViewTextBoxColumn4.HeaderText = "SportTypeID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
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
            this.txtSessionID.TabStop = false;
            this.txtSessionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSessionID.TextChanged += new System.EventHandler(this.txtSessionID_TextChanged);
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
            this.txtTrainID.TabStop = false;
            this.txtTrainID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtUserID.TabStop = false;
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
            this.txtSportTypeID.TabStop = false;
            this.txtSportTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSportTypeID.TextChanged += new System.EventHandler(this.txtSportTypeID_TextChanged);
            // 
            // txtDist
            // 
            this.txtDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Distance", true));
            this.txtDist.Location = new System.Drawing.Point(646, 40);
            this.txtDist.MaxLength = 8;
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(52, 20);
            this.txtDist.TabIndex = 6;
            this.txtDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDist.Validating += new System.ComponentModel.CancelEventHandler(this.txtDist_Validating);
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "T"));
            this.txtTime.Location = new System.Drawing.Point(646, 66);
            this.txtTime.MaxLength = 9;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(78, 20);
            this.txtTime.TabIndex = 7;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtTime_Validating);
            // 
            // txtMedHR
            // 
            this.txtMedHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedHR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "MedHR", true));
            this.txtMedHR.Location = new System.Drawing.Point(854, 40);
            this.txtMedHR.MaxLength = 3;
            this.txtMedHR.Name = "txtMedHR";
            this.txtMedHR.Size = new System.Drawing.Size(40, 20);
            this.txtMedHR.TabIndex = 8;
            this.txtMedHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMedHR.Validating += new System.ComponentModel.CancelEventHandler(this.txtMedHR_Validating);
            // 
            // txtMaxHR
            // 
            this.txtMaxHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxHR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "MaxHR", true));
            this.txtMaxHR.Location = new System.Drawing.Point(854, 66);
            this.txtMaxHR.MaxLength = 3;
            this.txtMaxHR.Name = "txtMaxHR";
            this.txtMaxHR.Size = new System.Drawing.Size(40, 20);
            this.txtMaxHR.TabIndex = 9;
            this.txtMaxHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxHR.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaxHR_Validating);
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Value", true));
            this.txtValue.Location = new System.Drawing.Point(854, 92);
            this.txtValue.MaxLength = 2;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(19, 20);
            this.txtValue.TabIndex = 10;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
            // 
            // txtMemo
            // 
            this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Memo", true));
            this.txtMemo.Location = new System.Drawing.Point(12, 152);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(395, 159);
            this.txtMemo.TabIndex = 11;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sessionsBindingSource, "Date", true));
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Date", true));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(276, 36);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeftLayout = true;
            this.dtpDate.Size = new System.Drawing.Size(84, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2013, 10, 31, 10, 21, 49, 0);
            // 
            // chbxComp
            // 
            this.chbxComp.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sessionsBindingSource, "Competition", true));
            this.chbxComp.Location = new System.Drawing.Point(512, 41);
            this.chbxComp.Name = "chbxComp";
            this.chbxComp.Size = new System.Drawing.Size(17, 24);
            this.chbxComp.TabIndex = 4;
            this.chbxComp.UseVisualStyleBackColor = true;
            // 
            // chBxTrans
            // 
            this.chBxTrans.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sessionsBindingSource, "Transition", true));
            this.chBxTrans.Location = new System.Drawing.Point(512, 67);
            this.chBxTrans.Name = "chBxTrans";
            this.chBxTrans.Size = new System.Drawing.Size(17, 24);
            this.chBxTrans.TabIndex = 5;
            this.chBxTrans.UseVisualStyleBackColor = true;
            // 
            // trainingsTableAdapter
            // 
            this.trainingsTableAdapter.ClearBeforeFill = true;
            // 
            // txtTrainName
            // 
            this.txtTrainName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingsBindingSource, "TrainName", true));
            this.txtTrainName.Location = new System.Drawing.Point(134, 62);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.ReadOnly = true;
            this.txtTrainName.Size = new System.Drawing.Size(226, 20);
            this.txtTrainName.TabIndex = 36;
            this.txtTrainName.TabStop = false;
            // 
            // trainingsBindingSource
            // 
            this.trainingsBindingSource.DataMember = "Trainings";
            this.trainingsBindingSource.DataSource = this.trainITDataSet;
            // 
            // sportTypesTableAdapter
            // 
            this.sportTypesTableAdapter.ClearBeforeFill = true;
            // 
            // txtSportTypeName
            // 
            this.txtSportTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSportTypeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sportTypesBindingSource, "SportTypeName", true));
            this.txtSportTypeName.Location = new System.Drawing.Point(134, 88);
            this.txtSportTypeName.Name = "txtSportTypeName";
            this.txtSportTypeName.ReadOnly = true;
            this.txtSportTypeName.Size = new System.Drawing.Size(226, 20);
            this.txtSportTypeName.TabIndex = 37;
            this.txtSportTypeName.TabStop = false;
            // 
            // sportTypesBindingSource
            // 
            this.sportTypesBindingSource.DataMember = "SportTypes";
            this.sportTypesBindingSource.DataSource = this.trainITDataSet;
            // 
            // btnFindTrain
            // 
            this.btnFindTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnFindTrain.Image")));
            this.btnFindTrain.Location = new System.Drawing.Point(109, 60);
            this.btnFindTrain.Name = "btnFindTrain";
            this.btnFindTrain.Size = new System.Drawing.Size(24, 24);
            this.btnFindTrain.TabIndex = 2;
            this.btnFindTrain.UseVisualStyleBackColor = true;
            this.btnFindTrain.Click += new System.EventHandler(this.btnFindTrain_Click);
            // 
            // btnFindSportType
            // 
            this.btnFindSportType.Image = ((System.Drawing.Image)(resources.GetObject("btnFindSportType.Image")));
            this.btnFindSportType.Location = new System.Drawing.Point(109, 86);
            this.btnFindSportType.Name = "btnFindSportType";
            this.btnFindSportType.Size = new System.Drawing.Size(24, 24);
            this.btnFindSportType.TabIndex = 3;
            this.btnFindSportType.UseVisualStyleBackColor = true;
            this.btnFindSportType.Click += new System.EventHandler(this.btnFindSportType_Click);
            // 
            // btnFindMaterial
            // 
            this.btnFindMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnFindMaterial.Image")));
            this.btnFindMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindMaterial.Location = new System.Drawing.Point(425, 131);
            this.btnFindMaterial.Name = "btnFindMaterial";
            this.btnFindMaterial.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnFindMaterial.Size = new System.Drawing.Size(124, 24);
            this.btnFindMaterial.TabIndex = 12;
            this.btnFindMaterial.Text = "Añadir Material";
            this.btnFindMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindMaterial.UseVisualStyleBackColor = true;
            this.btnFindMaterial.Click += new System.EventHandler(this.btnFindMaterial_Click);
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.trainITDataSet;
            // 
            // btnDelMat
            // 
            this.btnDelMat.Image = ((System.Drawing.Image)(resources.GetObject("btnDelMat.Image")));
            this.btnDelMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelMat.Location = new System.Drawing.Point(555, 131);
            this.btnDelMat.Name = "btnDelMat";
            this.btnDelMat.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDelMat.Size = new System.Drawing.Size(119, 24);
            this.btnDelMat.TabIndex = 14;
            this.btnDelMat.Text = "Quitar Material";
            this.btnDelMat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelMat.UseVisualStyleBackColor = true;
            this.btnDelMat.Click += new System.EventHandler(this.btnDelMat_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpeed.Location = new System.Drawing.Point(646, 92);
            this.txtSpeed.MaxLength = 8;
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(52, 20);
            this.txtSpeed.TabIndex = 43;
            this.txtSpeed.TabStop = false;
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = this.sessionsTableAdapter;
            this.tableAdapterManager.SportTypesTableAdapter = null;
            this.tableAdapterManager.TempMaterialTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // tempMaterialBindingSource
            // 
            this.tempMaterialBindingSource.DataMember = "TempMaterial";
            this.tempMaterialBindingSource.DataSource = this.trainITDataSet;
            // 
            // tempMaterialTableAdapter
            // 
            this.tempMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMats
            // 
            this.dgvMats.AllowUserToAddRows = false;
            this.dgvMats.AllowUserToDeleteRows = false;
            this.dgvMats.AllowUserToOrderColumns = true;
            this.dgvMats.AutoGenerateColumns = false;
            this.dgvMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn17});
            this.dgvMats.ContextMenuStrip = this.cms1;
            this.dgvMats.DataSource = this.tempMaterialBindingSource;
            this.dgvMats.Location = new System.Drawing.Point(425, 161);
            this.dgvMats.Name = "dgvMats";
            this.dgvMats.ReadOnly = true;
            this.dgvMats.RowHeadersVisible = false;
            this.dgvMats.RowTemplate.Height = 45;
            this.dgvMats.Size = new System.Drawing.Size(546, 220);
            this.dgvMats.TabIndex = 44;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "MatImage";
            this.dataGridViewImageColumn1.HeaderText = "MatImage";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MatName";
            this.dataGridViewTextBoxColumn14.HeaderText = "MatName";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 180;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MatModel";
            this.dataGridViewTextBoxColumn15.HeaderText = "MatModel";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 180;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MatBrand";
            this.dataGridViewTextBoxColumn16.HeaderText = "MatBrand";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 180;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "matID";
            this.dataGridViewTextBoxColumn8.HeaderText = "matID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "SessionID";
            this.dataGridViewTextBoxColumn17.HeaderText = "SessionID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms1Add,
            this.toolStripSeparator1,
            this.cms1Del,
            this.cms1DelAll});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(320, 76);
            this.cms1.Text = "Materia usado en la sesión";
            // 
            // cms1Add
            // 
            this.cms1Add.Name = "cms1Add";
            this.cms1Add.Size = new System.Drawing.Size(319, 22);
            this.cms1Add.Text = "Añadir material usado en la sesión";
            this.cms1Add.Click += new System.EventHandler(this.btnFindMaterial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(316, 6);
            // 
            // cms1Del
            // 
            this.cms1Del.Name = "cms1Del";
            this.cms1Del.Size = new System.Drawing.Size(319, 22);
            this.cms1Del.Text = "Quitar material usado en la sesión";
            this.cms1Del.Click += new System.EventHandler(this.btnDelMat_Click);
            // 
            // cms1DelAll
            // 
            this.cms1DelAll.Name = "cms1DelAll";
            this.cms1DelAll.Size = new System.Drawing.Size(319, 22);
            this.cms1DelAll.Text = "Quitar todos los materiales usados en la sesión";
            this.cms1DelAll.Click += new System.EventHandler(this.btnDelAllMat_Click);
            // 
            // btnDelAllMat
            // 
            this.btnDelAllMat.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAllMat.Image")));
            this.btnDelAllMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAllMat.Location = new System.Drawing.Point(680, 131);
            this.btnDelAllMat.Name = "btnDelAllMat";
            this.btnDelAllMat.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDelAllMat.Size = new System.Drawing.Size(119, 24);
            this.btnDelAllMat.TabIndex = 46;
            this.btnDelAllMat.Text = "Quitar Todos";
            this.btnDelAllMat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelAllMat.UseVisualStyleBackColor = true;
            this.btnDelAllMat.Click += new System.EventHandler(this.btnDelAllMat_Click);
            // 
            // FSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 762);
            this.Controls.Add(this.btnDelAllMat);
            this.Controls.Add(this.dgvMats);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnDelMat);
            this.Controls.Add(this.btnFindMaterial);
            this.Controls.Add(this.btnFindSportType);
            this.Controls.Add(this.btnFindTrain);
            this.Controls.Add(this.txtSportTypeName);
            this.Controls.Add(this.txtTrainName);
            this.Controls.Add(transitionLabel);
            this.Controls.Add(this.chBxTrans);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSessions_FormClosing);
            this.Load += new System.EventHandler(this.FSessions_Load);
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingNavigator)).EndInit();
            this.sessionsBindingNavigator.ResumeLayout(false);
            this.sessionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMats)).EndInit();
            this.cms1.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chBxTrans;
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
        private System.Windows.Forms.Button btnFindMaterial;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private TrainITDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.Button btnDelMat;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.BindingSource tempMaterialBindingSource;
        private TrainITDataSetTableAdapters.TempMaterialTableAdapter tempMaterialTableAdapter;
        private System.Windows.Forms.DataGridView dgvMats;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem cms1Add;
        private System.Windows.Forms.ToolStripMenuItem cms1Del;
        private System.Windows.Forms.Button btnDelAllMat;
        private System.Windows.Forms.ToolStripMenuItem cms1DelAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.ToolStripButton tsBtnDelSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportTypeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}