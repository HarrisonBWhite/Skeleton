using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 userID;
    protected void Page_Load(object sender, EventArgs e)
    {
        userID = Convert.ToInt32(Session["userID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsLoginCollection LoginBook = new clsLoginCollection();
        LoginBook.ThisLogin.Find(userID);
        Response.Redirect("1LoginList.aspx");
    }
}