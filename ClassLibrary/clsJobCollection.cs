using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsJobCollection
    {
        clsJob mThisJob = new clsJob();
        public clsJobCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblJob_SelectAll");
            PopulateArray(DB);

            
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


        public clsJob ThisJob
        {
            get
            {
                return mThisJob;
            }
            set
            {
                mThisJob = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@lastName", mThisJob.lastName);
            DB.AddParameter("@houseName", mThisJob.houseName);
            DB.AddParameter("@comments", mThisJob.comments);
            DB.AddParameter("@date", mThisJob.date);
            DB.AddParameter("@jobTake", mThisJob.jobTake);
            DB.AddParameter("@totalVisits", mThisJob.totalVisits);

            return DB.Execute("sproc_tblJob_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@jobID", mThisJob.jobID);
            DB.AddParameter("@lastName", mThisJob.lastName);
            DB.AddParameter("@houseName", mThisJob.houseName);
            DB.AddParameter("@comments", mThisJob.comments);
            DB.AddParameter("@date", mThisJob.date);
            DB.AddParameter("@jobTake", mThisJob.jobTake);
            DB.AddParameter("@totalVisits", mThisJob.totalVisits);

            DB.Execute("sproc_tblJob_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@jobID", mThisJob.jobID);
            DB.Execute("sproc_tblJob_Delete");
        }

        public void ReportByLastName(string lastName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@lastName", lastName);
            DB.Execute("sproc_tblJob_FilterByLastName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mJobList = new List<clsJob>();

            while(Index < RecordCount)
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

    }



}
