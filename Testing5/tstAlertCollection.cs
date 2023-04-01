using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstAlertCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAlertCollection AllAlerts = new clsAlertCollection();
            Assert.IsNotNull(AllAlerts);
        }

        [TestMethod]
        public void AlertListOK()
        {
            clsAlertCollection AllAlerts = new clsAlertCollection();
            List<clsAlert> TestList = new List<clsAlert>();
            clsAlert TestItem = new clsAlert();

            TestItem.alertID = 1;
            TestItem.customerID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.reminderInterval = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllAlerts.AlertList = TestList;
            Assert.AreEqual(AllAlerts.AlertList, TestList);
        }

        

        [TestMethod]
        public void ThisAlertPropertyOK()
        {
            clsAlertCollection AllAlerts = new clsAlertCollection();
            clsAlert TestAlert = new clsAlert();

            TestAlert.alertID = 1;
            TestAlert.customerID = 1;
            TestAlert.date = DateTime.Now.Date;
            TestAlert.reminderInterval = DateTime.Now.Date;

            AllAlerts.ThisAlert = TestAlert;
            Assert.AreEqual(AllAlerts.ThisAlert, TestAlert);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsAlertCollection AllALerts = new clsAlertCollection();
            List<clsAlert> TestList = new List<clsAlert>();

            clsAlert TestItem = new clsAlert();

            TestItem.alertID = 1;
            TestItem.customerID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.reminderInterval = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllALerts.AlertList = TestList;
            Assert.AreEqual(AllALerts.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsAlertCollection AllAlerts = new clsAlertCollection();
            clsAlert TestItem = new clsAlert();
            Int32 PrimaryKey = 0;
            TestItem.alertID = 1;
            TestItem.customerID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.reminderInterval = DateTime.Now.Date;
            AllAlerts.ThisAlert = TestItem;
            PrimaryKey = AllAlerts.Add();
            TestItem.alertID = PrimaryKey;
            AllAlerts.ThisAlert.Find(PrimaryKey);
            Assert.AreEqual(AllAlerts.ThisAlert, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsAlertCollection AllAlerts = new clsAlertCollection();
            clsAlert TestItem = new clsAlert();
            Int32 PrimaryKey = 0;

            TestItem.customerID = 8;
            TestItem.date = DateTime.Now.Date;
            TestItem.reminderInterval = DateTime.Now.Date;

            AllAlerts.ThisAlert = TestItem;
            PrimaryKey = AllAlerts.Add();
            TestItem.alertID = PrimaryKey;

            TestItem.customerID = 9;
            TestItem.date = DateTime.Now.Date;
            TestItem.reminderInterval = DateTime.Now.Date;

            AllAlerts.ThisAlert = TestItem;
            AllAlerts.Update();
            AllAlerts.ThisAlert.Find(PrimaryKey);
            Assert.AreEqual(AllAlerts.ThisAlert, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsAlertCollection AllAlerts = new clsAlertCollection();
            clsAlert TestItem = new clsAlert();
            Int32 PrimaryKey = 0;

            TestItem.alertID = 1;
            TestItem.customerID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.reminderInterval = DateTime.Now.Date;

            AllAlerts.ThisAlert = TestItem;
            PrimaryKey = AllAlerts.Add();
            TestItem.alertID = PrimaryKey;
            AllAlerts.ThisAlert.Find(PrimaryKey);
            AllAlerts.Delete();
            Boolean Found = AllAlerts.ThisAlert.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

       


    }
}
