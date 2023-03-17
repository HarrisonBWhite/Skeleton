using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsJobCollection
    {
        public clsJobCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblJob_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsJob AnJob = new clsJob();
                AnJob.jobID = Convert.ToInt32(DB.DataTable.Rows[Index]["jobID"]);
                AnJob.lastName = Convert.ToString(DB.DataTable.Rows[Index]["lastName"]);
                AnJob.houseName = Convert.ToString(DB.DataTable.Rows[Index]["houseName"]);
                AnJob.comments = Convert.ToString(DB.DataTable.Rows[Index]["comments"]);
                AnJob.date = Convert.ToDateTime(DB.DataTable.Rows[Index]["date"]);
                AnJob.jobTake = Convert.ToInt32(DB.DataTable.Rows[Index]["jobTake"]);
                AnJob.totalVisits = Convert.ToInt32(DB.DataTable.Rows[Index]["totalVisits"]);
                mJobList.Add(AnJob);
                Index++;

            }
        }

        List<clsJob> mJobList = new List<clsJob>();


        public List<clsJob> JobList
        {
            get
            {
                return mJobList;
            }
            set
            {
                mJobList = value;
            }
        }
        public int Count
        {
            get
            {
                return mJobList.Count;
            }
            set
            {
                //sort later
            }
        }


        public clsJob ThisJob { get; set; }
    }
}
