using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3Job
{
    [TestClass]
    public class tstJob
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsJob AnJob = new clsJob();
            Assert.IsNotNull(AnJob);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsJob AnJob = new clsJob();
            Boolean TestData = true;
            AnJob.Active = TestData;
            Assert.AreEqual(AnJob.Active, TestData);
        }

        [TestMethod]
        public void JobIDOK()
        {
            clsJob AnJob = new clsJob();
            int TestData = 1;
            AnJob.jobID = TestData;
            Assert.AreEqual(AnJob.jobID, TestData);
        }


        [TestMethod]
        public void LastNameOK()
        {
            clsJob AnJob = new clsJob();
            string TestData = "White";
            AnJob.lastName = TestData;
            Assert.AreEqual(AnJob.lastName, TestData);
        }

        [TestMethod]
        public void HouseNameOK()
        {
            clsJob AnJob = new clsJob();
            string TestData = "April Cottage";
            AnJob.houseName = TestData;
            Assert.AreEqual(AnJob.houseName, TestData);
        }

        [TestMethod]
        public void commnetsOK()
        {
            clsJob AnJob = new clsJob();
            string TestData = "N/A";
            AnJob.comments = TestData;
            Assert.AreEqual(AnJob.comments, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            clsJob AnJob = new clsJob();
            DateTime TestData = DateTime.Now.Date;
            AnJob.date = TestData;
            Assert.AreEqual(AnJob.date, TestData);
        }

        [TestMethod]
        public void JobTakeOK()
        {
            clsJob AnJob = new clsJob();
            double TestData = 45.0;
            AnJob.jobTake = TestData;
            Assert.AreEqual(AnJob.jobTake, TestData);
        }

        [TestMethod]
        public void TotalVisitsOK()
        {
            clsCompletedJob AnJob = new clsJob();
            int TestData = 1;
            AnJob.totalVisits = TestData;
            Assert.AreEqual(AnJob.totalVisits, TestData);
        }

    }
}
