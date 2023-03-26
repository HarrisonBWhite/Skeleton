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
            DisplayRequests();
        }
    }

    void DisplayRequests()
    {
        clsRequestsCollection Requests = new clsRequestsCollection();

        lstRequestList.DataSource = Requests.RequestList;

        lstRequestList.DataValueField = "requestID";

        lstRequestList.DataTextField = "postcode";

        lstRequestList.DataBind();
    }

    protected void lstRequestList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}