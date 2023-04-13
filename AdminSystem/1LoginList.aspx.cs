using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayLogins();
        }

    }

    void DisplayLogins()
    {
        clsLoginCollection Logins = new clsLoginCollection();
        lstLoginList.DataSource = Logins.LoginList;
        lstLoginList.DataValueField = "UserID";
        lstLoginList.DataTextField = "username";
        lstLoginList.DataBind();
    }

    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["userID"] = -1;
        Response.Redirect("1LoginDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 userID;

        if(lstLoginList.SelectedIndex != -1)
        {
            userID = Convert.ToInt32(lstLoginList.SelectedValue);
            Session["userID"] = userID;
            Response.Redirect("1LoginDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void lstLoginList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 userID;

        if(lstLoginList.SelectedIndex != -1)
        {
            userID = Convert.ToInt32(lstLoginList.SelectedValue);
            Session["userID"] = userID;
            Response.Redirect("1LoginConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record to delete from list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsLoginCollection Logins = new clsLoginCollection();
        Logins.ReportByUsername(txtAnswer.Text);
        lstLoginList.DataSource = Logins.LoginList;
        lstLoginList.DataValueField = "UserID";
        lstLoginList.DataTextField = "username";
        lstLoginList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsLoginCollection Logins = new clsLoginCollection();
        Logins.ReportByUsername("");
        txtAnswer.Text = "";
        lstLoginList.DataSource = Logins.LoginList;
        lstLoginList.DataValueField = "UserID";
        lstLoginList.DataTextField = "username";
        lstLoginList.DataBind();


    }
}