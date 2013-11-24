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
    public partial class FEstadGlobal : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();
        Int64 userIDWorking = TrainItLibrary.Global.userIDWorking;

        public FEstadGlobal()
        {
            InitializeComponent();
        }

        private void clearData()
        {
            txbxSesiones.Text = "";
            txbxDist.Text = "";
            txbxDistMed.Text = "";
            txbxDistMax.Text = "";
            txbxTime.Text = "";
            txbxTimeMed.Text = "";
            txbxTimeMax.Text = "";
            txbxHRAvg.Text = "";
            txbxHRAvgMax.Text = "";
            txbxHRMaxAvg.Text = "";
            txbxMaxMax.Text = "";
            txbxValMed.Text = "";
            txbxValMax.Text = "";
            txbxDias.Text = "";
        }

        // To Delete-------------------------------------------------------------------------
        private void loadGeneralData()
        {
            string query;            
            clearData();
            //Get Max and Min Date for sessions
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"select
                               MIN(Date) as firstDate,
                               Max(Date) as lastDate
              
                        from Sessions 
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
                            laName.Text = "No hay datos disponibles";
                        }
                        else
                        {
                            dtpIni.Value = Convert.ToDateTime(reader["firstDate"]);
                            dtpFin.Value = Convert.ToDateTime(reader["lastDate"]);
                        }
                    }
                    reader.Close();
                }
            }
            
            //Get global data for the text boxes
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"select
                               COUNT(SessionID) as SesionsCant,	   
                               CAST(SUM(Distance)as decimal(7,2))as TotDist, 
                               CAST(AVG(Distance)as decimal(7,2)) as AvgDist,
                               MAX(Distance) as MaxDist, 
	 		   	 
	                           dbo.floatToTimeChar(SUM(CAST(Time As Float)*24*60*60)) As TotTimeCalc,
                               dbo.floatToTimeChar(AVG(CAST(Time As Float)*24*60*60)) As AvgTimeCalc,                       
                               dbo.floatToTimeChar(MAX(CAST(Time As Float)*24*60*60)) As MaxTimeCalc,                       
                           
                               CAST(AVG(CAST(MedHR as float)) as decimal (7,2) )as AvgMedHR,
                               MAX(MedHR) as MaxMedHR,
                               CAST(AVG(CAST(MaxHR as float)) as decimal (7,2) )as AvgMaxHR,
                               MAX(MaxHR) as MaxMaxHR,
                               CAST(AVG(CAST(Value as float)) as decimal (7,2) )as AvgValue,
                               MAX(Value) as MaxValue,
       
                               --CONVERT(varchar,@minDate,106) as firstDate,
                               --CONVERT(varchar,@maxDate,106) as lastDate,
                               DATEDIFF (day, CONVERT(varchar,@minDate,106), CONVERT(varchar,@maxDate,106))+1 as days
       
                        from Sessions 
                        where UserID=@userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;

                    cmd.Parameters.Add(new SqlParameter("@minDate", SqlDbType.DateTime));
                    cmd.Parameters["@minDate"].Value = dtpIni.Value;

                    cmd.Parameters.Add(new SqlParameter("@maxDate", SqlDbType.DateTime));
                    cmd.Parameters["@maxDate"].Value = dtpFin.Value.AddDays(-1);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(1))
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
                            txbxDias.Text = reader["days"].ToString();
                        }                        
                    }
                    reader.Close();

                }
            }
               


                //Get grouped data by sportType for the grid
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"select 
	                           (SELECT ST.SportTypeName from SportTypes ST where ST.SportTypeID=Sessions.SportTypeID) as SportName,  	
	                           COUNT(SessionID) as SesionsCant,	   
                               CAST(SUM(Distance)as decimal(7,2))as TotDist, 
                               CAST(AVG(Distance)as decimal(7,2)) as AvgDist,
                               MAX(Distance) as MaxDist, 
	 		   	 
	                           dbo.floatToTimeChar(SUM(CAST(Time As Float)*24*60*60)) As TotTimeCalc,
                               dbo.floatToTimeChar(AVG(CAST(Time As Float)*24*60*60)) As AvgTimeCalc,                       
                               dbo.floatToTimeChar(MAX(CAST(Time As Float)*24*60*60)) As MaxTimeCalc,                       
                           
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

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dgv.DataSource = dataTable;
                    reader.Close();

                }
            }//Get grouped data by sportType for the grid           
        }
        // To Delete-------------------------------------------------------------------------

        private void loadDatedData()
        {
            string query;
            clearData();
            bool noData = false;            
            //Get global data for the text boxes
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"select
                               COUNT(SessionID) as SesionsCant,	   
                               CAST(SUM(Distance)as decimal(7,2))as TotDist, 
                               CAST(AVG(Distance)as decimal(7,2)) as AvgDist,
                               MAX(Distance) as MaxDist, 
	 		   	 
	                           dbo.floatToTimeChar(SUM(CAST(Time As Float)*24*60*60)) As TotTimeCalc,
                               dbo.floatToTimeChar(AVG(CAST(Time As Float)*24*60*60)) As AvgTimeCalc,                       
                               dbo.floatToTimeChar(MAX(CAST(Time As Float)*24*60*60)) As MaxTimeCalc,                       
                           
                               CAST(AVG(CAST(MedHR as float)) as decimal (7,2) )as AvgMedHR,
                               MAX(MedHR) as MaxMedHR,
                               CAST(AVG(CAST(MaxHR as float)) as decimal (7,2) )as AvgMaxHR,
                               MAX(MaxHR) as MaxMaxHR,
                               CAST(AVG(CAST(Value as float)) as decimal (7,2) )as AvgValue,
                               MAX(Value) as MaxValue,
                                  
                               DATEDIFF (day, CONVERT(varchar,@minDate,106), CONVERT(varchar,@maxDate,106))+1 as days
       
                        from Sessions 
                        where UserID=@userID AND date Between @minDate AND @maxDate ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;

                    cmd.Parameters.Add(new SqlParameter("@minDate", SqlDbType.DateTime));
                    cmd.Parameters["@minDate"].Value = dtpIni.Value.AddDays(-1);

                    cmd.Parameters.Add(new SqlParameter("@maxDate", SqlDbType.DateTime));
                    cmd.Parameters["@maxDate"].Value = dtpFin.Value;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(1))
                        {
                            noData = true;
                            laName.Text = "No hay datos disponibles entra las fechas " + dtpIni.Value.ToShortDateString() + " y " + dtpFin.Value.ToShortDateString();
                        }
                        else
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
                            txbxDias.Text = reader["days"].ToString();
                        }
                    }
                    reader.Close();

                }
            }
            
            //Get grouped data by sportType for the grid
            using (SqlConnection conn = new SqlConnection(connString))
            {
                query = @"select 
	                           (SELECT ST.SportTypeName from SportTypes ST where ST.SportTypeID=Sessions.SportTypeID) as SportName,  	
	                           COUNT(SessionID) as SesionsCant,	   
                               CAST(SUM(Distance)as decimal(7,2))as TotDist, 
                               CAST(AVG(Distance)as decimal(7,2)) as AvgDist,
                               MAX(Distance) as MaxDist, 
	 		   	 
	                           dbo.floatToTimeChar(SUM(CAST(Time As Float)*24*60*60)) As TotTimeCalc,
                               dbo.floatToTimeChar(AVG(CAST(Time As Float)*24*60*60)) As AvgTimeCalc,                       
                               dbo.floatToTimeChar(MAX(CAST(Time As Float)*24*60*60)) As MaxTimeCalc,                       
                           
                               CAST(AVG(CAST(MedHR as float)) as decimal (7,2) )as AvgMedHR,
                               MAX(MedHR) as MaxMedHR,
                               CAST(AVG(CAST(MaxHR as float)) as decimal (7,2) )as AvgMaxHR,
                               MAX(MaxHR) as MaxMaxHR,
                               CAST(AVG(CAST(Value as float)) as decimal (7,2) )as AvgValue,
                               MAX(Value) as MaxValue,
       
                               DATEDIFF (day, CONVERT(varchar,@minDate,106), CONVERT(varchar,@maxDate,106))+1 as days
       
                        from Sessions 
                        where UserID=@userID AND date Between @minDate AND @maxDate
                        group by SportTypeID;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = userIDWorking;

                    cmd.Parameters.Add(new SqlParameter("@minDate", SqlDbType.DateTime));
                    cmd.Parameters["@minDate"].Value = dtpIni.Value.AddDays(-1);

                    cmd.Parameters.Add(new SqlParameter("@maxDate", SqlDbType.DateTime));
                    cmd.Parameters["@maxDate"].Value = dtpFin.Value;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dgv.DataSource = dataTable;
                    reader.Close();
                }
            }//Get grouped data by sportType for the grid 

        }

        private void FEstadGlobal_Load(object sender, EventArgs e)
        {
            //Load data for current week
            semanal_Click(this, e);

//            string query;
//            clearData();
//            //Get Max and Min Date for sessions
//            using (SqlConnection conn = new SqlConnection(connString))
//            {
//                query = @"select
//                               MIN(Date) as firstDate,
//                               Max(Date) as lastDate
//              
//                        from Sessions 
//                        where UserID=@userID";
//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
//                    cmd.Parameters["@userID"].Value = userIDWorking;

//                    conn.Open();
//                    SqlDataReader reader = cmd.ExecuteReader();
//                    while (reader.Read())
//                    {
//                        if (reader.IsDBNull(0))
//                        {
//                            laName.Text = "No hay datos disponibles";
//                        }
//                        else
//                        {
//                            dtpIni.Value = Convert.ToDateTime(reader["firstDate"]);
//                            dtpFin.Value = Convert.ToDateTime(reader["lastDate"]);
//                        }
//                    }
//                    reader.Close();
//                }
//            }
//            loadDatedData();
//            laName.Text = "Datos globales: Primera sesión : " + dtpIni.Value.ToShortDateString() + "    Última sesión : " + dtpFin.Value.ToShortDateString();
        }

        private void tsbtPrint_Click(object sender, EventArgs e)
        {

        }

        private void manual_Click(object sender, EventArgs e)
        {
            loadDatedData();
            laName.Text = "Datos acumulados del " + dtpIni.Value.ToShortDateString() + " al " + dtpFin.Value.ToShortDateString();
        }

        private void global_Click(object sender, EventArgs e)
        {
            loadGeneralData();
            laName.Text = "Datos globales: Primera sesión : " + dtpIni.Value.ToShortDateString() + "    Última sesión : " + dtpFin.Value.ToShortDateString();
        }

        private void anual_Click(object sender, EventArgs e)
        {
            dtpIni.Value = Utilities.firstDayOfYear(DateTime.Now);
            dtpFin.Value = Utilities.lastDayOfYear(DateTime.Now);
            loadDatedData();
            laName.Text = "Sesiones realizadas en el año en curso : " + Convert.ToString(DateTime.Now.Year);
        }

        private void mensual_Click(object sender, EventArgs e)
        {
            dtpIni.Value = Utilities.firstDayOfMonth(DateTime.Now);
            dtpFin.Value = Utilities.lastDayOfMonth(DateTime.Now);
            loadDatedData();
            laName.Text = "Sesiones realizadas en el mes en curso : " + DateTime.Now.Month;
        }

        private void semanal_Click(object sender, EventArgs e)
        {
            dtpIni.Value = Utilities.firstDayOfWeek(DateTime.Now);
            dtpFin.Value = Utilities.lastDayOfWeek(DateTime.Now);
            loadDatedData();
            laName.Text = "Sesiones realizadas en la semana actual: " + dtpIni.Value.ToShortDateString() + " al " + dtpFin.Value.ToShortDateString();
        }

        private void diario_Click(object sender, EventArgs e)
        {
            dtpIni.Value = DateTime.Now.AddDays(-1);
            dtpFin.Value = DateTime.Now;
            loadDatedData();
            laName.Text = "Sesiones realizadas hoy día " + DateTime.Now.ToShortDateString();
        }

        private void btnReCalc_Click(object sender, EventArgs e)
        {
            manual_Click(this, e);
        }



    }
}
