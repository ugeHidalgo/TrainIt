using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainItLibrary;

namespace TrainItTests
{
    [TestClass]
    public class UsersTest
    {
        //Prepares a communication string
        static string server = "HPDESPACHO\\SQLSERVER1";
        static string catalog = "TrainIT";
        static string connString = @"Integrated Security = true;
                                     Initial catalog = " + catalog + @";
                                     Data Source = " + server + @";";

        [TestMethod]
        public void Users_checkUserData()
        {   /*Verify the data to save:
           *       1: Data is ok to save.
           *      -1: userName is missing.
           *      -2: userName exists in data base
           *      -3: Password lenght is less than 8 characters.
           *      -4: Password and Confirm are differents.
           */
            //Reg ok.---> Before test check that ther insn´t a userName=userNick
            Users aUser = new Users(1, "Nombre", "Apellido", DateTime.Now, "userNick", "12345678", "12345678", "nombre@gmail.com");
            int res=0;
            res=aUser.checkUserData(connString);
            Assert.AreEqual(1,res);

            //User name missing
            aUser = aUser.LoadData(1, "Nombre", "Apellido", DateTime.Now, "", "12345678", "12345678", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(connString);
            Assert.AreEqual(-1,res); 

            //Password is different than confirm, but fails because password lenght less than 8
            aUser = aUser.LoadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "", "12345678", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(connString);
            Assert.AreEqual(-3,res);

            //Password is different than confirm
            aUser = aUser.LoadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "12345678", "", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(connString);
            Assert.AreEqual(-4,res);

            //Password lenght less than 8
            aUser = aUser.LoadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "", "", "nombre@gmail.com");
            res=0;
            res=aUser.checkUserData(connString);
            Assert.AreEqual(-3,res);

            //User exists
            aUser = aUser.LoadData(1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "admin", "12345678", "12345678", "nombre@gmail.com");
            res = 0;
            res = aUser.checkUserData(connString);
            Assert.AreEqual(-2, res);
        }

        [TestMethod]
        public void Users_TestReset()
        {
            Users aUser = new Users(-1, "Nombre", "Apellido", DateTime.Now, "userNick", "1234", "1234", "nombre@gmail.com");
            aUser = aUser.Reset();
            Assert.AreEqual(-1, aUser.userID);
            Assert.AreEqual(null, aUser.userFirstName);
            Assert.AreEqual(null, aUser.userSecondName);
            Assert.AreEqual(DateTime.Now, aUser.userBDate);
            Assert.AreEqual(null, aUser.userName);
            Assert.AreEqual(null, aUser.userPass);
            Assert.AreEqual(null, aUser.userConfirmPassword);
            Assert.AreEqual(null, aUser.userMail);
        }

        [TestMethod]
        public void Users_TestFindUserByID()
        {
            //Creates an User with data.
            int userID = 78;
            Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", ""); 
            //findUserByUserID returns a user if find, if not find return a user wit UserID=-1
            aUser = aUser.findUserByUserID (connString, userID);
            Assert.AreNotEqual(-1, aUser.userID);
            Assert.AreEqual(userID, aUser.userID);
        }

        [TestMethod]
        public void Users_TestFindUserByUserName()
        {
            //Creates an User with data.
            string userName = "uge";  //Put here the username of a user that exits in the BD.
            Users aUser = new Users(-1, "", "", DateTime.Now, "", "", "", "");
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            aUser = aUser.findUserByUserName(connString, userName);
            Assert.AreNotEqual(-1, aUser.userID);
            Assert.AreEqual(userName, aUser.userName);
        }        

