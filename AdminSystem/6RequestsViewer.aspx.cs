using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsRequests AnRequest = new clsRequests();
        AnRequest = (clsRequests)Session["postcode"];
        AnRequest = (clsRequests)Session["requestID"];
        AnRequest = (clsRequests)Session["flumeCount"];
        Response.Write(AnRequest.postcode);
        Response.Write(AnRequest.requestID);
        Response.Write(AnRequest.flumeCount);
    }
}