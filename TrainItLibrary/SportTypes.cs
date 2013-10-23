using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrainItLibrary
{
    public class SportTypes
    {
        public int sportTypeID;
        public string sportTypeName;
        public int parentSportTypeID;
        public string memo;
        public int userID;

        //Creates an empty SportType object
        public SportTypes()
        {
            sportTypeID = -1;
            sportTypeName = "";
            parentSportTypeID = -1;
            memo = "";
            userID = -1;
        }

        //Creates a SportType object with data
        public SportTypes(int SportTypeID, string SportTypeName, int ParentSportTypeID, string Memo, int UserID)
        {            
            sportTypeID = SportTypeID;
            sportTypeName = SportTypeName;
            parentSportTypeID = ParentSportTypeID;
            memo = Memo;
            userID = UserID;
        }

        //Creates a SportType object with data
        public SportTypes LoadData(int SportTypeID, string SportTypeName, int parentSportTypeID, string Memo, int UserID)
        {
            SportTypes aSportType = new SportTypes(SportTypeID, SportTypeName, parentSportTypeID, Memo, UserID); 
            return aSportType;

        }

        //Reset data into a SportType object
        public SportTypes Reset()
        {
            SportTypes a = new SportTypes();
            return a;
        }

        //Save SportType object into BD returning the ID of the object inserted. 0 in case of error
        public SportTypes SaveData(string connString)
        {  
            int res = 0;
            SportTypes aSportType = new SportTypes();
            using (SqlConnection conn = new SqlConnection(connString))
            {                
                string query = @"INSERT INTO SportTypes(SportTypeName, ParentSportTypeID, Memo, UserID)
                                 VALUES(@sportTypeName, @parentSportTypeID, @memo, @userID);                                 
                                 SELECT CAST(SCOPE_IDENTITY() AS int)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sportTypeName", SqlDbType.VarChar));
                    cmd.Parameters["@sportTypeName"].Value = sportTypeName;

                    cmd.Parameters.Add(new SqlParameter("@parentSportTypeID", SqlDbType.Int));
                    cmd.Parameters["@parentSportTypeID"].Value = parentSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@memo", SqlDbType.VarChar));
                    cmd.Parameters["@memo"].Value = memo;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = userID;

                    conn.Open();
                    //res = cmd.ExecuteNonQuery();
                    res = (Int32)cmd.ExecuteScalar();
                    if (res > 0)
                    {
                        aSportType = aSportType.LoadData(res, sportTypeName, parentSportTypeID, memo, userID);
                    }
                }
            }
            return aSportType;
        }

        //Update an User object into BD using a connection and a userID, suposses data are checked with checkUserData.
        public SportTypes UpdateData(string connString)
        { //Return the user updated. If error return an empty user with userID=-1
            SportTypes aSportType = new SportTypes();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string pass = userPass;
                string query = null;

                query = @"UPDATE SportTypes SET SportTypeName=@sportTypeName, ParentSportTypeID=@parentSportTypeID, 
                          Memo=@memo, UserID=@userID
                          WHERE SportTypeID=@sportTypeID";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.Int));
                    cmd.Parameters["@sportTypeID"].Value = sportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@sportTypeName", SqlDbType.VarChar));
                    cmd.Parameters["@sportTypeName"].Value = sportTypeName;

                    cmd.Parameters.Add(new SqlParameter("@parentSportTypeID", SqlDbType.Int));
                    cmd.Parameters["@parentSportTypeID"].Value = parentSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@memo", SqlDbType.VarChar));
                    cmd.Parameters["@memo"].Value = memo;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = userID;

                    conn.Open();
                    int res = cmd.ExecuteNonQuery();

                    //Find the userID asigned.
                    if (res > 0)
                    {
                        aSportType = aSportType.LoadData(sportTypeID, sportTypeName, parentSportTypeID, memo, userID);                        
                    }
                }
            }
            return aSportType;
        }

        //Find an SportType object by a given ID, and return this object. If not find returns an SportType object with ID=-1
        public SportTypes FindSportTypeByID(string connString)
        {
            SportTypes aSportType = new SportTypes();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * from SportTypes WHERE SportTypeID = @sportTypeID AND UserID=@userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.Int));
                    cmd.Parameters["@SportTypeID"].Value = sportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = userID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        aSportType.sportTypeID = reader.GetInt32(0);
                        aSportType.sportTypeName = reader.GetString(1);
                        aSportType.parentSportTypeID = reader.GetInt32(2);
                        aSportType.memo = reader.GetString(3);
                        aSportType.userID = reader.GetInt32(4);
                    }
                    reader.Close();
                }
            }
            return aSportType;  
        }

        //Find an SportType object by a given name, and return this object. If not find returns an SportType object with ID=-1
        public SportTypes FindSportTypeByName(string connString)
        {
            SportTypes aSportType = new SportTypes();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * from SportTypes WHERE SportTypeName = @sportTypeName AND UserID=@userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sportTypeName", SqlDbType.VarChar));
                    cmd.Parameters["@SportTypeName"].Value = sportTypeName;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = userID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        aSportType.sportTypeID = reader.GetInt32(0);
                        aSportType.sportTypeName = reader.GetString(1);
                        aSportType.parentSportTypeID = reader.GetInt32(2);
                        aSportType.memo = reader.GetString(3);
                        aSportType.userID = reader.GetInt32(4);
                    }
                    reader.Close();
                }
            }
            return aSportType;
        }

        //Delete de given object
        public int Delete(string connString)
        {//Return 1 if deleted,-1 if any problem.
            int res = -1;         
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //Delete all 
                string query = "DELETE FROM SportTypes WHERE SportTypeID=@sportTypeID AND UserID=@userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.Int));
                    cmd.Parameters["@sportTypeID"].Value = sportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = userID;
                    conn.Open();
                    res = cmd.ExecuteNonQuery();
                }
            }
            return res;
        }

        //Check if data into de object is correct to save into de BD
        public int CheckData(string connString)
        { // 1: Data is ok
          // 0: SportType Name not given
          //-1: SportTypeName exist on BD.
          //-2: ParentSportID does not exist on BD and is different to 0(root)
            int res = 1;
            
            Users aUser = new Users();
            bool sigue = true;
            if ((sportTypeName=="") || (sportTypeName==null))
            {
                sigue = false;
                res = 0; //0: SportType Name not given
            }
            if (sigue)
            {
                SportTypes aST = new SportTypes(sportTypeID, sportTypeName, parentSportTypeID, memo, userID);

                aST = aST.FindSportTypeByID(connString);
                if (aST.sportTypeID != -1)
                {
                    sigue = false;
                    res = -1; //-1: SportTypeName exist on BD.
                }
            }

            if (sigue)
            {
                if (parentSportTypeID != 0)
                {
                    SportTypes aST = new SportTypes(parentSportTypeID, sportTypeName, parentSportTypeID, memo, userID);                    
                    aST = aST.FindSportTypeByID(connString);
                    if (aST.sportTypeID == -1)
                    {
                        sigue = false;
                        res = -2; //-2: ParentSportID does not exist on BD and is different to 0(root)
                    }
                }
            }
             
            if (sigue)
            {
                aUser = aUser.LoadData(userID, null, null, DateTime.Now, null, null, null, null);
                aUser = aUser.findUserByUserID(connString,userID);
                if (aUser.userID == -1)
                {
                    sigue = false;
                    res = -3; //-3: UserID does not exist on BD.
                }
            }

            return res;
        }        

        public SportTypes FindParentSportType(string connString)
        {//Return an object containing the parent SportType.
            SportTypes aSportType = new SportTypes();
            aSportType.sportTypeID = parentSportTypeID;
            aSportType.userID = userID;
            aSportType = aSportType.FindSportTypeByID(connString);
            return aSportType;
        }
    }
}
