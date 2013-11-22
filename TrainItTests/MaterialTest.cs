using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainItLibrary;
using System.Data.SqlTypes;
using System.Xml;

namespace TrainItTests
{
    [TestClass]
    public class MaterialTest
    {
        Material aMattemp = new Material();
  
        //Prepares a communication string
        static string server = "HPDESPACHO\\SQLSERVER1";
        static string catalog = "TrainIT";
        static string connString = @"Integrated Security = true;
                                     Initial catalog = " + catalog + @";
                                     Data Source = " + server + @";";

        public Int64 aMatID=100;
        public string aMatName="Nombre";
        public string aMatModel="Modelo";
        public string aMatBrand="Marca";
        public string aMatSize="Talla";
        public decimal aMatWeight=10.90M;
        public DateTime aMatBuyDate=DateTime.Now;
        public SqlMoney aMatCost=(SqlMoney)600.10F;
        public double aMatInitTime=0;
        public decimal aMatInitDist=100.340M;
        public string aMatRecTime="1000:00:00";
        public decimal aMatRecDist=3450.340M;
        public string aMatBuyMemo="Memo";
        public Int64 aUserID=85;



         [TestMethod]
        public void Material_LoadFromData()
        {
            Material aMatToLoad = new Material();
            aMatToLoad.LoadData(aMatID,aMatName,aMatModel,aMatBrand,aMatSize,aMatWeight,aMatBuyDate,aMatCost,aMatInitTime,aMatInitDist,
                                aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);

            Assert.AreEqual(aMatID, aMatToLoad.MatID);
            Assert.AreEqual(aMatName, aMatToLoad.MatName);
            Assert.AreEqual(aMatModel, aMatToLoad.MatModel);
            Assert.AreEqual(aMatBrand, aMatToLoad.MatBrand);
            Assert.AreEqual(aMatSize, aMatToLoad.MatSize);
            Assert.AreEqual(aMatWeight, aMatToLoad.MatWeight);
            Assert.AreEqual(aMatBuyDate, aMatToLoad.MatBuyDate);
            Assert.AreEqual(aMatCost, aMatToLoad.MatCost);
            Assert.AreEqual(aMatInitTime, aMatToLoad.MatInitTime);
            Assert.AreEqual(aMatInitDist, aMatToLoad.MatInitDist);
            Assert.AreEqual(aMatRecTime, aMatToLoad.MatRecTime);
            Assert.AreEqual(aMatRecDist, aMatToLoad.MatRecDist);
            Assert.AreEqual(aMatBuyMemo, aMatToLoad.MatBuyMemo);
            Assert.AreEqual(aUserID, aMatToLoad.UserID);
        }

        [TestMethod]
        public void Material_FindNotFound()
        {
            Material aMatToLoad = new Material();
            aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            aMatToLoad = aMatToLoad.findMatByMatID(connString, aMatID);

            Assert.AreEqual(-1, aMatToLoad.MatID);
        }

        [TestMethod]
        public void Material_FindFound()
        {
            //This object must exist on BD
            aMatID = 51;
            aMatName = "Epic MTB";
            aMatModel = "Epic Comp";
            aMatBrand = "Specialized";
            aMatSize = "17";
            aMatWeight = 12.5M;
            aMatBuyDate = Convert.ToDateTime("01/04/2011");
            aMatCost =  (SqlMoney)600.00F;
            aMatInitTime = 0;
            aMatInitDist = 2500.000M;
            aMatRecTime = "1000:00:00";
            aMatRecDist = 10000.000M;
            aMatBuyMemo = "Comprada";
            aUserID = 85;   

            Material aMatToLoad = new Material();
            aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            aMatToLoad = aMatToLoad.findMatByMatID(connString, aMatID);
            
            Assert.AreEqual(aMatID, aMatToLoad.MatID);
            Assert.AreEqual(aMatName, aMatToLoad.MatName);
            Assert.AreEqual(aMatModel, aMatToLoad.MatModel);
            Assert.AreEqual(aMatBrand, aMatToLoad.MatBrand);
            Assert.AreEqual(aMatSize, aMatToLoad.MatSize);
            Assert.AreEqual(aMatWeight, aMatToLoad.MatWeight);
            Assert.AreEqual(aMatBuyDate, aMatToLoad.MatBuyDate);
            Assert.AreEqual(aMatCost, aMatToLoad.MatCost);
            Assert.AreEqual(aMatInitTime, aMatToLoad.MatInitTime);
            Assert.AreEqual(aMatInitDist, aMatToLoad.MatInitDist);
            Assert.AreEqual(aMatRecTime, aMatToLoad.MatRecTime);
            Assert.AreEqual(aMatRecDist, aMatToLoad.MatRecDist);
            Assert.AreEqual(aMatBuyMemo, aMatToLoad.MatBuyMemo);
            Assert.AreEqual(aUserID, aMatToLoad.UserID);
        }

    }
}
