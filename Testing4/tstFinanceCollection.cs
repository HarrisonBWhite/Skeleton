using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstFinanceCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsFinanceCollection AllFinance = new clsFinanceCollection();
            Assert.IsNotNull(AllFinance);
        }

        [TestMethod]
        public void FinanceListOK()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();
            List<clsFinance> TestList = new List<clsFinance>();
            clsFinance TestItem = new clsFinance();

            TestItem.financeID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;

            TestList.Add(TestItem);

            AllFinances.FinanceList = TestList;
            Assert.AreEqual(AllFinances.FinanceList, TestList);
            

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();

            Int32 SomeCount = 0;
            AllFinances.Count = SomeCount;
            Assert.AreEqual(AllFinances.Count, SomeCount);

        }

        [TestMethod]
        public void ThisFinancePopertyOK()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();
            clsFinance TestFinance = new clsFinance();

            TestFinance.financeID = 1;
            TestFinance.date = DateTime.Now.Date;
            TestFinance.jobTake = 45;

            AllFinances.ThisFinance = TestFinance;
            Assert.AreEqual(AllFinances.ThisFinance, TestFinance);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();
            List<clsFinance> TestList = new List<clsFinance>();
            clsFinance TestItem = new clsFinance();

            TestItem.financeID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;

            TestList.Add(TestItem);
            AllFinances.FinanceList = TestList;
            Assert.AreEqual(AllFinances.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPreset()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();
            Assert.AreEqual(AllFinances.Count, 2);
        }

    }
}
