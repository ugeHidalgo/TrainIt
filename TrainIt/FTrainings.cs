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
    public partial class FTrainings : Form
    {
        private static bool onSearchMode;
        string connString = Utilities.GetConnString();
        Int64 userIDWorking = Global.userIDWorking;
        Int64 trainIDUsing = -1;
        bool onEdition = false;
        bool returnValue = false;

        public bool OnSearchMode
        {
            get { return onSearchMode;}
            set { onSearchMode = value; }
        }

        public FTrainings()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + Global.userIDWorking + ")" + Global.userNameWorking;

            setNormalMode();
        }

        private void FTrainings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainITDataSet.Sessions' table. You can move, or remove it, as needed.
            this.sessionsTableAdapter.Fill(this.trainITDataSet.Sessions);
            // TODO: This line of code loads data into the 'trainITDataSet.MaterialSession' table. You can move, or remove it, as needed.
            this.materialSessionTableAdapter.Fill(this.trainITDataSet.MaterialSession);
            //if this form is shomw in order to search, then enable buttons for search
            btnChoose.Visible = OnSearchMode;
            btnCancel.Visible = OnSearchMode;

            // Loads data for the Training Grid.
            this.trainingsTableAdapter.FillBy(this.trainITDataSet.Trainings, userIDWorking);
        }

        private void FTrainings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana actual.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                returnValue = false;
            }
            else
            {
                Global.trainingUsed.LoadDataFromView(txtID.Text, txtName.Text, dtpDate.Value, txtUserID.Text);                
                e.Cancel = false;
                OnSearchMode = false;
                if (returnValue)
                    OnSearchMode = true;
            }
        }

        private void setEditMode()
        {
            onEdition = true;

            txtName.ReadOnly = false;
            dtpDate.Enabled=true;

            dgvTrainings.Enabled = false;

            tsBtnFirst.Enabled = false;
            tsBtnPrevious.Enabled = false;
            tsBtnNext.Enabled = false;
            tsBtnLast.Enabled = false;
            tsBtnNew.Enabled = false;
            tsBtnEdit.Enabled = false;
            tsBtnCancel.Enabled = true;
            tsBtnSave.Enabled = true;
            tsBtnDelTraining.Enabled = false;

            btnChoose.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void setNormalMode()
        {
            onEdition = false;

            txtName.ReadOnly = true;
            dtpDate.Enabled = false;

            dgvTrainings.Enabled = true;

            tsBtnFirst.Enabled = true;
            tsBtnPrevious.Enabled = true;
            tsBtnNext.Enabled = true;
            tsBtnLast.Enabled = true;
            tsBtnNew.Enabled = true;
            tsBtnEdit.Enabled = true;
            tsBtnCancel.Enabled = false;
            tsBtnSave.Enabled = false;
            tsBtnDelTraining.Enabled = true;

            btnChoose.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void resetFields()
        {
            //Clear data in textboxes
            txtUserID.Text = userIDWorking.ToString();
            dtpDate.Value = DateTime.Now;
            txtTotDist.Text = "0";
            txtTotTime.Text = "00:00:00";
        }       

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            resetFields();
            setEditMode();
            txtName.Focus();

            //Reloads sessions for new session: this avoid show data when New is clicked
            this.sessionsTableAdapter.FillByUserAndTrain(this.trainITDataSet.Sessions, userIDWorking, -1);
            if (this.sessionsTableAdapter.TotDist(userIDWorking, -1) == null)
                txtTotDist.Text = "0";
            else 
                txtTotDist.Text = this.sessionsTableAdapter.TotDist(userIDWorking, -1).ToString();
            if (this.sessionsTableAdapter.TotTime(userIDWorking, -1) == null)
                txtTotTime.Text = "00:00:00";
            else
                txtTotTime.Text = this.sessionsTableAdapter.TotTime(userIDWorking, -1).ToString();  
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
            txtName.Focus();
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar la edición del entrenamiento?.\n Los cambios realizados se perderán.";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.trainingsBindingSource.CancelEdit();
                setNormalMode();
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {    
            string mensaje = "¿Desea guardar el entrenamiento creado?\nPara asignar sesiones a este entrenamiento grabe y vaya a 'Sesiones'.";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.Validate();
                this.trainingsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);

                MessageBox.Show("Entrenamiento guardado corectamente.\nPara asignar sesiones a este entrenamiento vaya a 'Sesiones'.");

                setNormalMode();
            }
        }

        private void tsBtnDelTraining_Click(object sender, EventArgs e)
        {
            string mensaje = "Va a borrar el entrenamiento ("+txtID.Text+"/"+txtUserID.Text+").\n" +
                 "Se borraran igualmente todas las sesiones adicionales de este entrenamiento.\n\n" +
                 "¿Esta seguro?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.trainingsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);
                MessageBox.Show("Entrenamiento y sesiones del entrenamiento borradas corectamente.");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //Load data for the Sessions grid.
            trainIDUsing = Convert.ToInt64(txtID.Text);
            if (trainIDUsing > 0)
            {
                this.sessionsTableAdapter.FillByUserAndTrain(this.trainITDataSet.Sessions, userIDWorking, trainIDUsing);
                if (this.sessionsTableAdapter.TotDist(userIDWorking, trainIDUsing)!=null)                
                    txtTotDist.Text=this.sessionsTableAdapter.TotDist(userIDWorking, trainIDUsing).ToString();
                
                if (this.sessionsTableAdapter.TotTime(userIDWorking, trainIDUsing)!=null)
                    txtTotTime.Text = this.sessionsTableAdapter.TotTime(userIDWorking, trainIDUsing).ToString();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Sin nombre";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            returnValue = true;
            this.Close();
        }

        private void dgvTrainings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnSearchMode)
            {
                btnChoose_Click(this, e);
            }
        }

    }
}
