namespace TrainIt
{
    partial class FMaterial
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
            System.Windows.Forms.Label matInitTimeLabel;
            System.Windows.Forms.Label matInitDistLabel;
            System.Windows.Forms.Label matBuyMemoLabel;
            System.Windows.Forms.Label matBuyDateLabel;
            System.Windows.Forms.Label matCostLabel;
            System.Windows.Forms.Label matIDLabel;
            System.Windows.Forms.Label matNameLabel;
            System.Windows.Forms.Label matModelLabel;
            System.Windows.Forms.Label matBrandLabel;
            System.Windows.Forms.Label matSizeLabel;
            System.Windows.Forms.Label matWeightLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label matRecTimeLabel;
            System.Windows.Forms.Label matRecDistLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMaterial));
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.materialsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatBuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatTotTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatTotDist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.mtxtWeight = new System.Windows.Forms.MaskedTextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnCancelImage = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuyMemo = new System.Windows.Forms.TextBox();
            this.dtpBuyDate = new System.Windows.Forms.DateTimePicker();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUseTime = new System.Windows.Forms.TextBox();
            this.txtTimeBar = new System.Windows.Forms.TextBox();
            this.txtDistBar = new System.Windows.Forms.TextBox();
            this.mtxtRecTime = new System.Windows.Forms.MaskedTextBox();
            this.mtxtInitTime = new System.Windows.Forms.MaskedTextBox();
            this.txtRecDist = new System.Windows.Forms.TextBox();
            this.txtUseDist = new System.Windows.Forms.TextBox();
            this.txtInitDist = new System.Windows.Forms.TextBox();
            this.txtBarsBack = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.MaterialsTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            matInitTimeLabel = new System.Windows.Forms.Label();
            matInitDistLabel = new System.Windows.Forms.Label();
            matBuyMemoLabel = new System.Windows.Forms.Label();
            matBuyDateLabel = new System.Windows.Forms.Label();
            matCostLabel = new System.Windows.Forms.Label();
            matIDLabel = new System.Windows.Forms.Label();
            matNameLabel = new System.Windows.Forms.Label();
            matModelLabel = new System.Windows.Forms.Label();
            matBrandLabel = new System.Windows.Forms.Label();
            matSizeLabel = new System.Windows.Forms.Label();
            matWeightLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            matRecTimeLabel = new System.Windows.Forms.Label();
            matRecDistLabel = new System.Windows.Forms.Label();
            this.statusS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingNavigator)).BeginInit();
            this.materialsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // matInitTimeLabel
            // 
            matInitTimeLabel.AutoSize = true;
            matInitTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matInitTimeLabel.Location = new System.Drawing.Point(6, 29);
            matInitTimeLabel.Name = "matInitTimeLabel";
            matInitTimeLabel.Size = new System.Drawing.Size(105, 20);
            matInitTimeLabel.TabIndex = 20;
            matInitTimeLabel.Text = "Tiempo Inicial";
            matInitTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matInitDistLabel
            // 
            matInitDistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matInitDistLabel.Location = new System.Drawing.Point(2, 180);
            matInitDistLabel.Name = "matInitDistLabel";
            matInitDistLabel.Size = new System.Drawing.Size(155, 20);
            matInitDistLabel.TabIndex = 22;
            matInitDistLabel.Text = "Distancia Inicial";
            matInitDistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matBuyMemoLabel
            // 
            matBuyMemoLabel.AutoSize = true;
            matBuyMemoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matBuyMemoLabel.Location = new System.Drawing.Point(6, 74);
            matBuyMemoLabel.Name = "matBuyMemoLabel";
            matBuyMemoLabel.Size = new System.Drawing.Size(182, 20);
            matBuyMemoLabel.TabIndex = 26;
            matBuyMemoLabel.Text = "Observaciones Compra :";
            // 
            // matBuyDateLabel
            // 
            matBuyDateLabel.AutoSize = true;
            matBuyDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matBuyDateLabel.Location = new System.Drawing.Point(135, 21);
            matBuyDateLabel.Name = "matBuyDateLabel";
            matBuyDateLabel.Size = new System.Drawing.Size(122, 20);
            matBuyDateLabel.TabIndex = 22;
            matBuyDateLabel.Text = "Fecha Compra :";
            // 
            // matCostLabel
            // 
            matCostLabel.AutoSize = true;
            matCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matCostLabel.Location = new System.Drawing.Point(198, 51);
            matCostLabel.Name = "matCostLabel";
            matCostLabel.Size = new System.Drawing.Size(59, 20);
            matCostLabel.TabIndex = 24;
            matCostLabel.Text = "Coste :";
            // 
            // matIDLabel
            // 
            matIDLabel.AutoSize = true;
            matIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matIDLabel.Location = new System.Drawing.Point(29, 32);
            matIDLabel.Name = "matIDLabel";
            matIDLabel.Size = new System.Drawing.Size(67, 20);
            matIDLabel.TabIndex = 12;
            matIDLabel.Text = "Código :";
            // 
            // matNameLabel
            // 
            matNameLabel.AutoSize = true;
            matNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matNameLabel.Location = new System.Drawing.Point(23, 64);
            matNameLabel.Name = "matNameLabel";
            matNameLabel.Size = new System.Drawing.Size(73, 20);
            matNameLabel.TabIndex = 14;
            matNameLabel.Text = "Nombre :";
            // 
            // matModelLabel
            // 
            matModelLabel.AutoSize = true;
            matModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matModelLabel.Location = new System.Drawing.Point(27, 96);
            matModelLabel.Name = "matModelLabel";
            matModelLabel.Size = new System.Drawing.Size(69, 20);
            matModelLabel.TabIndex = 16;
            matModelLabel.Text = "Modelo :";
            // 
            // matBrandLabel
            // 
            matBrandLabel.AutoSize = true;
            matBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matBrandLabel.Location = new System.Drawing.Point(35, 128);
            matBrandLabel.Name = "matBrandLabel";
            matBrandLabel.Size = new System.Drawing.Size(61, 20);
            matBrandLabel.TabIndex = 18;
            matBrandLabel.Text = "Marca :";
            // 
            // matSizeLabel
            // 
            matSizeLabel.AutoSize = true;
            matSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matSizeLabel.Location = new System.Drawing.Point(571, 64);
            matSizeLabel.Name = "matSizeLabel";
            matSizeLabel.Size = new System.Drawing.Size(50, 20);
            matSizeLabel.TabIndex = 20;
            matSizeLabel.Text = "Talla :";
            // 
            // matWeightLabel
            // 
            matWeightLabel.AutoSize = true;
            matWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matWeightLabel.Location = new System.Drawing.Point(568, 96);
            matWeightLabel.Name = "matWeightLabel";
            matWeightLabel.Size = new System.Drawing.Size(53, 20);
            matWeightLabel.TabIndex = 21;
            matWeightLabel.Text = "Peso :";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(178, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 20);
            label1.TabIndex = 24;
            label1.Text = "Tiempo Total";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(178, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 20);
            label2.TabIndex = 26;
            label2.Text = "Distancia Total";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matRecTimeLabel
            // 
            matRecTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matRecTimeLabel.Location = new System.Drawing.Point(334, 29);
            matRecTimeLabel.Name = "matRecTimeLabel";
            matRecTimeLabel.Size = new System.Drawing.Size(177, 20);
            matRecTimeLabel.TabIndex = 27;
            matRecTimeLabel.Text = "Tiempo Recomendado";
            matRecTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // matRecDistLabel
            // 
            matRecDistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matRecDistLabel.Location = new System.Drawing.Point(302, 181);
            matRecDistLabel.Name = "matRecDistLabel";
            matRecDistLabel.Size = new System.Drawing.Size(215, 20);
            matRecDistLabel.TabIndex = 28;
            matRecDistLabel.Text = "Distancia Recomendada";
            matRecDistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 735);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(950, 22);
            this.statusS1.TabIndex = 3;
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
            // materialsBindingNavigator
            // 
            this.materialsBindingNavigator.AddNewItem = this.tsBtnNew;
            this.materialsBindingNavigator.BindingSource = this.materialsBindingSource;
            this.materialsBindingNavigator.CountItem = null;
            this.materialsBindingNavigator.DeleteItem = null;
            this.materialsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.materialsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialsBindingNavigator.MoveFirstItem = this.tsBtnFirst;
            this.materialsBindingNavigator.MoveLastItem = this.tsBtnLast;
            this.materialsBindingNavigator.MoveNextItem = this.tsBtnNext;
            this.materialsBindingNavigator.MovePreviousItem = this.tsBtnPrevious;
            this.materialsBindingNavigator.Name = "materialsBindingNavigator";
            this.materialsBindingNavigator.PositionItem = null;
            this.materialsBindingNavigator.Size = new System.Drawing.Size(950, 25);
            this.materialsBindingNavigator.TabIndex = 4;
            this.materialsBindingNavigator.Text = "bindingNavigator1";
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
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.trainITDataSet;
            this.materialsBindingSource.PositionChanged += new System.EventHandler(this.materialsBindingSource_PositionChanged);
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
            // tsBtnDel
            // 
            this.tsBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDel.Image")));
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.RightToLeftAutoMirrorImage = true;
            this.tsBtnDel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDel.Text = "Borrar registro";
            this.tsBtnDel.Click += new System.EventHandler(this.tsBtnDel_Click);
            // 
            // dgvMat
            // 
            this.dgvMat.AllowUserToAddRows = false;
            this.dgvMat.AllowUserToDeleteRows = false;
            this.dgvMat.AllowUserToOrderColumns = true;
            this.dgvMat.AutoGenerateColumns = false;
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.MatModel,
            this.MatBrand,
            this.MatBuyDate,
            this.MatCost,
            this.MatTotTime,
            this.MatTotDist});
            this.dgvMat.DataSource = this.materialsBindingSource;
            this.dgvMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMat.Location = new System.Drawing.Point(0, 437);
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.ReadOnly = true;
            this.dgvMat.RowHeadersVisible = false;
            this.dgvMat.Size = new System.Drawing.Size(950, 298);
            this.dgvMat.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // MatModel
            // 
            this.MatModel.DataPropertyName = "MatModel";
            this.MatModel.HeaderText = "Modelo";
            this.MatModel.Name = "MatModel";
            this.MatModel.ReadOnly = true;
            this.MatModel.Width = 180;
            // 
            // MatBrand
            // 
            this.MatBrand.DataPropertyName = "MatBrand";
            this.MatBrand.HeaderText = "Marca";
            this.MatBrand.Name = "MatBrand";
            this.MatBrand.ReadOnly = true;
            this.MatBrand.Width = 180;
            // 
            // MatBuyDate
            // 
            this.MatBuyDate.DataPropertyName = "MatBuyDate";
            this.MatBuyDate.HeaderText = "Compra";
            this.MatBuyDate.Name = "MatBuyDate";
            this.MatBuyDate.ReadOnly = true;
            // 
            // MatCost
            // 
            this.MatCost.DataPropertyName = "MatCost";
            this.MatCost.HeaderText = "Coste";
            this.MatCost.Name = "MatCost";
            this.MatCost.ReadOnly = true;
            this.MatCost.Width = 80;
            // 
            // MatTotTime
            // 
            this.MatTotTime.DataPropertyName = "MatTotTime";
            this.MatTotTime.HeaderText = "Tiempo Uso";
            this.MatTotTime.Name = "MatTotTime";
            this.MatTotTime.ReadOnly = true;
            // 
            // MatTotDist
            // 
            this.MatTotDist.DataPropertyName = "MatTotDist";
            this.MatTotDist.HeaderText = "Distancia";
            this.MatTotDist.Name = "MatTotDist";
            this.MatTotDist.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnChoose);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.mtxtWeight);
            this.groupBox1.Controls.Add(matWeightLabel);
            this.groupBox1.Controls.Add(matSizeLabel);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(matIDLabel);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(matNameLabel);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(matModelLabel);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(matBrandLabel);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 173);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "userID", true));
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(160, 29);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(54, 26);
            this.txtUserID.TabIndex = 22;
            this.txtUserID.TabStop = false;
            // 
            // mtxtWeight
            // 
            this.mtxtWeight.BeepOnError = true;
            this.mtxtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatWeight", true));
            this.mtxtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtWeight.Location = new System.Drawing.Point(627, 93);
            this.mtxtWeight.Name = "mtxtWeight";
            this.mtxtWeight.Size = new System.Drawing.Size(100, 26);
            this.mtxtWeight.TabIndex = 5;
            this.mtxtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtWeight.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mTxtWeight_TypeValidationCompleted);
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatSize", true));
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(627, 61);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 26);
            this.txtSize.TabIndex = 4;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxImage);
            this.panel1.Controls.Add(this.btnCancelImage);
            this.panel1.Controls.Add(this.btnLoadImage);
            this.panel1.Location = new System.Drawing.Point(747, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 147);
            this.panel1.TabIndex = 20;
            // 
            // pbxImage
            // 
            this.pbxImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.materialsBindingSource, "MatImage", true));
            this.pbxImage.Location = new System.Drawing.Point(3, 4);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(168, 111);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 25;
            this.pbxImage.TabStop = false;
            // 
            // btnCancelImage
            // 
            this.btnCancelImage.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelImage.Image")));
            this.btnCancelImage.Location = new System.Drawing.Point(122, 121);
            this.btnCancelImage.Name = "btnCancelImage";
            this.btnCancelImage.Size = new System.Drawing.Size(50, 23);
            this.btnCancelImage.TabIndex = 24;
            this.btnCancelImage.UseVisualStyleBackColor = true;
            this.btnCancelImage.Click += new System.EventHandler(this.btnCancelImage_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadImage.Image")));
            this.btnLoadImage.Location = new System.Drawing.Point(3, 121);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(113, 23);
            this.btnLoadImage.TabIndex = 23;
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatID", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(102, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(59, 26);
            this.txtID.TabIndex = 13;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatName", true));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(102, 61);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(444, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatModel", true));
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(100, 93);
            this.txtModel.MaxLength = 50;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(446, 26);
            this.txtModel.TabIndex = 2;
            // 
            // txtBrand
            // 
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatBrand", true));
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(100, 125);
            this.txtBrand.MaxLength = 50;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(446, 26);
            this.txtBrand.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(matBuyMemoLabel);
            this.groupBox2.Controls.Add(this.txtBuyMemo);
            this.groupBox2.Controls.Add(matBuyDateLabel);
            this.groupBox2.Controls.Add(this.dtpBuyDate);
            this.groupBox2.Controls.Add(matCostLabel);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 224);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra";
            // 
            // txtBuyMemo
            // 
            this.txtBuyMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuyMemo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatBuyMemo", true));
            this.txtBuyMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyMemo.Location = new System.Drawing.Point(10, 97);
            this.txtBuyMemo.Multiline = true;
            this.txtBuyMemo.Name = "txtBuyMemo";
            this.txtBuyMemo.Size = new System.Drawing.Size(378, 112);
            this.txtBuyMemo.TabIndex = 8;
            // 
            // dtpBuyDate
            // 
            this.dtpBuyDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.materialsBindingSource, "MatBuyDate", true));
            this.dtpBuyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuyDate.Location = new System.Drawing.Point(263, 16);
            this.dtpBuyDate.Name = "dtpBuyDate";
            this.dtpBuyDate.Size = new System.Drawing.Size(125, 26);
            this.dtpBuyDate.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatCost", true));
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(263, 48);
            this.txtCost.MaxLength = 10;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(90, 26);
            this.txtCost.TabIndex = 7;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUseTime);
            this.groupBox3.Controls.Add(this.txtTimeBar);
            this.groupBox3.Controls.Add(this.txtDistBar);
            this.groupBox3.Controls.Add(this.mtxtRecTime);
            this.groupBox3.Controls.Add(this.mtxtInitTime);
            this.groupBox3.Controls.Add(matRecDistLabel);
            this.groupBox3.Controls.Add(this.txtRecDist);
            this.groupBox3.Controls.Add(matRecTimeLabel);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(this.txtUseDist);
            this.groupBox3.Controls.Add(matInitTimeLabel);
            this.groupBox3.Controls.Add(matInitDistLabel);
            this.groupBox3.Controls.Add(this.txtInitDist);
            this.groupBox3.Controls.Add(this.txtBarsBack);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(416, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 224);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uso";
            // 
            // txtUseTime
            // 
            this.txtUseTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUseTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatTotTime", true));
            this.txtUseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseTime.Location = new System.Drawing.Point(182, 58);
            this.txtUseTime.Name = "txtUseTime";
            this.txtUseTime.ReadOnly = true;
            this.txtUseTime.Size = new System.Drawing.Size(122, 19);
            this.txtUseTime.TabIndex = 25;
            this.txtUseTime.TabStop = false;
            this.txtUseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeBar
            // 
            this.txtTimeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTimeBar.Location = new System.Drawing.Point(7, 87);
            this.txtTimeBar.Name = "txtTimeBar";
            this.txtTimeBar.ReadOnly = true;
            this.txtTimeBar.Size = new System.Drawing.Size(503, 26);
            this.txtTimeBar.TabIndex = 34;
            this.txtTimeBar.TabStop = false;
            // 
            // txtDistBar
            // 
            this.txtDistBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDistBar.Location = new System.Drawing.Point(7, 115);
            this.txtDistBar.Name = "txtDistBar";
            this.txtDistBar.ReadOnly = true;
            this.txtDistBar.Size = new System.Drawing.Size(503, 26);
            this.txtDistBar.TabIndex = 32;
            this.txtDistBar.TabStop = false;
            // 
            // mtxtRecTime
            // 
            this.mtxtRecTime.BeepOnError = true;
            this.mtxtRecTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtRecTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatRecTime", true));
            this.mtxtRecTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtRecTime.Location = new System.Drawing.Point(382, 54);
            this.mtxtRecTime.Name = "mtxtRecTime";
            this.mtxtRecTime.Size = new System.Drawing.Size(129, 26);
            this.mtxtRecTime.TabIndex = 10;
            this.mtxtRecTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtRecTime.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtRecTime_Validating);
            // 
            // mtxtInitTime
            // 
            this.mtxtInitTime.BeepOnError = true;
            this.mtxtInitTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtInitTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatInitTime", true));
            this.mtxtInitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInitTime.Location = new System.Drawing.Point(6, 51);
            this.mtxtInitTime.Name = "mtxtInitTime";
            this.mtxtInitTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtInitTime.Size = new System.Drawing.Size(122, 26);
            this.mtxtInitTime.SkipLiterals = false;
            this.mtxtInitTime.TabIndex = 9;
            this.mtxtInitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtInitTime.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtInitTime_Validating);
            // 
            // txtRecDist
            // 
            this.txtRecDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecDist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatRecDist", true));
            this.txtRecDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecDist.Location = new System.Drawing.Point(389, 149);
            this.txtRecDist.Name = "txtRecDist";
            this.txtRecDist.Size = new System.Drawing.Size(122, 26);
            this.txtRecDist.TabIndex = 12;
            this.txtRecDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecDist.Validating += new System.ComponentModel.CancelEventHandler(this.txtRecDist_Validating);
            // 
            // txtUseDist
            // 
            this.txtUseDist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUseDist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatTotDist", true));
            this.txtUseDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseDist.Location = new System.Drawing.Point(178, 149);
            this.txtUseDist.Name = "txtUseDist";
            this.txtUseDist.ReadOnly = true;
            this.txtUseDist.Size = new System.Drawing.Size(122, 19);
            this.txtUseDist.TabIndex = 27;
            this.txtUseDist.TabStop = false;
            this.txtUseDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInitDist
            // 
            this.txtInitDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitDist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MatInitDist", true));
            this.txtInitDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitDist.Location = new System.Drawing.Point(6, 148);
            this.txtInitDist.Name = "txtInitDist";
            this.txtInitDist.Size = new System.Drawing.Size(122, 26);
            this.txtInitDist.TabIndex = 11;
            this.txtInitDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInitDist.Validating += new System.ComponentModel.CancelEventHandler(this.txtInitDist_Validating);
            // 
            // txtBarsBack
            // 
            this.txtBarsBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBarsBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarsBack.Location = new System.Drawing.Point(6, 83);
            this.txtBarsBack.Multiline = true;
            this.txtBarsBack.Name = "txtBarsBack";
            this.txtBarsBack.ReadOnly = true;
            this.txtBarsBack.Size = new System.Drawing.Size(505, 61);
            this.txtBarsBack.TabIndex = 33;
            this.txtBarsBack.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "/Images";
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.SessionsTableAdapter = null;
            this.tableAdapterManager.SportTypesTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(419, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(126, 41);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoose.Location = new System.Drawing.Point(247, 14);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChoose.Size = new System.Drawing.Size(168, 41);
            this.btnChoose.TabIndex = 29;
            this.btnChoose.Text = "Seleccionar";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // FMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 757);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMat);
            this.Controls.Add(this.materialsBindingNavigator);
            this.Controls.Add(this.statusS1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMaterial";
            this.Text = "Materiales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMaterial_FormClosing);
            this.Load += new System.EventHandler(this.FMaterial_Load);
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingNavigator)).EndInit();
            this.materialsBindingNavigator.ResumeLayout(false);
            this.materialsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
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
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private TrainITDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialsBindingNavigator;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnDel;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnPrevious;
        private System.Windows.Forms.ToolStripButton tsBtnNext;
        private System.Windows.Forms.ToolStripButton tsBtnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuyMemo;
        private System.Windows.Forms.DateTimePicker dtpBuyDate;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInitDist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtUseTime;
        private System.Windows.Forms.TextBox txtUseDist;
        private System.Windows.Forms.TextBox txtRecDist;
        private System.Windows.Forms.MaskedTextBox mtxtInitTime;
        private System.Windows.Forms.MaskedTextBox mtxtRecTime;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.MaskedTextBox mtxtWeight;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtDistBar;
        private System.Windows.Forms.TextBox txtBarsBack;
        private System.Windows.Forms.TextBox txtTimeBar;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnCancelImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatBuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatTotTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatTotDist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;

    }
}