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

namespace TrainIt
{
    public partial class FUserProfile : Form
    {
        private static bool onNewMode;
        private static bool saved = false;
        private bool passwordChange = false;
        private bool sportsChange = false;
        string connString = Utilities.GetConnString();

        public bool OnNewMode
        {
            get { return onNewMode; }
            set { onNewMode = value; }
        }

        public FUserProfile()
        {
            InitializeComponent();
            if (Global.userUsed.userID == -1)
            {
                MessageBox.Show("Introduzca los datos de usuario nuevo para poder acceder al programa.");
                btnChangePassword.Visible = false;
                bTShowPass.Visible = true;
                txtUserPass.ReadOnly = false;
                txtConfirm.ReadOnly = false;
                txtUserID.Text = "-1";
                this.Size = new System.Drawing.Size(477, 496);
                passwordChange = true;
            }
            else
            {
                txtUserID.Text = Global.userUsed.userID.ToString();
                txtFirstName.Text = Global.userUsed.userFirstName;
                txtSecondName.Text = Global.userUsed.userSecondName;
                txtMail.Text = Global.userUsed.userMail;
                dtpBDate.Value = Global.userUsed.userBDate;
                txtUserName.Text = Global.userUsed.userName;
                this.Size = new System.Drawing.Size(963, 496);
                bTShowPass.Visible = false;
                passwordChange = false;

                loadDataForSports(connString, Global.userUsed.userID);
            }
            saved = false;
            sportsChange = false;
        }

