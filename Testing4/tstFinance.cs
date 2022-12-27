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
        public void ActivePropertyOK()
        {
            clsFinance AnFinance = new clsFinance();
            Boolean TestData = true;
            AnFinance.Active = TestData;
            Assert.AreEqual(AnFinance.Active, TestData);
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



    }
}
