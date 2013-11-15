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
using System.Data.SqlClient;

namespace TrainIt
{
    public partial class FUsers : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();
        Boolean onEdition = false; //Used to indicate wether or not we are in edit mode
        public bool savePass = false;
        Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
        Int64 userIDToUpdate = -1;

        public FUsers()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking+")"+TrainItLibrary.Global.userNameWorking;
            setNormalMode();       
     }

        private DataTable LoadDataInGrid(DataGridView dgv)
        {   //Load data into data grid view: dgvUsers
            DataTable aDataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select UserID, UserFirstName, UserSecondName, UserBdate, UserName, UserMail from Users";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        aDataTable.Load(reader);
                        dgv.DataSource = aDataTable;
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A problem with the User SQL Connection occurs");
                        throw;
                    }
                }
            }
            return aDataTable;
        }

        private void LoadDataInGrid(DataGridView dgv, string aFirstName)
        {//Load data into data grid view: dgvUsers given a FirstName
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select UserID, UserFirstName, UserSecondName, UserBdate, UserName, UserMail from Users where UserFirstName = @userFirstName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userFirstName", SqlDbType.VarChar));
                    cmd.Parameters["@userFirstName"].Value = aFirstName;


                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgv.DataSource = dataTable;
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A problem with the User SQL Connection occurs");
                        throw;
                    }
                }
            }
        }

        private void LoadDataInBoxes(Users aUser)
        {
            txtUserID.Text = aUser.userID.ToString();
            txtFirstName.Text = aUser.userFirstName;
            txtSecondName.Text = aUser.userSecondName;
            dtpBDate.Value = aUser.userBDate;
            txtUserName.Text = aUser.userName;
            txtUserPass.Text = aUser.userPass;
            txtConfirm.Text = aUser.userConfirmPassword;
            txtMail.Text = aUser.userMail;
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
            btnChangePassword.Enabled = false;

            txtFirstName.ReadOnly = false;
            txtSecondName.ReadOnly = false;
            txtMail.ReadOnly = false;
            dtpBDate.Enabled = true;
            txtUserName.ReadOnly = false;
            txtUserPass.ReadOnly = false;
            laConfirm.Visible = true;
            txtConfirm.Visible = true;

            dgvUsers.Enabled = false;
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
            btnChangePassword.Enabled = false;

            txtFirstName.ReadOnly = true;
            txtSecondName.ReadOnly = true;
            txtMail.ReadOnly = true;
            dtpBDate.Enabled = false;
            txtUserName.ReadOnly = true;
            txtUserPass.ReadOnly = true;
            txtConfirm.ReadOnly = true;
            laConfirm.Visible = false;
            txtConfirm.Visible = false;

            dgvUsers.Enabled = true;

            savePass = false;
        }

        private void clearUserTextBoxes()
        {
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtMail.Text = "";
            dtpBDate.Value = DateTime.Now;
            txtUserName.Text = "";
            txtUserPass.Text = "";
            txtConfirm.Text = "";
        }

        private void FUsers_Load(object sender, EventArgs e)
        {
            //Load data into data grid
            LoadDataInGrid(dgvUsers);

            if (this.dgvUsers.RowCount > 0)
            {
                //Takes the userID of the first
                int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);

                //Find the User and load into aUser
                aUser = aUser.findUserByUserID(connString, userID);

                //LoadData in boxes
                LoadDataInBoxes(aUser);
            }                                   
        }

        private void FUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana actual.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            else e.Cancel = false;
        }

        private void tsBtnFirst_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.RowCount > 0)
            {
                dgvUsers.CurrentCell = dgvUsers[0, 0];

                //Takes the userID
                int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);

                //Find the User and load into aUser
                aUser = aUser.findUserByUserID(connString, userID);

                //LoadData in boxes
                LoadDataInBoxes(aUser);
            }  
        }

        private void tsBtnPrevious_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.RowCount > 0)
            {
                if (dgvUsers.CurrentRow.Index > 0)
                {
                    dgvUsers.CurrentCell = dgvUsers[0, dgvUsers.CurrentRow.Index - 1];

                    //Takes the userID
                    int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);

                    //Find the User and load into aUser
                    aUser = aUser.findUserByUserID(connString, userID);

                    //LoadData in boxes
                    LoadDataInBoxes(aUser);
                }
            }                                            
        }

        private void tsBtnNext_Click(object sender, EventArgs e)
        {

            if (this.dgvUsers.RowCount > 0)
            {
                if (dgvUsers.CurrentRow.Index < dgvUsers.RowCount - 1)
                {
                    dgvUsers.CurrentCell = dgvUsers[0, dgvUsers.CurrentRow.Index + 1];

                    //Takes the userID
                    int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);

                    //Find the User and load into aUser
                    aUser = aUser.findUserByUserID(connString, userID);

                    //LoadData in boxes
                    LoadDataInBoxes(aUser);
                }                
            }              
        }

        private void tsBtnLast_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.RowCount > 0)
            {
                dgvUsers.CurrentCell = dgvUsers[0, dgvUsers.RowCount - 1];

                //Takes the userID
                int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);

                //Find the User and load into aUser
                aUser = aUser.findUserByUserID(connString, userID);

                //LoadData in boxes
                LoadDataInBoxes(aUser);
            }  
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            //Put form on edit mode.
            setEditMode();

            //Clear all data fields.
            clearUserTextBoxes();
            userIDToUpdate = -1;

            //Set userID to -1;
            txtUserID.Text = "";

            //Allow to write password
            txtUserPass.ReadOnly = false;
            txtConfirm.ReadOnly = false;

            //Reset user data 
            aUser = aUser.Reset();

            //Put focus on first component
            txtFirstName.Focus();
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.RowCount > 0)
            {
                //Put form on edit mode.
                setEditMode();

                //Take de UserID of the reg being updated
                userIDToUpdate = Convert.ToInt32(txtUserID.Text);

                //Load data for the user being updated
                aUser = aUser.findUserByUserID(connString, userIDToUpdate);

                //Not allow to update userPass
                txtUserPass.ReadOnly = true;
                txtConfirm.ReadOnly = true;

                //Énables button to change password
                btnChangePassword.Enabled = true;

                //Put focus on first component
                txtFirstName.Focus();
            }
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            //Puts form in Normal mode.
            setNormalMode();
            clearUserTextBoxes();
            userIDToUpdate = -1;

            if (dgvUsers.RowCount > 0)
            {
                //Goes to current reg
                dgvUsers.CurrentCell = dgvUsers[0, dgvUsers.CurrentRow.Index];

                //Takes user ID clicked
                int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);
                //Load data into aUser
                aUser = aUser.findUserByUserID(connString, userID);

                //Loads data into boxes
                LoadDataInBoxes(aUser);
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {

        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0)
            {
                string message = "Va a borrar el usuario : " + aUser.userName + ".\n" +
                                 "Esto incluye todos los datos asociados a el.\n" +
                                 "¿Esta seguro de hacerlo?";
                DialogResult valor = MessageBox.Show(message, "Atención...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (valor == DialogResult.OK)
                {
                    int position = dgvUsers.CurrentRow.Index;
                    int totalRegs = dgvUsers.RowCount;
                    if (position + 1 == totalRegs) position--;

                    //Delete data.
                    int res = aUser.deleteUserByUserID(connString, aUser.userID);

                    if (dgvUsers.RowCount > 0)
                    {
                        //Update data grid.
                        LoadDataInGrid(this.dgvUsers);

                        //Moves to position near deleted
                        dgvUsers.CurrentCell = dgvUsers[0, position];

                        //Load data from user in position
                        int userIDToFind = Convert.ToInt32(dgvUsers[0, position].Value);
                        aUser = aUser.findUserByUserID(connString, userIDToFind);
                    }
                    else
                    {
                        aUser = aUser.LoadData(-1, "", "", DateTime.Now, "", "", "", "");
                    }
                    //Load Data in boxes
                    LoadDataInBoxes(aUser);

                    //Put form in normal mode.
                    setNormalMode();
                    userIDToUpdate = -1;
                }
            }
        }   

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0)
            {
                //Takes user ID clicked
                int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);
                //Load data into aUser
                aUser = aUser.findUserByUserID(connString, userID);

                //Loads data into boxes
                LoadDataInBoxes(aUser);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //Check if user is admin, because is the only user with permission to change passwords.
            if (TrainItLibrary.Global.userNameWorking == "admin")
            {

                DialogResult result = MessageBox.Show("Solo puede fijar una contraseña nueva.\n" +
                                                      "Si habilita esta opción podrá introducir una contraseña nueva perdiendo la anterior. No podrá editar la existente. \n\n" +
                                                      "¿Desea continuar adelante con el cambio de contraseña?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    //Enables password change.
                    txtUserPass.ReadOnly = false;
                    txtConfirm.ReadOnly = false;
                    laConfirm.Visible = true;
                    txtConfirm.Visible = true;
                    btnChangePassword.Enabled = false;

                    savePass = true;
                }
            }
            else
            {
                MessageBox.Show("Solo Solo el usuario admin puede hacer un cambio de contraseña.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
      
    }
}



