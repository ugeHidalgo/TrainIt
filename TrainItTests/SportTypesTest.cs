using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainItLibrary;


namespace TrainItTests
{
    [TestClass]
    public class SportTypesTest
    {
        //Create an instance of an object
        SportTypes aSportType = new SportTypes();

        //Prepares a communication string
        static string server = "HPDESPACHO\\SQLSERVER1";
        static string catalog = "TrainIT";
        static string connString = @"Integrated Security = true;
                                     Initial catalog = " + catalog + @";
                                     Data Source = " + server + @";";

        [TestMethod]
        public void SportType_LoadData()
        {            
            aSportType = aSportType.LoadData(-1, "Bike", 0, "Bike sports", 85);
            Assert.AreEqual(aSportType.sportTypeID, -1);
            Assert.AreEqual(aSportType.sportTypeName, "Bike");
            Assert.AreEqual(aSportType.parentSportTypeID, 0);
            Assert.AreEqual(aSportType.memo, "Bike sports");
            Assert.AreEqual(aSportType.userID, 85);
        }

        [TestMethod]
        public void SportType_Reset()
        {
            //SportTypes aSportType = new SportTypes();            
            aSportType=aSportType.LoadData(-1, "Bicicleta", 1, "Deportes de Bicicleta",85);            
            aSportType=aSportType.Reset();
            Assert.AreEqual(aSportType.sportTypeID, -1);
            Assert.AreEqual(aSportType.sportTypeName, null);
            Assert.AreEqual(aSportType.parentSportTypeID, -1);
            Assert.AreEqual(aSportType.memo, null);
            Assert.AreEqual(aSportType.userID, -1);
        }

