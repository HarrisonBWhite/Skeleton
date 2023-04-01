using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 alertID;
    protected void Page_Load(object sender, EventArgs e)
    {
        alertID = Convert.ToInt32(Session["alertID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsAlertCollection Alerts = new clsAlertCollection();
        Alerts.ThisAlert.Find(alertID);
        Alerts.Delete();
        Response.Redirect("5AlertList.aspx");

    }
}