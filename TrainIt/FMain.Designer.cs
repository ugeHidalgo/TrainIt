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
            this.tslAppUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnStr = new System.Windows.Forms.ToolStripStatusLabel();
            this.mS = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.msUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mSSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnMaterial = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.msDeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.msTiposDeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenamientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biologicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosBioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sS.SuspendLayout();
            this.mS.SuspendLayout();
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sS
            // 
            this.sS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sSDate,
            this.sSTime,
            this.tslAppUser,
            this.tslConnStr});
            this.sS.Location = new System.Drawing.Point(0, 503);
            this.sS.Name = "sS";
            this.sS.Size = new System.Drawing.Size(982, 22);
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
            // tslAppUser
            // 
            this.tslAppUser.Name = "tslAppUser";
            this.tslAppUser.Size = new System.Drawing.Size(50, 17);
            this.tslAppUser.Text = "Usuario:";
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
            this.archivoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.entrenamientosToolStripMenuItem});
            this.mS.Location = new System.Drawing.Point(0, 0);
            this.mS.Name = "mS";
            this.mS.Size = new System.Drawing.Size(982, 24);
            this.mS.TabIndex = 1;
            this.mS.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSMaterial,
            this.msUsuarios,
            this.toolStripSeparator3,
            this.msDeportes,
            this.msTiposDeportes,
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
            this.mSMaterial.Size = new System.Drawing.Size(164, 22);
            this.mSMaterial.Text = "Material";
            this.mSMaterial.Click += new System.EventHandler(this.mSMaterial_Click);
            // 
            // msUsuarios
            // 
            this.msUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("msUsuarios.Image")));
            this.msUsuarios.Name = "msUsuarios";
            this.msUsuarios.Size = new System.Drawing.Size(164, 22);
            this.msUsuarios.Text = "Usuarios";
            this.msUsuarios.Click += new System.EventHandler(this.msUsuarios_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // mSSalir
            // 
            this.mSSalir.Image = ((System.Drawing.Image)(resources.GetObject("mSSalir.Image")));
            this.mSSalir.Name = "mSSalir";
            this.mSSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mSSalir.Size = new System.Drawing.Size(164, 22);
            this.mSSalir.Text = "Salir";
            this.mSSalir.Click += new System.EventHandler(this.mSSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMaterial,
            this.tsBtnUsuarios,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsBtnClose});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(982, 25);
            this.tsPrincipal.TabIndex = 3;
            this.tsPrincipal.Text = "toolStrip1";
            // 
            // tsBtnMaterial
            // 
            this.tsBtnMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMaterial.Image")));
            this.tsBtnMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMaterial.Name = "tsBtnMaterial";
            this.tsBtnMaterial.Size = new System.Drawing.Size(23, 22);
            this.tsBtnMaterial.Text = "Materiales";
            // 
            // tsBtnUsuarios
            // 
            this.tsBtnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnUsuarios.Image")));
            this.tsBtnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUsuarios.Name = "tsBtnUsuarios";
            this.tsBtnUsuarios.Size = new System.Drawing.Size(23, 22);
            this.tsBtnUsuarios.Text = "Usuarios";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnClose.Image")));
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(23, 22);
            this.tsBtnClose.Text = "Cerrar aplicación";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // msDeportes
            // 
            this.msDeportes.Image = ((System.Drawing.Image)(resources.GetObject("msDeportes.Image")));
            this.msDeportes.Name = "msDeportes";
            this.msDeportes.Size = new System.Drawing.Size(164, 22);
            this.msDeportes.Text = "Deportes";
            this.msDeportes.Click += new System.EventHandler(this.msDeportes_Click);
            // 
            // msTiposDeportes
            // 
            this.msTiposDeportes.Name = "msTiposDeportes";
            this.msTiposDeportes.Size = new System.Drawing.Size(164, 22);
            this.msTiposDeportes.Text = "Tipos de Deporte";
            this.msTiposDeportes.Click += new System.EventHandler(this.msTiposDeportes_Click);
            // 
            // entrenamientosToolStripMenuItem
            // 
            this.entrenamientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrenamientosToolStripMenuItem1,
            this.sesionesToolStripMenuItem,
            this.registrosPersonalesToolStripMenuItem});
            this.entrenamientosToolStripMenuItem.Name = "entrenamientosToolStripMenuItem";
            this.entrenamientosToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.entrenamientosToolStripMenuItem.Text = "Actividades";
            // 
            // entrenamientosToolStripMenuItem1
            // 
            this.entrenamientosToolStripMenuItem1.Name = "entrenamientosToolStripMenuItem1";
            this.entrenamientosToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.entrenamientosToolStripMenuItem1.Text = "Entrenamientos";
            // 
            // sesionesToolStripMenuItem
            // 
            this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sesionesToolStripMenuItem.Text = "Sesiones";
            // 
            // registrosPersonalesToolStripMenuItem
            // 
            this.registrosPersonalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biologicosToolStripMenuItem,
            this.marcasPersonalesToolStripMenuItem});
            this.registrosPersonalesToolStripMenuItem.Name = "registrosPersonalesToolStripMenuItem";
            this.registrosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.registrosPersonalesToolStripMenuItem.Text = "Registros";
            // 
            // biologicosToolStripMenuItem
            // 
            this.biologicosToolStripMenuItem.Name = "biologicosToolStripMenuItem";
            this.biologicosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.biologicosToolStripMenuItem.Text = "Biologicos";
            // 
            // marcasPersonalesToolStripMenuItem
            // 
            this.marcasPersonalesToolStripMenuItem.Name = "marcasPersonalesToolStripMenuItem";
            this.marcasPersonalesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.marcasPersonalesToolStripMenuItem.Text = "Marcas Personales";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.sesionesToolStripMenuItem1,
            this.registrosBioToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(36, 20);
            this.toolStripMenuItem2.Text = "Ver";
            // 
            // sesionesToolStripMenuItem1
            // 
            this.sesionesToolStripMenuItem1.Name = "sesionesToolStripMenuItem1";
            this.sesionesToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.sesionesToolStripMenuItem1.Text = "Sesiones";
            // 
            // registrosBioToolStripMenuItem
            // 
            this.registrosBioToolStripMenuItem.Name = "registrosBioToolStripMenuItem";
            this.registrosBioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.registrosBioToolStripMenuItem.Text = "Registros Bio";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem3.Text = "Entrenamientos";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.tsPrincipal);
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
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem msUsuarios;
        private System.Windows.Forms.ToolStripStatusLabel tslConnStr;
        private System.Windows.Forms.ToolStripStatusLabel tslAppUser;
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnMaterial;
        private System.Windows.Forms.ToolStripButton tsBtnUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem msDeportes;
        private System.Windows.Forms.ToolStripMenuItem msTiposDeportes;
        private System.Windows.Forms.ToolStripMenuItem entrenamientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenamientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrosBioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biologicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasPersonalesToolStripMenuItem;
    }
}

