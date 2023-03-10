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
            clsJob AnJob = new clsJob();
            int TestData = 1;
            AnJob.totalVisits = TestData;
            Assert.AreEqual(AnJob.totalVisits, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestJobIDFound()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Boolean OK = true;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            if (AnJob.jobID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Boolean OK = true;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            if (AnJob.lastName != "Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestHouseNameFound()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Boolean OK = true;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            if (AnJob.houseName != "1a")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCommentsFound()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Boolean OK = true;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            if (AnJob.comments != "N/A")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateFound()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Boolean OK = true;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            if (AnJob.date != Convert.ToDateTime("09/03/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestJobTakeFound()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Boolean OK = true;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            if (AnJob.jobTake != Convert.ToDouble(45.00))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalVisitsFound()
        {
            clsJob AnJob = new clsJob();
            Boolean Found = false;
            Boolean OK = true;
            Int32 jobID = 1;
            Found = AnJob.Find(jobID);
            if (AnJob.totalVisits != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


    }
}
