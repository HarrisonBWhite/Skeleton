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
        public void ActivePropertyOK()
        {
            clsRequests AnRequests = new clsRequests();
            Boolean TestData = true;
            AnRequests.Active = TestData;
            Assert.AreEqual(AnRequests.Active, TestData);
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


    }
}
