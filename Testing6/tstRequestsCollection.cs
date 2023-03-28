using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstRequestsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            Assert.IsNotNull(AllRequests);
        }

        [TestMethod]
        public void RequestsListOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            List<clsRequests> TestList = new List<clsRequests>();
            clsRequests TestItem = new clsRequests();

            TestItem.requestID = 1;
            TestItem.postcode = "YO62 6TJ";
            TestItem.flumeCount = 1;

            TestList.Add(TestItem);
            AllRequests.RequestList = TestList;
            Assert.AreEqual(AllRequests.RequestList, TestList);

        }

        [TestMethod]
        public void ThisRequestPropertyOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            clsRequests TestRequest = new clsRequests();

            TestRequest.requestID = 1;
            TestRequest.postcode = "YO62 6TJ";
            TestRequest.flumeCount = 1;

            AllRequests.ThisRequest = TestRequest;
            Assert.AreEqual(AllRequests.ThisRequest, TestRequest);
        }

        

        [TestMethod]
        public void ListAndCountOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            List<clsRequests> TestList = new List<clsRequests>();
            clsRequests TestItem = new clsRequests();

            TestItem.requestID = 1;
            TestItem.postcode = "YO62 6TJ";
            TestItem.flumeCount = 1;

            TestList.Add(TestItem);

            AllRequests.RequestList = TestList;
            Assert.AreEqual(AllRequests.Count, TestList.Count);



        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            clsRequests TestItem = new clsRequests();

            Int32 PrimaryKey = 0;

            TestItem.requestID = 1;
            TestItem.postcode = "YO62 6TJ";
            TestItem.flumeCount = 1;

            AllRequests.ThisRequest = TestItem;
            PrimaryKey = AllRequests.Add();
            TestItem.requestID = PrimaryKey;
            AllRequests.ThisRequest.Find(PrimaryKey);
            Assert.AreEqual(AllRequests.ThisRequest, TestItem);


        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            clsRequests TestItem = new clsRequests();

            Int32 PrimaryKey = 0;

            TestItem.postcode = "YO62 6TJ";
            TestItem.flumeCount = 1;

            AllRequests.ThisRequest = TestItem;

            PrimaryKey = AllRequests.Add();

            TestItem.requestID = PrimaryKey;

            TestItem.postcode = "LE3 6BJ";
            TestItem.flumeCount = 2;

            AllRequests.ThisRequest = TestItem;
            AllRequests.Update();
            AllRequests.ThisRequest.Find(PrimaryKey);
            Assert.AreEqual(AllRequests.ThisRequest, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            clsRequests TestItem = new clsRequests();
            Int32 PrimaryKey = 0;

            TestItem.requestID = 1;
            TestItem.postcode = "YO62 6TJ";
            TestItem.flumeCount = 1;

            AllRequests.ThisRequest = TestItem;


            PrimaryKey = AllRequests.Add();
            TestItem.requestID = PrimaryKey;
            AllRequests.ThisRequest.Find(PrimaryKey);
            AllRequests.Delete();
            Boolean Found = AllRequests.ThisRequest.Find(PrimaryKey);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ReportByPostcodeMethodOK()
        {
            clsRequestsCollection AllRequests = new clsRequestsCollection();
            clsRequestsCollection FilteredRequests = new clsRequestsCollection();

            FilteredRequests.ReportByPostCode("");
            Assert.AreEqual(AllRequests.Count, FilteredRequests.Count);
        }

        [TestMethod]
        public void ReportByPostcodeNoneFound()
        {
            clsRequestsCollection FilteredRequests = new clsRequestsCollection();
            FilteredRequests.ReportByPostCode("xxx xxx");
            Assert.AreEqual(0, FilteredRequests.Count);
        }

        [TestMethod]
        public void ReportByPostcodeTestDataFound()
        {
            clsRequestsCollection FilteredRequests = new clsRequestsCollection();
            Boolean OK = true;
            FilteredRequests.ReportByPostCode("YO62 6TJ");

            if(FilteredRequests.Count == 2)
            {
                if(FilteredRequests.RequestList[0].requestID != 36)
                {
                    OK = false;
                }
                if (FilteredRequests.RequestList[1].requestID != 37)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

    }
}
