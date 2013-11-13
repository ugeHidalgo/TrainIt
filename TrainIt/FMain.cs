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
            DialogResult valor;
            valor = MessageBox.Show("¿Desea salir de la aplicacón?", "Atencíón", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            e.Cancel = (valor == DialogResult.Cancel);                
        }

        //Reloj de la aplicación para la hora y fecha
        private void timer1_Tick(object sender, EventArgs e)
        {
            sSTime.Text = DateTime.Now.ToString("HH:mm:ss");
            sSDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void mSMaterial_Click(object sender, EventArgs e)
        {
            //mSMaterial.Enabled = false;            
            FMaterial fMaterial = new FMaterial();
            //fMaterial.MdiParent = this;
            fMaterial.ShowDialog();
        }

        private void msUsuarios_Click(object sender, EventArgs e)
        {
            //FUsers fUsers = new FUsers();
            //fUsers.ShowDialog();
            FUserProfile fUserProfile = new FUserProfile();
            fUserProfile.OnNewMode = false;
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
            //fTrainings.MdiParent = this;
            fTrainings.ShowDialog();
        }

        private void tsBtnSessions_Click(object sender, EventArgs e)
        {
            FSessions fSessions = new FSessions();
            //fSessions.MdiParent = this;
            fSessions.ShowDialog();  
        }


    }
}
