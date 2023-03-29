using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5Alert
{
    [TestClass]
    public class tstAlert
    {
        string customerID = "1";
        string date = DateTime.Now.Date.ToString();
        string reminderInterval = DateTime.Now.Date.ToString();

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


        [TestMethod]
        public void ValidMethodOK()
        {
            clsAlert AnAlert = new clsAlert();
            String Error = "";
            Error = AnAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");
        }

        //customerID validation

        [TestMethod]
        public void CustomerIDLessOne()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            string customerID = "";
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMin()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            string customerID = "a";
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            string customerID = "aa";
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMid()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            string customerID = "";
            customerID = customerID.PadRight(25, 'a');
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            string customerID = "";
            customerID = customerID.PadRight(49, 'a');
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMax()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            string customerID = "";
            customerID = customerID.PadRight(50, 'a');
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            string customerID = "";
            customerID = customerID.PadRight(51, 'a');
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        //date validation

        [TestMethod]
        public void DateExtremeMin()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string date = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMinLessOne()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string date = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMin()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string date = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string date = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        //reminder interval validation

        [TestMethod]
        public void ReminderIntervalExtremeMin()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string reminderInterval = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReminderIntervalMinLessOne()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string reminderInterval = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReminderIntervalMin()
        {
            clsAlert anAlert = new clsAlert();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string reminderInterval = TestDate.ToString();
            Error = anAlert.Valid(customerID, date, reminderInterval);
            Assert.AreEqual(Error, "");

        }

        


    }
}
