
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

        [TestMethod]
        public void AddMethodOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            clsJob TestItem = new clsJob();
            Int32 PrimaryKey = 0;

            TestItem.jobID = 1;
            TestItem.lastName = "White";
            TestItem.houseName = "April Cottage";
            TestItem.comments = "N/A";
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;
            TestItem.totalVisits = 1;

            AllJobs.ThisJob = TestItem;

            PrimaryKey = AllJobs.Add();
            TestItem.jobID = PrimaryKey;
            Assert.AreEqual(AllJobs.ThisJob, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            clsJob TestItem = new clsJob();

            Int32 PrimaryKey = 0;

            TestItem.jobID = 1;
            TestItem.lastName = "White";
            TestItem.houseName = "April Cottage";
            TestItem.comments = "N/A";
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;
            TestItem.totalVisits = 1;

            AllJobs.ThisJob = TestItem;
            PrimaryKey = AllJobs.Add();
            TestItem.jobID = PrimaryKey;

            TestItem.jobID = 2;
            TestItem.lastName = "Black";
            TestItem.houseName = "June House";
            TestItem.comments = "N/A";
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 90;
            TestItem.totalVisits = 2;

            AllJobs.ThisJob = TestItem;
            AllJobs.Update();
            AllJobs.ThisJob.Find(PrimaryKey);
            Assert.AreEqual(AllJobs.ThisJob, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            clsJob TestItem = new clsJob();
            Int32 PrimaryKey = 0;

            TestItem.jobID = 1;
            TestItem.lastName = "White";
            TestItem.houseName = "April Cottage";
            TestItem.comments = "N/A";
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;
            TestItem.totalVisits = 1;

            AllJobs.ThisJob = TestItem;
            PrimaryKey = AllJobs.Add();
            TestItem.jobID = PrimaryKey;
            AllJobs.ThisJob.Find(PrimaryKey);
            AllJobs.Delete();
            Boolean Found = AllJobs.ThisJob.Find(PrimaryKey);
            Assert.IsFalse(Found);



        }

        /*[TestMethod]
        public void ReportByLastNameMethodOK()
        {
            clsJobCollection AllJobs = new clsJobCollection();
            clsJobCollection FilteredJobs = new clsJobCollection();
            FilteredJobs.ReportByLastName("");
            Assert.AreEqual(AllJobs.Count, FilteredJobs.Count);
        }*/

       [TestMethod]
       public void ReportByLastNameNoneFound()
        {
            clsJobCollection FilteredJobs = new clsJobCollection();
            FilteredJobs.ReportByLastName("XXX");
            Assert.AreEqual(0, FilteredJobs.Count);
        }


        

    }
}
