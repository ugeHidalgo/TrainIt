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
        public Int64 userID;        
        public string userFirstName;
        public string userSecondName;
        public DateTime userBDate;
        public string userName;
        public string userPass;
        public string userConfirmPassword;
        public string userMail;

        public Users()
        {
            userID = -1;
            userFirstName = "";
            userSecondName = "";
            userBDate = DateTime.Now;
            userName = "";
            userPass = "";
            userConfirmPassword = "";
            userMail = "";
        }


        public Users(Int64 UserID, string UserFirstName, string UserSecondName, DateTime UserBDate, string UserLoginName,
                     string UserPassword, string UserConfirmPassword, string UserMail)
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
        public Users LoadData(Int64 UserID, string UserFirstName, string UserSecondName, DateTime UserBDate, string UserLoginName,
                     string UserPassword, string UserConfirmPassword, string UserMail)
        {
            Users aUser = new Users(UserID, UserFirstName, UserSecondName, UserBDate, UserLoginName, UserPassword, UserConfirmPassword, UserMail);
            return aUser;
        }

        //Reset the user object
        public Users Reset()
        {
            Users aUser = new Users();
            return aUser;
        }

        //Check user data
        public int checkUserData(string connString)
        { /*Verify the data to save:
           *       1: Data is ok to save.
           *      -1: userName is missing.
           *      -2: userName exists in data base.
           *      -3: Password lenght is less than 8 characters.
           *      -4: Password and Confirm are differents.
           */
            int res = 1;            
            Boolean sigue = true;
            //Check if username is empty
            if (userName == "")
            {
                res = -1;
                sigue = false;
            }
            
            if (sigue)
            {
                Users aUser = findUserByUserName(connString, userName);
                if (aUser.userID != -1)
                { //user exits in DB
                    sigue = false;
                    res = -2;
                }
            }

            if (sigue)
            {
                int lenghtPassword = userPass.Length;
                if (lenghtPassword<8)
                { //Password shorter than 8 characters
                    sigue = false;
                    res = -3;
                }
            }
            
            if (sigue && (userPass!=userConfirmPassword))
                res = -4; //Password and confirm are differents           

            return res;
        }

        //Save an User object into BD using a connection, suposses data are checked with checkUserData.
        public Users saveUserData(string connString)
        { //Return the user saved. If error return an empty user with userId=-1
            Users aUser = new Users();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string pass = userPass;
                string query = String.Format(@"INSERT INTO Users(UserFirstName, UserSecondName, UserBdate, UserName, UserPass, UserMail)
                                            VALUES(@userFirstName,@userSecondName,@userBDate,@userName,PwdEncrypt('{0}'),@userMail)", pass);
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userFirstName", SqlDbType.VarChar));
                    cmd.Parameters["@userFirstName"].Value = userFirstName;

                    cmd.Parameters.Add(new SqlParameter("@userSecondName", SqlDbType.VarChar));
                    cmd.Parameters["@userSecondName"].Value = userSecondName;

                    cmd.Parameters.Add(new SqlParameter("@userBDate", SqlDbType.Date));
                    cmd.Parameters["@userBDate"].Value = userBDate;

                    cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
                    cmd.Parameters["@userName"].Value = userName;

                    cmd.Parameters.Add(new SqlParameter("@userMail", SqlDbType.VarChar));
                    cmd.Parameters["@userMail"].Value = userMail;

                    conn.Open();
                    int res = cmd.ExecuteNonQuery();

                    //Find the userID asigned.                        
                    if (res >= 0)
                    {
                        string user = userName;
                        aUser = aUser.findUserByUserName(connString, user);
                    }                    
                }
            }      
            return aUser;
        }

        //Update an User object into BD using a connection and a userID, suposses data are checked with checkUserData.
        public Users updateUserData(string connString, Boolean savePassword)
        { //Return the user updated. If error return an empty user with userID=-1
            Users aUser = new Users();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string pass = userPass;
                string query = null;

                if (!savePassword)
                {
                    query = @"UPDATE Users SET UserFirstName=@userFirstName, UserSecondName=@userSecondName, 
                              UserBdate=@userBDate, UserName=@userName , UserMail=@userMail
                               WHERE UserID=@userID";
                }
                else
                {
                    query = String.Format(@"UPDATE Users SET UserFirstName=@userFirstName, UserSecondName=@userSecondName,
                                                UserBdate=@userBDate, UserName=@userName, UserPass=PwdEncrypt('{0}'), UserMail=@userMail
                                                WHERE UserID=@userID", userPass);
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userID;

                    cmd.Parameters.Add(new SqlParameter("@userFirstName", SqlDbType.VarChar));
                    cmd.Parameters["@userFirstName"].Value = userFirstName;

                    cmd.Parameters.Add(new SqlParameter("@userSecondName", SqlDbType.VarChar));
                    cmd.Parameters["@userSecondName"].Value = userSecondName;

                    cmd.Parameters.Add(new SqlParameter("@userBDate", SqlDbType.Date));
                    cmd.Parameters["@userBDate"].Value = userBDate;

                    cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
                    cmd.Parameters["@userName"].Value = userName;

                    cmd.Parameters.Add(new SqlParameter("@userMail", SqlDbType.VarChar));
                    cmd.Parameters["@userMail"].Value = userMail;

                    conn.Open();
                    int res = cmd.ExecuteNonQuery();

                    //Find the userID asigned.
                    if (res > 0)
                    {
                        aUser = aUser.findUserByUserID(connString, userID);
                    }
                }
            }                       
            return aUser;
        }

        //Find an user into de DB. Given a user ID and returns all data into de Users object. If not find return a user with userID=-1.
        public Users findUserByUserID(string connString, Int64 userID)
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
                        aUser.userID = reader.GetInt64(0);
                        aUser.userFirstName = reader.GetString(1);
                        aUser.userSecondName = reader.GetString(2);
                        aUser.userBDate = Convert.ToDateTime(reader.GetDateTime(3));
                        aUser.userName = reader.GetString(4);
                        aUser.userPass = reader.GetSqlBinary(5).ToString();
                        aUser.userConfirmPassword = aUser.userPass;
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
                        aUser.userID = reader.GetInt64(0);
                        aUser.userFirstName = reader.GetString(1);
                        aUser.userSecondName = reader.GetString(2);
                        aUser.userBDate = Convert.ToDateTime(reader.GetDateTime(3));
                        aUser.userName = reader.GetString(4);
                        aUser.userPass = reader.GetSqlBinary(5).ToString();
                        aUser.userConfirmPassword = aUser.userPass;
                        aUser.userMail = reader.GetString(6); 
                    }
                    reader.Close();
                }
            }
            return aUser; 
        }

        //Delete a user using his userID.
        public static int deleteUserByUserID(string connString, Int64 aUserID)
        { //Return 1 if deleted,-1 if any problem.
            int res = -1;
            Users aUser = new Users();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "delete from Users where UserID = @userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = aUserID;
                    conn.Open();
                    res=cmd.ExecuteNonQuery();                    
                }
            }
            return res;
        }

        //verifies a userName/password combination
        public Users verifyPass(string userName, string userPass, string connString)
        { //return the user found if login is correct, if not return a user with userID=-1            
            Users tempUser = new Users();
            int count = 0;
            //Comprobamos el login.
            using (SqlConnection conn = new SqlConnection(connString))
            {               
                string query = String.Format(@"select * from Users where UserName=@userLeido and PWdCompare('{0}',UserPass)=1", userPass);
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userLeido", SqlDbType.VarChar));
                    cmd.Parameters["@userLeido"].Value = userName;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            count++;
                            tempUser.userID = reader.GetInt64(0);
                            tempUser.userFirstName = reader.GetString(1);
                            tempUser.userSecondName = reader.GetString(2);
                            tempUser.userBDate = Convert.ToDateTime(reader.GetDateTime(3));
                            tempUser.userName = reader.GetString(4);
                            tempUser.userPass = reader.GetSqlBinary(5).ToString();
                            tempUser.userConfirmPassword = tempUser.userPass;
                            tempUser.userMail = reader.GetString(6);
                        }
                        reader.Close();
                    }
                    catch
                    {                        
                        tempUser.userID = -2;
                    }
                }
            }

            return tempUser;
        }
    }
}
