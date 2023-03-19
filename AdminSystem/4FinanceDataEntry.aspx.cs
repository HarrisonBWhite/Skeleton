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
        clsFinance AnFinance = new clsFinance();

        //AnFinance.financeID = Convert.ToInt32(txtFinanceID.Text);
        //AnFinance.date = Convert.ToDateTime(txtDate.Text);
        AnFinance.jobTake = Convert.ToInt32(txtJobTake.Text);
        Session["AnFinance"] = AnFinance;
        Response.Redirect("4FinanceViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsFinance AnFinance = new clsFinance();
        Int32 financeID;
        Boolean Found = false;
        financeID = Convert.ToInt32(txtFinanceID.Text);
        Found = AnFinance.Find(financeID);
        if (Found == true)
        {
            txtDate.Text = AnFinance.date.ToString();
            txtJobTake.Text = AnFinance.jobTake.ToString();

        }
    }
}