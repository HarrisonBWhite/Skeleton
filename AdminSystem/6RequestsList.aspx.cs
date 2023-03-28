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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["requestID"] = -1;
        Response.Redirect("6RequestsDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 requestID;

        if (lstRequestList.SelectedIndex != -1)
        {
            requestID = Convert.ToInt32(lstRequestList.SelectedValue);
            Session["requestID"] = requestID;
            Response.Redirect("6RequestsDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 requestID;

        if (lstRequestList.SelectedIndex != -1)
        {
            requestID = Convert.ToInt32(lstRequestList.SelectedValue);
            Session["requestID"] = requestID;
            Response.Redirect("6RequestsConfrimDelete.aspx");
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsRequestsCollection Requests = new clsRequestsCollection();
        Requests.ReportByPostCode(txtAnswer.Text);
        lstRequestList.DataSource = Requests.RequestList;
        lstRequestList.DataValueField = "requestID";
        lstRequestList.DataTextField = "postcode";
        lstRequestList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsRequestsCollection Requests = new clsRequestsCollection();
        Requests.ReportByPostCode("");

        txtAnswer.Text = "";
        lstRequestList.DataSource = Requests.RequestList;
        lstRequestList.DataValueField = "requestID";
        lstRequestList.DataTextField = "postcode";
        lstRequestList.DataBind();
    }
}