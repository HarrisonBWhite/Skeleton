using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2Customer
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        string FirstName = "Sherlock";
        string LastName = "Holmes";
        string HouseName = "221B";
        string Street = "Baker Street";
        string Town = "London";
        string County = "Greater London";
        string Postcode = "NW1 6XE";
        string ContactNumber = "02072243688";
        string Email = "holmes.sherlock@gmail.com";
        string TotalChimneys = "1";
        string Comments = "N/A";
        string TotalVisits = "2";


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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 customerID = 1;
            Found = AnCustomer.Find(customerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);
            if (AnCustomer.customerID != 43)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.firstName != "TestFName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.lastName != "TestLName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestHouseNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.houseName != "TestHName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStreetFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.street != "TestStreet")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTownFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.town != "TestTown")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCountyFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.county != "TestCounty")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.postcode != "TestPostcode")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestContactNumberFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.contactNumber != "0000")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.email != "test@test.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalChimneysFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.totalChimneys != 22)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCommentsFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.comments != "Testing")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalVisitsFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int customerID = 43;
            Found = AnCustomer.Find(customerID);

            if (AnCustomer.totalVisits != 23)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        //firstName Validation

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");

        }

        //lastName Validation
        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNamePlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }


        //houseName Validation
        [TestMethod]
        public void HouseNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string HouseName = "";
            HouseName = HouseName.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        //street Validation
        [TestMethod]
        public void StreetMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }



        //Town Validation
        [TestMethod]
        public void TownMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "";
            Town = Town.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "";
            Town = Town.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "";
            Town = Town.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "";
            Town = Town.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Town = "";
            Town = Town.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }


        //County Validation
        [TestMethod]
        public void CountyMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "";
            County = County.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "";
            County = County.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "";
            County = County.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "";
            County = County.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string County = "";
            County = County.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }


        //Postcode Validation
        [TestMethod]
        public void PostcodeMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "";
            Postcode = Postcode.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "";
            Postcode = Postcode.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "";
            Postcode = Postcode.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "";
            Postcode = Postcode.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Postcode = "";
            Postcode = Postcode.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }


        //ContactNumber Validation
        [TestMethod]
        public void ContactNumberMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }


        //Email Validation
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(50, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(51, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(500, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        //Comments Validation
        [TestMethod]
        public void CommentsMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "a";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "aa";
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(1999, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(2000, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(2001, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(1000, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(5000, 'a');
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }



        //TotalChimneys Validation
        [TestMethod]
        public void TotalChimneysLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = -1;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = 0;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = 1;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = 499;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = 500;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = 501;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = 250;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalChimneysExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Chimneys = 5000;
            string TotalChimneys = Chimneys.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        //TotalVisits Validation
        [TestMethod]
        public void TotalVisitsLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = -1;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = 0;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = 1;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = 99;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = 100;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = 101;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = 50;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalVisitsExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Int32 Visits = 1000;
            string TotalVisits = Visits.ToString();
            Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);
            Assert.AreNotEqual(Error, "");
        }
    }
}
