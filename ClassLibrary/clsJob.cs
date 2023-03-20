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


        public string Valid(string LastName, string HouseName, string Comments, string Date, string JobTake, string TotalVisits)
        {
            String Error =  "";
            DateTime DateTemp;
            Int32 Take;
            Int32 Visits;
            

            if (LastName.Length == 0)
            {
                Error = Error + "Last Name may not be blank";
            }

            if (LastName.Length > 50)
            {
                Error = Error + "Last name cannot exceed 50 characters";
            }

            if (HouseName.Length == 0)
            {
                Error = Error + "House Name may not be blank";
            }

            if (HouseName.Length > 50)
            {
                Error = Error + "House name cannot exceed 50 characters";
            }

            if (Comments.Length == 0)
            {
                Error = Error + "Comments may not be blank";
            }

            if (Comments.Length > 50)
            {
                Error = Error + "Comments cannot exceed 50 characters";
            }

            try
            {
                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }

                return Error;

            }
            catch
            {
                Error = Error + "The date was invalid";
            }

            try
            {
                Take = Convert.ToInt32(JobTake);
                if (Take < 0)
                {
                    Error = Error + "Total take cannot be lower than 0";
                }

                if (Take > 500)
                {
                    Error = Error + "Total take cannot exceed 500";
                }
            }
            catch
            {
                Error = Error + "The take value is not valid";
            }

            try
            {
                Visits = Convert.ToInt32(TotalVisits);
                if (Visits < 0)
                {
                    Error = Error + "Total chimneys cannot be lower than 0";
                }

                if (Visits > 500)
                {
                    Error = Error + "Total chimneys cannot exceed 500";
                }
            }
            catch
            {
                Error = Error + "The take value is not valid";
            }

            return Error;
        }

    }
}