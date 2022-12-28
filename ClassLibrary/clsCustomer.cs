

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
            mCustomerID = 21;
            mFirstName = "TestFName";
            mLastName = "TestLName";
            mHouseName = "TestHName";
            mStreet = "TestStreet";
            mTown = "TestTown";
            mCounty = "TestCounty";
            mPostcode = "TestPostcode";
            mContactNumber = "0000";
            mEmail = "test@test.com";
            mTotalChimneys = 22;
            mComments = "Testing";
            mTotalVisits = 23;
            return true;
        }
    }
}