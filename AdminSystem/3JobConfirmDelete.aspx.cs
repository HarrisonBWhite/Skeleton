using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 jobID;
    protected void Page_Load(object sender, EventArgs e)
    {
        jobID = Convert.ToInt32(Session["jobID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsJobCollection Job = new clsJobCollection();
        Job.ThisJob.Find(jobID);
        Job.Delete();
        Response.Redirect("3JobList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("3JobList.aspx");
    }
}