        private void loadDataForSports(string connString, long p)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string pass = userPass;
                string query = null;
                query = @"delete from TempUserSports;
                          select UserID, SportTypeID from UserSports where UserID=@userID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = Global.userUsed.userID;
                    
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {                       
                        addSportTypeToList(connString, reader.GetInt64(0), reader.GetInt64(1));
                    }
                    reader.Close();
                }
            }
            // Loads data into the 'trainITDataSet.TempUserSports' table. 
            this.tempUserSportsTableAdapter.Fill(this.trainITDataSet.TempUserSports);
        }

        private void FUserProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            txtUserPass.ReadOnly = false;
            txtConfirm.ReadOnly = false;
            bTShowPass.Visible = true;
            txtUserPass.Text = "";
            txtConfirm.Text = "";
            passwordChange = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            saved = true;
            FUserProfile.onNewMode = false;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool cambios = profileChanged(Global.userUsed);
            if ((cambios) || (sportsChange))
            {
                bool badPass = false;
                //check for username missing
                if (txtUserName.Text == "")
                {
                    txtUserName.BackColor = Color.Red;                    
                    badPass = true;
                    MessageBox.Show("Falta el nombre de usuario para poder acceder al programa.");
                }

                //check if password is correct only when a change request for pass has been made
                if ( (txtUserPass.Text.Length < 5) && (passwordChange) )
                {
                    txtUserPass.BackColor = Color.Red;                    
                    badPass = true;
                    MessageBox.Show("La contraseña debe tener una longitud mínima de cinco caracteres.");
                }

                if ((txtConfirm.Text != txtUserPass.Text) && (passwordChange) )
                {
                    txtUserPass.BackColor = Color.Red;
                    txtConfirm.BackColor = Color.Red;
                    badPass = true;
                    MessageBox.Show("La contraseña y su confirmación no coinciden");
                }

                if (!badPass)
                {
                    txtUserPass.BackColor = SystemColors.Window;
                    txtConfirm.BackColor = SystemColors.Window;
                    txtUserName.BackColor = SystemColors.Window;

                    //Loads user data into object
                    Int64 user = -1;
                    if (txtUserID.Text != "")
                        user = Convert.ToInt64(txtUserID.Text);

                    Global.userUsed = Global.userUsed.LoadData(user, txtFirstName.Text, txtSecondName.Text, dtpBDate.Value, txtUserName.Text, txtUserPass.Text, txtConfirm.Text, txtMail.Text);
                    if (onNewMode)
                    {
                        Global.userUsed = Global.userUsed.saveUserData(connString);
                        txtUserID.Text = Global.userUsed.userID.ToString();
                        MessageBox.Show("Nuevo usuario creado, confirme ahora la entrada al software.");
                        saved = true;
                        this.Close();
                    }
                    else
                    {
                        Global.userUsed = Global.userUsed.updateUserData(connString, passwordChange);
                        saved = true;
                        passwordChange = false;
                        txtUserPass.ReadOnly = true;
                        txtConfirm.ReadOnly = true;
                        MessageBox.Show("Datos de usuario actualizados");

                        if (sportsChange)
                        { //save data for sports
                            saveSportDataForUser(connString, Global.userUsed.userID);
                            sportsChange = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha habido cambios en la ficha de usuario. Grabación cancelada.");
            }
            
        }

        private void saveSportDataForUser(string connString, Int64 aUSerID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string pass = userPass;
                string query = null;
                query = @"delete from UserSports where UserID=@userID;
                          select UserID, SportTypeID from TempUserSports";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = aUSerID;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        addSportTypeToBD(connString, reader.GetInt64(0), reader.GetInt64(1));
                    }
                    reader.Close();
                }
            }
            // Loads data into the 'trainITDataSet.TempUserSports' table. 
            this.tempUserSportsTableAdapter.Fill(this.trainITDataSet.TempUserSports);
        }

        private void FUserProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (  (profileChanged(Global.userUsed) && (!saved) ) || ((sportsChange) && (!saved))  )
            {
                DialogResult res =MessageBox.Show("Hay cambios pendientes de grabar. ¿Desea salir sin grabar los cambios?", "ATENCIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    OnNewMode = false;
                    e.Cancel = false;
                }
            }
        }

        private bool profileChanged(Users users)
        {
            bool changed = false;

            if (txtFirstName.Text != Global.userUsed.userFirstName)
                changed = true;

            if (!changed)
            {
                if (txtSecondName.Text == Global.userUsed.userSecondName)
                    changed = false;
                else changed = true;
            }

            if (!changed)
            {
                if (txtMail.Text == Global.userUsed.userMail)
                    changed = false;
                else changed = true;
            }

            if (!changed)
            {
                if (txtUserName.Text == Global.userUsed.userName)
                    changed = false;
                else changed = true;
            }

            if ((!changed) && passwordChange)
            {
                if (txtUserPass.Text == Global.userUsed.userPass)
                    changed = false;
                else changed = true;
            }

            if (!changed)
            {
                if (dtpBDate.Value == Global.userUsed.userBDate)
                    changed = false;
                else changed = true;
            }

            return changed;
        }

        private void bTShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            //Eliminates de mask character an let see de content of the text box.
            txtUserPass.PasswordChar = (char)0;
        }

        private void bTShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            //Set de mask to the password text box.
            txtUserPass.PasswordChar = '*';
        }

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            //Check if is a correct mail address
            e.Cancel = false;
            if (txtMail.Text != "")
            {
                int at = txtMail.Text.IndexOf("@");
                int point = txtMail.Text.LastIndexOf(".");
                if (point+1 == txtMail.Text.Length)
                    point = -1;
                if ( (at==-1) || (point==-1) )
                    e.Cancel=true;                 
            }

            if (e.Cancel)
            {
                txtMail.BackColor = Color.Red;
                MessageBox.Show("La dirección de correo no es válida. Puede dejarla vacía, pero es importante para el caso en que quiera recuperar una contraseña olvidada.");
            }
            else
            {
                txtMail.BackColor = SystemColors.Window;
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            //check for username missing
            if (txtUserName.Text == "")
            {              
                error = true;
                MessageBox.Show("Falta el nombre de usuario para poder acceder al programa.");
            }
            
            //Check if user name exist only if was changed
            if ((!error) && (txtUserName.Text!=Global.userUsed.userName) )
            {
                Users aUserFound = new Users();
                aUserFound = aUserFound.findUserByUserName(connString, txtUserName.Text);
                if (aUserFound.userID != -1)
                {
                    error = true;
                    MessageBox.Show("Ya existe ese nombre de usuario en la base de datos.");
                }
            }

            if (error)
            {
                txtUserName.BackColor = Color.Red;
            }
            else
            {
                txtUserName.BackColor = SystemColors.Window;
            }

        }

        private void btnFindSport_Click(object sender, EventArgs e)
        {
            FSportTypes fSportTypes = new FSportTypes();
            fSportTypes.OnSearchMode = true;
            fSportTypes.ShowDialog();

            if (fSportTypes.OnSearchMode)
            {
                Int64 aSportID = Global.sportTypeUsed.SportTypeID;
                //txtSportTypeName.Text = Global.sportTypeUsed.SportTypeName;
                fSportTypes.OnSearchMode = false;

                //Check if Sports yet exists on bd
                bool finded = false;
                finded = SportTypes.checkIfSportsIsInUserList(connString, aSportID, Global.userUsed.userID);

                if (!finded)
                {
                    addSportTypeToList(connString, Global.userUsed.userID, aSportID);
                    sportsChange = true;
                }
                else
                {
                    MessageBox.Show("Ese deporte ya estaba en la lista.");
                }
            }
        }

        private void addSportTypeToList(string connString, Int64 aUserID, Int64 aSportTypeID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string pass = userPass;
                string query = null;
                query = "insert into TempUserSports (UserID, SportTypeID) values (@userID,@sportTypeID)";
               
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = aUserID;

                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.VarChar));
                    cmd.Parameters["@sportTypeID"].Value = aSportTypeID;                    

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            // Loads data into the 'trainITDataSet.TempUserSports' table. 
            this.tempUserSportsTableAdapter.Fill(this.trainITDataSet.TempUserSports);
        }

        private void addSportTypeToBD(string connString, Int64 aUserID, Int64 aSportTypeID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string pass = userPass;
                string query = null;
                query = "insert into UserSports (UserID, SportTypeID) values (@userID,@sportTypeID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = aUserID;

                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.VarChar));
                    cmd.Parameters["@sportTypeID"].Value = aSportTypeID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            // Loads data into the 'trainITDataSet.TempUserSports' table. 
            this.tempUserSportsTableAdapter.Fill(this.trainITDataSet.TempUserSports);
        }

        private void btnDelSport_Click(object sender, EventArgs e)
        {//Delete selected sports from user´s favourites sports
            Int64 aSportTypeID = Convert.ToInt64(dgvUserSports[0, dgvUserSports.CurrentRow.Index].Value);
            string aSportTypeName = dgvUserSports[1, dgvUserSports.CurrentRow.Index].Value.ToString();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string message="¿Desea eliminar el deportes "+Convert.ToString(aSportTypeID)+"/"+aSportTypeName+" de su lista de favoritos?";
                DialogResult result = MessageBox.Show(message, "Atención",
                                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == result)
                {
                    //string pass = userPass;
                    string query = null;
                    query = "delete from TempUserSports Where UserID=@userID AND SportTypeID=@sportTypeID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                        cmd.Parameters["@userID"].Value = Global.userUsed.userID;

                        cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                        cmd.Parameters["@sportTypeID"].Value = aSportTypeID;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    // Loads data into the 'trainITDataSet.TempUserSports' table. 
                    this.tempUserSportsTableAdapter.Fill(this.trainITDataSet.TempUserSports);
                    sportsChange = true;
                }
            }            
        }

        private void btnDelAllSports_Click(object sender, EventArgs e)
        {//Delete all sports from user´s favourites sports
            using (SqlConnection conn = new SqlConnection(connString))
            {
                DialogResult result = MessageBox.Show("¿Desea borrar todos los deportes favoritos de su perfil?", "Atención",
                                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK==result)
                {
                    //string pass = userPass;
                    string query = null;
                    query = "delete from TempUserSports Where UserID=@userID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                        cmd.Parameters["@userID"].Value = Global.userUsed.userID;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    // Loads data into the 'trainITDataSet.TempUserSports' table. 
                    this.tempUserSportsTableAdapter.Fill(this.trainITDataSet.TempUserSports);
                    sportsChange = true;
                }
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string message ="Va a borrar al usuario actual: ("+ txtUserID.Text+"-"+txtUserName.Text+").  Igualmente se borrarán todos los datos asociados."+
                            "Esta operación no tiene vuelta atrás.  ¿Está realmente seguro?";
            bool delete = false;
            DialogResult res = MessageBox.Show(message,"Atención",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (res==DialogResult.OK)
	        {
		        message = "Por segunda vez. ¿Está realmente seguro de borrar el usuario?. Una vez borrado el usuario se cerrará el programa.";
                res = MessageBox.Show(message,"Atención",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (res==DialogResult.OK)
                    delete=true;
	        }

            if (delete)
            {
                int result = Users.deleteUserByUserID(connString, Convert.ToInt64(txtUserID.Text));
                if (result == 1)
                {
                    MessageBox.Show("Usuario eliminado. Cerrando el programa.");
                    this.Close();
                    FMain.closeAppWithQuestion = false;
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Hubo algún problema durante el borrado del usuario eliminado. No se ha eliminado ningún dato.");
                }

            }		 	
        }
    }
}
