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
    }
}