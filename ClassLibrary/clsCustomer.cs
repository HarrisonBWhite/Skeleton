

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

        public string Valid(string firstName, string lastName, string houseName, string street, string town, string county, string postcode, string contactNumber, string email, string totalChimneys, string comments, string totalVisits)
        {
            String Error = "";
            Int32 Chimneys;
            Int32 Visits;
            //firstName
            if(firstName.Length == 0)
            {
                Error = Error + "First name cannot be blank";
            }
            if(firstName.Length > 50)
            {
                Error = Error + "First name must be less then 50 characters";
            }

            //lastName
            if (lastName.Length == 0)
            {
                Error = Error + "Last name cannot be blank";
            }
            if(lastName.Length > 50)
            {
                Error = Error + "Last name cannot be greater then 50 characters";
            }

            //houseName
            if (houseName.Length == 0)
            {
                Error = Error + "House name cannot be blank";
            }
            if (houseName.Length > 50)
            {
                Error = Error + "House name cannot be greater then 50 characters";
            }

            //street
            if (street.Length == 0)
            {
                Error = Error + "Street cannot be blank";
            }
            if (street.Length > 50)
            {
                Error = Error + "Street cannot be greater then 50 characters";
            }

            //town
            if (town.Length == 0)
            {
                Error = Error + "Town cannot be blank";
            }
            if (town.Length > 50)
            {
                Error = Error + "Town cannot be greater then 50 characters";
            }

            //county
            if (county.Length == 0)
            {
                Error = Error + "County cannot be blank";
            }
            if (county.Length > 50)
            {
                Error = Error + "County cannot be greater then 50 characters";
            }

            //postcode
            if (postcode.Length == 0)
            {
                Error = Error + "Postcode cannot be blank";
            }
            if (postcode.Length > 50)
            {
                Error = Error + "Postcode cannot be greater then 50 characters";
            }

            //contactNumber
            if (contactNumber.Length == 0)
            {
                Error = Error + "Contact number cannot be blank";
            }
            if (contactNumber.Length > 50)
            {
                Error = Error + "Contact number cannot be greater then 50 characters";
            }

            //email
            if (email.Length == 0)
            {
                Error = Error + "Email cannot be blank";
            }
            if (email.Length > 50)
            {
                Error = Error + "Email cannot be greater then 50 characters";
            }

            //comments
            if (comments.Length == 0)
            {
                Error = Error + "Comments cannot be blank";
            }
            if (comments.Length > 2000)
            {
                Error = Error + "Comments cannot be greater then 2000 characters";
            }


            //totalChimneys
            try
            {
                Chimneys = Convert.ToInt32(totalChimneys);
                if (Chimneys < 0)
                {
                    Error = Error + "Total chimneys cannot be lower than 0";
                }

                if (Chimneys > 500)
                {
                    Error = Error + "Total chimneys cannot exceed 500";
                }
            }
            catch
            {
                Error = Error + "The chimney total is not valid";
            }

            //totalVisits
            try
            {
                Visits = Convert.ToInt32(totalVisits);
                if (Visits < 0)
                {
                    Error = Error + "Total visits cannot be lower than 0";
                }

                if (Visits > 100)
                {
                    Error = Error + "Total visits cannot exceed 100";
                }
            }
            catch
            {
                Error = Error + "The visit total is not valid";
            }

            return Error;
        }
    }


}