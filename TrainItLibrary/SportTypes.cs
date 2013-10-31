using System;
using System.Data;
using System.Data.SqlClient;

namespace TrainItLibrary
{
    public class SportTypes
    {
        private Int64 sportTypeID;
        private string sportTypeName;
        private Int64 parentSportTypeID;
        private string memo;
        private Int64 userID;

        public Int64 SportTypeID
        {
            get { return sportTypeID; }
            set { sportTypeID = value; }
        }
        public string SportTypeName
        {
            get { return sportTypeName; }
            set { sportTypeName = value; }
        }
        public Int64 ParentSportTypeID
        {
            get { return parentSportTypeID; }
            set { parentSportTypeID = value; }
        }
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
        public Int64 UserID
        {
            get { return userID; }
            set { userID = value; }
        }


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
        public SportTypes(Int64 SportTypeID, string SportTypeName, Int64 ParentSportTypeID, string Memo, Int64 UserID)
        {            
            sportTypeID = SportTypeID;
            sportTypeName = SportTypeName;
            parentSportTypeID = ParentSportTypeID;
            memo = Memo;
            userID = UserID;
        }

        //Load data into a SportType object.
        public void LoadData(Int64 SportTypeID, string SportTypeName, Int64 ParentSportTypeID, string Memo, Int64 UserID)
        {
            sportTypeID = SportTypeID;
            sportTypeName = SportTypeName;
            parentSportTypeID = ParentSportTypeID;
            memo = Memo;
            userID = UserID;
        }

        //Reset data into a SportType object
        public void Reset()
        {
            sportTypeID = -1;
            sportTypeName = "";
            parentSportTypeID = -1;
            memo = "";
            userID = -1;
        }

        //Find an SportType object by a given ID, and return this object. If not find returns an SportType object with ID=-1
        public SportTypes FindSportTypeByID(string connString)
        {
            SportTypes returnSportType = new SportTypes();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * from SportTypes WHERE SportTypeID = @sportTypeID AND UserID=@userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@SportTypeID"].Value = sportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())                      
                        returnSportType.LoadData(reader.GetInt64(0), reader.GetString(1), reader.GetInt64(2), reader.GetString(3), reader.GetInt64(4));                    
                    reader.Close();
                }
            }
            return returnSportType;
        }

        //Save SportType object into BD returning the ID of the object inserted. 0 in case of error
        public SportTypes SaveData(string connString)
        {  
            Int64 res = 0;
            SportTypes aSportType = new SportTypes();
            using (SqlConnection conn = new SqlConnection(connString))
            {                
                string query = @"INSERT INTO SportTypes(SportTypeName, ParentSportTypeID, Memo, UserID)
                                 VALUES(@sportTypeName, @parentSportTypeID, @memo, @userID);                                 
                                 SELECT CAST(SCOPE_IDENTITY() AS bigint)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sportTypeName", SqlDbType.VarChar));
                    cmd.Parameters["@sportTypeName"].Value = sportTypeName;

                    cmd.Parameters.Add(new SqlParameter("@parentSportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@parentSportTypeID"].Value = parentSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@memo", SqlDbType.VarChar));
                    cmd.Parameters["@memo"].Value = memo;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userID;

                    conn.Open();
                    //res = cmd.ExecuteNonQuery();
                    res = (Int64)cmd.ExecuteScalar();
                    if (res > 0)
                    {
                        aSportType.LoadData(res, sportTypeName, parentSportTypeID, memo, userID);
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
                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@sportTypeID"].Value = sportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@sportTypeName", SqlDbType.VarChar));
                    cmd.Parameters["@sportTypeName"].Value = sportTypeName;

                    cmd.Parameters.Add(new SqlParameter("@parentSportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@parentSportTypeID"].Value = parentSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@memo", SqlDbType.VarChar));
                    cmd.Parameters["@memo"].Value = memo;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userID;

                    conn.Open();
                    int res = cmd.ExecuteNonQuery();

                    //Find the userID asigned.
                    if (res > 0)
                    {
                        aSportType.LoadData(sportTypeID, sportTypeName, parentSportTypeID, memo, userID);                        
                    }
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

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        aSportType.LoadData(reader.GetInt64(0), reader.GetString(1), reader.GetInt64(2), reader.GetString(3), reader.GetInt64(4));                    
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
                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@sportTypeID"].Value = TrainItLibrary.Global.sportTypeUsed.SportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = TrainItLibrary.Global.sportTypeUsed.UserID;
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
            SportTypes aST = new SportTypes();                    
            int res = 1;            
            bool sigue = true;

            if ((sportTypeName == "") || (sportTypeName == null))
            {
                sigue = false;
                res = 0; //0: SportType Name not given
            }
            if (sigue)
            {
                aST.sportTypeName = sportTypeName;
                aST.userID = userID;
                aST = aST.FindSportTypeByName(connString);
                if (aST.SportTypeID != -1)
                {
                    sigue = false;
                    res = -1; //-1: SportTypeName exist on BD.
                }
            }

            if (sigue)
            {
                if (parentSportTypeID != 0)
                {
                    aST.sportTypeID = parentSportTypeID;
                    aST.userID = userID;
                    aST = aST.FindSportTypeByID(connString);
                    if (aST.SportTypeID == -1)
                    {
                        sigue = false;
                        res = -2; //-2: ParentSportID does not exist on BD and is different to 0(root)
                    }
                }
            }             
            return res;
        }        

        public SportTypes FindParentSportType(string connString)
        {//Return an object containing the parent SportType.
            SportTypes aSportType = new SportTypes();
            aSportType.SportTypeID = parentSportTypeID;
            aSportType.UserID = userID;
            aSportType = aSportType.FindSportTypeByID(connString);
            return aSportType;
        }
    }
}
