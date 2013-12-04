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
using TrainIt.Search_Forms;

namespace TrainIt
{
    public partial class FBioRegs : Form
    {
        string connString = Utilities.GetConnString();
        Int64 userIDWorking = Global.userIDWorking;
        bool onEdition = false;


        public FBioRegs()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + Global.userIDWorking + ")" + Global.userNameWorking;

            setNormalMode();
        }

        private void FBioRegs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainITDataSet.BioRegs' table. You can move, or remove it, as needed.
            this.bioRegsTableAdapter.Fill(this.trainITDataSet.BioRegs);


            Global.aBioRegUsed = LoadData();

        }

        private BioReg LoadData()
        {
            BioReg aBioReg = new BioReg();

            aBioReg.bioRegID = Convert.ToInt64(txtBioRegID.Text);
            aBioReg.bioRegTypeID = Convert.ToInt64(txtBioRegTypeID.Text);
            aBioReg.bioRegDate = dtpBioRegDate.Value;
            if (String.IsNullOrEmpty(txtValue.Text))
            {
                txtValue.Text = "0";
            }
            aBioReg.value = Convert.ToDouble(txtValue.Text);
            aBioReg.memo = txtMemo.Text;
            aBioReg.userID = Global.userIDWorking;


            return aBioReg;
        }

        private void LoadDataOnGrid(BioReg aBioReg)
        {
            //dgvBioRegs[0, dgvBioRegs.CurrentRow.Index].Value = aBioReg.bioRegID;
            //dgvBioRegs[1, dgvBioRegs.CurrentRow.Index].Value = aBioReg.userID;
            //dgvBioRegs[2, dgvBioRegs.CurrentRow.Index].Value = aBioReg.bioRegTypeID;            
            //dgvBioRegs[4, dgvBioRegs.CurrentRow.Index].Value = aBioReg.bioRegDate;
            //dgvBioRegs[5, dgvBioRegs.CurrentRow.Index].Value = aBioReg.value;
            //dgvBioRegs[6, dgvBioRegs.CurrentRow.Index].Value = aBioReg.memo;
        }

        private void setEditMode()
        {
            onEdition = true;

            txtBioRegTypeID.ReadOnly = false;
            txtValue.ReadOnly = false;
            txtMemo.ReadOnly = false;
            dtpBioRegDate.Enabled = true;

            dgvBioRegs.Enabled = true;

            tsBtnFirst.Enabled = false;
            tsBtnPrevious.Enabled = false;
            tsBtnNext.Enabled = false;
            tsBtnLast.Enabled = false;
            tsBtnNew.Enabled = false;
            tsBtnEdit.Enabled = false;
            tsBtnCancel.Enabled = true;
            tsBtnSave.Enabled = true;
            tsBtnDel.Enabled = false;

            btnFindBioRegType.Enabled = true;
        }

        private void setNormalMode()
        {
            onEdition = false;

            txtBioRegTypeID.ReadOnly = true;
            txtValue.ReadOnly = true;
            txtMemo.ReadOnly = true;
            dtpBioRegDate.Enabled = true;

            dgvBioRegs.Enabled = false;

            tsBtnFirst.Enabled = true;
            tsBtnPrevious.Enabled = true;
            tsBtnNext.Enabled = true;
            tsBtnLast.Enabled = true;
            tsBtnNew.Enabled = true;
            tsBtnEdit.Enabled = true;
            tsBtnCancel.Enabled = false;
            tsBtnSave.Enabled = false;
            tsBtnDel.Enabled = true;

            btnFindBioRegType.Enabled = false;
        }

        private void resetFields()
        {
            txtBioRegID.Text = "-1";
            txtBioRegTypeID.Text = "";
            txtBioRegName.Text = "";
            txtValue.Text = "0,0";
            dtpBioRegDate.Value = DateTime.Now;
            txtMemo.Text = "";
            txtUserID.Text = Global.userIDWorking.ToString();
        }

        private void btnFindSportType_Click(object sender, EventArgs e)
        {
            FSBioRegsTypes fSBioRegsTypes = new FSBioRegsTypes();
            fSBioRegsTypes.ShowDialog();

            if (Global.bioRegTypeIDSelected != 0)
            {
                txtBioRegTypeID.Text = Global.bioRegTypeIDSelected.ToString();
            }
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {            
            setEditMode();
            resetFields();
            txtBioRegTypeID.Focus();
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
            txtBioRegTypeID.Focus();
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar la edición del registro " + txtBioRegName.Text + "?\n Los cambios realizados se perderán.";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.bioRegsBindingSource.CancelEdit();
                setNormalMode();
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea guardar la ficha creada?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                //Load data into object
                Global.aBioRegUsed = LoadData();

                //Load all data on grid
                LoadDataOnGrid(Global.aBioRegUsed);

                this.Validate();
                this.bioRegsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);

                setNormalMode();

                MessageBox.Show("Ficha guardada corectamente");
            }
        }

        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            string mensaje = "Va a borrar el registro relativo a: " + txtBioRegName.Text + ". ¿Esta seguro?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.bioRegsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);
            }
        }






    }
}
