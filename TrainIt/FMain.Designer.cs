namespace TrainIt
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.sS = new System.Windows.Forms.StatusStrip();
            this.sSDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.sSTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnStr = new System.Windows.Forms.ToolStripStatusLabel();
            this.mS = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mSSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sS.SuspendLayout();
            this.mS.SuspendLayout();
            this.SuspendLayout();
            // 
            // sS
            // 
            this.sS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sSDate,
            this.sSTime,
            this.tslConnStr});
            this.sS.Location = new System.Drawing.Point(0, 483);
            this.sS.Name = "sS";
            this.sS.Size = new System.Drawing.Size(732, 22);
            this.sS.TabIndex = 0;
            this.sS.Text = "statusStrip1";
            // 
            // sSDate
            // 
            this.sSDate.Name = "sSDate";
            this.sSDate.Size = new System.Drawing.Size(65, 17);
            this.sSDate.Text = "10/10/2013";
            // 
            // sSTime
            // 
            this.sSTime.Name = "sSTime";
            this.sSTime.Size = new System.Drawing.Size(34, 17);
            this.sSTime.Text = "09:13";
            // 
            // tslConnStr
            // 
            this.tslConnStr.Name = "tslConnStr";
            this.tslConnStr.Size = new System.Drawing.Size(109, 17);
            this.tslConnStr.Text = "Connection String :";
            // 
            // mS
            // 
            this.mS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mS.Location = new System.Drawing.Point(0, 0);
            this.mS.Name = "mS";
            this.mS.Size = new System.Drawing.Size(732, 24);
            this.mS.TabIndex = 1;
            this.mS.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSMaterial,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.mSSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mSMaterial
            // 
            this.mSMaterial.Image = ((System.Drawing.Image)(resources.GetObject("mSMaterial.Image")));
            this.mSMaterial.Name = "mSMaterial";
            this.mSMaterial.Size = new System.Drawing.Size(152, 22);
            this.mSMaterial.Text = "Material";
            this.mSMaterial.Click += new System.EventHandler(this.mSMaterial_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Usuarios";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mSSalir
            // 
            this.mSSalir.Image = ((System.Drawing.Image)(resources.GetObject("mSSalir.Image")));
            this.mSSalir.Name = "mSSalir";
            this.mSSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mSSalir.Size = new System.Drawing.Size(152, 22);
            this.mSSalir.Text = "Salir";
            this.mSSalir.Click += new System.EventHandler(this.mSSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 505);
            this.Controls.Add(this.sS);
            this.Controls.Add(this.mS);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mS;
            this.Name = "FMain";
            this.Text = "Train It!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.sS.ResumeLayout(false);
            this.sS.PerformLayout();
            this.mS.ResumeLayout(false);
            this.mS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sS;
        private System.Windows.Forms.MenuStrip mS;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mSSalir;
        private System.Windows.Forms.ToolStripStatusLabel sSDate;
        private System.Windows.Forms.ToolStripStatusLabel sSTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mSMaterial;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel tslConnStr;
    }
}

