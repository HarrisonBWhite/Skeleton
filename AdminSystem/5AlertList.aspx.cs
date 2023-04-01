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



    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["customerID"] = -1;
        Response.Redirect("5AlertDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 alertID;

        if (lstAlertList.SelectedIndex != -1)
        {
            alertID = Convert.ToInt32(lstAlertList.SelectedValue);
            Session["alertID"] = alertID;
            Response.Redirect("5AlertDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 alertID;

        if(lstAlertList.SelectedIndex != -1)
        {
            alertID = Convert.ToInt32(lstAlertList.SelectedValue);
            Session["alertID"] = alertID;
            Response.Redirect("5AlertConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsAlertCollection Alerts = new clsAlertCollection();
        Alerts.ReportByCustomerID("");

        txtAnswer.Text = "";
        lstAlertList.DataSource = Alerts.AlertList;
        lstAlertList.DataValueField = "alertID";
        lstAlertList.DataTextField = "customerID";
        lstAlertList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsAlertCollection Alerts = new clsAlertCollection();
        Alerts.ReportByCustomerID(txtAnswer.Text);
        lstAlertList.DataSource = Alerts.AlertList;
        lstAlertList.DataValueField = "alertID";
        lstAlertList.DataTextField = "customerID";
        lstAlertList.DataBind();

    }
}