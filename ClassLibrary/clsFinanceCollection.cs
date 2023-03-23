using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsFinanceCollection
    {
        List<clsFinance> mFinanceList = new List<clsFinance>();
        clsFinance mThisFinance = new clsFinance();

        public clsFinanceCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblFinance_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsFinance AnFinance = new clsFinance();

                AnFinance.financeID = Convert.ToInt32(DB.DataTable.Rows[Index]["FinanceID"]);
                AnFinance.date = Convert.ToDateTime(DB.DataTable.Rows[Index]["date"]);
                AnFinance.jobTake = Convert.ToDouble(DB.DataTable.Rows[Index]["jobTake"]);

                mFinanceList.Add(AnFinance);
                Index++;
            }
        }
        

        public List<clsFinance> FinanceList
        {
            get
            {
                return mFinanceList;
            }
            set
            {
                mFinanceList = value;
            }
        }

        public int Count
        {
            get
            {
                return mFinanceList.Count;

            }
            set
            {
                //worry about this later
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FinanceID", mThisFinance.financeID);
            DB.AddParameter("@date", mThisFinance.date);
            DB.AddParameter("@jobTake", mThisFinance.jobTake);

            return DB.Execute("sproc_tblFinance_Insert");

        }

        public clsFinance ThisFinance
        {
            get
            {
                return mThisFinance;
            }
            set
            {
                mThisFinance = value;
            }
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FinanceID", mThisFinance.financeID);
            DB.AddParameter("@date", mThisFinance.date);
            DB.AddParameter("@jobTake", mThisFinance.jobTake);

            DB.Execute("sproc_tblFinance_Update");


        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FinanceID", mThisFinance.financeID);
            DB.Execute("sproc_tblFinance_Delete");
        }
    }
}
