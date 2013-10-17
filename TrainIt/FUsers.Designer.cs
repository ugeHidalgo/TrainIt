namespace TrainIt
{
    partial class FUsers
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userFirstNameLabel;
            System.Windows.Forms.Label userSecondNameLabel;
            System.Windows.Forms.Label userBDateLabel;
            System.Windows.Forms.Label userMailLabel;
            System.Windows.Forms.Label userPassLabel;
            System.Windows.Forms.Label userNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUsers));
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolS1 = new System.Windows.Forms.ToolStrip();
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new TrainIt.TrainITDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new TrainIt.TrainITDataSetTableAdapters.TableAdapterManager();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsTxtPosition = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userIDLabel = new System.Windows.Forms.Label();
            userFirstNameLabel = new System.Windows.Forms.Label();
            userSecondNameLabel = new System.Windows.Forms.Label();
            userBDateLabel = new System.Windows.Forms.Label();
            userMailLabel = new System.Windows.Forms.Label();
            userPassLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            this.statusS1.SuspendLayout();
            this.toolS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIDLabel.Location = new System.Drawing.Point(18, 66);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(67, 20);
            userIDLabel.TabIndex = 4;
            userIDLabel.Text = "Código :";
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userFirstNameLabel.Location = new System.Drawing.Point(6, 101);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new System.Drawing.Size(73, 20);
            userFirstNameLabel.TabIndex = 6;
            userFirstNameLabel.Text = "Nombre :";
            // 
            // userSecondNameLabel
            // 
            userSecondNameLabel.AutoSize = true;
            userSecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userSecondNameLabel.Location = new System.Drawing.Point(249, 101);
            userSecondNameLabel.Name = "userSecondNameLabel";
            userSecondNameLabel.Size = new System.Drawing.Size(81, 20);
            userSecondNameLabel.TabIndex = 8;
            userSecondNameLabel.Text = "Apellidos :";
            // 
            // userBDateLabel
            // 
            userBDateLabel.AutoSize = true;
            userBDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userBDateLabel.Location = new System.Drawing.Point(433, 133);
            userBDateLabel.Name = "userBDateLabel";
            userBDateLabel.Size = new System.Drawing.Size(112, 20);
            userBDateLabel.TabIndex = 10;
            userBDateLabel.Text = "F. nacimiento :";
            // 
            // userMailLabel
            // 
            userMailLabel.AutoSize = true;
            userMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userMailLabel.Location = new System.Drawing.Point(14, 134);
            userMailLabel.Name = "userMailLabel";
            userMailLabel.Size = new System.Drawing.Size(65, 20);
            userMailLabel.TabIndex = 14;
            userMailLabel.Text = "Correo :";
            // 
            // userPassLabel
            // 
            userPassLabel.AutoSize = true;
            userPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userPassLabel.Location = new System.Drawing.Point(68, 64);
            userPassLabel.Name = "userPassLabel";
            userPassLabel.Size = new System.Drawing.Size(86, 20);
            userPassLabel.TabIndex = 20;
            userPassLabel.Text = "Password :";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(82, 31);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(72, 20);
            userNameLabel.TabIndex = 18;
            userNameLabel.Text = "Usuario :";
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 544);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(692, 22);
            this.statusS1.TabIndex = 0;
            this.statusS1.Text = "statusStrip1";
            // 
            // tslConnString
            // 
            this.tslConnString.Name = "tslConnString";
            this.tslConnString.Size = new System.Drawing.Size(79, 17);
            this.tslConnString.Text = "Conn String : ";
            // 
            // toolS1
            // 
            this.toolS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFirst,
            this.tsBtnPrevious,
            this.tsTxtPosition,
            this.tsBtnNext,
            this.tsBtnLast,
            this.toolStripSeparator1,
            this.tsBtnNew,
            this.tsBtnEdit,
            this.tsBtnDelete,
            this.tsBtnSave,
            this.tsBtnCancel});
            this.toolS1.Location = new System.Drawing.Point(0, 0);
            this.toolS1.Name = "toolS1";
            this.toolS1.Size = new System.Drawing.Size(692, 25);
            this.toolS1.TabIndex = 1;
            this.toolS1.Text = "toolStrip1";
            // 
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.trainITDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialSessionTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = null;
            this.tableAdapterManager.SportsTableAdapter = null;
            this.tableAdapterManager.SportTypesTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrainIt.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRegsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // txtUserID
            // 
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserID", true));
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(85, 60);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(147, 26);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(85, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(147, 26);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtSecondName
            // 
            this.txtSecondName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserSecondName", true));
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(336, 95);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(335, 26);
            this.txtSecondName.TabIndex = 8;
            // 
            // dtpBDate
            // 
            this.dtpBDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "UserBDate", true));
            this.dtpBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBDate.Location = new System.Drawing.Point(551, 128);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(120, 26);
            this.dtpBDate.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laConfirm);
            this.groupBox1.Controls.Add(this.txtConfirm);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(userPassLabel);
            this.groupBox1.Controls.Add(this.txtUserPass);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(106, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 137);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso al programa";
            // 
            // laConfirm
            // 
            this.laConfirm.AutoSize = true;
            this.laConfirm.Location = new System.Drawing.Point(20, 97);
            this.laConfirm.Name = "laConfirm";
            this.laConfirm.Size = new System.Drawing.Size(134, 20);
            this.laConfirm.TabIndex = 22;
            this.laConfirm.Text = "Repetir Pasword :";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(160, 91);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(202, 26);
            this.txtConfirm.TabIndex = 13;
            this.txtConfirm.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(160, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 26);
            this.txtUserName.TabIndex = 11;
            // 
            // txtUserPass
            // 
            this.txtUserPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserPass", true));
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(160, 58);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(202, 26);
            this.txtUserPass.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserMail", true));
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(85, 128);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(330, 26);
            this.txtMail.TabIndex = 9;
            // 
            // tsBtnFirst
            // 
            this.tsBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFirst.Image")));
            this.tsBtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFirst.Name = "tsBtnFirst";
            this.tsBtnFirst.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFirst.Text = "Primer registro";
            this.tsBtnFirst.Click += new System.EventHandler(this.tsBtnFirst_Click);
            // 
            // tsBtnPrevious
            // 
            this.tsBtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrevious.Image")));
            this.tsBtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrevious.Name = "tsBtnPrevious";
            this.tsBtnPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrevious.Text = "Registro anterior";
            this.tsBtnPrevious.Click += new System.EventHandler(this.tsBtnPrevious_Click);
            // 
            // tsTxtPosition
            // 
            this.tsTxtPosition.Name = "tsTxtPosition";
            this.tsTxtPosition.Size = new System.Drawing.Size(50, 25);
            // 
            // tsBtnNext
            // 
            this.tsBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNext.Image")));
            this.tsBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNext.Name = "tsBtnNext";
            this.tsBtnNext.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNext.Text = "Registro siguiente";
            this.tsBtnNext.Click += new System.EventHandler(this.tsBtnNext_Click);
            // 
            // tsBtnLast
            // 
            this.tsBtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLast.Image")));
            this.tsBtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLast.Name = "tsBtnLast";
            this.tsBtnLast.Size = new System.Drawing.Size(23, 22);
            this.tsBtnLast.Text = "Último registro";
            this.tsBtnLast.Click += new System.EventHandler(this.tsBtnLast_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNew.Image")));
            this.tsBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNew.Text = "Nuevo registro";
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
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
            // tsBtnDelete
            // 
            this.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelete.Text = "Borrar registro";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "Grabar registro";
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancel.Image")));
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCancel.Text = "Cancelar edición de registro";
            this.tsBtnCancel.Click += new System.EventHandler(this.tsBtnCancel_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.userName,
            this.userFirstName,
            this.UserLastName,
            this.userBDate,
            this.userMail});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.Location = new System.Drawing.Point(0, 339);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.Size = new System.Drawing.Size(692, 205);
            this.dgvUsers.TabIndex = 19;
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "Código";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "UserName";
            this.userName.HeaderText = "Usuario";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 60;
            // 
            // userFirstName
            // 
            this.userFirstName.DataPropertyName = "UserFirstName";
            this.userFirstName.HeaderText = "Nombre";
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.ReadOnly = true;
            // 
            // UserLastName
            // 
            this.UserLastName.DataPropertyName = "UserSecondName";
            this.UserLastName.HeaderText = "Apellidos";
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.ReadOnly = true;
            this.UserLastName.Width = 180;
            // 
            // userBDate
            // 
            this.userBDate.DataPropertyName = "UserBDate";
            this.userBDate.HeaderText = "F.Nac.";
            this.userBDate.Name = "userBDate";
            this.userBDate.ReadOnly = true;
            this.userBDate.Width = 80;
            // 
            // userMail
            // 
            this.userMail.DataPropertyName = "UserMail";
            this.userMail.HeaderText = "Mail";
            this.userMail.Name = "userMail";
            this.userMail.ReadOnly = true;
            this.userMail.Width = 140;
            // 
            // FUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 566);
            this.Controls.Add(this.dgvUsers);
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
            this.Controls.Add(this.toolS1);
            this.Controls.Add(this.statusS1);
            this.Name = "FUsers";
            this.Text = " Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FUsers_FormClosing);
            this.Load += new System.EventHandler(this.FUsers_Load);
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            this.toolS1.ResumeLayout(false);
            this.toolS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusS1;
        private System.Windows.Forms.ToolStripStatusLabel tslConnString;
        private System.Windows.Forms.ToolStrip toolS1;
        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private TrainITDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label laConfirm;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnPrevious;
        private System.Windows.Forms.ToolStripTextBox tsTxtPosition;
        private System.Windows.Forms.ToolStripButton tsBtnNext;
        private System.Windows.Forms.ToolStripButton tsBtnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMail;
    }
}