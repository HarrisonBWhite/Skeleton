using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2Customer
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData = 1;
            AnCustomer.customerID = TestData;
            Assert.AreEqual(AnCustomer.customerID, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Toby";
            AnCustomer.firstName = TestData;
            Assert.AreEqual(AnCustomer.firstName, TestData);
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "White";
            AnCustomer.lastName = TestData;
            Assert.AreEqual(AnCustomer.lastName, TestData);
        }

        [TestMethod]
        public void HouseNameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "April Cottage";
            AnCustomer.houseName = TestData;
            Assert.AreEqual(AnCustomer.houseName, TestData);
        }

        [TestMethod]
        public void StreetOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Low St";
            AnCustomer.street = TestData;
            Assert.AreEqual(AnCustomer.street, TestData);
        }

        [TestMethod]
        public void TownOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Lastingham";
            AnCustomer.town = TestData;
            Assert.AreEqual(AnCustomer.town, TestData);
        }

        [TestMethod]
        public void CountyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "N-Yorks";
            AnCustomer.county = TestData;
            Assert.AreEqual(AnCustomer.county, TestData);
        }

        [TestMethod]
        public void PostcodeOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "YO62 6TJ";
            AnCustomer.postcode = TestData;
            Assert.AreEqual(AnCustomer.postcode, TestData);
        }

        [TestMethod]
        public void ContactNumberOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "07388138013";
            AnCustomer.contactNumber = TestData;
            Assert.AreEqual(AnCustomer.contactNumber, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "tobywhite2309@gmail.com";
            AnCustomer.email = TestData;
            Assert.AreEqual(AnCustomer.email, TestData);
        }

        [TestMethod]
        public void TotalChimneysOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData = 1;
            AnCustomer.totalChimneys = TestData;
            Assert.AreEqual(AnCustomer.totalChimneys, TestData);
        }

        [TestMethod]
        public void commentsOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "N/A";
            AnCustomer.comments = TestData;
            Assert.AreEqual(AnCustomer.comments, TestData);
        }

        [TestMethod]
        public void TotalVisitsOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData = 1;
            AnCustomer.totalVisits = TestData;
            Assert.AreEqual(AnCustomer.totalVisits, TestData);
        }


    }
}
