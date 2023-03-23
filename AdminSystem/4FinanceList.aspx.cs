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
        if (IsPostBack == false)
        {
            DisplayFinances();
        }
    }

    void DisplayFinances()
    {
        clsFinanceCollection Finances = new clsFinanceCollection();
        lstFinanceList.DataSource = Finances.FinanceList;
        lstFinanceList.DataValueField = "financeID";
        lstFinanceList.DataTextField = "jobTake";
        lstFinanceList.DataBind();

    }

    protected void lstFinanceList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["FinanceID"] = -1;
        Response.Redirect("4FinanceDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 financeID;

        if(lstFinanceList.SelectedIndex != -1)
        {
            financeID = Convert.ToInt32(lstFinanceList.SelectedValue);
            Session["financeID"] = financeID;
            Response.Redirect("4FinanceDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 financeID;

        if(lstFinanceList.SelectedIndex != -1)
        {
            financeID = Convert.ToInt32(lstFinanceList.SelectedValue);
            Session["financeID"] = financeID;
            Response.Redirect("4FinanceConfrimDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the lsit";
        }
    }
}