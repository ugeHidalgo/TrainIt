using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainItLibrary;

namespace TrainItTests
{
    [TestClass]
    public class UsersTest
    {     
        [TestMethod]
        public void checkUserData()
        {            
            Users aUser = new Users(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "1234", "1234", "nombre@gmail.com");
            int res=0;
            res=aUser.checkUserData(aUser);
            Assert.AreEqual(0,res);

            aUser = aUser.loadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "", "1234", "1234", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(aUser);
            Assert.AreEqual(-1,res);

            aUser = aUser.loadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "", "1234", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(aUser);
            Assert.AreEqual(-2,res);

            aUser = aUser.loadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "1234", "", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(aUser);
            Assert.AreEqual(-2,res);

            aUser = aUser.loadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "", "", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(aUser);
            Assert.AreEqual(0,res);

            aUser = aUser.loadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "", "", "", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(aUser);
            Assert.AreEqual(-1,res);

            aUser = aUser.loadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "", "", "123", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(aUser);
            Assert.AreEqual(-1,res);
        }

        [TestMethod]
        public void TestReset()
        {
            Users aUser = new Users(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "1234", "1234", "nombre@gmail.com");
            aUser = aUser.Reset(aUser);
            Assert.AreEqual(-1, aUser.userID);
            Assert.AreEqual("", aUser.userFirstName);
            Assert.AreEqual("", aUser.userSecondName);
            Assert.AreEqual(DateTime.Now, aUser.userBDate);
            Assert.AreEqual("", aUser.userName);
            Assert.AreEqual("", aUser.userPass);
            Assert.AreEqual("", aUser.userConfirmPassword);
            Assert.AreEqual("", aUser.userMail);
        }

        [TestMethod]
        public void TestFindUserByID()
        {
            //Prepares a communication string
            string server = "HPDESPACHO\\SQLSERVER1";
            string catalog = "TrainIT";
            string connString = @"Integrated Security = true;
                                  Initial catalog = " + catalog + @";
                                  Data Source = " + server + @";";

            //Creates an User with data.
            int userID = 64;
            Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", ""); 
            //findUserByUserID returns a user if find, if not find return a user wit UserID=-1
            aUser = aUser.findUserByUserID (connString,userID);
            Assert.AreNotEqual(-1, aUser.userID);
            Assert.AreEqual(userID, aUser.userID);
        }


        [TestMethod]
        public void TestFindUserByUserName()
        {
            //Prepares a communication string
            string server = "HPDESPACHO\\SQLSERVER1";
            string catalog = "TrainIT";
            string connString = @"Integrated Security = true;
                                  Initial catalog = " + catalog + @";
                                  Data Source = " + server + @";";

            //Creates an User with data.
            string userName = "uge";  //Put here the username of a user that exits in the BD.
            Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            aUser = aUser.findUserByUserName(connString, userName);
            Assert.AreNotEqual(-1, aUser.userID);
            Assert.AreEqual(userName, aUser.userName);
        }        

        [TestMethod]
        public void TestSaveUser()
        {
            //Creates anUser with data.
            Users aUser = new Users(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "1234", "1234", "nombre@gmail.com");

            //Prepares a communication string
            string server = "HPDESPACHO\\SQLSERVER1";
            string catalog = "TrainIT";
            string connString = @"Integrated Security = true;
                                  Initial catalog = " + catalog + @";
                                  Data Source = " + server + @";";

            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try without password and confirm            
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick1", "", "", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try without login name            
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "", "1234", "1234", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreEqual(-1, aUser.userID); //-1=no save data, missing login name

            //Try without password
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick2", "", "1234", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreEqual(-1, aUser.userID); //-2=no save data, pass and confirm not equal

            //Try without confirm            
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick3", "1234", "", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreEqual(-1, aUser.userID); //-2=no save data, pass and confirm not equal

            //Try with different password and confirm            
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "1234", "4321", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreEqual(-1, aUser.userID); //-2=no save data, pass and confirm not equal
        }

        [TestMethod]
        public void TestDeleteUserName()
        {
            //Prepares a communication string
            string server = "HPDESPACHO\\SQLSERVER1";
            string catalog = "TrainIT";
            string connString = @"Integrated Security = true;
                                  Initial catalog = " + catalog + @";
                                  Data Source = " + server + @";";

            //Creates an User with data.            
            Users aUser = new Users(-1, "name", "", DateTime.Now, "", "", "", "");

            //Try to save first
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "NickToDel", "1234", "1234", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try to find it
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            string expectedUserName = aUser.userName;
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreNotEqual(-1, aUser.userID); //User finded


            //Try to Delete previous saved user.            
            int res = aUser.deleteUserByUserID(connString, aUser.userID);
            Assert.AreEqual( 1, res); //Deleted with success


            //Try to find it
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1            
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreEqual(-1, aUser.userID); //User not found because was deleted            
        }


        [TestMethod]
        public void UpdateTest()
        {
            //Prepares a communication string
            string server = "HPDESPACHO\\SQLSERVER1";
            string catalog = "TrainIT";
            string connString = @"Integrated Security = true;
                                  Initial catalog = " + catalog + @";
                                  Data Source = " + server + @";";

            //Creates an User with data.            
            Users aUser = new Users(-1, "name", "", DateTime.Now, "", "", "", "");

            //Try to save first
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "NickToDel", "1234", "1234", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try to find it and take the userID
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            string expectedUserName = aUser.userName;
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreEqual(expectedUserName, aUser.userName);
            int expectedUserID = aUser.userID;

            //Try to Update previous saved user.            
            aUser.userSecondName = "Second Name Updated";
            aUser = aUser.updateUserData(aUser, connString,expectedUserID);
            Assert.AreNotEqual(-1, aUser.userID); //1=update data without any problem.

            //Try to find it
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            expectedUserName = aUser.userName;
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreEqual(expectedUserName, aUser.userName);

            //Verify the update.
            Assert.AreEqual("Second Name Updated", aUser.userSecondName);

            //Try to Delete previous saved user.            
            int res = aUser.deleteUserByUserID(connString, aUser.userID);
            Assert.AreEqual(1, res); //Deleted with success

            //Try to find it
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            expectedUserName = aUser.userName;
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreEqual(-1, aUser.userID); //user not found because was deleted            
        }

        [TestMethod]
        public void loginTest()
        {
            //Prepares a communication string
            string server = "HPDESPACHO\\SQLSERVER1";
            string catalog = "TrainIT";
            string connString = @"Integrated Security = true;
                                  Initial catalog = " + catalog + @";
                                  Data Source = " + server + @";";

            //Creates an User with data.            
            Users aUser = new Users(-1, "name", "", DateTime.Now, "", "", "", "");

            //Try to save first
            aUser = aUser.loadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "NickToDel", "1234", "1234", "nombre@gmail.com");
            aUser = aUser.saveUserData(aUser, connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try to find it and take the userID
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            string expectedUserName = aUser.userName;
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreEqual(expectedUserName, aUser.userName);
            int expectedUserID = aUser.userID;

            //Correct login
            string givenPassword = "1234";
            Boolean login = aUser.verifyPass(aUser.userName, givenPassword, connString);
            Assert.AreEqual(true, login);

            //Uncorrect Login
            givenPassword = "";
            login = aUser.verifyPass(aUser.userName, givenPassword, connString);
            Assert.AreEqual(false, login);

            //Try to Delete previous saved user.            
            int res = aUser.deleteUserByUserID(connString, aUser.userID);
            Assert.AreEqual(1, res); //Deleted with success
        }

    }
}
