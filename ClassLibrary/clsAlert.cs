using System;

namespace ClassLibrary
{
    public class clsAlert
    {
        private Int32 mAlertID;
        private Int32 mCustomerID;
        private DateTime mDate;
        private DateTime mReminderInterval;
        
        public int alertID
        {
            get
            {
                return mAlertID;
            }
            set
            {
                mAlertID = value;
            }
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

        public DateTime reminderInterval
        {
            get
            {
                return mReminderInterval;
            }
            set
            {
                mReminderInterval = value;
            }
        }

        public bool Find(int alertID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@alertID", alertID);
            DB.Execute("sproc_tblAlert_FilterByAlertID");

            if(DB.Count == 1)
            {
                mAlertID = Convert.ToInt32(DB.DataTable.Rows[0]["alertID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["date"]);
                mReminderInterval = Convert.ToDateTime(DB.DataTable.Rows[0]["reminderInterval"]);
                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string customerID, string date, string reminderInterval)
        {
            String Error = "";
            DateTime DateTemp;
            DateTime DateTemp2;

            if (customerID.Length == 0)
            {
                Error = Error + "Customer ID cannot be blank";
            }

            if (customerID.Length > 50)
            {
                Error = Error + "Customer ID cannot exceed 50 characters";
            }

            DateTemp = Convert.ToDateTime(date);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "Date cannot be in the past";
            }

            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "Date cannot be in the future";
            }

            DateTemp2 = Convert.ToDateTime(reminderInterval);

            if (DateTemp2 < DateTime.Now.Date)
            {
                Error = Error + "Interval cannot be in the past";
            }

           

            return Error;
        }
    }
}