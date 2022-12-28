

using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mCustomerID;
        private string mFirstName;
        private string mLastName;
        private string mHouseName;
        private string mStreet;
        private string mTown;
        private string mCounty;
        private string mPostcode;
        private string mContactNumber;
        private string mEmail;
        private int mTotalChimneys;
        private string mComments;
        private int mTotalVisits;

        public clsCustomer()
        {
        }

        public int customerID 
        { 
            get
            {

                return mCustomerID;
            }
            set 
            {
                mCustomerID = value;
            
            } 
        }

        public bool Active { get; set; }

        public string firstName 
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string lastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string houseName
        {
            get
            {
                return mHouseName;
            }
            set
            {
                mHouseName = value;
            }
        }
        public string street
        {
            get
            {
                return mStreet;
            }
            set
            {
                mStreet = value;
            }
        }
        public string town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }
        public string county
        {
            get
            {
                return mCounty;
            }
            set
            {
                mCounty = value;
            }
        }
        public string postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }
        public string contactNumber
        {
            get
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
            }
        }
        public string email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public int totalChimneys
        {
            get
            {
                return mTotalChimneys;
            }
            set
            {
                mTotalChimneys= value;
            }
        }
        public string comments
        {
            get
            {
                return mComments;
            }
            set
            {
                mComments = value;
            }
        }
        public int totalVisits
        {
            get
            {
                return mTotalVisits;
            }
            set
            {
                mTotalVisits = value;
            }
        }

        public bool Find(int customerID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@customerID", customerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");

            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["firstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["lastName"]);
                mHouseName = Convert.ToString(DB.DataTable.Rows[0]["houseName"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["town"]);
                mCounty = Convert.ToString(DB.DataTable.Rows[0]["county"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["postcode"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["contactNumber"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                mTotalChimneys = Convert.ToInt32(DB.DataTable.Rows[0]["totalChimneys"]);
                mComments = Convert.ToString(DB.DataTable.Rows[0]["comments"]);
                mTotalVisits = Convert.ToInt32(DB.DataTable.Rows[0]["totalVisits"]);
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }


}