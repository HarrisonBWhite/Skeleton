using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();

                AnCustomer.firstName = Convert.ToString(DB.DataTable.Rows[Index]["firstName"]);
                AnCustomer.lastName = Convert.ToString(DB.DataTable.Rows[Index]["lastName"]);
                AnCustomer.houseName = Convert.ToString(DB.DataTable.Rows[Index]["houseName"]);
                AnCustomer.street = Convert.ToString(DB.DataTable.Rows[Index]["street"]);
                AnCustomer.town = Convert.ToString(DB.DataTable.Rows[Index]["town"]);
                AnCustomer.county = Convert.ToString(DB.DataTable.Rows[Index]["county"]);
                AnCustomer.postcode = Convert.ToString(DB.DataTable.Rows[Index]["postcode"]);
                AnCustomer.contactNumber = Convert.ToString(DB.DataTable.Rows[Index]["contactNumber"]);
                AnCustomer.email = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                AnCustomer.totalChimneys = Convert.ToInt32(DB.DataTable.Rows[Index]["totalChimneys"]);
                AnCustomer.comments = Convert.ToString(DB.DataTable.Rows[Index]["comments"]);
                AnCustomer.totalVisits = Convert.ToInt32(DB.DataTable.Rows[Index]["totalVisits"]);

                mCustomerList.Add(AnCustomer);

                Index++;

            }
        }

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //finish later
            }
        }
        public clsCustomer ThisCustomer { get; set; }
    }
}
