using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainItLibrary;


namespace TrainIt
{
    public partial class FEstadSport : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();
        Int64 userIDWorking = TrainItLibrary.Global.userIDWorking;

        public FEstadSport()
        {
            InitializeComponent();
        }

        private void FEstadSport_Load(object sender, EventArgs e)
        {
            //dtpIni.Value = Utilities.firstDayOfWeek(DateTime.Now);
            dtpIni.Value = Utilities.firstDayOfYear(DateTime.Now);
            dtpFin.Value = Utilities.lastDayOfWeek(DateTime.Now);

            //Create temp table with favourites sports and his childs.
            string query;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"delete from TempUserSports;
                          select SportTypeID                               
                          from UserSports 
                          where UserID=@userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            laName.Text = "NO hay datos disponibles, no ha seleccionado deportes principales. ";
                        }
                        else
                        {
                            insertIntoTempSportType(connString, userIDWorking, reader.GetInt64(0), reader.GetInt64(0));
                            insertChildSports(connString, userIDWorking, reader.GetInt64(0));
                        }
                    }
                    reader.Close();
                }
            }


            //Create a temp table with the sum of sessions for each ChildSportType in TempUserSports
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"delete from TempSessionData;
                          select * from TempUserSports";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {                    
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            addSessionDataForSport(connString, reader.GetInt64(0), reader.GetInt64(1), reader.GetInt64(2));                            
                        }
                    }
                    reader.Close();
                }
            }

            //Extract data form temp table to use in the dgv

            //Get grouped data by sportType for the grid
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"select
                               SportTypeID,
                               (select SportTypeName from SportTypes where SportTypeID=T.SportTypeID) As SportName,
                               SUM(SessionsCant) as SessionsCant,                                                                                             
                               CAST(SUM(TotDist)as decimal(7,2))as TotDist,                               
                               CAST( (SUM(TotDist)/SUM(SessionsCant)) as decimal(7,2) ) as AvgDist,
                               MAX(MaxDist) as MaxDist,
	 		   	 
	                           dbo.floatToTimeChar(SUM(CAST(TotTimeCalc As Float))) As TotTimeCalc,
                               dbo.floatToTimeChar(SUM(CAST(TotTimeCalc As Float))/SUM(SessionsCant)) As AvgTimeCalc,
                               dbo.floatToTimeChar(MAX(CAST(MaxTimeCalc As Float))) As MaxTimeCalc,                      
                           
                               CAST((SUM(AvgMedHR)/SUM(SessionsCant)) as decimal (7,2) )as AvgMedHR,
                               MAX(MaxMedHR) as MaxMedHR,
                               CAST((SUM(AvgMaxHR)/SUM(SessionsCant)) as decimal (7,2) )as AvgMaxHR,
                               MAX(MaxMAxHR) as MaxMaxHR,
                               CAST( (SUM(AvgValue)/SUM(SessionsCant)) as decimal (7,2) )as AvgValue,
                               MAX(MaxValue) as MaxValue,
                                  
                               DATEDIFF (day, CONVERT(varchar,@minDate,106), CONVERT(varchar,@maxDate,106))+1 as days
                                      
                        from TempSessionData T
                        where UserID=@userID
                        group by SportTypeID;";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                        cmd.Parameters["@userID"].Value = userIDWorking;

                        cmd.Parameters.Add(new SqlParameter("@minDate", SqlDbType.DateTime));
                        cmd.Parameters["@minDate"].Value = dtpIni.Value;

                        cmd.Parameters.Add(new SqlParameter("@maxDate", SqlDbType.DateTime));
                        cmd.Parameters["@maxDate"].Value = dtpFin.Value;

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgv.DataSource = dataTable;
                        reader.Close();
                    }
                }
                catch
                {
                    throw;
                }
            }//Get grouped data by sportType for the grid 
        }

        private void insertChildSports(string connString, Int64 userIDWorking, Int64 aSportTypeID)
        {
            //Create temp table with favourites sports and his childs.
            string query;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"Select SportTypeID from SportTypes
                          where ParentSportTypeID=@sportTypeID and UserID=@userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;

                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@sportTypeID"].Value = aSportTypeID;                    

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {                            
                            insertIntoTempSportType(connString, userIDWorking, aSportTypeID, reader.GetInt64(0));
                            insertChildSports(connString, userIDWorking, reader.GetInt64(0));
                        }
                    }
                    reader.Close();
                }
            }
        }

        private void insertIntoTempSportType(string connString, Int64 userIDWorking, Int64 aSportTypeID, Int64 aChildSportTypeID)
        {
            //Create temp table with favourites sports and his childs.
            string query;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"insert into TempUserSports (UserID,SportTypeID,ChildSportTypeID)
                          values (@userID,@sportTypeID,@childSportTypeID);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;

                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@sportTypeID"].Value = aSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@childSportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@childSportTypeID"].Value = aChildSportTypeID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void addSessionDataForSport(string connString, Int64 aUserID, Int64 aSportTypeID, Int64 aChildSportTypeID)
        {
            string query;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"select
                               COUNT(SessionID) as SesionsCant,	   
                               CAST(SUM(Distance)as decimal(7,2))as TotDist, 
                               CAST(AVG(Distance)as decimal(7,2)) as AvgDist,
                               MAX(Distance) as MaxDist, 
	 		   	 
	                           SUM(CAST(Time As Float)*24*60*60) As TotTimeCalc,
                               AVG(CAST(Time As Float)*24*60*60) As AvgTimeCalc,                       
                               MAX(CAST(Time As Float)*24*60*60) As MaxTimeCalc,                       
                           
                               AVG(CAST(MedHR as float)) as AvgMedHR,
                               MAX(MedHR) as MaxMedHR,
                               AVG(CAST(MaxHR as float)) as AvgMaxHR,
                               MAX(MaxHR) as MaxMaxHR,
                               AVG(CAST(Value as float)) as AvgValue,
                               MAX(Value) as MaxValue,
       
                               --CONVERT(varchar,@minDate,106) as firstDate,
                               --CONVERT(varchar,@maxDate,106) as lastDate,
                               DATEDIFF (day, CONVERT(varchar,@minDate,106), CONVERT(varchar,@maxDate,106))+1 as Days
       
                        from Sessions 
                        where UserID=@userID AND SportTypeID=@childSportTypeID AND date Between @minDate AND @maxDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = aUserID;

                    cmd.Parameters.Add(new SqlParameter("@childSportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@childSportTypeID"].Value = aChildSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@minDate", SqlDbType.DateTime));
                    cmd.Parameters["@minDate"].Value = dtpIni.Value;

                    cmd.Parameters.Add(new SqlParameter("@maxDate", SqlDbType.DateTime));
                    cmd.Parameters["@maxDate"].Value = dtpFin.Value;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["SesionsCant"]) != 0)
                        {
                            insertIntoTempSessionData(connString,aUserID,aSportTypeID,aChildSportTypeID,
                                                      Convert.ToInt32(reader["SesionsCant"]), 
                                                      Convert.ToDecimal(reader["TotDist"]),
                                                      Convert.ToDecimal(reader["AvgDist"]),
                                                      Convert.ToDecimal(reader["MaxDist"]),
                                                      Convert.ToDouble(reader["TotTimeCalc"]),
                                                      Convert.ToDouble(reader["AvgTimeCalc"]),
                                                      Convert.ToDouble(reader["MaxTimeCalc"]),
                                                      Convert.ToDouble(reader["AvgMedHR"]),
                                                      Convert.ToInt16(reader["MaxMedHR"]),
                                                      Convert.ToDouble(reader["AvgMaxHR"]),
                                                      Convert.ToInt16(reader["MaxMaxHR"]),
                                                      Convert.ToDouble(reader["AvgValue"]),
                                                      Convert.ToInt16(reader["MaxValue"]),
                                                      Convert.ToInt16(reader["Days"])
                                                      );
                        }
                    }
                    reader.Close();
                }
            }
        }

        private void insertIntoTempSessionData(string connString, Int64 aUSerID, Int64 aSportTypeID, Int64 aChildSportTypeID, 
                                                  int sessionsCant, decimal totDist, decimal avgDist, decimal maxDist,
                                                  double totTimeCalc, double avgTimeCalc, double maxTimeCalc,
                                                  double avgMedHR, Int16 maxMedHR, double avgMaxHR, Int16 maxMaxHR,
                                                  double avgValue, Int16 maxValue, Int16 days)
        {            
            string query;
            using (SqlConnection conn = new SqlConnection(connString))
            {                
                query = @"insert into TempSessionData (UserID,SportTypeID,ChildSportTypeID,SessionsCant,TotDist,AvgDist,MaxDist,TotTimeCalc,AvgTimeCalc,
                                                       MaxTimeCalc,AvgMedHR,MaxMedHR,AvgMaxHR,MaxMaxHR,AvgValue,MaxValue,Days)
                          values (@userID,@sportTypeID,@childSportTypeID,@sessionsCant,@totDist,@avgDist,@maxDist,@totTimeCalc,@avgTimeCalc,
                                  @maxTimeCalc,@avgMedHR,@maxMedHR,@avgMaxHR,@maxMaxHR,@avgValue,@maxValue,@days);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;

                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@sportTypeID"].Value = aSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@childSportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@childSportTypeID"].Value = aChildSportTypeID;

                    cmd.Parameters.Add(new SqlParameter("@sessionsCant", SqlDbType.Int));
                    cmd.Parameters["@sessionsCant"].Value = sessionsCant;

                    cmd.Parameters.Add(new SqlParameter("@totDist", SqlDbType.Decimal));
                    cmd.Parameters["@totDist"].Value = totDist;

                    cmd.Parameters.Add(new SqlParameter("@avgDist", SqlDbType.Decimal));
                    cmd.Parameters["@avgDist"].Value = avgDist;

                    cmd.Parameters.Add(new SqlParameter("@maxDist", SqlDbType.Decimal));
                    cmd.Parameters["@maxDist"].Value = maxDist;

                    cmd.Parameters.Add(new SqlParameter("@totTimeCalc", SqlDbType.Float));
                    cmd.Parameters["@totTimeCalc"].Value = totTimeCalc;

                    cmd.Parameters.Add(new SqlParameter("@avgTimeCalc", SqlDbType.Float));
                    cmd.Parameters["@avgTimeCalc"].Value = avgTimeCalc;

                    cmd.Parameters.Add(new SqlParameter("@maxTimeCalc", SqlDbType.Float));
                    cmd.Parameters["@maxTimeCalc"].Value = maxTimeCalc;

                    cmd.Parameters.Add(new SqlParameter("@avgMedHR", SqlDbType.Float));
                    cmd.Parameters["@avgMedHR"].Value = avgMedHR;

                    cmd.Parameters.Add(new SqlParameter("@maxMedHR", SqlDbType.Int));
                    cmd.Parameters["@maxMedHR"].Value = maxMedHR;

                    cmd.Parameters.Add(new SqlParameter("@avgMaxHR", SqlDbType.Float));
                    cmd.Parameters["@avgMaxHR"].Value = avgMaxHR;

                    cmd.Parameters.Add(new SqlParameter("@maxMaxHR", SqlDbType.Int));
                    cmd.Parameters["@maxMaxHR"].Value = maxMaxHR;

                    cmd.Parameters.Add(new SqlParameter("@avgValue", SqlDbType.Float));
                    cmd.Parameters["@avgValue"].Value = avgValue;

                    cmd.Parameters.Add(new SqlParameter("@maxValue", SqlDbType.Int));
                    cmd.Parameters["@maxValue"].Value = maxValue;

                    cmd.Parameters.Add(new SqlParameter("@days", SqlDbType.Int));
                    cmd.Parameters["@days"].Value = days;
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();                    
                }
            }
        }
    }
}
