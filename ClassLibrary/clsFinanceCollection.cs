using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsFinanceCollection
    {
        public clsFinanceCollection()
        {
            clsFinance TestItem = new clsFinance();
            TestItem.financeID = 1;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 45;

            mFinanceList.Add(TestItem);

            TestItem = new clsFinance();

            
            TestItem.financeID = 2;
            TestItem.date = DateTime.Now.Date;
            TestItem.jobTake = 90;

            mFinanceList.Add(TestItem);
        }
        List<clsFinance> mFinanceList = new List<clsFinance>();

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

        public clsFinance ThisFinance { get; set; }
    }
}
