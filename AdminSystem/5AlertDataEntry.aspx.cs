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
        clsAlert AnAlert = new clsAlert();
        AnAlert.customerID = Convert.ToInt32(txtCustomerID.Text);
        Session["AnAlert"] = AnAlert;
        Response.Redirect("5AlertViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsAlert AnAlert = new clsAlert();
        Int32 alertID;
        Boolean Found = false;
        alertID = Convert.ToInt32(txtAlertID.Text);
        Found = AnAlert.Find(alertID);

        if (Found == true)
        {
            txtCustomerID.Text = AnAlert.customerID.ToString();
            txtDate.Text = AnAlert.date.ToString();
            txtReminderInterval.Text = AnAlert.reminderInterval.ToString();
        }
    }
}