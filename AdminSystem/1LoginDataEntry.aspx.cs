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
        clsLogin AnLogin = new clsLogin();

        string username = txtUsername.Text;
        string password = txtPassword.Text;
        string Error = "";

        Error = AnLogin.Valid(username, password);

        if(Error == "")
        {
            AnLogin.username = username;
            AnLogin.password = password;

            Session["AnLogin"] = AnLogin;
            Response.Write("1LoginViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }
}