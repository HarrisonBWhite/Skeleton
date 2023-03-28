using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5Alert
{
    [TestClass]
    public class tstAlert
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAlert AnAlert = new clsAlert();
            Assert.IsNotNull(AnAlert);
        }


        


        [TestMethod]
        public void alertIDOK()
        {
            clsAlert AnAlert = new clsAlert();
            int TestData = 1;
            AnAlert.alertID = TestData;
            Assert.AreEqual(AnAlert.alertID, TestData);
        }

        [TestMethod]
        public void customerIDOK()
        {
            clsAlert AnAlert = new clsAlert();
            int TestData = 1;
            AnAlert.customerID = TestData;
            Assert.AreEqual(AnAlert.customerID, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            clsAlert AnAlert = new clsAlert();
            DateTime TestData = DateTime.Now.Date;
            AnAlert.date = TestData;
            Assert.AreEqual(AnAlert.date, TestData);
        }

        [TestMethod]
        public void ReminderIntervalOK()
        {
            clsAlert AnAlert = new clsAlert();
            DateTime TestData = DateTime.Now.Date;
            AnAlert.reminderInterval = TestData;
            Assert.AreEqual(AnAlert.reminderInterval, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsAlert AnAlert = new clsAlert();
            Boolean Found = false;
            Int32 alertID = 1;
            Found = AnAlert.Find(alertID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAlertIDFound()
        {
            clsAlert AnAlert = new clsAlert();
            Boolean Found = false;
            Boolean OK = true;
            Int32 alertID = 1;
            Found = AnAlert.Find(alertID);
            if (AnAlert.alertID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsAlert AnAlert = new clsAlert();
            Boolean Found = false;
            Boolean OK = true;
            Int32 alertID = 1;
            Found = AnAlert.Find(alertID);
            if (AnAlert.customerID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateFound()
        {
            clsAlert AnAlert = new clsAlert();
            Boolean Found = false;
            Boolean OK = true;
            Int32 alertID = 1;
            Found = AnAlert.Find(alertID);
            if (AnAlert.date != Convert.ToDateTime("10/04/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReminderIntervalFound()
        {
            clsAlert AnAlert = new clsAlert();
            Boolean Found = false;
            Boolean OK = true;
            Int32 alertID = 1;
            Found = AnAlert.Find(alertID);
            if (AnAlert.reminderInterval != Convert.ToDateTime("10/05/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

    }
}
