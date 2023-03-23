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
        public void AddMethodOK()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();
            clsFinance TestItem = new clsFinance();

            Int32 PrimaryKey = 0;

            TestItem.financeID = 2;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 50;

            AllFinances.ThisFinance = TestItem;

            PrimaryKey = AllFinances.Add();
            TestItem.financeID = PrimaryKey;
            AllFinances.ThisFinance.Find(PrimaryKey);
            Assert.AreEqual(AllFinances.ThisFinance, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();
            clsFinance TestItem = new clsFinance();
            Int32 PrimaryKey = 0;

            TestItem.financeID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;

            AllFinances.ThisFinance = TestItem;
            PrimaryKey = AllFinances.Add();
            TestItem.financeID = PrimaryKey;

            TestItem.financeID = 2;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 50;

            AllFinances.ThisFinance = TestItem;
            AllFinances.Update();
            AllFinances.ThisFinance.Find(PrimaryKey);
            Assert.AreEqual(AllFinances.ThisFinance, TestItem);




        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsFinanceCollection AllFinances = new clsFinanceCollection();
            clsFinance TestItem = new clsFinance();
            Int32 PrimaryKey = 0;

            TestItem.financeID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;

            AllFinances.ThisFinance = TestItem;
            PrimaryKey = AllFinances.Add();
            TestItem.financeID = PrimaryKey;
            
            AllFinances.ThisFinance.Find(PrimaryKey);
            AllFinances.Delete();
            Boolean Found = AllFinances.ThisFinance.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

    }
}
