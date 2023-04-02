using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1Login
{
    [TestClass]
    public class tstLogin
    {
        string username = "user1";
        string password = "pass1";

        [TestMethod]
        public void InstanceOK()
        {
            clsLogin AnLogin = new clsLogin();
            Assert.IsNotNull(AnLogin);
        }

        
        [TestMethod]
        public void UserIDOK()
        {
            clsLogin AnLogin = new clsLogin();
            int TestData = 1;
            AnLogin.userID = TestData;
            Assert.AreEqual(AnLogin.userID, TestData);

        }

        [TestMethod]
        public void UsernameOK()
        {
            clsLogin AnLogin = new clsLogin();
            string TestData = "user0";
            AnLogin.username = TestData;
            Assert.AreEqual(AnLogin.username, TestData);

        }

        [TestMethod]
        public void PasswordOK()
        {
            clsLogin AnLogin = new clsLogin();
            string TestData = "pass0";
            AnLogin.password = TestData;
            Assert.AreEqual(AnLogin.password, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsLogin AnLogin = new clsLogin();
            Boolean Found = false;
            Int32 userID = 2;
            Found = AnLogin.Find(userID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIDFound()
        {
            clsLogin AnLogin = new clsLogin();
            Boolean Found = false;
            Boolean OK = true;
            Int32 userID = 2;
            Found = AnLogin.Find(userID);
            if(AnLogin.userID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            clsLogin AnLogin = new clsLogin();
            Boolean Found = false;
            Boolean OK = true;
            Int32 userID = 2;
            Found = AnLogin.Find(userID);
            if (AnLogin.username != "user1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsLogin AnLogin = new clsLogin();
            Boolean Found = false;
            Boolean OK = true;
            Int32 userID = 2;
            Found = AnLogin.Find(userID);
            if (AnLogin.password != "pass1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");
        }

        //username validation
        [TestMethod]
        public void UsernameMinLessOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "";
            Error = AnLogin.Valid(username, password);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMin()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "a";
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "aa";
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMid()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "";
            username = username.PadRight(25, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "";
            username = username.PadRight(49, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMax()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "";
            username = username.PadRight(50, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "";
            username = username.PadRight(51, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void UsernameExtremeMax()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string username = "";
            username = username.PadRight(500, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreNotEqual(Error, "");

        }

        //password validation
        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "";
            Error = AnLogin.Valid(username, password);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMin()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "a";
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "aa";
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMid()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "";
            password = password.PadRight(25, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "";
            password = password.PadRight(49, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMax()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "";
            password = password.PadRight(50, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "";
            password = password.PadRight(51, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string password = "";
            password = password.PadRight(500, 'a');
            Error = AnLogin.Valid(username, password);
            Assert.AreNotEqual(Error, "");

        }



    }
}
