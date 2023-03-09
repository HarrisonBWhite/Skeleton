using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsJob AnJob = new clsJob();
        AnJob = (clsJob)Session["AnJob"];
        Response.Write(AnJob.lastName);
        Response.Write(AnJob.houseName);
        Response.Write(AnJob.comments);
        Response.Write(AnJob.date);
        Response.Write(AnJob.jobTake);
        Response.Write(AnJob.totalVisits);
    }
}