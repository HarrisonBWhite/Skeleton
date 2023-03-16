using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3Job
{
    [TestClass]
    public class tstJob
    {

        string LastName = "Holmes";
        string HouseName = "221b";
        string Comments = "N/A";
        string Date = DateTime.Now.Date.ToString();
        string JobTake = "45";
        string TotalVisits = "1";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");        
        }

        //lastName Validation

        [TestMethod]
        public void lastNameMinLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMin()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "a";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMinPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "aa";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMid()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMaxLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMaxPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        

        [TestMethod]
        public void lastNameExtremeMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }


        //houseName Validation

        [TestMethod]
        public void HouseNameMinLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMin()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "a";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMinPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "aa";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMid()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(25, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMaxLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(49, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(50, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMaxPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(51, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void HouseNameExtremeMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(500, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }


        //comments validation

        [TestMethod]
        public void CommentsMinLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMin()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "a";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMinPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "aa";
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMid()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(25, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMaxLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(49, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(50, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMaxPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(51, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void CommentsExtremeMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(500, 'a');
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        //date validation

        [TestMethod]
        public void DateExtremeMin()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string Date = TestDate.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMinLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Date = TestDate.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMin()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Date = TestDate.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Date = TestDate.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreNotEqual(Error, "");

        }

        //job take validation

        [TestMethod]
        public void JobTakeNameMinLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = -1;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMin()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = 0;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMinPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = 1;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMid()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = 250;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMaxLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = 499;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = 500;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMaxPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = 501;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeExtremeMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Take = 501;
            string JobTake = Take.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        // total visits validation
        [TestMethod]
        public void TotalVisitsMinLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = -1;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMin()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = 0;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMinPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = 1;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMid()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = 250;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMaxLessOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = 499;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = 500;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMaxPlusOne()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = 501;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsExtremeMax()
        {
            clsJob AnJob = new clsJob();
            String Error = "";
            Int32 Visits = 1000;
            string TotalVisits = Visits.ToString();
            Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);
            Assert.AreEqual(Error, "");
        }

    }
}
