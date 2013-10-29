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
    public partial class FSessions : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();
        int userIDWorking = TrainItLibrary.Global.userIDWorking;
        bool onEdition = false;

        public FSessions()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking + ")" + TrainItLibrary.Global.userNameWorking;

            setNormalMode();
        }

        private void FSessions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana actual.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            else e.Cancel = false;
        }

        private void setEditMode()
        {
            onEdition = true;
        }

        private void setNormalMode()
        {
            onEdition = false;
        }

        private void resetFields()
        {

        }

        private void FSessions_Load(object sender, EventArgs e)
        {
            //Load data for sessions
            this.sessionsTableAdapter.Fill(this.trainITDataSet.Sessions, userIDWorking);
        }

        private void trainIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void trainIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindTrain_Click(object sender, EventArgs e)
        {
            FTrainings fTrainings = new FTrainings();
            fTrainings.ShowDialog();

            txtTrainID.Text = TrainItLibrary.Global.trainingUsed.TrainID.ToString();
            txtTrainName.Text = TrainItLibrary.Global.trainingUsed.TrainName;
        }

        private void btnSportType_Click(object sender, EventArgs e)
        {
            FSportTypes fSportTypes = new FSportTypes();
            fSportTypes.ShowDialog();

        }
    }
}
