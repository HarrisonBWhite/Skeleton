using System;

namespace ClassLibrary
{
    public class clsJob
    {
        private Int32 mJobID;
        private String mLastName;
        private String mHouseName;
        private String mComments;
        private DateTime mDate;
        private Double mJobTake;
        private Int32 mTotalVisits;
        
       
        public int jobID
        {
            get
            {
                return mJobID;
            }
            set
            {
                mJobID = value;
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

        public DateTime date
        {
            get
            {
                return mDate;

            }
            set
            {
                mDate = value;
            }
        }
        public double jobTake
        {
            get
            {
                return mJobTake;
            }
            set
            {
                mJobTake = value;
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

        public bool Find(int jobID)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@jobID", jobID);
            db.Execute("sproc_tblJob_FilterByJobID");
            if(db.Count == 1)
            {
                mJobID = Convert.ToInt32(db.DataTable.Rows[0]["jobID"]);
                mLastName = Convert.ToString(db.DataTable.Rows[0]["lastName"]);
                mHouseName = Convert.ToString(db.DataTable.Rows[0]["houseName"]);
                mComments = Convert.ToString(db.DataTable.Rows[0]["comments"]);
                mDate = Convert.ToDateTime(db.DataTable.Rows[0]["date"]);
                mJobTake = Convert.ToDouble(db.DataTable.Rows[0]["jobTake"]);
                mTotalVisits = Convert.ToInt32(db.DataTable.Rows[0]["totalVisits"]);

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}