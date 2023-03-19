using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4Finance
{
    [TestClass]
    public class tstFinance
    {
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


    }
}
