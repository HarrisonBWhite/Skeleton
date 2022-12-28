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
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Write(AnCustomer.firstName);
        Response.Write(AnCustomer.lastName);
        Response.Write(AnCustomer.houseName);
        Response.Write(AnCustomer.street);
        Response.Write(AnCustomer.town);
        Response.Write(AnCustomer.county);
        Response.Write(AnCustomer.postcode);
        Response.Write(AnCustomer.contactNumber);
        Response.Write(AnCustomer.email);
        Response.Write(AnCustomer.totalChimneys);
        Response.Write(AnCustomer.comments);
        Response.Write(AnCustomer.totalVisits);

    }
}