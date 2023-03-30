using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsAlertCollection
    {

        public clsAlertCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAlert_SelectAll");
            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsAlert AnAlert = new clsAlert();
                AnAlert.alertID = Convert.ToInt32(DB.DataTable.Rows[Index]["alertID"]);
                AnAlert.customerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                AnAlert.date = Convert.ToDateTime(DB.DataTable.Rows[Index]["date"]);
                AnAlert.reminderInterval = Convert.ToDateTime(DB.DataTable.Rows[Index]["reminderInterval"]);

                mAlertList.Add(AnAlert);
                Index++;
            }
        }

        List<clsAlert> mAlertList = new List<clsAlert>();
        public List<clsAlert> AlertList
        {
            get
            {
                return mAlertList;
            }
            set
            {
                mAlertList = value;
            }
        }

        public int Count
        {
            get
            {
                return mAlertList.Count;
            }
            set
            {
                //worry ab later
            }
        }
        public clsAlert ThisAlert { get; set; }
    }
}
