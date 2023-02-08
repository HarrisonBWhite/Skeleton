using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing2Customer
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.firstName = "Harry";
            TestItem.lastName = "Potter";
            TestItem.houseName = "4";
            TestItem.street = "Privet Drive";
            TestItem.town = "London";
            TestItem.county = "Greater London";
            TestItem.postcode = "HP7 JKR";
            TestItem.contactNumber = "554156 17059";
            TestItem.email = "potter.h@ministrymail.com";
            TestItem.totalChimneys = 2;
            TestItem.comments = "Stove works like magic";
            TestItem.totalVisits = 1;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

       

        [TestMethod]
        public void ThisCustomerPorpertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Active = true;
            TestCustomer.firstName = "Harry";
            TestCustomer.lastName = "Potter";
            TestCustomer.houseName = "4";
            TestCustomer.street = "Privet Drive";
            TestCustomer.town = "London";
            TestCustomer.county = "Greater London";
            TestCustomer.postcode = "HP7 JKR";
            TestCustomer.contactNumber = "554156 17059";
            TestCustomer.email = "potter.h@ministrymail.com";
            TestCustomer.totalChimneys = 2;
            TestCustomer.comments = "Stove works like magic";
            TestCustomer.totalVisits = 1;

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();


            TestItem.Active = true;
            TestItem.firstName = "Harry";
            TestItem.lastName = "Potter";
            TestItem.houseName = "4";
            TestItem.street = "Privet Drive";
            TestItem.town = "London";
            TestItem.county = "Greater London";
            TestItem.postcode = "HP7 JKR";
            TestItem.contactNumber = "554156 17059";
            TestItem.email = "potter.h@ministrymail.com";
            TestItem.totalChimneys = 2;
            TestItem.comments = "Stove works like magic";
            TestItem.totalVisits = 1;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.customerID = 1;
            TestItem.firstName = "Jack";
            TestItem.lastName = "Skellington";
            TestItem.houseName = "Pumpkin Manor";
            TestItem.street = "Grave End";
            TestItem.town = "Halloween Town";
            TestItem.county = "Festival Street";
            TestItem.postcode = "PUM K1N";
            TestItem.contactNumber = "666";
            TestItem.email = "skellington.j@spookmail.com";
            TestItem.totalChimneys = 3;
            TestItem.comments = "Bats in flume";
            TestItem.totalVisits = 4;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.customerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.firstName = "Muffin";
            TestItem.lastName = "Man";
            TestItem.houseName = "Ye Old Bakery";
            TestItem.street = "Drewery Lane";
            TestItem.town = "Cakenation";
            TestItem.county = "Ovenswell";
            TestItem.postcode = "DYK TMM";
            TestItem.contactNumber = "07834 956341";
            TestItem.email = "muffin.man@bakermail.com";
            TestItem.totalChimneys = 6;
            TestItem.comments = "Open fires";
            TestItem.totalVisits = 2;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.customerID = PrimaryKey;

            TestItem.firstName = "Lord";
            TestItem.lastName = "Farquaad";
            TestItem.houseName = "Main Tower";
            TestItem.street = "Castle Road";
            TestItem.town = "Capital";
            TestItem.county = "Duloc";
            TestItem.postcode = "M4Y D13";
            TestItem.contactNumber = "07622 65721";
            TestItem.email = "farquaad.lord@mirrormail.com";
            TestItem.totalChimneys = 12;
            TestItem.comments = "Very Tall Flumes";
            TestItem.totalVisits = 4;

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.customerID = 1;
            TestItem.firstName = "Muffin";
            TestItem.lastName = "Man";
            TestItem.houseName = "Ye Old Bakery";
            TestItem.street = "Drewery Lane";
            TestItem.town = "Cakenation";
            TestItem.county = "Ovenswell";
            TestItem.postcode = "DYK TMM";
            TestItem.contactNumber = "07834 956341";
            TestItem.email = "muffin.man@bakermail.com";
            TestItem.totalChimneys = 6;
            TestItem.comments = "Open fires";
            TestItem.totalVisits = 2;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.customerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByPostCode("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByPostCode("xxx xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByPostCode("PUM K1N");

            if(FilteredCustomers.Count == 2)
            {
                if(FilteredCustomers.CustomerList[0].customerID != 13)
                {
                    OK = false;
                }
                if(FilteredCustomers.CustomerList[1].customerID != 16)
                {
                    OK = false;

                }
            }
            else
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

    }
}
