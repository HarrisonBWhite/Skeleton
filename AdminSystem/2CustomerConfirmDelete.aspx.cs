using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 customerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        customerID = Convert.ToInt32(Session["customerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(customerID);
        Customer.Delete();
        Response.Redirect("2CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("2CustomerList.aspx");
    }
}