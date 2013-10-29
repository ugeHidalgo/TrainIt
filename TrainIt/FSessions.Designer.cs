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
            System.Windows.Forms.Label distanceLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label medHRLabel;
            System.Windows.Forms.Label maxHRLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label trainNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSessions));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.sessionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.sessionsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.SessionsTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.trainingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.txtSessionID = new System.Windows.Forms.TextBox();
            this.txtTrainID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtSportTypeID = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.medHRTextBox = new System.Windows.Forms.TextBox();
            this.maxHRTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtSportTypeName = new System.Windows.Forms.TextBox();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.competitionCheckBox = new System.Windows.Forms.CheckBox();
            this.transitionCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindTrain = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSportType = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            sessionIDLabel = new System.Windows.Forms.Label();
            trainIDLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            medHRLabel = new System.Windows.Forms.Label();
            maxHRLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            trainNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.statusS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingNavigator)).BeginInit();
            this.trainingsBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sessionIDLabel
            // 
            sessionIDLabel.AutoSize = true;
            sessionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sessionIDLabel.Location = new System.Drawing.Point(25, 34);
            sessionIDLabel.Name = "sessionIDLabel";
            sessionIDLabel.Size = new System.Drawing.Size(75, 20);
            sessionIDLabel.TabIndex = 14;
            sessionIDLabel.Text = "Código :";
            // 
            // trainIDLabel
            // 
            trainIDLabel.AutoSize = true;
            trainIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trainIDLabel.Location = new System.Drawing.Point(111, 28);
            trainIDLabel.Name = "trainIDLabel";
            trainIDLabel.Size = new System.Drawing.Size(75, 20);
            trainIDLabel.TabIndex = 16;
            trainIDLabel.Text = "Código :";
            trainIDLabel.Click += new System.EventHandler(this.trainIDLabel_Click);
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            distanceLabel.Location = new System.Drawing.Point(628, 398);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(85, 20);
            distanceLabel.TabIndex = 26;
            distanceLabel.Text = "Distance:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeLabel.Location = new System.Drawing.Point(628, 445);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(52, 20);
            timeLabel.TabIndex = 28;
            timeLabel.Text = "Time:";
            // 
            // medHRLabel
            // 
            medHRLabel.AutoSize = true;
            medHRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medHRLabel.Location = new System.Drawing.Point(265, 411);
            medHRLabel.Name = "medHRLabel";
            medHRLabel.Size = new System.Drawing.Size(79, 20);
            medHRLabel.TabIndex = 30;
            medHRLabel.Text = "Med HR:";
            // 
            // maxHRLabel
            // 
            maxHRLabel.AutoSize = true;
            maxHRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maxHRLabel.Location = new System.Drawing.Point(265, 437);
            maxHRLabel.Name = "maxHRLabel";
            maxHRLabel.Size = new System.Drawing.Size(77, 20);
            maxHRLabel.TabIndex = 32;
            maxHRLabel.Text = "Max HR:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valueLabel.Location = new System.Drawing.Point(723, 511);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(60, 20);
            valueLabel.TabIndex = 34;
            valueLabel.Text = "Value:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            memoLabel.Location = new System.Drawing.Point(10, 514);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(62, 20);
            memoLabel.TabIndex = 36;
            memoLabel.Text = "Memo:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(31, 85);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(69, 20);
            dateLabel.TabIndex = 38;
            dateLabel.Text = "Fecha :";
            // 
            // trainNameLabel
            // 
            trainNameLabel.AutoSize = true;
            trainNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trainNameLabel.Location = new System.Drawing.Point(105, 66);
            trainNameLabel.Name = "trainNameLabel";
            trainNameLabel.Size = new System.Drawing.Size(81, 20);
            trainNameLabel.TabIndex = 42;
            trainNameLabel.Text = "Nombre :";
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 844);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(1130, 22);
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
            // sessionsDataGridView
            // 
            this.sessionsDataGridView.AllowUserToAddRows = false;
            this.sessionsDataGridView.AllowUserToDeleteRows = false;
            this.sessionsDataGridView.AllowUserToOrderColumns = true;
            this.sessionsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.sessionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.TrainName,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.sessionsDataGridView.DataSource = this.sessionsBindingSource;
            this.sessionsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sessionsDataGridView.Location = new System.Drawing.Point(0, 610);
            this.sessionsDataGridView.Name = "sessionsDataGridView";
            this.sessionsDataGridView.ReadOnly = true;
            this.sessionsDataGridView.RowHeadersVisible = false;
            this.sessionsDataGridView.Size = new System.Drawing.Size(1130, 234);
            this.sessionsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Date";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn14.HeaderText = "Fecha Sesión";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // TrainName
            // 
            this.TrainName.DataPropertyName = "TrainName";
            this.TrainName.HeaderText = "Entrenamiento";
            this.TrainName.Name = "TrainName";
            this.TrainName.ReadOnly = true;
            this.TrainName.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Competition";
            this.dataGridViewTextBoxColumn6.HeaderText = "Com.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Transition";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tran.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SportTypeName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn15.HeaderText = "Deporte";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Distance";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn8.HeaderText = "Distancia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Time";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn9.HeaderText = "Tiempo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MedHR";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn10.HeaderText = "Pulso Medio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaxHR";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn11.HeaderText = "Pulso Máximo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Value";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn12.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 40;
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "Sessions";
            this.sessionsBindingSource.DataSource = this.trainITDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.SportTypesTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // trainingsBindingNavigator
            // 
            this.trainingsBindingNavigator.AddNewItem = this.tsBtnNew;
            this.trainingsBindingNavigator.CountItem = null;
            this.trainingsBindingNavigator.DeleteItem = null;
            this.trainingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.trainingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trainingsBindingNavigator.MoveFirstItem = this.tsBtnFirst;
            this.trainingsBindingNavigator.MoveLastItem = this.tsBtnLast;
            this.trainingsBindingNavigator.MoveNextItem = this.tsBtnNext;
            this.trainingsBindingNavigator.MovePreviousItem = this.tsBtnPrevious;
            this.trainingsBindingNavigator.Name = "trainingsBindingNavigator";
            this.trainingsBindingNavigator.PositionItem = null;
            this.trainingsBindingNavigator.Size = new System.Drawing.Size(1130, 25);
            this.trainingsBindingNavigator.TabIndex = 14;
            this.trainingsBindingNavigator.Text = "bindingNavigator1";
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNew.Image")));
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.RightToLeftAutoMirrorImage = true;
            this.tsBtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNew.Text = "Nuevo registro";
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
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancel.Image")));
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCancel.Text = "Cancelar Edición";
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "Grabar Registro";
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
            // txtSessionID
            // 
            this.txtSessionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSessionID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "SessionID", true));
            this.txtSessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessionID.Location = new System.Drawing.Point(106, 32);
            this.txtSessionID.Name = "txtSessionID";
            this.txtSessionID.ReadOnly = true;
            this.txtSessionID.Size = new System.Drawing.Size(62, 26);
            this.txtSessionID.TabIndex = 15;
            this.txtSessionID.TabStop = false;
            // 
            // txtTrainID
            // 
            this.txtTrainID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "TrainID", true));
            this.txtTrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainID.Location = new System.Drawing.Point(192, 26);
            this.txtTrainID.Name = "txtTrainID";
            this.txtTrainID.ReadOnly = true;
            this.txtTrainID.Size = new System.Drawing.Size(79, 26);
            this.txtTrainID.TabIndex = 17;
            this.txtTrainID.TextChanged += new System.EventHandler(this.trainIDTextBox_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "UserID", true));
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(167, 32);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(67, 26);
            this.txtUserID.TabIndex = 19;
            this.txtUserID.TabStop = false;
            // 
            // txtSportTypeID
            // 
            this.txtSportTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSportTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "SportTypeID", true));
            this.txtSportTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSportTypeID.Location = new System.Drawing.Point(194, 22);
            this.txtSportTypeID.Name = "txtSportTypeID";
            this.txtSportTypeID.ReadOnly = true;
            this.txtSportTypeID.Size = new System.Drawing.Size(79, 26);
            this.txtSportTypeID.TabIndex = 21;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Distance", true));
            this.distanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTextBox.Location = new System.Drawing.Point(727, 395);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(200, 26);
            this.distanceTextBox.TabIndex = 27;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Time", true));
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(727, 442);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 26);
            this.timeTextBox.TabIndex = 29;
            // 
            // medHRTextBox
            // 
            this.medHRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "MedHR", true));
            this.medHRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medHRTextBox.Location = new System.Drawing.Point(364, 408);
            this.medHRTextBox.Name = "medHRTextBox";
            this.medHRTextBox.Size = new System.Drawing.Size(200, 26);
            this.medHRTextBox.TabIndex = 31;
            // 
            // maxHRTextBox
            // 
            this.maxHRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "MaxHR", true));
            this.maxHRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHRTextBox.Location = new System.Drawing.Point(364, 434);
            this.maxHRTextBox.Name = "maxHRTextBox";
            this.maxHRTextBox.Size = new System.Drawing.Size(200, 26);
            this.maxHRTextBox.TabIndex = 33;
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Value", true));
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTextBox.Location = new System.Drawing.Point(822, 508);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(200, 26);
            this.valueTextBox.TabIndex = 35;
            // 
            // memoTextBox
            // 
            this.memoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "Memo", true));
            this.memoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoTextBox.Location = new System.Drawing.Point(109, 511);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(200, 26);
            this.memoTextBox.TabIndex = 37;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sessionsBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(106, 84);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(121, 26);
            this.dateDateTimePicker.TabIndex = 39;
            // 
            // txtSportTypeName
            // 
            this.txtSportTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSportTypeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "SportTypeName", true));
            this.txtSportTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSportTypeName.Location = new System.Drawing.Point(194, 61);
            this.txtSportTypeName.Name = "txtSportTypeName";
            this.txtSportTypeName.Size = new System.Drawing.Size(533, 26);
            this.txtSportTypeName.TabIndex = 41;
            // 
            // txtTrainName
            // 
            this.txtTrainName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "TrainName", true));
            this.txtTrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainName.Location = new System.Drawing.Point(192, 64);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(535, 26);
            this.txtTrainName.TabIndex = 43;
            // 
            // competitionCheckBox
            // 
            this.competitionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sessionsBindingSource, "Competition", true));
            this.competitionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionCheckBox.Location = new System.Drawing.Point(-3, 134);
            this.competitionCheckBox.Name = "competitionCheckBox";
            this.competitionCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.competitionCheckBox.Size = new System.Drawing.Size(203, 24);
            this.competitionCheckBox.TabIndex = 44;
            this.competitionCheckBox.Text = "Competición ";
            this.competitionCheckBox.UseVisualStyleBackColor = true;
            // 
            // transitionCheckBox
            // 
            this.transitionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sessionsBindingSource, "Transition", true));
            this.transitionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionCheckBox.Location = new System.Drawing.Point(90, 172);
            this.transitionCheckBox.Name = "transitionCheckBox";
            this.transitionCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transitionCheckBox.Size = new System.Drawing.Size(110, 24);
            this.transitionCheckBox.TabIndex = 45;
            this.transitionCheckBox.Text = "Transición";
            this.transitionCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transitionCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindTrain);
            this.groupBox1.Controls.Add(trainIDLabel);
            this.groupBox1.Controls.Add(this.txtTrainID);
            this.groupBox1.Controls.Add(trainNameLabel);
            this.groupBox1.Controls.Add(this.txtTrainName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 105);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrenamiento";
            // 
            // btnFindTrain
            // 
            this.btnFindTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnFindTrain.Image")));
            this.btnFindTrain.Location = new System.Drawing.Point(279, 17);
            this.btnFindTrain.Name = "btnFindTrain";
            this.btnFindTrain.Size = new System.Drawing.Size(42, 42);
            this.btnFindTrain.TabIndex = 44;
            this.btnFindTrain.UseVisualStyleBackColor = true;
            this.btnFindTrain.Click += new System.EventHandler(this.btnFindTrain_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSportType);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.txtSportTypeID);
            this.groupBox2.Controls.Add(this.txtSportTypeName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 105);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deporte";
            // 
            // btnSportType
            // 
            this.btnSportType.Image = ((System.Drawing.Image)(resources.GetObject("btnSportType.Image")));
            this.btnSportType.Location = new System.Drawing.Point(279, 13);
            this.btnSportType.Name = "btnSportType";
            this.btnSportType.Size = new System.Drawing.Size(42, 42);
            this.btnSportType.TabIndex = 44;
            this.btnSportType.UseVisualStyleBackColor = true;
            this.btnSportType.Click += new System.EventHandler(this.btnSportType_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(113, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 16;
            label1.Text = "Código :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(105, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 42;
            label2.Text = "Nombre :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.transitionCheckBox);
            this.groupBox3.Controls.Add(sessionIDLabel);
            this.groupBox3.Controls.Add(this.txtSessionID);
            this.groupBox3.Controls.Add(this.competitionCheckBox);
            this.groupBox3.Controls.Add(this.txtUserID);
            this.groupBox3.Controls.Add(dateLabel);
            this.groupBox3.Controls.Add(this.dateDateTimePicker);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 221);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // FSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 866);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(distanceLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(medHRLabel);
            this.Controls.Add(this.medHRTextBox);
            this.Controls.Add(maxHRLabel);
            this.Controls.Add(this.maxHRTextBox);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.trainingsBindingNavigator);
            this.Controls.Add(this.sessionsDataGridView);
            this.Controls.Add(this.statusS1);
            this.Name = "FSessions";
            this.Text = "Sesiones de entreamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSessions_FormClosing);
            this.Load += new System.EventHandler(this.FSessions_Load);
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingNavigator)).EndInit();
            this.trainingsBindingNavigator.ResumeLayout(false);
            this.trainingsBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridView sessionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingNavigator trainingsBindingNavigator;
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
        private System.Windows.Forms.TextBox txtSessionID;
        private System.Windows.Forms.TextBox txtTrainID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtSportTypeID;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox medHRTextBox;
        private System.Windows.Forms.TextBox maxHRTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox txtSportTypeName;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.CheckBox competitionCheckBox;
        private System.Windows.Forms.CheckBox transitionCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindTrain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSportType;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}