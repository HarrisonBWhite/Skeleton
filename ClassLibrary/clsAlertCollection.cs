using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsAlertCollection
    {

        List<clsAlert> mAlertList = new List<clsAlert>();
        clsAlert mThisAlert = new clsAlert();

        public clsAlertCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAlert_SelectAll");
            PopulateArray(DB);
            
        }

        //List<clsAlert> mAlertList = new List<clsAlert>();
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
        public clsAlert ThisAlert
        {
            get
            {
                return mThisAlert;
            }
            set
            {
                mThisAlert = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@customerID", mThisAlert.customerID);
            DB.AddParameter("@date", mThisAlert.date);
            DB.AddParameter("@reminderInterval", mThisAlert.reminderInterval);

            return DB.Execute("sproc_tblAlert_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@alertID", mThisAlert.alertID);
            DB.AddParameter("@customerID", mThisAlert.customerID);
            DB.AddParameter("@date", mThisAlert.date);
            DB.AddParameter("@reminderInterval", mThisAlert.reminderInterval);

            DB.Execute("sproc_tblAlert_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@alertID", mThisAlert.alertID);
            DB.Execute("sproc_tblAlert_Delete");
        }

        public void ReportByCustomerID(string customerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customerID", customerID);
            DB.Execute("sproc_tblAlert_FilterByCustomerID");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mAlertList = new List<clsAlert>();
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

    }
}