        [TestMethod]
        public void SportType_CheckDataBeforeSave()
        {
            //Create a SportType object with data.
            aSportType = aSportType.LoadData(-1, "Weird Sport", 0, "any kind of weird sport", 85);
            int res = aSportType.CheckData(connString);
            Assert.AreEqual(1, res); //Data are ok because the type of sport isn´t in de BD.

            //Save the data into BD, and check again.            
            aSportType = aSportType.SaveData(connString);
            int sportTypeIDUsed = aSportType.sportTypeID;
            int userIDUsed = aSportType.userID;
            res = aSportType.CheckData(connString);
            Assert.AreEqual(-1, res); //Data are not ok, SportTypeName is in de BD.
            
            //Create a SportType object with data: 
            aSportType = aSportType.LoadData(-1, "Weird Sport2", -10, "any kind of weird sport", 85);
            res = aSportType.CheckData(connString);
            Assert.AreEqual(-2, res); //Data are not ok, parentSportID does not exist on SportTypes

            //Create a SportType object with data: 
            aSportType = aSportType.LoadData(-1, "", 0, "any kind of weird sport", 85);
            res = aSportType.CheckData(connString);
            Assert.AreEqual(0, res); //Data are not ok, SportTypeName is empty.            

            //Create a SportType object with data: 
            aSportType = aSportType.LoadData(-1, "Weird Sport2", 0, "any kind of weird sport", -100);
            res = aSportType.CheckData(connString);
            Assert.AreEqual(-3, res); //Data are not ok, userID not in data base.

            //Deleting object saved first.
            aSportType.sportTypeID = sportTypeIDUsed;
            aSportType.userID = userIDUsed;
            aSportType = aSportType.FindSportTypeByID(connString);
            res = aSportType.Delete(connString);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void SportType_SaveFindDeleteData()
         {
            //Create a SportType object
             string sportTypeNameUsed = "Bicicleta";
            int parentSportTypeIDUsed = 0;
            string memoUsed = "Deportes de bicicleta";
            int userIDUsed = 85;
            SportTypes aSportType = new SportTypes();
            aSportType = aSportType.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportType = aSportType.SaveData(connString);
            Assert.AreNotEqual(0, aSportType.sportTypeID); //saving correct data and res containg the sportTypeID
            int sportTypeIDUsed = aSportType.sportTypeID;

            //Try to find
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreNotEqual(-1, aSportType.sportTypeName);
            Assert.AreEqual(sportTypeNameUsed, aSportType.sportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.parentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.memo);
            Assert.AreEqual(userIDUsed, aSportType.userID);

            //Deleting object previously saved
            int res=aSportType.Delete(connString);
            Assert.AreEqual(1, res);

            //Try to find again after deleting
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreEqual(-1, aSportType.sportTypeID);          
        }

        [TestMethod]
        public void SportType_SaveFindByName()
        {
            //Create a SportType object
            string sportTypeNameUsed = "Bicicleta";
            int parentSportTypeIDUsed = 0;
            string memoUsed = "Deportes de bicicleta";
            int userIDUsed = 85;
            SportTypes aSportType = new SportTypes();
            aSportType = aSportType.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportType = aSportType.SaveData(connString);
            Assert.AreNotEqual(0, aSportType.sportTypeID);
            Assert.AreNotEqual(0, aSportType.sportTypeID); //saving correct data            

            //Try to find
            aSportType = aSportType.FindSportTypeByName(connString);
            Assert.AreNotEqual(-1, aSportType.sportTypeID);
            Assert.AreEqual(sportTypeNameUsed, aSportType.sportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.parentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.memo);
            Assert.AreEqual(userIDUsed, aSportType.userID);

            //Deleting object previously saved
            int res = aSportType.Delete(connString);
            Assert.AreEqual(1, res);

            //Try to find again after deleting
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreEqual(-1, aSportType.sportTypeID);
        }

        [TestMethod]
        public void SportType_Update()
        {
            //Create a SportType object
            string sportTypeNameUsed = "Bicicleta";
            int parentSportTypeIDUsed = 0;
            string memoUsed = "Deportes de bicicleta";
            int userIDUsed = 85;
            SportTypes aSportType = new SportTypes();
            aSportType = aSportType.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportType = aSportType.SaveData(connString);
            Assert.AreNotEqual(0, aSportType.sportTypeID);
            Assert.AreNotEqual(0, aSportType.sportTypeID); //saving correct data            
            int sportTypeIDUsed = aSportType.sportTypeID;

            //Try to find and check values
            aSportType = aSportType.FindSportTypeByName(connString);
            Assert.AreNotEqual(-1, aSportType.sportTypeID);
            Assert.AreEqual(sportTypeNameUsed, aSportType.sportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.parentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.memo);
            Assert.AreEqual(userIDUsed, aSportType.userID);

            //Update values
            sportTypeNameUsed = "Bike Updated";
            parentSportTypeIDUsed = 0;
            memoUsed = "Deportes de bicicleta updated";
            userIDUsed = 85;
            aSportType = aSportType.LoadData(sportTypeIDUsed, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);
            aSportType.UpdateData(connString);

            //Try to find and check values
            aSportType = aSportType.FindSportTypeByName(connString);
            Assert.AreNotEqual(-1, aSportType.sportTypeID);
            Assert.AreEqual(sportTypeNameUsed, aSportType.sportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.parentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.memo);
            Assert.AreEqual(userIDUsed, aSportType.userID);

            //Deleting object previously saved
            int res = aSportType.Delete(connString);
            Assert.AreEqual(1, res);

            //Try to find again after deleting
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreEqual(-1, aSportType.sportTypeID);
        }

        [TestMethod]
        public void SportType_FindParent()
        {
           //Create a SportType object to be the parent
            string sportTypeNameUsed = "Deporte Padre";
            int parentSportTypeIDUsed = 0;
            string memoUsed = "Deporte padre";
            int userIDUsed = 85;
            SportTypes aSportTypeParent = new SportTypes();
            aSportTypeParent = aSportTypeParent.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportTypeParent = aSportTypeParent.SaveData(connString);            
            Assert.AreNotEqual(0, aSportTypeParent.sportTypeID); //saving correct data            

           //Create a SportType object to be the child
            sportTypeNameUsed = "Deporte Hijo";
            parentSportTypeIDUsed = aSportTypeParent.sportTypeID;
            memoUsed = "Deporte Hijo";
            userIDUsed = 85;
            SportTypes aSportTypeChild = new SportTypes();
            aSportTypeChild = aSportTypeChild.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportTypeChild = aSportTypeChild.SaveData(connString);            
            Assert.AreNotEqual(0, aSportTypeChild.sportTypeID); //saving correct data            

            //Try to find the parent sport type.
            SportTypes parentSportTypeToFind = new SportTypes();
            parentSportTypeToFind = aSportTypeChild.FindParentSportType(connString);
            Assert.AreNotEqual(-1, parentSportTypeToFind.sportTypeID); //Found it!!
            Assert.AreEqual(aSportTypeParent.sportTypeID, parentSportTypeToFind.sportTypeID);
            Assert.AreEqual(aSportTypeParent.sportTypeName, parentSportTypeToFind.sportTypeName);
            Assert.AreEqual(aSportTypeParent.parentSportTypeID, parentSportTypeToFind.parentSportTypeID);
            Assert.AreEqual(aSportTypeParent.memo, parentSportTypeToFind.memo);

            //Deleting object previously saved
            int res = aSportTypeParent.Delete(connString);
            Assert.AreEqual(1, res);

            //Deleting object previously saved
            res = aSportTypeChild.Delete(connString);
            Assert.AreEqual(1, res);
        }

    }
}
