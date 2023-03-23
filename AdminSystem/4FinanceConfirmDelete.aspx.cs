using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 financeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        financeID = Convert.ToInt32(Session["financeID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsFinanceCollection Finance = new clsFinanceCollection();
        Finance.ThisFinance.Find(financeID);
        Finance.Delete();
        Response.Redirect("4FinanceList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("4FinanceList.aspx");
    }
}