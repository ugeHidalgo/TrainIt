using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainItLibrary;
using System.Windows.Forms;

namespace TrainIt
{
    public partial class FLogin : Form
    {
        Boolean accessGranted = false;
        string connString = TrainItLibrary.Utilities.GetConnString();
        public string userNameGiven = null;
        public Int64 userIDGiven = -1;
        string userPassGiven = null;        

        public FLogin()
        {
            InitializeComponent();
        }

        //Try to validate password, and then goes into the app.
        private void btAccept_Click(object sender, EventArgs e)
        {
            Boolean sigue = true;

            //Takes user ID clicked
            userNameGiven = txtUser.Text;
            userPassGiven = txtPass.Text;

            //Verify if an user has been entered.
            if (userNameGiven=="")
            {
                MessageBox.Show("No has introducido un nombre de ususario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sigue = false;
            }

            //Verify password
            if (sigue)
            {
                Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
                aUser = aUser.verifyPass (userNameGiven, userPassGiven, connString);
                userIDGiven = aUser.userID;
                if (aUser.userID == -1)
                {
                    sigue = false;
                    MessageBox.Show("Usuario o contraseña incorrectos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (aUser.userID == -2)
                {
                    sigue = false;
                    MessageBox.Show("No se puede conectar con el servidor de datos");
                }
                
            }

            //give or not access depending de result of the query
            if (sigue)
            {
                accessGranted = true;
                Global.userUsed = Global.userUsed.findUserByUserID(connString, userIDGiven);
                Global.userNameWorking = userNameGiven;
                Close();
            }
        }

        //Close the application
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        //Show the password into the text edit
        private void bTShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            //Eliminates de mask character an let see de content of the text box.
            txtPass.PasswordChar = (char)0;
        }

        //Encript the password when stop hold mouse button
        private void bTShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            //Set de mask to the password text box.
            txtPass.PasswordChar = '*';
        }

        //Goes to FUsers to create a new user.
        private void laNewUser_Click(object sender, EventArgs e)
        {
            FUserProfile fUserProfile = new FUserProfile();
            fUserProfile.OnNewMode = true;           
            fUserProfile.ShowDialog();

            if (fUserProfile.OnNewMode)
            {
                txtUser.Text = Global.userUsed.userName;
                txtPass.Text = "";
                fUserProfile.OnNewMode = false;
            }
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!accessGranted) Application.Exit();          
        }
    }
}
