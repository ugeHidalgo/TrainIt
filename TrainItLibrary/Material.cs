using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace TrainItLibrary
{
    public class Material
    {
        //Data strored into DB
        public Int32 matID;
        public string matName;
        public string matModel;
        public string matBrand;
        public string matSize;
        public decimal matWeight;
        public DateTime matBuyDate;
        public SqlMoney matCost;
        public string matInitTime;
        public decimal matInitDist;
        public string matRecTime;
        public decimal matRecDist;
        public string matBuyMemo;
        public Int32 userID;

        //Data AutoCalculated.


        public Material()
        {
            matID=-1;
            matName="";
            matModel="";
            matBrand="";
            matSize="";
            matWeight=0.00M;
            matBuyDate=DateTime.Now;
            matCost=(SqlMoney)0;
            matInitTime="";
            matInitDist=0.000M;
            matRecTime="";
            matRecDist=0.000M;
            matBuyMemo="";
            userID=-1;        
        }

        public Material(Int32 MatID, string MatName, string MatModel, string MatBrand, string MatSize, decimal MatWeight, DateTime MatBuyDate, 
                        SqlMoney MatCost, string MatinitTime, decimal MatInitDist, string MatRecTime, decimal MatRecDist, string MatBuyMemo, Int32 UserID)
        {
            matID=MatID;
            matName=MatName;
            matModel=MatModel;
            matBrand=MatBrand;
            matSize=MatSize;
            matWeight=MatWeight;
            matBuyDate=MatBuyDate;
            matCost=MatCost;
            matInitTime=MatinitTime;
            matInitDist=MatInitDist;
            matRecTime=MatRecTime;
            matRecDist=MatRecDist;
            matBuyMemo=MatBuyMemo;
            userID=UserID;
        }

        public Material LoadData()
        {
            Material aMaterial = new Material(matID, matName, matModel, matBrand, matSize, matWeight, matBuyDate, matCost, matInitTime, matInitDist, matRecTime, matRecDist, matBuyMemo, userID);
            return aMaterial;
        }

        public Material LoadData(Int32 MatID, string MatName, string MatModel, string MatBrand, string MatSize, decimal MatWeight, DateTime MatBuyDate, 
                        SqlMoney MatCost, string MatinitTime, decimal MatInitDist, string MatRecTime, decimal MatRecDist, string MatBuyMemo, Int32 UserID)
        {
          Material aMaterial=new Material(MatID, MatName, MatModel, MatBrand, MatSize, MatWeight, MatBuyDate, MatCost, MatinitTime, MatInitDist, MatRecTime, MatRecDist, MatBuyMemo, UserID);
          return aMaterial;
        }

        public Material Reset()
        {
            Material aMaterial=new Material();
            return aMaterial;
        }
        
        public Material findMatByMatID(string connString, int matID)
        {//Find a Material by MatID, returns object found or an object with ID=-1 if not found            
            Material aMaterial = new Material();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select * from Materials where MatID = @matID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@matID", SqlDbType.Int));
                    cmd.Parameters["@matID"].Value = matID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        aMaterial.matID = reader.GetInt32(0);
                        aMaterial.matName = reader.GetString(1);
                        aMaterial.matModel = reader.GetString(2);
                        aMaterial.matBrand = reader.GetString(3);
                        aMaterial.matSize = reader.GetString(4);
                        aMaterial.matWeight = reader.GetDecimal(5);
                        aMaterial.matBuyDate = Convert.ToDateTime(reader.GetDateTime(6));
                        aMaterial.matCost = reader.GetSqlMoney(7);
                        aMaterial.matInitTime = reader.GetString(8);
                        aMaterial.matInitDist = reader.GetDecimal(9);
                        aMaterial.matRecTime = reader.GetString(10);
                        aMaterial.matRecDist = reader.GetDecimal(11);
                        aMaterial.matBuyMemo = reader.GetString(12);
                        aMaterial.userID = reader.GetInt32(13);
                    }
                    reader.Close();
                }
            }
            return aMaterial;
        }

        public Material checkData(string connString)
        {//Check integrity of data into Material object if correct return an object, else return an object with MatID=
         //-1 Missing MatID;
         //-2 Missing Matname
         //-3 Missing UserId
            Material aMat = new Material();
            bool sigue=true;
            if (matID < 0)
            {
                sigue = false;
            }

            if (sigue)  
            {
                if (matName == "")
                {
                    sigue = false;
                    aMat.matID = -2;
                }
            }

            if (sigue)
            {
                if (userID<0)
                {
                    sigue = false;
                    aMat.matID = -3;
                }
            }

            if (sigue)
            {
                //Loads into object
                aMat = aMat.LoadData(matID, matName, matModel, matBrand, matSize, matWeight, matBuyDate, matCost,
                                             matInitTime, matInitDist, matRecTime, matRecDist, matBuyMemo, userID);
            }

            return aMat;
        }
    }
}
