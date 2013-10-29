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
        string connString = TrainItLibrary.Utilities.GetConnString();
        int userIDWorking = TrainItLibrary.Global.userIDWorking;
        int trainIDUsing=-1;
        bool onEdition = false;

        public FTrainings()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking + ")" + TrainItLibrary.Global.userNameWorking;

            setNormalMode();
        }

        private void FTrainings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana actual.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            else
            {
                TrainItLibrary.Global.trainingUsed.LoadDataFromView(txtID.Text, txtName.Text, dtpDate.Value, txtUserID.Text);                
                e.Cancel = false;
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
            tsBtnDel.Enabled = false;
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
            tsBtnDel.Enabled = true;
        }

        private void resetFields()
        {
            txtUserID.Text = userIDWorking.ToString();
            dtpDate.Value = DateTime.Now;
        }

        private void FTrainings_Load(object sender, EventArgs e)
        {
            // Loads data for the Training Grid.
            this.trainingsTableAdapter.FillBy(this.trainITDataSet.Trainings,userIDWorking);

            //Load data for the Sessions grid.
            trainIDUsing=Convert.ToInt16(txtID.Text);
            if (trainIDUsing > 0)
                this.sessionsTableAdapter.FillBy(this.trainITDataSet.Sessions, userIDWorking, trainIDUsing);
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            resetFields();
            setEditMode();
            txtName.Focus();
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
            this.Validate();
            this.trainingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainITDataSet);

            MessageBox.Show("Ficha guardada corectamente");

            setNormalMode();
        }

        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            string mensaje = "Va a borrar el entrenamiento seleccionado. ¿Esta seguro?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.trainingsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);
            }  
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //Load data for the Sessions grid.
            trainIDUsing = Convert.ToInt16(txtID.Text);
            if (trainIDUsing > 0)
                this.sessionsTableAdapter.FillBy(this.trainITDataSet.Sessions, userIDWorking, trainIDUsing);
        }

    }
}
