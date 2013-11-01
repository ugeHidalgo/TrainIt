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
using System.Data.SqlTypes;

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
            //Check if user chooses a SportType, if not give a warning error                      
            if (txtSportTypeID.Text != "")
            {
                string mensaje = "¿Desea guardar la sesión creada?";
                DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (delMat == DialogResult.OK)
                {
                    //Check if user chooses a Train ID, if not create new traininig
                    if (txtTrainID.Text == "")
                    {
                        Global.trainingUsed.UserID = userIDWorking;
                        Global.trainingUsed.TrainDate = dtpDate.Value;
                        Global.trainingUsed.TrainName = "Sin Nombre";
                        Global.trainingUsed.SaveATraining(connString);
                        txtTrainID.Text = Global.trainingUsed.TrainID.ToString();
                    }
                    txtUserID.Text = userIDWorking.ToString();
                    this.Validate();
                    this.sessionsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.trainITDataSet);
                    MessageBox.Show("Sesión guardada corectamente");
                    setNormalMode();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado el deporte realizado en la sesión.");
                btnFindSportType.Focus();
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

        private void txtDist_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtDist.Text != "")
            {//Se permiten números con decimales o el campo vacío.
                try
                {
                    SqlDecimal temp = Convert.ToDecimal(txtDist.Text);
                    if ((temp < 1000) && (temp >= 0))
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
            }
            else txtDist.Text = "0,000";
            if (e.Cancel)
            {
                txtDist.BackColor = Color.Red;
                MessageBox.Show("La distancia de sesión debe ser un número entre 0 y 999.999.\n Se permiten decimales.");
            }
            else
                txtDist.BackColor = SystemColors.Window;  
        }

        private void txtTime_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtTime.Text != "    :  :")
            {
                if (!Time.CheckTimeFormat(txtTime.Text,99))
                    e.Cancel = true;
                if (e.Cancel)
                {//Format not correct
                    txtTime.BackColor = Color.Red;
                    string message = "El tiempo de sesión debe ser en formato: hh:mm:ss \n\n" +
                                     "      - Segundos entre 0 y 59. \n" +
                                     "      - Minutos entre 0 y 59.  \n" +
                                     "      - Horas entre 0 y 99.    ";
                    MessageBox.Show(message);
                }
                else
                {//Format correct
                    txtTime.BackColor = SystemColors.Window;
                }
            }
        }

        private void txtMedHR_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtMedHR.Text != "")
            {//Se permiten números sin decimales o el campo vacío.
                try
                {
                    int temp = Convert.ToInt16(txtMedHR.Text);
                    if ((temp < 300) && (temp >= 0))
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
            }
            else txtMedHR.Text = "0";
            if (e.Cancel)
            {
                txtMedHR.BackColor = Color.Red;
                MessageBox.Show("El pulso Medio debe ser un número entre 0 y 299.\n");
            }
            else
                txtMedHR.BackColor = SystemColors.Window;  
        }

        private void txtMaxHR_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtMaxHR.Text != "")
            {//Se permiten números sin decimales o el campo vacío.
                try
                {
                    int temp = Convert.ToInt16(txtMaxHR.Text);
                    if ((temp < 300) && (temp >= 0))
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
            }
            else txtMaxHR.Text = "0";
            if (e.Cancel)
            {
                txtMaxHR.BackColor = Color.Red;
                MessageBox.Show("El pulso Máximo debe ser un número entre 0 y 299.\n");
            }
            else
                txtMaxHR.BackColor = SystemColors.Window; 
        }

        private void txtValue_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtValue.Text != "")
            {//Se permiten números sin decimales o el campo vacío.
                try
                {
                    int temp = Convert.ToInt16(txtValue.Text);
                    if ((temp < 11) && (temp >= 0))
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
            }
            else txtValue.Text = "0";
            if (e.Cancel)
            {
                txtValue.BackColor = Color.Red;
                MessageBox.Show("La valoración de la sesión debe ser un número entre 0 y 10.\n");
            }
            else
                txtValue.BackColor = SystemColors.Window; 
        }  

    }
}
