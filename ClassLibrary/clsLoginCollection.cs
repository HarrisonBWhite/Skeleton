using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsLoginCollection
    {
        List<clsLogin> mLoginList = new List<clsLogin>();
        clsLogin mThisLogin = new clsLogin();
        

        public clsLoginCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblLogin_SelectAll");
            PopulateArray(DB);

        }

        public List<clsLogin> LoginList
        {
            get
            {
                return mLoginList;
            }
            set
            {
                mLoginList = value;
            }
        }
        public int Count
        {
            get
            {
                return mLoginList.Count;
            }
            set
            {
                //worry ab later
            }
        }
        public clsLogin ThisLogin
        {
            get
            {
                return mThisLogin;
            }
            set
            {
                mThisLogin = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@username", mThisLogin.username);
            DB.AddParameter("@password", mThisLogin.password);
            return DB.Execute("sproc_tblLogin_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserID", mThisLogin.userID);
            DB.AddParameter("@username", mThisLogin.username);
            DB.AddParameter("@password", mThisLogin.password);

            DB.Execute("sproc_tblLogin_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", mThisLogin.userID);
            DB.Execute("sproc_tblLogin_Delete");
        }

        public void ReportByUsername(string username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@username", username);
            DB.Execute("sproc_tblLogin_FilterByUsername");
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mLoginList = new List<clsLogin>();

            while (Index < RecordCount)
            {
                clsLogin AnLogin = new clsLogin();

                AnLogin.userID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AnLogin.username = Convert.ToString(DB.DataTable.Rows[Index]["username"]);
                AnLogin.password = Convert.ToString(DB.DataTable.Rows[Index]["password"]);

                mLoginList.Add(AnLogin);
                Index++;
            }


        }


    }
}
