using System;

namespace ClassLibrary
{
    public class clsLogin
    {
        private Int32 mUserID;
        private string mUsername;
        private string mPassword;
        
        public string username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }
        public string password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public Int32 userID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public bool Find(int userID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", userID);
            DB.Execute("sproc_tblLogin_FilterByUserID");
            if(DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["password"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string username, string password)
        {
            String Error = "";

            if(username.Length == 0)
            {
                Error = Error + "Username cannot be blank";
            }
            if (username.Length > 50)
            {
                Error = Error + "Username cannot exceed 50 characters";
            }
            if (password.Length == 0)
            {
                Error = Error + "Password cannot be blank";
            }
            if (password.Length > 50)
            {
                Error = Error + "Password cannot exceed 50 characters";
            }

            return Error;
        }



    }
}