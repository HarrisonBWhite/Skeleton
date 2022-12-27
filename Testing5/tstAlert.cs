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
        public void ActivePropertyOK()
        {
            clsAlert AnAlert = new clsAlert();
            Boolean TestData = true;
            AnAlert.Active = TestData;
            Assert.AreEqual(AnAlert.Active, TestData);
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
            int TestData = 1;
            AnAlert.reminderInterval = TestData;
            Assert.AreEqual(AnAlert.reminderInterval, TestData);
        }


    }
}
