using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TrainItLibrary;

namespace TrainIt
{
    public partial class FSportTypes : Form
    {
        private static bool onSearchMode;
        string connString = Utilities.GetConnString();
        Int64 userIDWorking = Global.userIDWorking;        
        Int64 sportTypeIDToUpdate = -1;
        Boolean onEdition = false; //Used to indicate wether or not we are in edit mode
        Boolean returnValue = false;

        public bool OnSearchMode
        {
            get { return onSearchMode; }
            set {onSearchMode=value;}
        }

        public FSportTypes()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking+")"+TrainItLibrary.Global.userNameWorking;
            setNormalMode();
        }

        private void FSportTypes_Load(object sender, EventArgs e)
        {
            //if this form is shomw in order to search, then enable buttons for search
            btnChoose.Visible = OnSearchMode;
            btnCancel.Visible = OnSearchMode;


            //Load Data into combo box
            this.sportTypesTableAdapter1.FillBy(this.trainITDataSet.SportTypes, userIDWorking);

            //Load data into data grid
            LoadDataInGrid(dgvSTypes, userIDWorking);

            if (dgvSTypes.RowCount > 0)
            {
                Global.sportTypeUsed.SportTypeID= Convert.ToInt64(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                Global.sportTypeUsed.UserID=userIDWorking;

                //Find the User and load other fields into Model object: sportTypeUSed
                Global.sportTypeUsed = Global.sportTypeUsed.FindSportTypeByID(connString);

                //LoadData in boxes
                LoadDataInBoxes(Global.sportTypeUsed);
            }
        }

        private DataTable LoadDataInGrid(DataGridView dgvSTypes, Int64 aUserID)
        {   //Load data into data grid view: dgvUsers
            DataTable aDataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT SportTypes.*, SportTypes_1.SportTypeName AS FamilyName
                                 FROM  SportTypes LEFT JOIN SportTypes AS SportTypes_1 
                                 ON SportTypes.ParentSportTypeID = SportTypes_1.SportTypeID
                                 WHERE SportTypes.UserID=@userID
                                 ORDER BY SportTypes.ParentSportTypeID, SportTypes.SportTypeName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = aUserID;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        aDataTable.Load(reader);
                        dgvSTypes.DataSource = aDataTable;
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A problem with the User SQL Connection occurs");
                    }
                }
            }
            return aDataTable;
        }

        private void LoadDataInBoxes( SportTypes aSportType)
        {
            txtSportTypeID.Text = aSportType.SportTypeID.ToString();
            txtSportTypeName.Text = aSportType.SportTypeName;
            txtParentSportTypeID.Text = aSportType.ParentSportTypeID.ToString();
            txtMemo.Text = aSportType.Memo;
            if (txtParentSportTypeID.Text == "0")
                chBxNoFamily.Checked = true;
            else
            {
                chBxNoFamily.Checked = false;
            }

            //Find the name of the parent sport type
            SportTypes parent = new SportTypes();
            parent = aSportType.FindParentSportType(connString);
            cbxSportTypeName.Text = parent.SportTypeName;                        
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
            tsBtnDel.Enabled = false;

            btnChoose.Enabled = false;
            btnCancel.Enabled = false;

            txtSportTypeName.ReadOnly = false;
            txtMemo.ReadOnly = false;

            chBxNoFamily.Enabled = true;
            cbxSportTypeName.Enabled = true;                                     

            dgvSTypes.Enabled = false;
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
            tsBtnDel.Enabled = true;

            btnChoose.Enabled = true;
            btnCancel.Enabled = true;

            chBxNoFamily.Enabled = false;
            cbxSportTypeName.Enabled = false;

            txtSportTypeName.ReadOnly = true;
            txtMemo.ReadOnly = true;

            dgvSTypes.Enabled = true;
        }

        private void clearUserTextBoxes()
        {
            txtSportTypeID.Text = "";
            txtSportTypeName.Text = "";
            txtParentSportTypeID.Text = "0";
            chBxNoFamily.Checked = true;            
            txtMemo.Text = "";
        }   

        private void FSportTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana actual.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                returnValue = false;
            }
            else
            {
                e.Cancel = false;
                OnSearchMode = false;
                if (returnValue)
                    OnSearchMode = true;
            }
        }

        private void tsBtnFirst_Click(object sender, EventArgs e)
        {
            if (dgvSTypes.RowCount > 0)
            {
                dgvSTypes.CurrentCell = dgvSTypes[0, 0];
                Global.sportTypeUsed.SportTypeID = Convert.ToInt64(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                Global.sportTypeUsed.UserID = userIDWorking;

                //Find the User and load into aUser
                TrainItLibrary.Global.sportTypeUsed = TrainItLibrary.Global.sportTypeUsed.FindSportTypeByID(connString);

                //LoadData in boxes
                LoadDataInBoxes(Global.sportTypeUsed);
            }  
        }

        private void tsBtnPrevious_Click(object sender, EventArgs e)
        {
            if (dgvSTypes.RowCount > 0)
            {
                if (dgvSTypes.CurrentRow.Index > 0)
                {
                    dgvSTypes.CurrentCell = dgvSTypes[0, dgvSTypes.CurrentRow.Index - 1];

                    Global.sportTypeUsed.SportTypeID = Convert.ToInt64(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                    Global.sportTypeUsed.UserID = userIDWorking;

                    //Find the User and load into aUser
                    Global.sportTypeUsed = TrainItLibrary.Global.sportTypeUsed.FindSportTypeByID(connString);

                    //LoadData in boxes
                    LoadDataInBoxes(Global.sportTypeUsed);
                }
            }
        }

        private void tsBtnNext_Click(object sender, EventArgs e)
        {
            if (this.dgvSTypes.RowCount > 0)
            {
                if (dgvSTypes.CurrentRow.Index < dgvSTypes.RowCount - 1)
                {
                    dgvSTypes.CurrentCell = dgvSTypes[0, dgvSTypes.CurrentRow.Index + 1];

                    Global.sportTypeUsed.SportTypeID = Convert.ToInt64(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                    Global.sportTypeUsed.UserID = userIDWorking;

                    //Find the User and load into aUser
                    Global.sportTypeUsed = Global.sportTypeUsed.FindSportTypeByID(connString);

                    //LoadData in boxes
                    LoadDataInBoxes(Global.sportTypeUsed);
                }
            }   
        }

        private void tsBtnLast_Click(object sender, EventArgs e)
        {
            if (this.dgvSTypes.RowCount > 0)
            {
                dgvSTypes.CurrentCell = dgvSTypes[0, dgvSTypes.RowCount - 1];

                Global.sportTypeUsed.SportTypeID = Convert.ToInt64(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                Global.sportTypeUsed.UserID = userIDWorking;

                //Find the User and load into aUser
                Global.sportTypeUsed = Global.sportTypeUsed.FindSportTypeByID(connString);

                //LoadData in boxes
                LoadDataInBoxes(Global.sportTypeUsed);
            }  
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            //Put form on edit mode.
            setEditMode();

            //Clear all data fields.
            clearUserTextBoxes();
            sportTypeIDToUpdate = -1;

            //Reset user data 
            TrainItLibrary.Global.sportTypeUsed.Reset();            

            //Put focus on first component
            txtSportTypeName.Focus();
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvSTypes.RowCount > 0)
            {
                //Put form on edit mode.
                setEditMode();

                //Take de UserID of the reg being updated
                sportTypeIDToUpdate = Convert.ToInt64(txtSportTypeID.Text);

                Global.sportTypeUsed.SportTypeID = sportTypeIDToUpdate;
                Global.sportTypeUsed.UserID = userIDWorking;
                
                Global.sportTypeUsed = Global.sportTypeUsed.FindSportTypeByID(connString);
                    
                //Put focus on first component
                txtSportTypeName.Focus();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PENDIENTE");
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            //Verify all data is correct.
            if (txtParentSportTypeID.Text == "")
                txtParentSportTypeID.Text = "0";
            SportTypes tempData = new SportTypes(sportTypeIDToUpdate,txtSportTypeName.Text,Convert.ToInt64(txtParentSportTypeID.Text),txtMemo.Text,userIDWorking);
            int verifyResult = tempData.CheckData(connString);

            //if update and user find, verify must be ok
            if ((sportTypeIDToUpdate != -1) && (verifyResult == -1))
                verifyResult = 1;

            //if data verification is ok, then we can save.
            if (verifyResult == 1)
            {
                int position = 0;
                if (sportTypeIDToUpdate == -1)
                { //New user
                    //Takes position
                    position = dgvSTypes.RowCount;

                    //Load data into aUSer
                    Global.sportTypeUsed.LoadData(-1, txtSportTypeName.Text, Convert.ToInt64(txtParentSportTypeID.Text), txtMemo.Text, userIDWorking);

                    //save data into BD
                    Global.sportTypeUsed = Global.sportTypeUsed.SaveData(connString);
                }
                else
                {//Update existing user

                    //Take actual position
                    position = dgvSTypes.CurrentRow.Index;

                    //Load data into aUSer
                    Global.sportTypeUsed.LoadData(sportTypeIDToUpdate, txtSportTypeName.Text, Convert.ToInt64(txtParentSportTypeID.Text), txtMemo.Text, userIDWorking);

                    //save data into BD
                    Global.sportTypeUsed = Global.sportTypeUsed.UpdateData(connString);
                    //aSportType = aSportType.up
                }
                //Reload data into grid
                LoadDataInGrid(dgvSTypes,userIDWorking);

                //Goes to the position
                dgvSTypes.CurrentCell = dgvSTypes[0, position];

                Global.sportTypeUsed.SportTypeID = Convert.ToInt32(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                Global.sportTypeUsed.UserID = userIDWorking;
                
                //Load data into aUser
                Global.sportTypeUsed = Global.sportTypeUsed.FindSportTypeByID(connString);

                //Loads data into boxes
                LoadDataInBoxes(TrainItLibrary.Global.sportTypeUsed);

                //Enable normal mode.
                setNormalMode();

                //Reload Data into combobox
                this.sportTypesTableAdapter1.FillBy(this.trainITDataSet.SportTypes, userIDWorking);
            }
            else //There is an error in data to save.
            {
                switch (verifyResult)
                {
                    case 0: //SportTypeName not present
                        MessageBox.Show("Falta el nombre del tipo de deporte.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSportTypeName.Focus();
                        break;
                    case -1: //SportTypeName exist on BD.
                        MessageBox.Show("Ya existe ese tipo de deporte en la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSportTypeName.Focus();
                        break;
                    case -2: //ParentSportID does not exist on BD and is different to 0(root)
                        MessageBox.Show("La familia a la que pertenece el tipo de deporte no existe en la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSportTypeName.Focus();
                        break;
                   
                }
            }
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            //Puts form in Normal mode.
            setNormalMode();
            clearUserTextBoxes();
            sportTypeIDToUpdate = -1;

            if (dgvSTypes.RowCount > 0)
            {
                //Goes to current reg
                dgvSTypes.CurrentCell = dgvSTypes[0, dgvSTypes.CurrentRow.Index];

                Global.sportTypeUsed.SportTypeID = Convert.ToInt64(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                Global.sportTypeUsed.UserID = userIDWorking;

                //Load data into aUser               
                Global.sportTypeUsed = Global.sportTypeUsed.FindSportTypeByID(connString);

                //Loads data into boxes
                LoadDataInBoxes(TrainItLibrary.Global.sportTypeUsed);
            }
        }

        private void dgvSTypes_Click(object sender, EventArgs e)
        {//Load data from current row in grid to the text boxes.
            if (!onEdition)
            {
                if (dgvSTypes.RowCount > 0)
                {
                    Global.sportTypeUsed.SportTypeID = Convert.ToInt64(dgvSTypes[0, dgvSTypes.CurrentRow.Index].Value);
                    Global.sportTypeUsed.UserID = userIDWorking;

                    //Load data into aUser
                    Global.sportTypeUsed = Global.sportTypeUsed.FindSportTypeByID(connString);

                    //Loads data into boxes
                    LoadDataInBoxes(TrainItLibrary.Global.sportTypeUsed);
                }
            }
        }

        private void chBxNoFamily_CheckedChanged(object sender, EventArgs e)
        {//Enable-Disable to choose sport family
            if (chBxNoFamily.Checked)
            {
                txtParentSportTypeID.Text = "0";                
                cbxSportTypeName.Text = "";
            }            
        }

        private void cbxSportTypeName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxSportTypeName.Text == "")            
                chBxNoFamily.Checked = true;
            else chBxNoFamily.Checked = false;                            
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

        private void dgvSTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnSearchMode)
            {
                btnChoose_Click(this, e);
            }
        }
    }
}
