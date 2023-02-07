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

        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string HouseName = txtHouseName.Text;
        string Street = txtStreet.Text;
        string Town = txtTown.Text;
        string County = txtCounty.Text;
        string Postcode = txtPostcode.Text;
        string ContactNumber = txtContactNumber.Text;
        string Email = txtEmail.Text;
        string TotalChimneys = txtTotalChimneys.Text;
        string Comments = txtComments.Text;
        string TotalVisits = txtTotalVisits.Text;
        
        string Error = "";
        Error = AnCustomer.Valid(FirstName, LastName, HouseName, Street, Town, County, Postcode, ContactNumber, Email, TotalChimneys, Comments, TotalVisits);

        if (Error == "")
        {
            AnCustomer.firstName = FirstName;
            AnCustomer.lastName = LastName;
            AnCustomer.houseName = HouseName;
            AnCustomer.street = Street;
            AnCustomer.town = Town;
            AnCustomer.county = County;
            AnCustomer.postcode = Postcode;
            AnCustomer.contactNumber = ContactNumber;
            AnCustomer.email = Email;
            AnCustomer.totalChimneys = Convert.ToInt32(TotalChimneys);
            AnCustomer.comments = Comments;
            AnCustomer.totalVisits = Convert.ToInt32(TotalVisits);

            Session["AnCustomer"] = AnCustomer;

            Response.Redirect("2CustomerViewer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }

        
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}