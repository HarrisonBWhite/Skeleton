using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 alertID;
    protected void Page_Load(object sender, EventArgs e)
    {
        alertID = Convert.ToInt32(Session["alertID"]);
        if (IsPostBack == false)
        {
            if (alertID != -1)
            {
                DisplayAlert();
            }
        }
    }

    void DisplayAlert()
    {
        clsAlertCollection Alerts = new clsAlertCollection();
        Alerts.ThisAlert.Find(alertID);

        txtAlertID.Text = Alerts.ThisAlert.alertID.ToString();
        txtCustomerID.Text = Alerts.ThisAlert.customerID.ToString();
        txtDate.Text = Alerts.ThisAlert.date.ToString();
        txtReminderInterval.Text = Alerts.ThisAlert.reminderInterval.ToString();

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsAlert AnAlert = new clsAlert();

        string customerID = txtCustomerID.Text;
        string date = txtDate.Text;
        string reminderInterval = txtReminderInterval.Text;
        string Error = "";

        Error = AnAlert.Valid(customerID, date, reminderInterval);

        if (Error == "")
        {
            AnAlert.customerID = Convert.ToInt32(customerID);
            AnAlert.date = Convert.ToDateTime(date);
            AnAlert.reminderInterval = Convert.ToDateTime(reminderInterval);

            clsAlertCollection AlertList = new clsAlertCollection();
            
            if (alertID == -1)
            {
                AlertList.ThisAlert = AnAlert;
                AlertList.Add();
            }
            else
            {
                AlertList.ThisAlert.Find(alertID);
                AlertList.ThisAlert = AnAlert;
                AlertList.Update();
            }
            Response.Redirect("5AlertList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    /*protected void btnFind_Click(object sender, EventArgs e)
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
    }*/

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("1LoginDataEntry.aspx");
    }
}