using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 customerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        customerID = Convert.ToInt32(Session["customerID"]);
        if(IsPostBack == false)
        {
            if(customerID != -1)
            {
                DisplayCustomer();
            }
        }

    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(customerID);

        txtCustomerID.Text = Customers.ThisCustomer.customerID.ToString();
        txtFirstName.Text = Customers.ThisCustomer.firstName.ToString();
        txtLastName.Text = Customers.ThisCustomer.lastName.ToString();
        txtHouseName.Text = Customers.ThisCustomer.houseName.ToString();
        txtStreet.Text = Customers.ThisCustomer.street.ToString();
        txtTown.Text = Customers.ThisCustomer.town.ToString();
        txtCounty.Text = Customers.ThisCustomer.county.ToString();
        txtPostcode.Text = Customers.ThisCustomer.postcode.ToString();
        txtContactNumber.Text = Customers.ThisCustomer.contactNumber.ToString();
        txtEmail.Text = Customers.ThisCustomer.email.ToString();
        txtTotalChimneys.Text = Customers.ThisCustomer.totalChimneys.ToString();
        txtComments.Text = Customers.ThisCustomer.comments.ToString();
        txtTotalVisits.Text = Customers.ThisCustomer.totalVisits.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        string customerID = txtCustomerID.Text;
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

            AnCustomer.customerID = Convert.ToInt32(customerID);
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

            if(Convert.ToInt32(customerID) == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(Convert.ToInt32(customerID));
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }


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