        [TestMethod]
        public void Users_TestSaveUser()
        {
            //Creates anUser with data.
            Users aUser = new Users(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "userNick", "12345678", "12345678", "nombre@gmail.com");
            aUser = aUser.saveUserData(connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.
        }

        [TestMethod]
        public void Users_TestDeleteUserName()
        {
            //Creates an User with data.            
            Users aUser = new Users(-1, "name", "", DateTime.Now, "", "", "", "");

            //Try to save first
            aUser = aUser.LoadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "NickToDel", "12345678", "12345678", "nombre@gmail.com");
            aUser = aUser.saveUserData(connString);
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
        public void Users_UpdateTestWithoutPass()
        {
            //Creates an User with data.            
            Users aUser = new Users(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "NickToDel", "12345678", "12345678", "nombre@gmail.com");
            //Try to save first
            aUser = aUser.saveUserData(connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try to find it and take the userID
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            Users aUserToFind = aUser.findUserByUserName(connString, aUser.userName);
            Assert.AreEqual(aUser.userName, aUserToFind.userName);
            int expectedUserID = aUser.userID;

            //Try to Update previous saved user.            
            aUser.userSecondName = "Second Name Updated";
            aUser = aUser.updateUserData(connString,false);
            Assert.AreNotEqual(-1, aUser.userID); //1=update data without any problem.

            //Try to find it
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            
            aUserToFind = aUser.findUserByUserID(connString,aUser.userID);
            Assert.AreEqual(aUser.userName, aUserToFind.userName);

            //Verify the update.
            Assert.AreEqual(aUser.userSecondName,aUserToFind.userSecondName);

            //Try to Delete previous saved user.            
            int res = aUser.deleteUserByUserID(connString, aUser.userID);
            Assert.AreEqual(1, res); //Deleted with success

            //Try to find it                       
            aUser = aUser.findUserByUserID(connString, aUser.userID);
            Assert.AreEqual(-1, aUser.userID); //user not found because was deleted            
        }

        [TestMethod]
        public void Users_UpdateTestWithPass()
        {
            //Creates an User with data.            
            Users aUser = new Users(-1, "name", "", DateTime.Now, "", "", "", "");

            //Try to save first
            aUser = aUser.LoadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "NickToDel", "12345678", "12345678", "nombre@gmail.com");
            aUser = aUser.saveUserData(connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try to find it and take the userID
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            string expectedUserName = aUser.userName;
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreEqual(expectedUserName, aUser.userName); //User finded
            int expectedUserID = aUser.userID;

            //Try to Update previous saved user. 
            string newPass="NewPass0";
            aUser.userPass = newPass;
            aUser.userConfirmPassword = newPass;
            aUser = aUser.updateUserData(connString, true);            
            Boolean login = aUser.verifyPass(aUser.userName, newPass, connString);
            Assert.AreEqual(true, login); //Verify if new password was stored correctly
                       
            //Try to Delete previous saved user.            
            int res = aUser.deleteUserByUserID(connString, aUser.userID);
            Assert.AreEqual(1, res); //Deleted with success

            ////Try to find it
            ////findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            //expectedUserName = aUser.userName;
            //aUser = aUser.findUserByUserName(connString, expectedUserName);
            //Assert.AreEqual(-1, aUser.userID); //user not found because was deleted            
        }

        [TestMethod]
        public void Users_loginTest()
        {
            //Creates an User with data.            
            Users aUser = new Users(-1, "name", "", DateTime.Now, "", "", "", "");

            //Try to save first
            aUser = aUser.LoadData(-1, "Nombre", "Apellido", Convert.ToDateTime("12/04/1982"), "NickToDel", "12345678", "12345678", "nombre@gmail.com");
            aUser = aUser.saveUserData(connString);
            Assert.AreNotEqual(-1, aUser.userID); //1=save data without any problem.

            //Try to find it and take the userID
            //findUserByUserName returns a user if find, if not find return a user wit UserID=-1
            string expectedUserName = aUser.userName;
            aUser = aUser.findUserByUserName(connString, expectedUserName);
            Assert.AreEqual(expectedUserName, aUser.userName);
            int expectedUserID = aUser.userID;

            //Correct login
            string givenPassword = "12345678";
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
