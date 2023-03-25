using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6Requests
{
    [TestClass]
    public class tstRequests
    {
        string postcode = "YO62 6TJ";
        string flumeCount = "1";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Error = AnRequest.Valid(postcode, flumeCount);
        }
        //postcode validation

        [TestMethod]
        public void PostcodeMinLessOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "";
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMin()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "a";
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "aa";
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "";
            postcode = postcode.PadRight(49, 'a');
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMax()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "";
            postcode = postcode.PadRight(50, 'a');
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "";
            postcode = postcode.PadRight(51, 'a');
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMid()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "";
            postcode = postcode.PadRight(25, 'a');
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            string postcode = "";
            postcode = postcode.PadRight(500, 'a');
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreNotEqual(Error, "");
        }

        //flume count validation
        [TestMethod]
        public void TotalChimneysLessOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = -1;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMin()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = 0;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMinPlusOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = 1;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMaxLessOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = 499;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMax()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = 500;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMaxPlusOne()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = 501;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMid()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = 250;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysExtremeMax()
        {
            clsRequests AnRequest = new clsRequests();
            String Error = "";
            Int32 Chimneys = 5000;
            string flumeCount = Chimneys.ToString();
            Error = AnRequest.Valid(postcode, flumeCount);
            Assert.AreNotEqual(Error, "");
        }

       

    }
}
