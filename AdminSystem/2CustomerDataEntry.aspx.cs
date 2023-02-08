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

        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string houseName = txtHouseName.Text;
        string street = txtStreet.Text;
        string town = txtTown.Text;
        string county = txtCounty.Text;
        string postcode = txtPostcode.Text;
        string contactNumber = txtContactNumber.Text;
        string email = txtEmail.Text;
        string totalChimneys = txtTotalChimneys.Text;
        string comments = txtComments.Text;
        string totalVisits = txtTotalVisits.Text;
        
        string Error = "";
        Error = AnCustomer.Valid(firstName, lastName, houseName, street, town, county, postcode, contactNumber, email, totalChimneys, comments, totalVisits);

        if (Error == "")
        {
            AnCustomer.firstName = firstName;
            AnCustomer.lastName = lastName;
            AnCustomer.houseName = houseName;
            AnCustomer.street = street;
            AnCustomer.town = town;
            AnCustomer.county = county;
            AnCustomer.postcode = postcode;
            AnCustomer.contactNumber = contactNumber;
            AnCustomer.email = email;
            AnCustomer.totalChimneys = Convert.ToInt32(totalChimneys);
            AnCustomer.comments = comments;
            AnCustomer.totalVisits = Convert.ToInt32(totalVisits);

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = AnCustomer;
            CustomerList.Add();


            Response.Redirect("2CustomerList.aspx");

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