namespace TrainIt
{
    partial class FSportTypes
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
            System.Windows.Forms.Label userMailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSportTypes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolS1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.statusS1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnString = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvSTypes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtSportTypeID = new System.Windows.Forms.TextBox();
            this.txtSportTypeName = new System.Windows.Forms.TextBox();
            this.txtParentSportTypeID = new System.Windows.Forms.TextBox();
            this.sportTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainITDataSet = new TrainIt.TrainITDataSet();
            this.chBxNoFamily = new System.Windows.Forms.CheckBox();
            this.cbxSportTypeName = new System.Windows.Forms.ComboBox();
            this.sportTypesTableAdapter1 = new TrainIt.TrainITDataSetTableAdapters.SportTypesTableAdapter();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            userIDLabel = new System.Windows.Forms.Label();
            userFirstNameLabel = new System.Windows.Forms.Label();
            userSecondNameLabel = new System.Windows.Forms.Label();
            userMailLabel = new System.Windows.Forms.Label();
            this.toolS1.SuspendLayout();
            this.statusS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIDLabel.Location = new System.Drawing.Point(105, 49);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(67, 20);
            userIDLabel.TabIndex = 15;
            userIDLabel.Text = "Código :";
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userFirstNameLabel.Location = new System.Drawing.Point(-1, 78);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new System.Drawing.Size(173, 20);
            userFirstNameLabel.TabIndex = 17;
            userFirstNameLabel.Text = "Nombre Tipo Deporte : ";
            // 
            // userSecondNameLabel
            // 
            userSecondNameLabel.AutoSize = true;
            userSecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userSecondNameLabel.Location = new System.Drawing.Point(32, 112);
            userSecondNameLabel.Name = "userSecondNameLabel";
            userSecondNameLabel.Size = new System.Drawing.Size(140, 20);
            userSecondNameLabel.TabIndex = 19;
            userSecondNameLabel.Text = "Pertenece al tipo : ";
            // 
            // userMailLabel
            // 
            userMailLabel.AutoSize = true;
            userMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userMailLabel.Location = new System.Drawing.Point(72, 169);
            userMailLabel.Name = "userMailLabel";
            userMailLabel.Size = new System.Drawing.Size(100, 20);
            userMailLabel.TabIndex = 22;
            userMailLabel.Text = "Descripción :";
            // 
            // toolS1
            // 
            this.toolS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFirst,
            this.tsBtnPrevious,
            this.tsBtnNext,
            this.tsBtnLast,
            this.toolStripSeparator1,
            this.tsBtnNew,
            this.tsBtnEdit,
            this.tsBtnCancel,
            this.tsBtnSave,
            this.tsBtnDel});
            this.toolS1.Location = new System.Drawing.Point(0, 0);
            this.toolS1.Name = "toolS1";
            this.toolS1.Size = new System.Drawing.Size(588, 25);
            this.toolS1.TabIndex = 2;
            this.toolS1.Text = "toolStrip1";
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
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancel.Image")));
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCancel.Text = "Cancelar edición.";
            this.tsBtnCancel.Click += new System.EventHandler(this.tsBtnCancel_Click);
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
            // tsBtnDel
            // 
            this.tsBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDel.Image")));
            this.tsBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDel.Text = "Borrar registro";
            this.tsBtnDel.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // statusS1
            // 
            this.statusS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslConnString});
            this.statusS1.Location = new System.Drawing.Point(0, 673);
            this.statusS1.Name = "statusS1";
            this.statusS1.Size = new System.Drawing.Size(588, 22);
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
            // dgvSTypes
            // 
            this.dgvSTypes.AllowUserToAddRows = false;
            this.dgvSTypes.AllowUserToDeleteRows = false;
            this.dgvSTypes.AllowUserToOrderColumns = true;
            this.dgvSTypes.AllowUserToResizeRows = false;
            this.dgvSTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SportTypeName,
            this.ParentID,
            this.parentName,
            this.memo,
            this.userID});
            this.dgvSTypes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSTypes.Location = new System.Drawing.Point(0, 273);
            this.dgvSTypes.Name = "dgvSTypes";
            this.dgvSTypes.ReadOnly = true;
            this.dgvSTypes.RowHeadersVisible = false;
            this.dgvSTypes.Size = new System.Drawing.Size(588, 400);
            this.dgvSTypes.TabIndex = 4;
            this.dgvSTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTypes_CellDoubleClick);
            this.dgvSTypes.Click += new System.EventHandler(this.dgvSTypes_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SportTypeID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // SportTypeName
            // 
            this.SportTypeName.DataPropertyName = "SportTypeName";
            this.SportTypeName.HeaderText = "Nombre";
            this.SportTypeName.Name = "SportTypeName";
            this.SportTypeName.ReadOnly = true;
            // 
            // ParentID
            // 
            this.ParentID.DataPropertyName = "ParentSportTypeID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ParentID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ParentID.HeaderText = "";
            this.ParentID.Name = "ParentID";
            this.ParentID.ReadOnly = true;
            this.ParentID.Width = 30;
            // 
            // parentName
            // 
            this.parentName.DataPropertyName = "FamilyName";
            this.parentName.HeaderText = "Familia";
            this.parentName.Name = "parentName";
            this.parentName.ReadOnly = true;
            // 
            // memo
            // 
            this.memo.DataPropertyName = "Memo";
            this.memo.HeaderText = "descripción";
            this.memo.Name = "memo";
            this.memo.ReadOnly = true;
            this.memo.Width = 300;
            // 
            // userID
            // 
            this.userID.DataPropertyName = "UserID";
            this.userID.HeaderText = "Usuario";
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Visible = false;
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemo.Location = new System.Drawing.Point(178, 169);
            this.txtMemo.MaxLength = 200;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(378, 87);
            this.txtMemo.TabIndex = 21;
            // 
            // txtSportTypeID
            // 
            this.txtSportTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSportTypeID.Location = new System.Drawing.Point(178, 43);
            this.txtSportTypeID.Name = "txtSportTypeID";
            this.txtSportTypeID.ReadOnly = true;
            this.txtSportTypeID.Size = new System.Drawing.Size(73, 26);
            this.txtSportTypeID.TabIndex = 16;
            this.txtSportTypeID.TabStop = false;
            // 
            // txtSportTypeName
            // 
            this.txtSportTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSportTypeName.Location = new System.Drawing.Point(178, 75);
            this.txtSportTypeName.MaxLength = 50;
            this.txtSportTypeName.Name = "txtSportTypeName";
            this.txtSportTypeName.Size = new System.Drawing.Size(378, 26);
            this.txtSportTypeName.TabIndex = 18;
            // 
            // txtParentSportTypeID
            // 
            this.txtParentSportTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sportTypesBindingSource, "SportTypeID", true));
            this.txtParentSportTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentSportTypeID.Location = new System.Drawing.Point(178, 109);
            this.txtParentSportTypeID.MaxLength = 50;
            this.txtParentSportTypeID.Name = "txtParentSportTypeID";
            this.txtParentSportTypeID.ReadOnly = true;
            this.txtParentSportTypeID.Size = new System.Drawing.Size(73, 26);
            this.txtParentSportTypeID.TabIndex = 20;
            this.txtParentSportTypeID.TabStop = false;
            // 
            // sportTypesBindingSource
            // 
            this.sportTypesBindingSource.DataMember = "SportTypes";
            this.sportTypesBindingSource.DataSource = this.trainITDataSet;
            // 
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chBxNoFamily
            // 
            this.chBxNoFamily.AutoSize = true;
            this.chBxNoFamily.Checked = true;
            this.chBxNoFamily.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBxNoFamily.Enabled = false;
            this.chBxNoFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxNoFamily.Location = new System.Drawing.Point(178, 142);
            this.chBxNoFamily.Name = "chBxNoFamily";
            this.chBxNoFamily.Size = new System.Drawing.Size(247, 24);
            this.chBxNoFamily.TabIndex = 24;
            this.chBxNoFamily.Text = "No pertenece a ninguna familia";
            this.chBxNoFamily.UseVisualStyleBackColor = true;
            this.chBxNoFamily.CheckStateChanged += new System.EventHandler(this.chBxNoFamily_CheckedChanged);
            // 
            // cbxSportTypeName
            // 
            this.cbxSportTypeName.DataSource = this.sportTypesBindingSource;
            this.cbxSportTypeName.DisplayMember = "SportTypeName";
            this.cbxSportTypeName.Enabled = false;
            this.cbxSportTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSportTypeName.FormattingEnabled = true;
            this.cbxSportTypeName.Location = new System.Drawing.Point(257, 109);
            this.cbxSportTypeName.Name = "cbxSportTypeName";
            this.cbxSportTypeName.Size = new System.Drawing.Size(299, 28);
            this.cbxSportTypeName.TabIndex = 23;
            this.cbxSportTypeName.ValueMember = "SportTypeID";
            this.cbxSportTypeName.SelectedValueChanged += new System.EventHandler(this.cbxSportTypeName_SelectedValueChanged);
            // 
            // sportTypesTableAdapter1
            // 
            this.sportTypesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoose.Location = new System.Drawing.Point(315, 28);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChoose.Size = new System.Drawing.Size(141, 41);
            this.btnChoose.TabIndex = 25;
            this.btnChoose.Text = "Seleccionar";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(462, 28);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 41);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FSportTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 695);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.chBxNoFamily);
            this.Controls.Add(this.cbxSportTypeName);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.txtSportTypeID);
            this.Controls.Add(userFirstNameLabel);
            this.Controls.Add(this.txtSportTypeName);
            this.Controls.Add(userSecondNameLabel);
            this.Controls.Add(this.txtParentSportTypeID);
            this.Controls.Add(userMailLabel);
            this.Controls.Add(this.dgvSTypes);
            this.Controls.Add(this.statusS1);
            this.Controls.Add(this.toolS1);
            this.Name = "FSportTypes";
            this.Text = "Tipos de deporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSportTypes_FormClosing);
            this.Load += new System.EventHandler(this.FSportTypes_Load);
            this.toolS1.ResumeLayout(false);
            this.toolS1.PerformLayout();
            this.statusS1.ResumeLayout(false);
            this.statusS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolS1;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnPrevious;
        private System.Windows.Forms.ToolStripButton tsBtnNext;
        private System.Windows.Forms.ToolStripButton tsBtnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnDel;
        private System.Windows.Forms.StatusStrip statusS1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslConnString;
        private System.Windows.Forms.DataGridView dgvSTypes;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtSportTypeID;
        private System.Windows.Forms.TextBox txtSportTypeName;
        private System.Windows.Forms.TextBox txtParentSportTypeID;
        private System.Windows.Forms.CheckBox chBxNoFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.ComboBox cbxSportTypeName;
        private TrainITDataSetTableAdapters.SportTypesTableAdapter sportTypesTableAdapter1;
        private System.Windows.Forms.BindingSource sportTypesBindingSource;
        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCancel;
    }
}