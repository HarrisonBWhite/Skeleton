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


    }
}
