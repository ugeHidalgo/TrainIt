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

namespace TrainIt
{
    public partial class FEstadGlobal : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();
        Int64 userIDWorking = TrainItLibrary.Global.userIDWorking;

        public FEstadGlobal()
        {
            InitializeComponent();
        }

        private void FEstadGlobal_Load(object sender, EventArgs e)
        {
            //Get global data for the text boxes
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query =@"declare @totTime float;
                                set @totTime=(select SUM(CAST(Time As Float)*24*60*60) from Sessions where UserID=@userID);
                                declare @totTimeVC varchar(14);
                                execute floatToTime @totTime,@totTimeVC output;

                                declare @maxTime float;
                                set @maxTime=(select MAX(CAST(Time As Float)*24*60*60) from Sessions where UserID=@userID);
                                declare @maxTimeVC varchar(14);
                                execute floatToTime @maxTime,@maxTimeVC output;

                                declare @avgTime float;
                                set @avgTime=(select AVG(CAST(Time As Float)*24*60*60) from Sessions where UserID=@userID);
                                declare @avgTimeVC varchar(14);
                                execute floatToTime @avgTime,@avgTimeVC output;


                                select COUNT(SessionID) as SesionsCant,
                                       SUM(Distance) as TotDist, 
                                       CAST(AVG(Distance)as decimal(7,2)) as AvgDist,
                                       MAX(Distance) as MaxDist, 
                                                
                                       @totTimeVC As TotTimeCalc,              
                                       @avgTimeVC As AvgTimeCalc,              
                                       @maxTimeVC As MaxTimeCalc,              
       
                                       CAST(AVG(CAST(MedHR as float)) as decimal (7,2) )as AvgMedHR,
                                       MAX(MedHR) as MaxMedHR,
                                       CAST(AVG(CAST(MaxHR as float)) as decimal (7,2) )as AvgMaxHR,
                                       MAX(MaxHR) as MaxMaxHR,
                                       CAST(AVG(CAST(Value as float)) as decimal (7,2) )as AvgValue,
                                       MAX(Value) as MaxValue,
       
                                       CONVERT(varchar,MIN(Date),106) as firstDate,
                                       CONVERT(varchar,MAX(Date),106) as lastDate,
                                       DATEDIFF (day, CONVERT(varchar,MIN(Date),106), CONVERT(varchar,MAX(Date),106))+1 as days
                                from Sessions 
                                where UserID=@userID;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txbxSesiones.Text = reader["SesionsCant"].ToString();
                            txbxDist.Text = reader["TotDist"].ToString();
                            txbxDistMed.Text = reader["AvgDist"].ToString();
                            txbxDistMax.Text = reader["MaxDist"].ToString();
                            txbxTime.Text = reader["TotTimeCalc"].ToString();
                            txbxTimeMed.Text = reader["AvgTimeCalc"].ToString();
                            txbxTimeMax.Text = reader["MaxTimeCalc"].ToString();
                            txbxHRAvg.Text = reader["AvgMedHR"].ToString();
                            txbxHRAvgMax.Text = reader["AvgMaxHR"].ToString(); 
                            txbxHRMaxAvg.Text = reader["MaxMedHR"].ToString();
                            txbxMaxMax.Text = reader["MaxMaxHR"].ToString();
                            txbxValMed.Text = reader["AvgValue"].ToString();
                            txbxValMax.Text = reader["MaxValue"].ToString();
                            txbxIni.Text = reader["firstDate"].ToString();
                            txBxFin.Text = reader["lastDate"].ToString();
                            txbxDias.Text = reader["days"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A problem with the User SQL Connection occurs");
                        throw;
                    }
                }
            }
            //Get grouped data by sportType for the grid
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"declare @totTime float;
                                 set @totTime=(select SUM(CAST(Time As Float)*24*60*60) from Sessions where UserID=@userID);
                                 declare @totTimeVC varchar(14);
                                 execute floatToTime @totTime,@totTimeVC output;
            
                                 declare @maxTime float;
                                 set @maxTime=(select MAX(CAST(Time As Float)*24*60*60) from Sessions where UserID=@userID);
                                 declare @maxTimeVC varchar(14);
                                 execute floatToTime @maxTime,@maxTimeVC output;
            
                                 declare @avgTime float;
                                 set @avgTime=(select AVG(CAST(Time As Float)*24*60*60) from Sessions where UserID=@userID);
                                 declare @avgTimeVC varchar(14);
                                 execute floatToTime @avgTime,@avgTimeVC output;
            
                                 select (SELECT ST.SportTypeName from SportTypes ST where ST.SportTypeID=Sessions.SportTypeID) as SportName,
                                                   COUNT(SessionID) as SesionsCant,
                                                   SUM(Distance) as TotDist, 
                                                   CAST(AVG(Distance)as decimal(7,2)) as AvgDist,
                                                   MAX(Distance) as MaxDist, 
                                                            
                                                   @totTimeVC As TotTimeCalc,              
                                                   @avgTimeVC As AvgTimeCalc,              
                                                   @maxTimeVC As MaxTimeCalc,              
                   
                                                   CAST(AVG(CAST(MedHR as float)) as decimal (7,2) )as AvgMedHR,
                                                   MAX(MedHR) as MaxMedHR,
                                                   CAST(AVG(CAST(MaxHR as float)) as decimal (7,2) )as AvgMaxHR,
                                                   MAX(MaxHR) as MaxMaxHR,
                                                   CAST(AVG(CAST(Value as float)) as decimal (7,2) )as AvgValue,
                                                   MAX(Value) as MaxValue,
                   
                                                   CONVERT(varchar,MIN(Date),106) as firstDate,
                                                   CONVERT(varchar,MAX(Date),106) as lastDate,
                                                   DATEDIFF (day, CONVERT(varchar,MIN(Date),106), CONVERT(varchar,MAX(Date),106))+1 as days
            
                                   from Sessions 
                                   where UserID=@userID
                                   group by SportTypeID;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;
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
    }
}
