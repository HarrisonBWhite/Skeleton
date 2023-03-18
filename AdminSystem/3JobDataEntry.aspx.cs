using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 jobID;
    protected void Page_Load(object sender, EventArgs e)
    {
        jobID = Convert.ToInt32(Session["jobID"]);
        if (IsPostBack == false)
        {
            if (jobID != -1)
            {
                DisplayJob();
            }
        }

    }

    void DisplayJob()
    {
        clsJobCollection Job = new clsJobCollection();
        Job.ThisJob.Find(jobID);

        txtJobID.Text = Job.ThisJob.jobID.ToString();
        txtLastName.Text = Job.ThisJob.lastName;
        txtHouseName.Text = Job.ThisJob.houseName;
        txtComments.Text = Job.ThisJob.comments;
        txtDate.Text = Job.ThisJob.date.ToString();
        txtJobTake.Text = Job.ThisJob.jobTake.ToString();
        txtTotalVisits.Text = Job.ThisJob.totalVisits.ToString();


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsJob AnJob = new clsJob();

        string LastName = txtLastName.Text;
        string HouseName = txtHouseName.Text;
        string Comments = txtComments.Text;
        string Date = txtDate.Text;
        string JobTake = txtJobTake.Text;
        string TotalVisits = txtTotalVisits.Text;

        string Error = "";


        Error = AnJob.Valid(LastName, HouseName, Comments, Date, JobTake, TotalVisits);




        if (Error == "")
        {
            AnJob.jobID = jobID;
            AnJob.lastName = LastName;
            AnJob.houseName = HouseName;
            AnJob.comments = Comments;
            AnJob.date = Convert.ToDateTime(txtDate.Text);
            AnJob.jobTake = Convert.ToDouble(txtJobTake.Text);
            AnJob.totalVisits = Convert.ToInt32(txtTotalVisits.Text);

            clsJobCollection JobList = new clsJobCollection();
            
            
            if (jobID == -1)
            {
                JobList.ThisJob = AnJob;
                JobList.Add();
            }
            else
            {
                JobList.ThisJob.Find(jobID);
                JobList.ThisJob = AnJob;
                JobList.Update();
            }

            Response.Redirect("3JobList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsJob AnJob = new clsJob();

        Int32 jobID;
        Boolean Found = false;
        jobID = Convert.ToInt32(txtJobID.Text);
        Found = AnJob.Find(jobID);

        if (Found == true)
        {
            txtLastName.Text = AnJob.lastName;
            txtHouseName.Text = AnJob.houseName;
            txtComments.Text = AnJob.comments;
            txtDate.Text = AnJob.date.ToString();
            txtJobTake.Text = AnJob.jobTake.ToString();
            txtTotalVisits.Text = AnJob.totalVisits.ToString();
        }
    }
}