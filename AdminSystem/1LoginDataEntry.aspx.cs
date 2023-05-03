using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 userID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsLogin AnLogin = new clsLogin();

        
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        string Error = "";

        Error = AnLogin.Valid(username, password);

        if(username == "admin1" && password == "admin1")
        {
            Response.Redirect("2CustomerViewer.aspx");
        }

        if (username == "sweep1" && password == "sweep1")
        {
            Response.Redirect("3JobViewer.aspx");
        }

        if (username == "customer1" && password == "customer1")
        {
            Response.Redirect("5AlertViewer.aspx");
        }

        /*if (Error == "")
        {
            AnLogin.userID = userID;
            AnLogin.username = username;
            AnLogin.password = password;

            clsLoginCollection LoginList = new clsLoginCollection();

            if (userID == -1)
            {
                LoginList.ThisLogin = AnLogin;
                LoginList.Add();
            }
            else
            {
                LoginList.ThisLogin.Find(userID);
                LoginList.ThisLogin = AnLogin;
                LoginList.Add();
            }
        }*/
        else
        {
            lblError.Text = "Please enter a valid username and password!";
        }

    }
}