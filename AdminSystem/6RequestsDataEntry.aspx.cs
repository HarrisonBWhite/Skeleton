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

        string postcode = txtPostcode.Text;
        string flumeCount = txtFlumeCount.Text;
        string Error = "";
        Error = AnRequest.Valid(postcode, flumeCount);

        if (Error == "")
        {
            AnRequest.postcode = postcode;
            AnRequest.flumeCount = Convert.ToInt32(flumeCount);
            Session["AnRequest"] = AnRequest;
            Response.Write("6RequestsViewer.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
    }
}