using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TrainItLibrary
{
    public class Users
    {
        public int userID;        
        public string userFirstName;
        public string userSecondName;
        public DateTime userBDate;
        public string userName;
        public string userPass;
        public string userConfirmPassword;
        public string userMail;

        public Users(int UserID, string UserFirstName, string UserSecondName, DateTime UserBDate, String UserLoginName,
                     String UserPassword, String UserConfirmPassword, String UserMail)
        {
            userID = UserID;
            userFirstName = UserFirstName;
            userSecondName = UserSecondName;
            userBDate = UserBDate;
            userName = UserLoginName;
            userPass = UserPassword;
            userConfirmPassword = UserConfirmPassword;
            userMail = UserMail;
        }

        //Load data into a user object
        public Users loadData(int UserID, string UserFirstName, string UserSecondName, DateTime UserBDate, String UserLoginName,
                     String UserPassword, String UserConfirmPassword, String UserMail)
        {
            Users aUser = new Users(UserID, UserFirstName, UserSecondName, UserBDate, UserLoginName, UserPassword, UserConfirmPassword, UserMail);
            return aUser;
        }

        //Reset the user object
        public Users Reset(Users aUser)
        {
            aUser.userID = -1;
            aUser.userFirstName = "";
            aUser.userSecondName = "";
            aUser.userBDate = DateTime.Now;
            aUser.userName = "";
            aUser.userPass = "";
            aUser.userConfirmPassword = "";
            aUser.userMail = "";
            return aUser;
        }

        //Check user data
        public int checkUserData(Users aUser)
        { //0: ok, -1: missing user name, -1:pass and confirm not equal
            int res = 0;
            if (aUser.userName == "")
                res = -1;
            else if (aUser.userPass!=aUser.userConfirmPassword)
                        res = -2;
            return res;
        }

        //Save an User object into BD using a connection
        public Users saveUserData(Users aUser, string connString)
        { //Return the user saved. If error return an empty user with userId=-1
            int res = checkUserData(aUser);
            if (res >= 0)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string pass = aUser.userPass;
                    string query = String.Format(@"INSERT INTO Users(UserFirstName, UserSecondName, UserBdate, UserName, UserPass, UserMail)
                                            VALUES(@userFirstName,@userSecondName,@userBDate,@userName,PwdEncrypt('{0}'),@userMail)", pass);
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@userFirstName", SqlDbType.VarChar));
                        cmd.Parameters["@userFirstName"].Value = aUser.userFirstName;

                        cmd.Parameters.Add(new SqlParameter("@userSecondName", SqlDbType.VarChar));
                        cmd.Parameters["@userSecondName"].Value = aUser.userSecondName;

                        cmd.Parameters.Add(new SqlParameter("@userBDate", SqlDbType.Date));
                        cmd.Parameters["@userBDate"].Value = aUser.userBDate;

                        cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
                        cmd.Parameters["@userName"].Value = aUser.userName;

                        cmd.Parameters.Add(new SqlParameter("@userMail", SqlDbType.VarChar));
                        cmd.Parameters["@userMail"].Value = aUser.userMail;

                        conn.Open();
                        res=cmd.ExecuteNonQuery(); 
                       
                        //Find the userID asigned.
                        if (res > 0)
                        {
                            string user = aUser.userName;
                            aUser = aUser.findUserByUserName(connString, user);
                        }
                        else
                        {
                            aUser = aUser.loadData(-1, "", "", DateTime.Now, "", "", "", "");
                        }
                    }
                }
            }
            return aUser;
        }
        
        //Update an User object into BD using a connection and a userID
        public Users updateUserData(Users aUser, string connString, int userID)
        { //Return the user updated. If error return an empty user with userID=-1
            int res = checkUserData(aUser);
            if (res < 0)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string pass = aUser.userPass;
                    string query = @"UPDATE Users SET UserFirstName=@userFirstName, UserSecondName=@userSecondName, 
                              UserBdate=@userBDate, UserName=@userName , UserMail=@userMail
                               WHERE UserID=@userID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                        cmd.Parameters["@userID"].Value = userID;

                        cmd.Parameters.Add(new SqlParameter("@userFirstName", SqlDbType.VarChar));
                        cmd.Parameters["@userFirstName"].Value = aUser.userFirstName;

                        cmd.Parameters.Add(new SqlParameter("@userSecondName", SqlDbType.VarChar));
                        cmd.Parameters["@userSecondName"].Value = aUser.userSecondName;

                        cmd.Parameters.Add(new SqlParameter("@userBDate", SqlDbType.Date));
                        cmd.Parameters["@userBDate"].Value = aUser.userBDate;

                        cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
                        cmd.Parameters["@userName"].Value = aUser.userName;

                        cmd.Parameters.Add(new SqlParameter("@userMail", SqlDbType.VarChar));
                        cmd.Parameters["@userMail"].Value = aUser.userMail;

                        conn.Open();
                        res = cmd.ExecuteNonQuery();

                        //Find the userID asigned.
                        if (res > 0)
                        {
                            aUser = aUser.findUserByUserID(connString, userID);
                        }
                        else
                        {
                            aUser = aUser.loadData(-1, "", "", DateTime.Now, "", "", "", "");
                        }
                    }
                }
            }
            return aUser;

        }

        //Find an user into de DB. Given a user ID and returns all data into de Users object. If not find return a user with userID=-1.
        public Users findUserByUserID(string connString, int userID)
        {
            Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
            using (SqlConnection conn = new SqlConnection(connString))
            {                
                string query = "select UserID, UserFirstName, UserSecondName, UserBdate, UserName, UserPass, UserMail from Users where UserID = @userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = userID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        aUser.userID = reader.GetInt32(0);
                        aUser.userFirstName = reader.GetString(1);
                        aUser.userSecondName = reader.GetString(2);
                        aUser.userBDate = Convert.ToDateTime(reader.GetDateTime(3));
                        aUser.userName = reader.GetString(4);
                        aUser.userPass = reader.GetSqlBinary(5).ToString();
                        aUser.userMail = reader.GetString(6);                        
                    }
                    reader.Close();                        
                }
            }
            return aUser;            
        }

        //Find an user into de DB. Given a user Name and returns all data into de Users object. If not find return a user with userID=-1.
        public Users findUserByUserName(string connString, string userName)
        {
            Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select UserID, UserFirstName, UserSecondName, UserBdate, UserName, UserPass, UserMail from Users where UserName = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
                    cmd.Parameters["@userName"].Value = userName;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        aUser.userID = reader.GetInt32(0);
                        aUser.userFirstName = reader.GetString(1);
                        aUser.userSecondName = reader.GetString(2);
                        aUser.userBDate = Convert.ToDateTime(reader.GetDateTime(3));
                        aUser.userName = reader.GetString(4);
                        aUser.userPass = reader.GetSqlBinary(5).ToString();
                        aUser.userMail = reader.GetString(6);
                    }
                    reader.Close();
                }
            }
            return aUser; 
        }

        //Delete a user using his userID.
        public int deleteUserByUserID(string connString, Int32 aUserID)
        { //Return 1 if deleted,-1 if any problem.
            int res = -1;
            Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "delete from Users where UserID = @userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = aUserID;
                    conn.Open();
                    res=cmd.ExecuteNonQuery();                    
                }
            }
            return res;
        }

        //verifies a userName/password combination
        public Boolean verifyPass(string userName, string userPass, string connString)
        {
            bool res = false;

            int count = 0;
            //Comprobamos el login.
            using (SqlConnection conn = new SqlConnection(connString))
            {               
                string query = String.Format(@"select UserName from Users where UserName=@userLeido and PWdCompare('{0}',UserPass)=1", userPass);
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userLeido", SqlDbType.VarChar));
                    cmd.Parameters["@userLeido"].Value = userName;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        count++;
                    }
                    reader.Close();
                }
            }

            if (count > 0) res = true;
            else res = false;

            return res;
        }
    }
}
