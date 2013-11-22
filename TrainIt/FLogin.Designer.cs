namespace TrainIt
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.bTShowPass = new System.Windows.Forms.Button();
            this.laNewUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAccept
            // 
            this.btAccept.Image = ((System.Drawing.Image)(resources.GetObject("btAccept.Image")));
            this.btAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccept.Location = new System.Drawing.Point(49, 299);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(75, 25);
            this.btAccept.TabIndex = 4;
            this.btAccept.Text = "Aceptar";
            this.btAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(151, 298);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 26);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancelar";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(12, 165);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(247, 29);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "uge";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(16, 241);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(219, 29);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Passw0rd.";
            // 
            // bTShowPass
            // 
            this.bTShowPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bTShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTShowPass.Image = ((System.Drawing.Image)(resources.GetObject("bTShowPass.Image")));
            this.bTShowPass.Location = new System.Drawing.Point(230, 241);
            this.bTShowPass.Name = "bTShowPass";
            this.bTShowPass.Size = new System.Drawing.Size(29, 29);
            this.bTShowPass.TabIndex = 3;
            this.bTShowPass.UseVisualStyleBackColor = false;
            this.bTShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bTShowPass_MouseDown);
            this.bTShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bTShowPass_MouseUp);
            // 
            // laNewUser
            // 
            this.laNewUser.AutoSize = true;
            this.laNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNewUser.ForeColor = System.Drawing.Color.Blue;
            this.laNewUser.Location = new System.Drawing.Point(111, 142);
            this.laNewUser.Name = "laNewUser";
            this.laNewUser.Size = new System.Drawing.Size(134, 16);
            this.laNewUser.TabIndex = 6;
            this.laNewUser.Text = "Crear Nuevo Usuario";
            this.laNewUser.Click += new System.EventHandler(this.laNewUser_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 353);
            this.ControlBox = false;
            this.Controls.Add(this.laNewUser);
            this.Controls.Add(this.bTShowPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FLogin";
            this.Text = "Acceso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button bTShowPass;
        private System.Windows.Forms.Label laNewUser;
    }
}