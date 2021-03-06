﻿using System;
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
        private static Int64 matID;
        private static string matName;
        private static string matModel;
        private static string matBrand;
        private static string matSize;
        private static decimal matWeight;
        private static DateTime matBuyDate;
        private static SqlMoney matCost;
        private static double matInitTime;
        private static decimal matInitDist;
        private static string matRecTime;
        private static decimal matRecDist;
        private static string matBuyMemo;
        private static Int64 userID;

        public Int64 MatID
        {
            get { return matID; }
            set { matID = value; }
        }
        public string MatName
        {
            get { return matName; }
            set { matName = value; }
        }
        public string MatModel
        {
            get { return matModel; }
            set { matModel = value; }
        }
        public string MatBrand
        {
            get { return matBrand; }
            set { matBrand = value; }
        }
        public string MatSize
        {
            get { return matSize; }
            set { matSize = value; }
        }
        public decimal MatWeight
        {
            get { return matWeight; }
            set { matWeight = value; }
        }
        public DateTime MatBuyDate
        {
            get { return matBuyDate; }
            set { matBuyDate = value; }
        }
        public SqlMoney MatCost
        {
            get { return matCost; }
            set { matCost = value; }
        }
        public double MatInitTime
        {
            get { return matInitTime; }
            set { matInitTime = value; }
        }
        public decimal MatInitDist
        {
            get { return matInitDist; }
            set { matInitDist = value; }
        }
        public string MatRecTime
        {
            get { return matRecTime; }
            set { matRecTime = value; }
        }
        public decimal MatRecDist
        {
            get { return matRecDist; }
            set { matRecDist = value; }
        }
        public string MatBuyMemo
        {
            get { return matBuyMemo; }
            set { matBuyMemo = value; }
        }
        public Int64 UserID
        {
            get { return userID; }
            set { userID = value; }
        }
       

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
            matInitTime=0;
            matInitDist=0.000M;
            matRecTime="00:00:00";
            matRecDist=0.000M;
            matBuyMemo="";
            userID=-1;
        }

        public Material(Int64 MatID, string MatName, string MatModel, string MatBrand, string MatSize, decimal MatWeight, DateTime MatBuyDate,
                        SqlMoney MatCost, double MatinitTime, decimal MatInitDist, string MatRecTime, decimal MatRecDist,  
                        string MatBuyMemo, Int64 UserID)
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

        public void LoadData(Int64 MatID, string MatName, string MatModel, string MatBrand, string MatSize, decimal MatWeight, DateTime MatBuyDate,
                        SqlMoney MatCost, double MatInitTime, decimal MatInitDist, string MatRecTime, decimal MatRecDist,  
                        string MatBuyMemo, Int64 UserID)
        {
            matID = MatID;
            matName = MatName;
            matModel = MatModel;
            matBrand = MatBrand;
            matSize = MatSize;
            matWeight = MatWeight;
            matBuyDate = MatBuyDate;
            matCost = MatCost;
            matInitTime = MatInitTime;
            matInitDist = MatInitDist;
            matRecTime = MatRecTime;
            matRecDist = MatRecDist;
            matBuyMemo = MatBuyMemo;
            userID = UserID;
        }

        public Material LoadDataFromView(string aMatID, string aMatName, string aMatModel, string aMatBrand, string aMatSize, string aMatWeight, string aMatBuyDate,
                        string aMatCost, string aMatInitTime, string aMatInitDist, string aMatRecTime, string aMatRecDist,  
                        string aMatBuyMemo, string aUserID)
        {
            Material aM = new Material();
            bool sigue = true;
            try
            {
                matID = Convert.ToInt64(aMatID);
            }
            catch (Exception)
            {
                sigue = false;
            }

            if (sigue)
            {
                try
                {
                    matWeight = Convert.ToDecimal(aMatWeight);
                }
                catch (Exception)
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                try
                {
                    matBuyDate = Convert.ToDateTime(aMatBuyDate);
                }
                catch (Exception)
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                try
                {
                    matCost = Convert.ToDecimal(aMatCost);
                }
                catch (Exception)
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                try
                {
                    matInitDist = Convert.ToDecimal(aMatInitDist);
                }
                catch (Exception)
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                try
                {
                    matRecDist = Convert.ToDecimal(aMatRecDist);
                }
                catch (Exception)
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                try
                {
                    userID = Convert.ToInt64(aUserID);
                }
                catch (Exception)
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                matName = aMatName;
                matModel = aMatModel;
                matBrand = aMatBrand;
                matSize = aMatSize;
                matInitTime = Time.ConvertStringTimeToLong(aMatInitTime);
                matRecTime = aMatRecTime;
                matBuyMemo = aMatBuyMemo;
            }
            else
                aM.Reset();

            return aM;
        }

        public void Reset()
        {
            matID = -1;
            matName = "";
            matModel = "";
            matBrand = "";
            matSize = "";
            matWeight = 0.00M;
            matBuyDate = DateTime.Now;
            matCost = (SqlMoney)0;
            matInitTime = 0;
            matInitDist = 0.000M;
            matRecTime = "";
            matRecDist = 0.000M;
            matBuyMemo = "";
            userID = -1;
        }

        public Material findMatByMatID(string connString, Int64 matID)
        {//Find a Material by MatID, returns object found or an object with ID=-1 if not found            
            Material aMaterial = new Material();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select * from Materials where MatID = @matID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@matID", SqlDbType.BigInt));
                    cmd.Parameters["@matID"].Value = matID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Create a buffer to hold the bytes, and then
                        long len = reader.GetBytes(14, 0, null, 0, 0);
                        Byte[] image = new Byte[len];
                        // read the bytes from the DataTableReader.                            
                        reader.GetBytes(14, 0, image, 0, (int)len);
                        aMaterial.LoadData(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                           reader.GetString(4), reader.GetDecimal(5), Convert.ToDateTime(reader.GetDateTime(6)),
                                           reader.GetSqlMoney(7), reader.GetDouble(8), reader.GetDecimal(9), reader.GetString(10),
                                           reader.GetDecimal(11), reader.GetString(12), reader.GetInt64(13));
                    }
                    reader.Close();
                }
            }
            return aMaterial;
        }

        public Byte[] loadImageForMatID(string connString, Int64 matID)
        {//Find a Material by MatID, and returns the image associated            
            Byte[] image = null;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select * from Materials where MatID = @matID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@matID", SqlDbType.BigInt));
                    cmd.Parameters["@matID"].Value = matID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Create a buffer to hold the bytes, and then
                        long len = reader.GetBytes(14, 0, null, 0, 0);
                        image = new Byte[len];
                        // read the bytes from the DataTableReader.                            
                        reader.GetBytes(14, 0, image, 0, (int)len);                        
                    }
                    reader.Close();
                }
            }
            return image;
        }

        public bool checkIfMaterialIsInTempTable(string connString)
        {
            bool finded = false;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select * from TempMaterial where MatID = @matID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@matID", SqlDbType.BigInt));
                    cmd.Parameters["@matID"].Value = matID;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    finded = reader.Read();                    
                    reader.Close();
                }
            }
            return finded;
        }

        public void delTempMaterial(string connString)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "delete from TempMaterial";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {                    
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
            }
        }

    }
}
