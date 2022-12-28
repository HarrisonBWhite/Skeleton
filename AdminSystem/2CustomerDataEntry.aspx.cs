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
        clsCustomer AnCustomer = new clsCustomer();

        AnCustomer.firstName = txtFirstName.Text;
        AnCustomer.lastName = txtLastName.Text;
        AnCustomer.houseName = txtHouseName.Text;
        AnCustomer.street = txtStreet.Text;
        AnCustomer.town = txtTown.Text;
        AnCustomer.county = txtCounty.Text;
        AnCustomer.postcode = txtPostcode.Text;
        AnCustomer.contactNumber = txtContactNumber.Text;
        AnCustomer.email = txtEmail.Text;
        AnCustomer.totalChimneys = Convert.ToInt32(txtTotalChimneys.Text);
        AnCustomer.comments = txtComments.Text;
        AnCustomer.totalVisits = Convert.ToInt32(txtTotalVisits.Text);
       
        Session["AnCustomer"] = AnCustomer;

        Response.Redirect("2CustomerViewer.aspx");
    }
}