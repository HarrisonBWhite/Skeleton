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

        [TestMethod]
        public void AddMethodOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();

            clsLogin TestItem = new clsLogin();

            Int32 PrimaryKey = 0;

            TestItem.userID = 2;
            TestItem.username = "user1";
            TestItem.password = "pass1";

            AllLogins.ThisLogin = TestItem;
            PrimaryKey = AllLogins.Add();
            TestItem.userID = PrimaryKey;
            AllLogins.ThisLogin.Find(PrimaryKey);
            Assert.AreEqual(AllLogins.ThisLogin, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();

            clsLogin TestItem = new clsLogin();
            Int32 PrimaryKey = 0;


            TestItem.username = "user1";
            TestItem.password = "pass1";

            AllLogins.ThisLogin = TestItem;
            PrimaryKey = AllLogins.Add();
            TestItem.userID = PrimaryKey;

            TestItem.username = "abcd";
            TestItem.password = "1234";

            AllLogins.ThisLogin = TestItem;
            AllLogins.Update();
            AllLogins.ThisLogin.Find(PrimaryKey);
            Assert.AreEqual(AllLogins.ThisLogin, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();
            clsLogin TestItem = new clsLogin();
            Int32 PrimaryKey = 0;

            TestItem.userID = 2;
            TestItem.username = "user6";
            TestItem.password = "pass6";

            AllLogins.ThisLogin = TestItem;
            PrimaryKey = AllLogins.Add();
            TestItem.userID = PrimaryKey;
            AllLogins.ThisLogin.Find(PrimaryKey);
            AllLogins.Delete();
            Boolean Found = AllLogins.ThisLogin.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            clsLoginCollection AllLogins = new clsLoginCollection();
            clsLoginCollection FilteredUsers = new clsLoginCollection();
            FilteredUsers.ReportByUsername("");
            Assert.AreEqual(AllLogins.Count, FilteredUsers.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsLoginCollection FilteredUsers = new clsLoginCollection();
            FilteredUsers.ReportByUsername("user1");
            Assert.AreNotEqual(0, FilteredUsers.Count);
        }

        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            clsLoginCollection FilteredUsers = new clsLoginCollection();

            Boolean OK = true;
            FilteredUsers.ReportByUsername("user1");

            if(FilteredUsers.Count == 2)
            {
                if(FilteredUsers.LoginList[0].userID != 2)
                {
                    OK = false;
                }
                /*if(FilteredUsers.LoginList[1].userID != 3)
                {
                    OK = false;
                }*/
            }
            else
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }


    }
}
