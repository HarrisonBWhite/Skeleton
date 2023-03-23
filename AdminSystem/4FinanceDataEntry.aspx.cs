using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 financeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        financeID = Convert.ToInt32(Session["financeID"]);
        if (IsPostBack == false)
        {
            if (financeID != -1)
            {
                DisplayFinance();
            }
        }
    }

    void DisplayFinance()
    {
        clsFinanceCollection Finance = new clsFinanceCollection();
        Finance.ThisFinance.Find(financeID);

        txtFinanceID.Text = Finance.ThisFinance.financeID.ToString();
        txtDate.Text = Finance.ThisFinance.date.ToString();
        txtJobTake.Text = Finance.ThisFinance.jobTake.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsFinance AnFinance = new clsFinance();

        string date = txtDate.Text;
        string jobTake = txtJobTake.Text;

        string Error = "";

        Error = AnFinance.Valid(date, jobTake);

        if (Error == "")
        {
            AnFinance.date = Convert.ToDateTime(date);
            AnFinance.jobTake = Convert.ToInt32(jobTake);

            clsFinanceCollection FinanceList = new clsFinanceCollection();

            if (financeID == -1)
            {
                FinanceList.ThisFinance = AnFinance;
                FinanceList.Add();
            }
            else
            {
                FinanceList.ThisFinance.Find(financeID);
                FinanceList.ThisFinance = AnFinance;
                FinanceList.Update();
            }
            Response.Redirect("4FinanceList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
            

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