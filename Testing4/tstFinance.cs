using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4Finance
{

   

    [TestClass]
    public class tstFinance
    {


        string date = DateTime.Now.Date.ToString();
        string jobTake = "45";

        [TestMethod]
        public void InstanceOK()
        {
            clsFinance AnFinance = new clsFinance();
            Assert.IsNotNull(AnFinance);
        }

        

        [TestMethod]
        public void FinanaceIDOK()
        {
            clsFinance AnFinance = new clsFinance();
            int TestData = 1;
            AnFinance.financeID = TestData;
            Assert.AreEqual(AnFinance.financeID, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            clsFinance AnFinance = new clsFinance();
            DateTime TestData = DateTime.Now.Date;
            AnFinance.date = TestData;
            Assert.AreEqual(AnFinance.date, TestData);
        }

        [TestMethod]
        public void JobTakeOK()
        {
            clsFinance AnFinance = new clsFinance();
            double TestData = 45.0;
            AnFinance.jobTake= TestData;
            Assert.AreEqual(AnFinance.jobTake, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsFinance AnFinance = new clsFinance();
            Boolean Found = false;
            Int32 financeID = 1;
            Found = AnFinance.Find(financeID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestFinanceIDFOund()
        {
            clsFinance AnFinance = new clsFinance();
            Boolean Found = false;
            Boolean OK = true;
            Int32 financeID = 1;
            Found = AnFinance.Find(financeID);

            if (AnFinance.financeID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateFound()
        {
            clsFinance AnFinance = new clsFinance();
            Boolean Found = false;
            Boolean OK = true;
            Int32 financeID = 1;
            Found = AnFinance.Find(financeID);

            if (AnFinance.date != Convert.ToDateTime("11/06/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestJobTakeFound()
        {
            clsFinance AnFinance = new clsFinance();
            Boolean Found = false;
            Boolean OK = true;
            Int32 financeID = 1;
            Found = AnFinance.Find(financeID);

            if (AnFinance.jobTake != 45)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreEqual(Error, "");
        }

        //date validation

        [TestMethod]
        public void DateMinLessOne()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string date = TestDate.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMin()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string date = TestDate.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string date = TestDate.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreNotEqual(Error, "");

        }

        // job take validation
        [TestMethod]
        public void JobTakeNameMinLessOne()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = -1;
            string jobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMin()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = 0;
            string jobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMinPlusOne()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = 1;
            string jobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMid()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = 250;
            string JobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMaxLessOne()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = 499;
            string jobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMax()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = 500;
            string jobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeNameMaxPlusOne()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = 501;
            string jobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobTakeExtremeMax()
        {
            clsFinance AnFinance = new clsFinance();
            String Error = "";
            Int32 Take = 501;
            string jobTake = Take.ToString();
            Error = AnFinance.Valid(date, jobTake);
            Assert.AreNotEqual(Error, "");
        }


    }
}
