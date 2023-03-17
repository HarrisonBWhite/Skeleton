
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstJobCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            Assert.IsNotNull(AllJobs);
        }

        [TestMethod]
        public void JobListOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            List<clsJob> TestList = new List<clsJob>();
            clsJob TestItem = new clsJob();

            TestItem.jobID = 1;
            TestItem.lastName = "White";
            TestItem.houseName = "April Cottage";
            TestItem.comments = "N/A";
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;
            TestItem.totalVisits = 1;

            TestList.Add(TestItem);
            AllJobs.JobList = TestList;
            Assert.AreEqual(AllJobs.JobList, TestList);
        }



        [TestMethod]
        public void ThisJobPropertyOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            clsJob TestJob = new clsJob();
            TestJob.jobID = 1;
            TestJob.lastName = "White";
            TestJob.houseName = "April Cottage";
            TestJob.comments = "N/A";
            TestJob.date = DateTime.Now.Date;
            TestJob.jobTake = 45;
            TestJob.totalVisits = 1;

            AllJobs.ThisJob = TestJob;
            Assert.AreEqual(AllJobs.ThisJob, TestJob);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            List<clsJob> TestList = new List<clsJob>();
            clsJob TestItem = new clsJob();

            TestItem.jobID = 1;
            TestItem.lastName = "White";
            TestItem.houseName = "April Cottage";
            TestItem.comments = "N/A";
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;
            TestItem.totalVisits = 1;

            TestList.Add(TestItem);
            AllJobs.JobList = TestList;
            Assert.AreEqual(AllJobs.Count, TestList.Count);

        }

       

    }
}
