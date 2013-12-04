using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainItLibrary;

namespace TrainIt
{
    public partial class FMain : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();
        public static bool closeAppWithQuestion=true;

        public FMain()
        {
            InitializeComponent();
            timer1.Enabled = true;
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();

            TrainItLibrary.Global.userNameWorking=fLogin.userNameGiven;
            TrainItLibrary.Global.userIDWorking = fLogin.userIDGiven;
            TrainItLibrary.Global.trainingUsed.Reset();

            tslConnStr.Text = connString;
            tslAppUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking + ")" + TrainItLibrary.Global.userNameWorking;
        }

        //Controla la salida de la aplicación
        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (closeAppWithQuestion)
            {
                DialogResult valor;
                valor = MessageBox.Show("¿Desea salir de la aplicacón?", "Atencíón", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                e.Cancel = (valor == DialogResult.Cancel);                 
            }
        }

        //Reloj de la aplicación para la hora y fecha
        private void timer1_Tick(object sender, EventArgs e)
        {
           sSTime.Text = DateTime.Now.ToString("HH:mm:ss");
           sSDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void mSMaterial_Click(object sender, EventArgs e)
        {           
            FMaterial fMaterial = new FMaterial();
            if (this.TopMost)
                fMaterial.TopMost = true;
            fMaterial.ShowDialog();
        }

        private void msUsuarios_Click(object sender, EventArgs e)
        {
            FUserProfile fUserProfile = new FUserProfile();
            fUserProfile.OnNewMode = false;
            if (this.TopMost)
                fUserProfile.TopMost = true;
            fUserProfile.ShowDialog();

            Global.userNameWorking = Global.userUsed.userName;
            Global.userIDWorking = Global.userUsed.userID;
            Global.trainingUsed.Reset();

            tslConnStr.Text = connString;
            tslAppUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking + ")" + TrainItLibrary.Global.userNameWorking;
        }

        private void msTiposDeportes_Click(object sender, EventArgs e)
        {
            FSportTypes fSportTypes = new FSportTypes();
            fSportTypes.OnSearchMode = false;
            if (this.TopMost)
                fSportTypes.TopMost = true;
            fSportTypes.ShowDialog();
        }
        
        private void mSSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnTrainings_Click(object sender, EventArgs e)
        {
            FTrainings fTrainings = new FTrainings();
            fTrainings.OnSearchMode = false;
            if (this.TopMost)
                fTrainings.TopMost = true;
            fTrainings.ShowDialog();
        }

        private void tsBtnSessions_Click(object sender, EventArgs e)
        {
            FSessions fSessions = new FSessions();
            if (this.TopMost)
                fSessions.TopMost = true; 
            fSessions.ShowDialog();
        }

        private void tsmiGlobales_Click(object sender, EventArgs e)
        {
            FEstadGlobal fEstadGlobal = new FEstadGlobal();
            fEstadGlobal.MdiParent = this;
            fEstadGlobal.Show();
        }

        private void tsmiDeporte_Click(object sender, EventArgs e)
        {
            FEstadSport fEstadSport = new FEstadSport();
            fEstadSport.MdiParent = this;
            fEstadSport.Show();
        }

        private void tsmiMosaicoHor_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void tsmiMosaicoVer_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void tsmiCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tsmiCerrarTodas_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void tsmiPantallaCompleta_Click(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                this.TopMost = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void tsmiPersonalBestTypes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("At work");
        }

        private void tsmiRegistros_Click(object sender, EventArgs e)
        {
            FBioRegs fBioRegs = new FBioRegs();
            fBioRegs.ShowDialog();
        }

    }
}
