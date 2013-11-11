namespace TrainIt
{
    partial class FTrainings
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
            System.Windows.Forms.Label trainIDLabel;
            System.Windows.Forms.Label trainDateLabel;
            System.Windows.Forms.Label trainNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTrainings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trainingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.trainingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelTraining = new System.Windows.Forms.ToolStripButton();
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.sessionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.TrainingsTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.sessionsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.SessionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            trainIDLabel = new System.Windows.Forms.Label();
            trainDateLabel = new System.Windows.Forms.Label();
            trainNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingNavigator)).BeginInit();
            this.trainingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            this.statusS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trainIDLabel
            // 
            trainIDLabel.AutoSize = true;
            trainIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trainIDLabel.Location = new System.Drawing.Point(447, 43);
            trainIDLabel.Name = "trainIDLabel";
            trainIDLabel.Size = new System.Drawing.Size(75, 20);
            trainIDLabel.TabIndex = 6;
            trainIDLabel.Text = "Código :";
            // 
            // trainDateLabel
            // 
            trainDateLabel.AutoSize = true;
            trainDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trainDateLabel.Location = new System.Drawing.Point(448, 134);
            trainDateLabel.Name = "trainDateLabel";
            trainDateLabel.Size = new System.Drawing.Size(74, 20);
            trainDateLabel.TabIndex = 10;
            trainDateLabel.Text = "Fecha  :";
            // 
            // trainNameLabel
            // 
            trainNameLabel.AutoSize = true;
            trainNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trainNameLabel.Location = new System.Drawing.Point(436, 87);
            trainNameLabel.Name = "trainNameLabel";
            trainNameLabel.Size = new System.Drawing.Size(86, 20);
            trainNameLabel.TabIndex = 11;
            trainNameLabel.Text = "Nombre  :";
            // 
            // trainingsBindingNavigator
            // 
            this.trainingsBindingNavigator.AddNewItem = this.tsBtnNew;
            this.trainingsBindingNavigator.BindingSource = this.trainingsBindingSource;
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
            this.tsBtnDelTraining});
            this.trainingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trainingsBindingNavigator.MoveFirstItem = this.tsBtnFirst;
            this.trainingsBindingNavigator.MoveLastItem = this.tsBtnLast;
            this.trainingsBindingNavigator.MoveNextItem = this.tsBtnNext;
            this.trainingsBindingNavigator.MovePreviousItem = this.tsBtnPrevious;
            this.trainingsBindingNavigator.Name = "trainingsBindingNavigator";
            this.trainingsBindingNavigator.PositionItem = null;
            this.trainingsBindingNavigator.Size = new System.Drawing.Size(1057, 25);
            this.trainingsBindingNavigator.TabIndex = 5;
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
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
            // 
            // trainingsBindingSource
            // 
            this.trainingsBindingSource.DataMember = "Trainings";
            this.trainingsBindingSource.DataSource = this.trainITDataSet;
            // 
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tsBtnDelTraining
            // 
            this.tsBtnDelTraining.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelTraining.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelTraining.Image")));
            this.tsBtnDelTraining.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelTraining.Name = "tsBtnDelTraining";
            this.tsBtnDelTraining.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelTraining.Text = "Borrar registro.";
            this.tsBtnDelTraining.Click += new System.EventHandler(this.tsBtnDelTraining_Click);
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 537);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(1057, 22);
            this.statusS1.TabIndex = 6;
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
            // dgvTrainings
            // 
            this.dgvTrainings.AllowUserToAddRows = false;
            this.dgvTrainings.AllowUserToDeleteRows = false;
            this.dgvTrainings.AllowUserToOrderColumns = true;
            this.dgvTrainings.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.TrainName});
            this.dgvTrainings.DataSource = this.trainingsBindingSource;
            this.dgvTrainings.Location = new System.Drawing.Point(6, 87);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.ReadOnly = true;
            this.dgvTrainings.RowHeadersVisible = false;
            this.dgvTrainings.Size = new System.Drawing.Size(403, 438);
            this.dgvTrainings.TabIndex = 6;
            this.dgvTrainings.TabStop = false;
            this.dgvTrainings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainings_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TrainDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // TrainName
            // 
            this.TrainName.DataPropertyName = "TrainName";
            this.TrainName.HeaderText = "Nombre Entrenamiento";
            this.TrainName.Name = "TrainName";
            this.TrainName.ReadOnly = true;
            this.TrainName.Width = 300;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingsBindingSource, "TrainID", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(527, 41);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(72, 26);
            this.txtID.TabIndex = 7;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingsBindingSource, "UserID", true));
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(598, 41);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(81, 26);
            this.txtUserID.TabIndex = 9;
            this.txtUserID.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trainingsBindingSource, "TrainDate", true));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(527, 129);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDate.Size = new System.Drawing.Size(133, 26);
            this.dtpDate.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingsBindingSource, "TrainName", true));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(527, 85);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(516, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // sessionsDataGridView
            // 
            this.sessionsDataGridView.AllowUserToAddRows = false;
            this.sessionsDataGridView.AllowUserToDeleteRows = false;
            this.sessionsDataGridView.AllowUserToOrderColumns = true;
            this.sessionsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sessionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.sessionsDataGridView.DataSource = this.sessionsBindingSource;
            this.sessionsDataGridView.Location = new System.Drawing.Point(415, 217);
            this.sessionsDataGridView.Name = "sessionsDataGridView";
            this.sessionsDataGridView.ReadOnly = true;
            this.sessionsDataGridView.RowHeadersVisible = false;
            this.sessionsDataGridView.Size = new System.Drawing.Size(634, 308);
            this.sessionsDataGridView.TabIndex = 12;
            this.sessionsDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Date";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn14.HeaderText = "Fecha Sesión";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 80;
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
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Distance";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.HeaderText = "Distancia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Time";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn9.HeaderText = "Tiempo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MedHR";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn10.HeaderText = "Pulso Medio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaxHR";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn11.HeaderText = "Pulso Máximo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Value";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle8;
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
            // trainingsTableAdapter
            // 
            this.trainingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = null;
            this.tableAdapterManager.SportTypesTableAdapter = null;
            this.tableAdapterManager.TempMaterialTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = this.trainingsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sesiones asociadas al entrenamiento :";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(315, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 41);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoose.Location = new System.Drawing.Point(168, 40);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChoose.Size = new System.Drawing.Size(141, 41);
            this.btnChoose.TabIndex = 27;
            this.btnChoose.Text = "Seleccionar";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Entrenamientos :";
            // 
            // FTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sessionsDataGridView);
            this.Controls.Add(this.dgvTrainings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(trainNameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(trainIDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(trainDateLabel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.trainingsBindingNavigator);
            this.Controls.Add(this.statusS1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FTrainings";
            this.Text = "Entrenamientos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FTrainings_FormClosing);
            this.Load += new System.EventHandler(this.FTrainings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingNavigator)).EndInit();
            this.trainingsBindingNavigator.ResumeLayout(false);
            this.trainingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.StatusStrip statusS1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslConnString;
        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.BindingSource trainingsBindingSource;
        private TrainITDataSetTableAdapters.TrainingsTableAdapter trainingsTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvTrainings;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private TrainITDataSetTableAdapters.SessionsTableAdapter sessionsTableAdapter;
        private System.Windows.Forms.DataGridView sessionsDataGridView;
        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsBtnDelTraining;     
    }
}