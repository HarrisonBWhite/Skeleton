using System;

namespace ClassLibrary
{
    public class clsFinance
    {
        private Int32 mFinanceID;
        private DateTime mDate;
        private double mJobTake;
        public clsFinance()
        {
        }

        public Int32 financeID
        {
            get
            {
                return mFinanceID;

            }
            set
            {
                mFinanceID = value;
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

        public bool Find(int financeID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@financeID", financeID);
            DB.Execute("sproc_tblFinance_FilterByFinanceID");
            if(DB.Count == 1)
            {
                mFinanceID = Convert.ToInt32(DB.DataTable.Rows[0]["FinanceID"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["date"]);
                mJobTake= Convert.ToDouble(DB.DataTable.Rows[0]["jobTake"]);

                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string date, string jobTake)
        {
            string Error = "";
            DateTime DateTemp;
            Int32 Take;
            


            DateTemp = Convert.ToDateTime(date);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past";
            }

            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error = "The date cannot be in the future";
            }

            try
            {
                Take = Convert.ToInt32(jobTake);
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

            return Error;
        }
    }
}