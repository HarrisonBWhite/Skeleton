﻿using System;
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
    
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("2CustomerList.aspx");
    }

    protected void btnJobPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("3JobList.aspx");
    }

    protected void btnFinancePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("4FinanceList.aspx");
    }
}