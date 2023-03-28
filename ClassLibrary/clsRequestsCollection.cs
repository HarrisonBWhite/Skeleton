using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsRequestsCollection
    {
        List<clsRequests> mRequestList = new List<clsRequests>();
        clsRequests mThisRequest = new clsRequests();

        public clsRequestsCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRequests_SelectAll");
            PopulateArray(DB);


        }


        public List<clsRequests> RequestList
        {
            get
            {
                return mRequestList;

            }
            set
            {
                mRequestList = value;
            }
        }

        public clsRequests ThisRequest
        {
            get
            {
                return mThisRequest;

            }
            set
            {
                mThisRequest = value;
            }
        }
        public int Count
        {
            get
            {
                return mRequestList.Count;
            }
            set
            {
                //worry ab this later
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            
            DB.AddParameter("@postcode", mThisRequest.postcode);
            DB.AddParameter("@flumeCount", mThisRequest.flumeCount);

            return DB.Execute("sproc_tblRequests_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@requestID", mThisRequest.requestID);
            DB.AddParameter("@postcode", mThisRequest.postcode);
            DB.AddParameter("@flumeCount", mThisRequest.flumeCount);

            DB.Execute("sproc_tblRequests_Update");


        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@requestID", mThisRequest.requestID);
            DB.Execute("sproc_tblRequests_Delete");
        }

        public void ReportByPostCode(string postcode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@postcode", postcode);
            DB.Execute("sproc_tblRequests_FilterByPostCode");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mRequestList = new List<clsRequests>();

            while(Index < RecordCount)
            {
                clsRequests AnRequest = new clsRequests();
                AnRequest.requestID = Convert.ToInt32(DB.DataTable.Rows[Index]["requestID"]);
                AnRequest.postcode = Convert.ToString(DB.DataTable.Rows[Index]["postcode"]);
                AnRequest.flumeCount = Convert.ToInt32(DB.DataTable.Rows[Index]["flumeCount"]);

                mRequestList.Add(AnRequest);
                Index++;

            }

        }
    }
}
