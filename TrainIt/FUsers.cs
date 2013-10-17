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
        Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
        int userIDToUpdate = -1;

        public FUsers()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            setNormalMode();       
     }

        private void FUsers_Load(object sender, EventArgs e)
        {
            //Load data into data grid
            LoadDataInGrid(dgvUsers);
            tsTxtPosition.Text = dgvUsers.CurrentRow.Index.ToString();

            if (this.dgvUsers.RowCount > 0)
            {
                //Takes the userID of the firs
                int userID = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);

                //Find the User and load into aUser
                aUser = aUser.findUserByUserID(connString, userID);

                //LoadData in boxes
                LoadDataInBoxes(aUser);
            }                                   
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
            tsTxtPosition.ReadOnly = true;
            tsBtnNext.Enabled = false;
            tsBtnLast.Enabled = false;
            tsBtnNew.Enabled = false;
            tsBtnEdit.Enabled = false;
            tsBtnDelete.Enabled = false;
            tsBtnSave.Enabled = true;
            tsBtnCancel.Enabled = true;

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
            tsTxtPosition.ReadOnly = false;
            tsBtnNext.Enabled = true;
            tsBtnLast.Enabled = true;
            tsBtnNew.Enabled = true;
            tsBtnEdit.Enabled = true;
            tsBtnDelete.Enabled = true;
            tsBtnSave.Enabled = false;
            tsBtnCancel.Enabled = false;

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

        private void FUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana de usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtUserID.Text = "-1";

            //Allow to write password
            txtUserPass.ReadOnly = false;
            txtConfirm.ReadOnly = false;

            //Reset user data 
            aUser = aUser.Reset(aUser);
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
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0)
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
                    aUser = aUser.loadData(-1, "", "", DateTime.Now, "", "", "", "");
                }
                //Load Data in boxes
                LoadDataInBoxes(aUser);

                //Put form in normal mode.
                setNormalMode();
                userIDToUpdate = -1;
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            int position = 0;

            if (userIDToUpdate == -1)
            { //New
                //Takes position
                position = dgvUsers.RowCount;

                //Load data into aUSer
                aUser = aUser.loadData(-1, txtFirstName.Text, txtSecondName.Text, dtpBDate.Value, txtUserName.Text, txtUserPass.Text, txtConfirm.Text, txtMail.Text);

                //save data into BD
                aUser = aUser.saveUserData(aUser, connString);
            }
            else
            { //Update
                position = dgvUsers.CurrentRow.Index;

                //Load data into aUSer
                aUser = aUser.loadData(userIDToUpdate, txtFirstName.Text, txtSecondName.Text, dtpBDate.Value, txtUserName.Text, txtUserPass.Text, txtConfirm.Text, txtMail.Text);

                //save data into BD
                aUser = aUser.updateUserData(aUser, connString, userIDToUpdate);
            }

            //Reload data into grid
            LoadDataInGrid(dgvUsers);

            //Goes to the position
            dgvUsers.CurrentCell = dgvUsers[0, position];

            //Loads data into boxes
            LoadDataInBoxes(aUser);

            //Enable normal mode.
            setNormalMode();
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

    }
}
