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
        AnLogin.username = txtUsername.Text;
        Session["AnLogin"] = AnLogin;
        Response.Redirect("1LoginViewer.aspx");
    }
}