using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3CompletedJob
{
    [TestClass]
    public class tstCompletedJob
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            Assert.IsNotNull(AnCompletedJob);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            Boolean TestData = true;
            AnCompletedJob.Active = TestData;
            Assert.AreEqual(AnCompletedJob.Active, TestData);
        }

        [TestMethod]
        public void JobIDOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            int TestData = 1;
            AnCompletedJob.jobID = TestData;
            Assert.AreEqual(AnCompletedJob.jobID, TestData);
        }


        [TestMethod]
        public void LastNameOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            string TestData = "White";
            AnCompletedJob.lastName = TestData;
            Assert.AreEqual(AnCompletedJob.lastName, TestData);
        }

        [TestMethod]
        public void HouseNameOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            string TestData = "April Cottage";
            AnCompletedJob.houseName = TestData;
            Assert.AreEqual(AnCompletedJob.houseName, TestData);
        }

        [TestMethod]
        public void commnetsOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            string TestData = "N/A";
            AnCompletedJob.comments = TestData;
            Assert.AreEqual(AnCompletedJob.comments, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            DateTime TestData = DateTime.Now.Date;
            AnCompletedJob.date = TestData;
            Assert.AreEqual(AnCompletedJob.date, TestData);
        }

        [TestMethod]
        public void JobTakeOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            double TestData = 45.0;
            AnCompletedJob.jobTake = TestData;
            Assert.AreEqual(AnCompletedJob.jobTake, TestData);
        }

        [TestMethod]
        public void TotalVisitsOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            int TestData = 1;
            AnCompletedJob.totalVisits = TestData;
            Assert.AreEqual(AnCompletedJob.totalVisits, TestData);
        }

    }
}
