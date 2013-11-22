namespace TrainIt
{
    partial class FUserProfile
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
            System.Windows.Forms.Label userPassLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userFirstNameLabel;
            System.Windows.Forms.Label userSecondNameLabel;
            System.Windows.Forms.Label userBDateLabel;
            System.Windows.Forms.Label userMailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUserProfile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTShowPass = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.laConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUserSports = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempUserSportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.btnDelAllSports = new System.Windows.Forms.Button();
            this.btnDelSport = new System.Windows.Forms.Button();
            this.btnFindSport = new System.Windows.Forms.Button();
            this.tempUserSportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportTypesTableAdapter = new TrainIt.TrainITDataSetTableAdapters.SportTypesTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.userSportsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.UserSportsTableAdapter();
            this.tempUserSportsTableAdapter = new TrainIt.TrainITDataSetTableAdapters.TempUserSportsTableAdapter();
            this.btnBorrar = new System.Windows.Forms.Button();
            userPassLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            userFirstNameLabel = new System.Windows.Forms.Label();
            userSecondNameLabel = new System.Windows.Forms.Label();
            userBDateLabel = new System.Windows.Forms.Label();
            userMailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUserSportsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUserSportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userPassLabel
            // 
            userPassLabel.AutoSize = true;
            userPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userPassLabel.Location = new System.Drawing.Point(98, 100);
            userPassLabel.Name = "userPassLabel";
            userPassLabel.Size = new System.Drawing.Size(86, 20);
            userPassLabel.TabIndex = 20;
            userPassLabel.Text = "Password :";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(112, 67);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(72, 20);
            userNameLabel.TabIndex = 18;
            userNameLabel.Text = "Usuario :";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIDLabel.Location = new System.Drawing.Point(61, 28);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(67, 20);
            userIDLabel.TabIndex = 19;
            userIDLabel.Text = "Código :";
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userFirstNameLabel.Location = new System.Drawing.Point(55, 62);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new System.Drawing.Size(73, 20);
            userFirstNameLabel.TabIndex = 21;
            userFirstNameLabel.Text = "Nombre :";
            // 
            // userSecondNameLabel
            // 
            userSecondNameLabel.AutoSize = true;
            userSecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userSecondNameLabel.Location = new System.Drawing.Point(47, 96);
            userSecondNameLabel.Name = "userSecondNameLabel";
            userSecondNameLabel.Size = new System.Drawing.Size(81, 20);
            userSecondNameLabel.TabIndex = 23;
            userSecondNameLabel.Text = "Apellidos :";
            // 
            // userBDateLabel
            // 
            userBDateLabel.AutoSize = true;
            userBDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userBDateLabel.Location = new System.Drawing.Point(16, 164);
            userBDateLabel.Name = "userBDateLabel";
            userBDateLabel.Size = new System.Drawing.Size(112, 20);
            userBDateLabel.TabIndex = 26;
            userBDateLabel.Text = "F. nacimiento :";
            // 
            // userMailLabel
            // 
            userMailLabel.AutoSize = true;
            userMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userMailLabel.Location = new System.Drawing.Point(63, 130);
            userMailLabel.Name = "userMailLabel";
            userMailLabel.Size = new System.Drawing.Size(65, 20);
            userMailLabel.TabIndex = 28;
            userMailLabel.Text = "Correo :";
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(134, 128);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(323, 26);
            this.txtMail.TabIndex = 25;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bTShowPass);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.laConfirm);
            this.groupBox1.Controls.Add(this.txtConfirm);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(userPassLabel);
            this.groupBox1.Controls.Add(this.txtUserPass);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 177);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso al programa";
            // 
            // bTShowPass
            // 
            this.bTShowPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bTShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTShowPass.Image = ((System.Drawing.Image)(resources.GetObject("bTShowPass.Image")));
            this.bTShowPass.Location = new System.Drawing.Point(391, 94);
            this.bTShowPass.Name = "bTShowPass";
            this.bTShowPass.Size = new System.Drawing.Size(26, 26);
            this.bTShowPass.TabIndex = 31;
            this.bTShowPass.UseVisualStyleBackColor = false;
            this.bTShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bTShowPass_MouseDown);
            this.bTShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bTShowPass_MouseUp);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(190, 25);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(202, 30);
            this.btnChangePassword.TabIndex = 30;
            this.btnChangePassword.Text = "Cambiar contraseña";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // laConfirm
            // 
            this.laConfirm.AutoSize = true;
            this.laConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laConfirm.Location = new System.Drawing.Point(45, 129);
            this.laConfirm.Name = "laConfirm";
            this.laConfirm.Size = new System.Drawing.Size(134, 20);
            this.laConfirm.TabIndex = 22;
            this.laConfirm.Text = "Repetir Pasword :";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Location = new System.Drawing.Point(190, 127);
            this.txtConfirm.MaxLength = 50;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.ReadOnly = true;
            this.txtConfirm.Size = new System.Drawing.Size(202, 26);
            this.txtConfirm.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(190, 61);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 26);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtUserPass
            // 
            this.txtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(190, 94);
            this.txtUserPass.MaxLength = 50;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.ReadOnly = true;
            this.txtUserPass.Size = new System.Drawing.Size(202, 26);
            this.txtUserPass.TabIndex = 12;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(134, 26);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(69, 26);
            this.txtUserID.TabIndex = 20;
            this.txtUserID.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(134, 60);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(323, 26);
            this.txtFirstName.TabIndex = 22;
            // 
            // txtSecondName
            // 
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(134, 94);
            this.txtSecondName.MaxLength = 50;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(323, 26);
            this.txtSecondName.TabIndex = 24;
            // 
            // dtpBDate
            // 
            this.dtpBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBDate.Location = new System.Drawing.Point(134, 162);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(120, 26);
            this.dtpBDate.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(289, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnSave.Size = new System.Drawing.Size(166, 32);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Grabar Cambios";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(180, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUserSports);
            this.groupBox2.Controls.Add(this.btnDelAllSports);
            this.groupBox2.Controls.Add(this.btnDelSport);
            this.groupBox2.Controls.Add(this.btnFindSport);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(463, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 418);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deportes principales";
            // 
            // dgvUserSports
            // 
            this.dgvUserSports.AllowUserToAddRows = false;
            this.dgvUserSports.AllowUserToDeleteRows = false;
            this.dgvUserSports.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            this.dgvUserSports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserSports.AutoGenerateColumns = false;
            this.dgvUserSports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserSports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.SportTypeName,
            this.ParentName,
            this.dataGridViewTextBoxColumn1});
            this.dgvUserSports.DataSource = this.tempUserSportsBindingSource1;
            this.dgvUserSports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUserSports.Location = new System.Drawing.Point(3, 68);
            this.dgvUserSports.Name = "dgvUserSports";
            this.dgvUserSports.ReadOnly = true;
            this.dgvUserSports.RowHeadersVisible = false;
            this.dgvUserSports.Size = new System.Drawing.Size(475, 347);
            this.dgvUserSports.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SportTypeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // SportTypeName
            // 
            this.SportTypeName.DataPropertyName = "SportTypeName";
            this.SportTypeName.HeaderText = "Nombre";
            this.SportTypeName.Name = "SportTypeName";
            this.SportTypeName.ReadOnly = true;
            this.SportTypeName.Width = 200;
            // 
            // ParentName
            // 
            this.ParentName.DataPropertyName = "ParentName";
            this.ParentName.HeaderText = "Familia";
            this.ParentName.Name = "ParentName";
            this.ParentName.ReadOnly = true;
            this.ParentName.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // tempUserSportsBindingSource1
            // 
            this.tempUserSportsBindingSource1.DataMember = "TempUserSports";
            this.tempUserSportsBindingSource1.DataSource = this.trainITDataSet;
            // 
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelAllSports
            // 
            this.btnDelAllSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAllSports.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAllSports.Image")));
            this.btnDelAllSports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAllSports.Location = new System.Drawing.Point(258, 35);
            this.btnDelAllSports.Name = "btnDelAllSports";
            this.btnDelAllSports.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDelAllSports.Size = new System.Drawing.Size(119, 24);
            this.btnDelAllSports.TabIndex = 49;
            this.btnDelAllSports.Text = "Quitar Todos";
            this.btnDelAllSports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelAllSports.UseVisualStyleBackColor = true;
            this.btnDelAllSports.Click += new System.EventHandler(this.btnDelAllSports_Click);
            // 
            // btnDelSport
            // 
            this.btnDelSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSport.Image = ((System.Drawing.Image)(resources.GetObject("btnDelSport.Image")));
            this.btnDelSport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSport.Location = new System.Drawing.Point(133, 35);
            this.btnDelSport.Name = "btnDelSport";
            this.btnDelSport.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDelSport.Size = new System.Drawing.Size(119, 24);
            this.btnDelSport.TabIndex = 48;
            this.btnDelSport.Text = "Quitar Deporte";
            this.btnDelSport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelSport.UseVisualStyleBackColor = true;
            this.btnDelSport.Click += new System.EventHandler(this.btnDelSport_Click);
            // 
            // btnFindSport
            // 
            this.btnFindSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSport.Image = ((System.Drawing.Image)(resources.GetObject("btnFindSport.Image")));
            this.btnFindSport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindSport.Location = new System.Drawing.Point(3, 35);
            this.btnFindSport.Name = "btnFindSport";
            this.btnFindSport.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnFindSport.Size = new System.Drawing.Size(124, 24);
            this.btnFindSport.TabIndex = 47;
            this.btnFindSport.Text = "Añadir Deporte";
            this.btnFindSport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindSport.UseVisualStyleBackColor = true;
            this.btnFindSport.Click += new System.EventHandler(this.btnFindSport_Click);
            // 
            // tempUserSportsBindingSource
            // 
            this.tempUserSportsBindingSource.DataSource = this.trainITDataSet;
            this.tempUserSportsBindingSource.Position = 0;
            // 
            // userSportsBindingSource
            // 
            this.userSportsBindingSource.DataMember = "UserSports";
            this.userSportsBindingSource.DataSource = this.trainITDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = null;
            this.tableAdapterManager.SportTypesTableAdapter = this.sportTypesTableAdapter;
            this.tableAdapterManager.TempMaterialTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // userSportsTableAdapter
            // 
            this.userSportsTableAdapter.ClearBeforeFill = true;
            // 
            // tempUserSportsTableAdapter
            // 
            this.tempUserSportsTableAdapter.ClearBeforeFill = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(4, 410);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnBorrar.Size = new System.Drawing.Size(143, 32);
            this.btnBorrar.TabIndex = 33;
            this.btnBorrar.Text = "Borrar Usuario";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 458);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(userFirstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(userSecondNameLabel);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(userBDateLabel);
            this.Controls.Add(this.dtpBDate);
            this.Controls.Add(userMailLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FUserProfile";
            this.Text = "Perfil de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FUserProfile_FormClosing);
            this.Load += new System.EventHandler(this.FUserProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUserSportsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUserSportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label laConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bTShowPass;
        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.BindingSource sportTypesBindingSource;
        private TrainITDataSetTableAdapters.SportTypesTableAdapter sportTypesTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnDelAllSports;
        private System.Windows.Forms.Button btnDelSport;
        private System.Windows.Forms.Button btnFindSport;
        private System.Windows.Forms.BindingSource userSportsBindingSource;
        private TrainITDataSetTableAdapters.UserSportsTableAdapter userSportsTableAdapter;
        private System.Windows.Forms.BindingSource tempUserSportsBindingSource;
        private TrainITDataSetTableAdapters.TempUserSportsTableAdapter tempUserSportsTableAdapter;
        private System.Windows.Forms.DataGridView dgvUserSports;
        private System.Windows.Forms.BindingSource tempUserSportsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnBorrar;
    }
}