using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstLoginCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();
            Assert.IsNotNull(AllLogins);
        }

        [TestMethod]
        public void LoginListOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();
            List<clsLogin> TestList = new List<clsLogin>();
            clsLogin TestItem = new clsLogin();

            TestItem.userID = 2;
            TestItem.username = "user1";
            TestItem.password = "pass1";

            TestList.Add(TestItem);
            AllLogins.LoginList = TestList;
            Assert.AreEqual(AllLogins.LoginList, TestList);

        }


        [TestMethod]
        public void ThisPropertyOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();
            clsLogin TestLogin = new clsLogin();

            TestLogin.userID = 2;
            TestLogin.username = "user1";
            TestLogin.password = "pass1";

            AllLogins.ThisLogin = TestLogin;
            Assert.AreEqual(AllLogins.ThisLogin, TestLogin);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();
            List<clsLogin> TestList = new List<clsLogin>();
            clsLogin TestItem = new clsLogin();

            TestItem.userID = 2;
            TestItem.username = "user1";
            TestItem.password = "pass1";

            TestList.Add(TestItem);
            AllLogins.LoginList = TestList;
            Assert.AreEqual(AllLogins.Count, TestList.Count);

        }

        


    }
}
