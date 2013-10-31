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
    public partial class FSessions : Form
    {
        string connString = Utilities.GetConnString();
        Int64 userIDWorking = Global.userIDWorking;
        Boolean onEdition=false;

        public FSessions()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + Global.userIDWorking + ")" + Global.userNameWorking;

            setNormalMode();
        }

        private void setNormalMode()
        {
            onEdition = false;

            tsBtnFirst.Enabled = true;
            tsBtnPrevious.Enabled = true;
            tsBtnNext.Enabled = true;
            tsBtnLast.Enabled = true;
            tsBtnNew.Enabled = true;
            tsBtnEdit.Enabled = true;
            tsBtnCancel.Enabled = false;
            tsBtnSave.Enabled = false;
            tsBtnDelete.Enabled = true;

            btnFindSportType.Enabled = false;
            btnFindTrain.Enabled = false;

            dgvSessions.Enabled = true;
            
            dtpDate.Enabled = false;
            txtDist.ReadOnly = true;
            txtTime.ReadOnly = true;
            txtMedHR.ReadOnly = true;
            txtMaxHR.ReadOnly = true;
            txtValue.ReadOnly = true;
            txtMemo.ReadOnly = true;
            chbxComp.Enabled = false;
            chBxTrns.Enabled = false;
        }

        private void setEditMode()
        {
            onEdition = true;

            tsBtnFirst.Enabled = false;
            tsBtnPrevious.Enabled = false;
            tsBtnNext.Enabled = false;
            tsBtnLast.Enabled = false;
            tsBtnNew.Enabled = false;
            tsBtnEdit.Enabled = false;
            tsBtnCancel.Enabled = true;
            tsBtnSave.Enabled = true;
            tsBtnDelete.Enabled = false;

            btnFindSportType.Enabled = true;
            btnFindTrain.Enabled = true;

            dgvSessions.Enabled = false;

            dtpDate.Enabled = true;
            txtDist.ReadOnly = false;
            txtTime.ReadOnly = false;
            txtMedHR.ReadOnly = false;
            txtMaxHR.ReadOnly = false;
            txtValue.ReadOnly = false;
            txtMemo.ReadOnly = false;
            chbxComp.Enabled = true;
            chBxTrns.Enabled = true;
        }

        private void LoadData()
        {
            // TODO: This line of code loads data into the 'trainITDataSet.Sessions' table. You can move, or remove it, as needed.
            this.sessionsTableAdapter.FillBy(this.trainITDataSet.Sessions, userIDWorking);
            Int64 aSportTypeID = Convert.ToInt64(txtSportTypeID.Text);
            Int64 aTrainID = Convert.ToInt64(txtTrainID.Text);

            // TODO: This line of code loads data into the 'trainITDataSet.SportTypes' table. You can move, or remove it, as needed.
            this.sportTypesTableAdapter.FillByID(this.trainITDataSet.SportTypes, aSportTypeID);
            // TODO: This line of code loads data into the 'trainITDataSet.Trainings' table. You can move, or remove it, as needed.
            this.trainingsTableAdapter.FillByID(this.trainITDataSet.Trainings, aTrainID);
        }

        private void FSessions_Load(object sender, EventArgs e)
        {
            LoadData();      
        }

        private void txtTrainID_TextChanged(object sender, EventArgs e)
        {
            try 
	        {
                Int64 aTrainID = Convert.ToInt64(txtTrainID.Text);
                // TODO: This line of code loads data into the 'trainITDataSet.Trainings' table. You can move, or remove it, as needed.
                this.trainingsTableAdapter.FillByID(this.trainITDataSet.Trainings, aTrainID);   
        	}
	        catch (Exception)
	        {
                txtTrainID.Text = "";
                txtTrainName.Text = "";
	        }                                    
        }

        private void txtSportTypeID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 aSportTypeID = Convert.ToInt64(txtSportTypeID.Text);

                // TODO: This line of code loads data into the 'trainITDataSet.SportTypes' table. You can move, or remove it, as needed.
                this.sportTypesTableAdapter.FillByID(this.trainITDataSet.SportTypes, aSportTypeID);
            }
            catch (Exception)
            {
                txtSportTypeID.Text = "";
                txtSportTypeName.Text = "";
            }
        }

        private void btnFindTrain_Click(object sender, EventArgs e)
        {
            FTrainings fTrainings = new FTrainings();
            fTrainings.OnSearchMode=true;
            fTrainings.ShowDialog();

            if (fTrainings.OnSearchMode)
            {
                txtTrainID.Text = Global.trainingUsed.TrainID.ToString();
                fTrainings.OnSearchMode = false;
            }
            
        }

        private void btnFindSportType_Click(object sender, EventArgs e)
        {            
            FSportTypes fSportTypes = new FSportTypes();
            fSportTypes.OnSearchMode = true;
            fSportTypes.ShowDialog();

            if (fSportTypes.OnSearchMode)
            {
                txtSportTypeID.Text = Global.sportTypeUsed.SportTypeID.ToString();
                fSportTypes.OnSearchMode = false;
            }
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            setEditMode();
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar la edición de sesión?.\n Los cambios realizados se perderán.";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.sessionsBindingSource.CancelEdit();
                setNormalMode();
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea guardar la sesión creada?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                txtUserID.Text = userIDWorking.ToString();
                this.Validate();
                this.sessionsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);
                MessageBox.Show("Sesión guardada corectamente");
                setNormalMode();
                LoadData();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "Va a borrar la sesión seleccionada. ¿Esta seguro?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.sessionsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);
                MessageBox.Show("Sesión borrada corectamente");
                LoadData();
            } 
        }  

    }
}
