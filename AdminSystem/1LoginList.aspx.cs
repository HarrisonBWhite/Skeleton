using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayLogins();
        }

    }

    void DisplayLogins()
    {
        clsLoginCollection Logins = new clsLoginCollection();
        lstLoginList.DataSource = Logins.LoginList;
        lstLoginList.DataValueField = "UserID";
        lstLoginList.DataTextField = "username";
        lstLoginList.DataBind();
    }

    protected void lstLoginList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}