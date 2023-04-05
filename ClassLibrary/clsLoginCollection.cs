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

        public clsLoginCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblLogin_SelectAll");
            RecordCount = DB.Count;

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
        public clsLogin ThisLogin { get; set; }
    }
}
