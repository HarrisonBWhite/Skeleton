using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 requestID;
    protected void Page_Load(object sender, EventArgs e)
    {
        requestID = Convert.ToInt32(Session["requestID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsRequestsCollection Requests = new clsRequestsCollection();
        Requests.ThisRequest.Find(requestID);
        Requests.Delete();
        Response.Redirect("6RequestsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("6RequestsList.aspx");
    }
}