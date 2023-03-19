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
    }
}