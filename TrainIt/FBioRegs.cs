using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            //Load data into model object
            Global.aBioRegUsed = LoadDataFromGrid();

            //Load Data into boxes
            LoadDataIntoBoxes(Global.aBioRegUsed);
        }

        /// <summary>
        /// Load data from the grid to the object model
        /// </summary>
        /// <returns>BioReg Object</returns>
        private BioReg LoadDataFromGrid()
        {
            BioReg aBioReg = new BioReg();
            aBioReg.bioRegID = Convert.ToInt64(dgvBioRegs["BioRegID", dgvBioRegs.CurrentRow.Index].Value);
            aBioReg.bioRegTypeID = Convert.ToInt64(dgvBioRegs["BioRegTypeID", dgvBioRegs.CurrentRow.Index].Value);
            aBioReg.bioRegDate = Convert.ToDateTime(dgvBioRegs["BioRegdate", dgvBioRegs.CurrentRow.Index].Value);
            aBioReg.value = Convert.ToDouble(dgvBioRegs["Value", dgvBioRegs.CurrentRow.Index].Value);
            aBioReg.memo = Convert.ToString(dgvBioRegs["Memo", dgvBioRegs.CurrentRow.Index].Value);
            aBioReg.userID = Convert.ToInt64(dgvBioRegs["UserID", dgvBioRegs.CurrentRow.Index].Value);
            return aBioReg;
        }

        /// <summary>
        /// Load Data from boxes to the model object
        /// </summary>
        /// <returns>BioReg object</returns>
        private BioReg LoadDataFromBoxes()
        {
            BioReg aBioReg = new BioReg();
            aBioReg.bioRegID = Convert.ToInt64(txtBioRegID.Text);
            aBioReg.bioRegTypeID = Convert.ToInt64(txtBioRegTypeID.Text);
            aBioReg.bioRegDate = Convert.ToDateTime(dtpBioRegDate.Value);
            try
            {
                aBioReg.value = Convert.ToDouble(txtValue.Text);
            }
            catch
            {
                aBioReg.value = 0;
            }
            aBioReg.memo = Convert.ToString(txtMemo.Text);
            aBioReg.userID = Convert.ToInt64(txtUserID.Text);
            return aBioReg;
        }

        /// <summary>
        /// Load data from the object model to the boxes in display
        /// </summary>
        /// <param name="aBioReg">A BioReg object</param>
        private void LoadDataIntoBoxes(BioReg aBioReg)
        {
            txtBioRegID.Text = aBioReg.bioRegID.ToString();
            txtUserID.Text = aBioReg.userID.ToString();
            if ((txtBioRegTypeID.Text != "") && (txtBioRegTypeID.Text != "-1"))
                txtBioRegName.Text = this.bioRegTypesTableAdapter1.GetBioRegTypeName(Convert.ToInt64(txtBioRegTypeID.Text));
            txtBioRegTypeID.Text = aBioReg.bioRegTypeID.ToString();
            dtpBioRegDate.Value = aBioReg.bioRegDate;
            txtValue.Text = aBioReg.value.ToString();
            txtMemo.Text = aBioReg.memo.ToString();
        }

        /// <summary>
        /// Load data from the object model to the grid
        /// </summary>
        private void LoadDataIntoGrid(BioReg aBioReg)
        {
            dgvBioRegs["BioRegTypeID", dgvBioRegs.CurrentRow.Index].Value = aBioReg.bioRegTypeID;
            dgvBioRegs["BioRegdate", dgvBioRegs.CurrentRow.Index].Value = aBioReg.bioRegDate;
            dgvBioRegs["Value", dgvBioRegs.CurrentRow.Index].Value = aBioReg.value;
            dgvBioRegs["Memo", dgvBioRegs.CurrentRow.Index].Value = aBioReg.memo;
            dgvBioRegs["UserID", dgvBioRegs.CurrentRow.Index].Value = aBioReg.userID;
        }

        private void setEditMode()
        {
            onEdition = true;

            txtBioRegTypeID.ReadOnly = false;
            txtValue.ReadOnly = false;
            txtMemo.ReadOnly = false;
            dtpBioRegDate.Enabled = true;

            dgvBioRegs.Enabled = false;

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

            dgvBioRegs.Enabled = true;

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
            //Clear boxes
            txtBioRegID.Text = "-1";
            txtBioRegTypeID.Text = "";
            txtBioRegName.Text = "";
            txtValue.Text = "0,0";
            dtpBioRegDate.Value = DateTime.Now;
            txtMemo.Text = "";
            txtUserID.Text = Global.userIDWorking.ToString();

            //Clear model obejct
            Global.aBioRegUsed.Clear();
        }

        private void btnFindSportType_Click(object sender, EventArgs e)
        {
            FSBioRegsTypes fSBioRegsTypes = new FSBioRegsTypes();
            fSBioRegsTypes.ShowDialog();

            if (Global.bioRegTypeIDSelected != 0)
            {
                txtBioRegTypeID.Text = Global.bioRegTypeIDSelected.ToString();
                txtBioRegName.Text = this.bioRegTypesTableAdapter1.GetBioRegTypeName(Convert.ToInt64(txtBioRegTypeID.Text));
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

                //Load data into boxes and model object
                movingRecords(sender, e);
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea guardar el registro creado?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                //Load data into object
                Global.aBioRegUsed = LoadDataFromBoxes();

                //Load data into grid 
                LoadDataIntoGrid(Global.aBioRegUsed);

                this.Validate();
                this.bioRegsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);

                setNormalMode();

                //Stores the BioRegID into model, and into box
                Global.aBioRegUsed.bioRegID = Convert.ToInt64(dgvBioRegs["BioRegID", dgvBioRegs.CurrentRow.Index].Value);
                txtBioRegID.Text = Global.aBioRegUsed.bioRegID.ToString();

                MessageBox.Show("Ficha guardada corectamente");

            }
        }

        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            string mensaje = "Va a borrar el registro nº " + txtBioRegID + "/" + txtUserID + " del tipo: " + txtBioRegName.Text + ". ¿Esta seguro?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.bioRegsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);

                //Load data into boxes and model object
                movingRecords(sender, e);
            }
        }

        private void txtBioRegTypeID_Validating(object sender, CancelEventArgs e)
        {
            Int64 anID;
            e.Cancel = false;
            txtBioRegTypeID.BackColor = SystemColors.Window;
            if (!string.IsNullOrEmpty(txtBioRegTypeID.Text))
            {
                try
                {
                    anID = Convert.ToInt64(txtBioRegTypeID.Text);
                    txtBioRegName.Text = this.bioRegTypesTableAdapter1.GetBioRegTypeName(anID);
                    txtBioRegTypeID.BackColor = SystemColors.Window;
                    if (txtBioRegName.Text == "")
                    {
                        txtBioRegTypeID.BackColor = Color.Red;
                        MessageBox.Show("El código de tipo de registro no existe en la base de datos.");
                        txtBioRegTypeID.Text = "";
                        e.Cancel = true;
                    }
                }
                catch (Exception)
                {
                    txtBioRegTypeID.BackColor = Color.Red;
                    MessageBox.Show("El código de tipo de registro debe ser un número.");
                    txtBioRegTypeID.Text = "";
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Loads data into object model and boxes after a record moves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movingRecords(object sender, EventArgs e)
        {
            //Load data into model object
            Global.aBioRegUsed = LoadDataFromGrid();

            //Load Data into boxes
            LoadDataIntoBoxes(Global.aBioRegUsed);
        }
    }
}
