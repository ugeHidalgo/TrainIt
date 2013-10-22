using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FUsers fUsers = new FUsers();
            fUsers.ShowDialog();
        }

        private void msTiposDeportes_Click(object sender, EventArgs e)
        {
            FSportTypes fSportTypes = new FSportTypes();
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





    }
}
