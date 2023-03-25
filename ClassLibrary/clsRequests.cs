using System;

namespace ClassLibrary
{
    public class clsRequests
    {
        private Int32 mRequestID;
        private string mPostCode;
        private Int32 mFlumeCount;


        public int requestID
        {
            get
            {
                return mRequestID;
            }
            set
            {
                mRequestID = value;
            }
        }
        public string postcode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public int flumeCount
        {
            get
            {
                return mFlumeCount;
            }
            set
            {
                mFlumeCount = value;
            }
        }

        public bool Find(int financeID)
        {
            mRequestID = 1;
            mPostCode = "YO62 6TJ";
            mFlumeCount = 1;
            return true;
        }

        public string Valid(string postcode, string flumeCount)
        {
            String Error = "";
            Int32 Chimneys;

            if (postcode.Length == 0)
            {
                Error = Error + "Postcode cannot be blank";
            }
            if (postcode.Length > 50)
            {
                Error = Error + "Postcode cannot be greater then 50 characters";
            }

            try
            {
                Chimneys = Convert.ToInt32(flumeCount);
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

            return Error;
        }
    }
}