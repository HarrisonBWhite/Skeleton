using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 requestID;
    protected void Page_Load(object sender, EventArgs e)
    {
        requestID = Convert.ToInt32(Session["requestID"]);
        if (IsPostBack == false)
        {
            if (requestID != -1)
            {
                DisplayRequest();
            }
        }
    }

    void DisplayRequest()
    {
        clsRequestsCollection Request = new clsRequestsCollection();
        Request.ThisRequest.Find(requestID);
        txtRequestID.Text = Request.ThisRequest.requestID.ToString();
        txtPostcode.Text = Request.ThisRequest.postcode;
        txtFlumeCount.Text = Request.ThisRequest.flumeCount.ToString();


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsRequests AnRequest = new clsRequests();

        string postcode = txtPostcode.Text;
        string flumeCount = txtFlumeCount.Text;
        string Error = "";
        Error = AnRequest.Valid(postcode, flumeCount);

        if (Error == "")
        {
            AnRequest.requestID = requestID;
            AnRequest.postcode = postcode;
            AnRequest.flumeCount = Convert.ToInt32(flumeCount);


            clsRequestsCollection RequestList = new clsRequestsCollection();
            
            if(requestID == -1)
            {
                RequestList.ThisRequest = AnRequest;
                RequestList.Add();

            }
            else
            {
                RequestList.ThisRequest.Find(requestID);
                RequestList.ThisRequest = AnRequest;
                RequestList.Update();
            }

            Response.Redirect("6RequestsList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
    }
}