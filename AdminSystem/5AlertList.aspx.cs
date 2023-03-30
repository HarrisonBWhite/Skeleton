using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayAlerts();
        }

    }

    void DisplayAlerts()
    {
        clsAlertCollection Alerts = new clsAlertCollection();
        lstAlertList.DataSource = Alerts.AlertList;
        lstAlertList.DataValueField = "alertID";
        lstAlertList.DataTextField = "customerID";
        lstAlertList.DataBind();
    }

    protected void lstAlertList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}