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
            aSportType.LoadData(-1, "Bike", 0, "Bike sports", 85);
            Assert.AreEqual(aSportType.SportTypeID, -1);
            Assert.AreEqual(aSportType.SportTypeName, "Bike");
            Assert.AreEqual(aSportType.ParentSportTypeID, 0);
            Assert.AreEqual(aSportType.Memo, "Bike sports");
            Assert.AreEqual(aSportType.UserID, 85);
        }

        [TestMethod]
        public void SportType_Reset()
        {
            //SportTypes aSportType = new SportTypes();            
            aSportType.LoadData(-1, "Bicicleta", 1, "Deportes de Bicicleta",85);            
            aSportType.Reset();
            Assert.AreEqual(aSportType.SportTypeID, -1);
            Assert.AreEqual(aSportType.SportTypeName, null);
            Assert.AreEqual(aSportType.ParentSportTypeID, -1);
            Assert.AreEqual(aSportType.Memo, null);
            Assert.AreEqual(aSportType.UserID, -1);
        }

        [TestMethod]
        public void SportType_CheckDataBeforeSave()
        {
            //Create a SportType object with data.
            aSportType.LoadData(-1, "Weird Sport", 0, "any kind of weird sport", 85);
            int res = aSportType.CheckData(connString);
            Assert.AreEqual(1, res); //Data are ok because the type of sport isn´t in de BD.

            //Save the data into BD, and check again.            
            aSportType = aSportType.SaveData(connString);
            Int64 sportTypeIDUsed = aSportType.SportTypeID;
            Int64 userIDUsed = aSportType.UserID;
            res = aSportType.CheckData(connString);
            Assert.AreEqual(-1, res); //Data are not ok, SportTypeName is in de BD.
            
            //Create a SportType object with data: 
            aSportType.LoadData(-1, "Weird Sport2", -10, "any kind of weird sport", 85);
            res = aSportType.CheckData(connString);
            Assert.AreEqual(-2, res); //Data are not ok, parentSportID does not exist on SportTypes

            //Create a SportType object with data: 
            aSportType.LoadData(-1, "", 0, "any kind of weird sport", 85);
            res = aSportType.CheckData(connString);
            Assert.AreEqual(0, res); //Data are not ok, SportTypeName is empty.            

            //Create a SportType object with data: 
            aSportType.LoadData(-1, "Weird Sport2", 0, "any kind of weird sport", -100);
            res = aSportType.CheckData(connString);
            Assert.AreEqual(-3, res); //Data are not ok, userID not in data base.

            //Deleting object saved first.            
            aSportType = aSportType.FindSportTypeByID(connString);
            res = aSportType.Delete(connString);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void SportType_SaveFindDeleteData()
         {
            //Create a SportType object
             string sportTypeNameUsed = "Bicicleta";
             Int64 parentSportTypeIDUsed = 0;
            string memoUsed = "Deportes de bicicleta";
            Int64 userIDUsed = 85;
            SportTypes aSportType = new SportTypes();
            aSportType.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportType = aSportType.SaveData(connString);
            Assert.AreNotEqual(0, aSportType.SportTypeID); //saving correct data and res containg the sportTypeID
            Int64 sportTypeIDUsed = aSportType.SportTypeID;

            //Try to find
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreNotEqual(-1, aSportType.SportTypeName);
            Assert.AreEqual(sportTypeNameUsed, aSportType.SportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.ParentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.Memo);
            Assert.AreEqual(userIDUsed, aSportType.UserID);

            //Deleting object previously saved
            int res=aSportType.Delete(connString);
            Assert.AreEqual(1, res);

            //Try to find again after deleting
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreEqual(-1, aSportType.SportTypeID);          
        }

        [TestMethod]
        public void SportType_SaveFindByName()
        {
            //Create a SportType object
            string sportTypeNameUsed = "Bicicleta";
            Int32 parentSportTypeIDUsed = 0;
            string memoUsed = "Deportes de bicicleta";
            Int32 userIDUsed = 85;
            SportTypes aSportType = new SportTypes();
            aSportType.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportType = aSportType.SaveData(connString);
            Assert.AreNotEqual(0, aSportType.SportTypeID);
            Assert.AreNotEqual(0, aSportType.SportTypeID); //saving correct data            

            //Try to find
            aSportType = aSportType.FindSportTypeByName(connString);
            Assert.AreNotEqual(-1, aSportType.SportTypeID);
            Assert.AreEqual(sportTypeNameUsed, aSportType.SportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.ParentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.Memo);
            Assert.AreEqual(userIDUsed, aSportType.UserID);

            //Deleting object previously saved
            int res = aSportType.Delete(connString);
            Assert.AreEqual(1, res);

            //Try to find again after deleting
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreEqual(-1, aSportType.SportTypeID);
        }

        [TestMethod]
        public void SportType_Update()
        {
            //Create a SportType object
            string sportTypeNameUsed = "Bicicleta";
            Int64 parentSportTypeIDUsed = 0;
            string memoUsed = "Deportes de bicicleta";
            Int64 userIDUsed = 85;
            SportTypes aSportType = new SportTypes();
            aSportType.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportType = aSportType.SaveData(connString);
            Assert.AreNotEqual(0, aSportType.SportTypeID);
            Assert.AreNotEqual(0, aSportType.SportTypeID); //saving correct data            
            Int64 sportTypeIDUsed = aSportType.SportTypeID;

            //Try to find and check values
            aSportType = aSportType.FindSportTypeByName(connString);
            Assert.AreNotEqual(-1, aSportType.SportTypeID);
            Assert.AreEqual(sportTypeNameUsed, aSportType.SportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.ParentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.Memo);
            Assert.AreEqual(userIDUsed, aSportType.UserID);

            //Update values
            sportTypeNameUsed = "Bike Updated";
            parentSportTypeIDUsed = 0;
            memoUsed = "Deportes de bicicleta updated";
            userIDUsed = 85;
            aSportType.LoadData(sportTypeIDUsed, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);
            aSportType.UpdateData(connString);

            //Try to find and check values
            aSportType = aSportType.FindSportTypeByName(connString);
            Assert.AreNotEqual(-1, aSportType.SportTypeID);
            Assert.AreEqual(sportTypeNameUsed, aSportType.SportTypeName);
            Assert.AreEqual(parentSportTypeIDUsed, aSportType.ParentSportTypeID);
            Assert.AreEqual(memoUsed, aSportType.Memo);
            Assert.AreEqual(userIDUsed, aSportType.UserID);

            //Deleting object previously saved
            int res = aSportType.Delete(connString);
            Assert.AreEqual(1, res);

            //Try to find again after deleting
            aSportType = aSportType.FindSportTypeByID(connString);
            Assert.AreEqual(-1, aSportType.SportTypeID);
        }

        [TestMethod]
        public void SportType_FindParent()
        {
           //Create a SportType object to be the parent
            string sportTypeNameUsed = "Deporte Padre";
            Int64 parentSportTypeIDUsed = 0;
            string memoUsed = "Deporte padre";
            Int64 userIDUsed = 85;
            SportTypes aSportTypeParent = new SportTypes();
            aSportTypeParent.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportTypeParent = aSportTypeParent.SaveData(connString);            
            Assert.AreNotEqual(0, aSportTypeParent.SportTypeID); //saving correct data            

           //Create a SportType object to be the child
            sportTypeNameUsed = "Deporte Hijo";
            parentSportTypeIDUsed = aSportTypeParent.SportTypeID;
            memoUsed = "Deporte Hijo";
            userIDUsed = 85;
            SportTypes aSportTypeChild = new SportTypes();
            aSportTypeChild.LoadData(-1, sportTypeNameUsed, parentSportTypeIDUsed, memoUsed, userIDUsed);

            //Save into BD obtaining the sportTypeID
            aSportTypeChild = aSportTypeChild.SaveData(connString);            
            Assert.AreNotEqual(0, aSportTypeChild.SportTypeID); //saving correct data            

            //Try to find the parent sport type.
            SportTypes parentSportTypeToFind = new SportTypes();
            parentSportTypeToFind = aSportTypeChild.FindParentSportType(connString);
            Assert.AreNotEqual(-1, parentSportTypeToFind.SportTypeID); //Found it!!
            Assert.AreEqual(aSportTypeParent.SportTypeID, parentSportTypeToFind.SportTypeID);
            Assert.AreEqual(aSportTypeParent.SportTypeName, parentSportTypeToFind.SportTypeName);
            Assert.AreEqual(aSportTypeParent.ParentSportTypeID, parentSportTypeToFind.ParentSportTypeID);
            Assert.AreEqual(aSportTypeParent.Memo, parentSportTypeToFind.Memo);

            //Deleting object previously saved
            int res = aSportTypeParent.Delete(connString);
            Assert.AreEqual(1, res);

            //Deleting object previously saved
            res = aSportTypeChild.Delete(connString);
            Assert.AreEqual(1, res);
        }

    }
}
