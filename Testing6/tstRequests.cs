using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6Requests
{
    [TestClass]
    public class tstRequests
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRequests AnRequests = new clsRequests();
            Assert.IsNotNull(AnRequests);
        }

        

        [TestMethod]
        public void RequestIDOK()
        {
            clsRequests AnRequests = new clsRequests();
            int TestData = 1;
            AnRequests.requestID = TestData;
            Assert.AreEqual(AnRequests.requestID, TestData);
        }

        [TestMethod]
        public void PostcodeOK()
        {
            clsRequests AnRequests = new clsRequests();
            string TestData = "YO62 6TJ";
            AnRequests.postcode = TestData;
            Assert.AreEqual(AnRequests.postcode, TestData);
        }

        [TestMethod]
        public void FlumeCountOK()
        {
            clsRequests AnRequests = new clsRequests();
            int TestData = 1;
            AnRequests.flumeCount = TestData;
            Assert.AreEqual(AnRequests.flumeCount, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsRequests AnRequest = new clsRequests();
            Boolean Found = false;
            Int32 requestID = 1;
            Found = AnRequest.Find(requestID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRequestIDFound()
        {
            clsRequests AnRequest = new clsRequests();
            Boolean Found = false;
            Boolean OK = true;
            Int32 requestID = 1;
            Found = AnRequest.Find(requestID);

            if (AnRequest.requestID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            clsRequests AnRequest = new clsRequests();
            Boolean Found = false;
            Boolean OK = true;
            Int32 requestID = 1;
            Found = AnRequest.Find(requestID);

            if(AnRequest.postcode != "YO62 6TJ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFlumeCountFound()
        {
            clsRequests AnRequest = new clsRequests();
            Boolean Found = false;
            Boolean OK = true;
            Int32 requestID = 1;
            Found = AnRequest.Find(requestID);

            if (AnRequest.flumeCount != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
