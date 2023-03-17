using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 jobID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayJob();
        }
    }

    void DisplayJob()
    {
        clsJobCollection Jobs = new clsJobCollection();
        lstJobList.DataSource = Jobs.JobList;
        lstJobList.DataValueField = "jobID";
        lstJobList.DataTextField = "lastName";
        lstJobList.DataBind();
    }


}