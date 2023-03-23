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
}