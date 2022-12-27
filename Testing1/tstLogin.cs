using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1Login
{
    [TestClass]
    public class tstLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLogin AnLogin = new clsLogin();
            Assert.IsNotNull(AnLogin);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsLogin AnLogin = new clsLogin();
            Boolean TestData = true;
            AnLogin.Active = TestData;
            Assert.AreEqual(AnLogin.Active, TestData);
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



    }
}
