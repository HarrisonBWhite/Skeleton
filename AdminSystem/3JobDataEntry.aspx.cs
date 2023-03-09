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
        clsJob AnJob = new clsJob();
        AnJob.lastName = txtLastName.Text;
        AnJob.houseName = txtHouseName.Text;
        AnJob.comments = txtComments.Text;
        AnJob.date = Convert.ToDateTime(txtDate.Text);
        AnJob.jobTake = Convert.ToDouble(txtJobTake.Text);
        AnJob.totalVisits = Convert.ToInt32(txtTotalVisits.Text);
        Session["AnJob"] = AnJob;
        Response.Redirect("3JobViewer.aspx");
    }
}