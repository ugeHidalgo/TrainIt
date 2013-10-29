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

        public Int32 aMatID=100;
        public string aMatName="Nombre";
        public string aMatModel="Modelo";
        public string aMatBrand="Marca";
        public string aMatSize="Talla";
        public decimal aMatWeight=10.90M;
        public DateTime aMatBuyDate=DateTime.Now;
        public SqlMoney aMatCost=(SqlMoney)600.10F;
        public string aMatInitTime="100:30:00";
        public decimal aMatInitDist=100.340M;
        public string aMatRecTime="1000:00:00";
        public decimal aMatRecDist=3450.340M;
        public string aMatBuyMemo="Memo";
        public Int32 aUserID=85;

        [TestMethod]
        public void Material_Creation()
        {      
            Material aMat = new Material(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost, 
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);           
            Assert.AreEqual(aMatID, aMat.matID);
            Assert.AreEqual(aMatName, aMat.matName);
            Assert.AreEqual(aMatModel, aMat.matModel);
            Assert.AreEqual(aMatBrand, aMat.matBrand);
            Assert.AreEqual(aMatSize, aMat.matSize);
            Assert.AreEqual(aMatWeight, aMat.matWeight);
            Assert.AreEqual(aMatBuyDate, aMat.matBuyDate);
            Assert.AreEqual(aMatCost, aMat.matCost);
            Assert.AreEqual(aMatInitTime, aMat.matInitTime);
            Assert.AreEqual(aMatInitDist, aMat.matInitDist);
            Assert.AreEqual(aMatRecTime, aMat.matRecTime);
            Assert.AreEqual(aMatRecDist, aMat.matRecDist);
            Assert.AreEqual(aMatBuyMemo, aMat.matBuyMemo);
            Assert.AreEqual(aUserID, aMat.userID);
        }

         [TestMethod]
        public void Material_LoadFromObject()
        {
            aMattemp.matID = aMatID;
            aMattemp.matName = aMatName;
            aMattemp.matModel=aMatModel;
            aMattemp.matBrand=aMatBrand;
            aMattemp.matSize=aMatSize;
            aMattemp.matWeight=aMatWeight;
            aMattemp.matBuyDate=aMatBuyDate;
            aMattemp.matCost=aMatCost;
            aMattemp.matInitTime=aMatInitTime;
            aMattemp.matInitDist=aMatInitDist;
            aMattemp.matRecTime=aMatRecTime;
            aMattemp.matRecDist=aMatRecDist;
            aMattemp.matBuyMemo=aMatBuyMemo;
            aMattemp.userID = aUserID;

            Material aMatToLoad = new Material();
            aMatToLoad = aMattemp.LoadData();

            Assert.AreEqual(aMatID, aMatToLoad.matID);
            Assert.AreEqual(aMatName, aMatToLoad.matName);
            Assert.AreEqual(aMatModel, aMatToLoad.matModel);
            Assert.AreEqual(aMatBrand, aMatToLoad.matBrand);
            Assert.AreEqual(aMatSize, aMatToLoad.matSize);
            Assert.AreEqual(aMatWeight, aMatToLoad.matWeight);
            Assert.AreEqual(aMatBuyDate, aMatToLoad.matBuyDate);
            Assert.AreEqual(aMatCost, aMatToLoad.matCost);
            Assert.AreEqual(aMatInitTime, aMatToLoad.matInitTime);
            Assert.AreEqual(aMatInitDist, aMatToLoad.matInitDist);
            Assert.AreEqual(aMatRecTime, aMatToLoad.matRecTime);
            Assert.AreEqual(aMatRecDist, aMatToLoad.matRecDist);
            Assert.AreEqual(aMatBuyMemo, aMatToLoad.matBuyMemo);
            Assert.AreEqual(aUserID, aMatToLoad.userID);
        }

        [TestMethod]
        public void Material_LoadFromdata()
        {                 
            aMattemp.matID = aMatID;
            aMattemp.matName = aMatName;
            aMattemp.matModel = aMatModel;
            aMattemp.matBrand = aMatBrand;
            aMattemp.matSize = aMatSize;
            aMattemp.matWeight = aMatWeight;
            aMattemp.matBuyDate = aMatBuyDate;
            aMattemp.matCost = aMatCost;
            aMattemp.matInitTime = aMatInitTime;
            aMattemp.matInitDist = aMatInitDist;
            aMattemp.matRecTime = aMatRecTime;
            aMattemp.matRecDist = aMatRecDist;
            aMattemp.matBuyMemo = aMatBuyMemo;
            aMattemp.userID = aUserID;

            Material aMatToLoad = new Material();
            aMatToLoad = aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost, 
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);

            Assert.AreEqual(aMatID, aMatToLoad.matID);
            Assert.AreEqual(aMatName, aMatToLoad.matName);
            Assert.AreEqual(aMatModel, aMatToLoad.matModel);
            Assert.AreEqual(aMatBrand, aMatToLoad.matBrand);
            Assert.AreEqual(aMatSize, aMatToLoad.matSize);
            Assert.AreEqual(aMatWeight, aMatToLoad.matWeight);
            Assert.AreEqual(aMatBuyDate, aMatToLoad.matBuyDate);
            Assert.AreEqual(aMatCost, aMatToLoad.matCost);
            Assert.AreEqual(aMatInitTime, aMatToLoad.matInitTime);
            Assert.AreEqual(aMatInitDist, aMatToLoad.matInitDist);
            Assert.AreEqual(aMatRecTime, aMatToLoad.matRecTime);
            Assert.AreEqual(aMatRecDist, aMatToLoad.matRecDist);
            Assert.AreEqual(aMatBuyMemo, aMatToLoad.matBuyMemo);
            Assert.AreEqual(aUserID, aMatToLoad.userID);
        }

        [TestMethod]
        public void Material_Reset()
        {
            Material aMatToLoad = new Material();
            aMatToLoad = aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            aMatToLoad.Reset();

            Assert.AreEqual(-1, aMattemp.matID);
            Assert.AreEqual("", aMattemp.matName);
            Assert.AreEqual("", aMattemp.matModel);
            Assert.AreEqual("", aMattemp.matBrand);
            Assert.AreEqual("", aMattemp.matSize);
            Assert.AreEqual(0.00M, aMattemp.matWeight);
            //Assert.AreEqual(DateTime.Now, aMattemp.matBuyDate, 1E-14);
            Assert.AreEqual(0, aMattemp.matCost);
            Assert.AreEqual("", aMattemp.matInitTime);
            Assert.AreEqual(0.000M, aMattemp.matInitDist);
            Assert.AreEqual("", aMattemp.matRecTime);
            Assert.AreEqual(0.000M, aMattemp.matRecDist);
            Assert.AreEqual("", aMattemp.matBuyMemo);
            Assert.AreEqual(-1, aMattemp.userID);

        }

        [TestMethod]
        public void Material_FindNotFound()
        {
            Material aMatToLoad = new Material();
            aMatToLoad = aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            aMatToLoad = aMatToLoad.findMatByMatID(connString, aMatID);

            Assert.AreEqual(-1, aMatToLoad.matID);
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
            aMatInitTime = "650:30:20";
            aMatInitDist = 2500.000M;
            aMatRecTime = "1000:00:00";
            aMatRecDist = 10000.000M;
            aMatBuyMemo = "Comprada";
            aUserID = 85;   

            Material aMatToLoad = new Material();
            aMatToLoad = aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            aMatToLoad = aMatToLoad.findMatByMatID(connString, aMatID);
            
            Assert.AreEqual(aMatID, aMatToLoad.matID);
            Assert.AreEqual(aMatName, aMatToLoad.matName);
            Assert.AreEqual(aMatModel, aMatToLoad.matModel);
            Assert.AreEqual(aMatBrand, aMatToLoad.matBrand);
            Assert.AreEqual(aMatSize, aMatToLoad.matSize);
            Assert.AreEqual(aMatWeight, aMatToLoad.matWeight);
            Assert.AreEqual(aMatBuyDate, aMatToLoad.matBuyDate);
            Assert.AreEqual(aMatCost, aMatToLoad.matCost);
            Assert.AreEqual(aMatInitTime, aMatToLoad.matInitTime);
            Assert.AreEqual(aMatInitDist, aMatToLoad.matInitDist);
            Assert.AreEqual(aMatRecTime, aMatToLoad.matRecTime);
            Assert.AreEqual(aMatRecDist, aMatToLoad.matRecDist);
            Assert.AreEqual(aMatBuyMemo, aMatToLoad.matBuyMemo);
            Assert.AreEqual(aUserID, aMatToLoad.userID);
        }

        [TestMethod]
        public void Material_CheckDataCorrect()
        {
            //Creates a material with data
            Material aMatToLoad = new Material();                                    
            aMatToLoad = aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            //Check data
            aMatToLoad = aMatToLoad.checkData(connString);
            Assert.AreEqual(aMatID, aMatToLoad.matID);
        }

        [TestMethod]
        public void Material_CheckDataBadID()
        {
            Material aMatToLoad = new Material();            
            aMatToLoad = aMatToLoad.LoadData(-1, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            //Check data
            aMatToLoad = aMatToLoad.checkData(connString);
            Assert.AreEqual(-1, aMatToLoad.matID);
        }

        [TestMethod]
        public void Material_CheckDataBadName()
        {
            //Creates a material with data
            Material aMatToLoad = new Material();
            aMatToLoad = aMatToLoad.LoadData(aMatID, "", aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, aUserID);
            //Check data
            aMatToLoad = aMatToLoad.checkData(connString);
            Assert.AreEqual(-2, aMatToLoad.matID);
        }

        [TestMethod]
        public void Material_CheckDataBadUserID()
        {
            Material aMatToLoad = new Material();
            aMatToLoad = aMatToLoad.LoadData(aMatID, aMatName, aMatModel, aMatBrand, aMatSize, aMatWeight, aMatBuyDate, aMatCost,
                                         aMatInitTime, aMatInitDist, aMatRecTime, aMatRecDist, aMatBuyMemo, -1);
            //Check data
            aMatToLoad = aMatToLoad.checkData(connString);
            Assert.AreEqual(-3, aMatToLoad.matID);
        }
    }
}
