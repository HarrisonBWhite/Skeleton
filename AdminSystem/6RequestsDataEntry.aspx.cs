using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsRequests AnRequest = new clsRequests();
        AnRequest.postcode = txtPostcode.Text;
        AnRequest.requestID = Convert.ToInt32(txtRequestID.Text);
        AnRequest.flumeCount = Convert.ToInt32(txtFlumeCount.Text);
        Session["postcode"] = AnRequest;
        Session["requestID"] = AnRequest;
        Session["flumeCount"] = AnRequest;

        Response.Redirect("6RequestsViewer.aspx");
    }
}