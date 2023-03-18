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



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["jobID"] = -1;
        Response.Redirect("3JobDataEntry.aspx");
    }





    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 jobID;

        if (lstJobList.SelectedIndex != -1)
        {
            jobID = Convert.ToInt32(lstJobList.SelectedValue);
            Session["jobID"] = jobID;
            Response.Redirect("3JobDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 jobID;

        if (lstJobList.SelectedIndex != -1)
        {
            jobID = Convert.ToInt32(lstJobList.SelectedValue);
            Session["jobID"] = jobID;
            Response.Redirect("3JobConfrimDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsJobCollection Job = new clsJobCollection();
        Job.ReportByLastName(txtAnswer.Text);
        lstJobList.DataValueField = "jobID";
        lstJobList.DataTextField = "lastName";
        lstJobList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsJobCollection Job = new clsJobCollection();
        Job.ReportByLastName("");
        txtAnswer.Text = "";
        lstJobList.DataSource = Job.JobList;
        lstJobList.DataValueField = "jobID";
        lstJobList.DataTextField = "lastName";
        lstJobList.DataBind();

    }
}