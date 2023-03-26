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

        public clsRequestsCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblRequests_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsRequests AnRequest = new clsRequests();

                AnRequest.requestID = Convert.ToInt32(DB.DataTable.Rows[Index]["requestID"]);
                AnRequest.postcode = Convert.ToString(DB.DataTable.Rows[Index]["postcode"]);
                AnRequest.flumeCount = Convert.ToInt32(DB.DataTable.Rows[Index]["flumeCount"]);

                mRequestList.Add(AnRequest);

                Index++;
            }


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

        public clsRequests ThisRequest { get; set; }
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
    }
}
