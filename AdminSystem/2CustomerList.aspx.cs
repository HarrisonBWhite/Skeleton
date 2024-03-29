﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 customerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //customerID = Convert.ToInt32(Session["customerID"]);
        if (IsPostBack == false)
        {
          
                DisplayCustomers();

            
            
        }

    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "customerID";
        lstCustomerList.DataTextField = "lastName";
        lstCustomerList.DataBind();
    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["customerID"] = -1;
        Response.Redirect("2CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 customerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            customerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["customerID"] = customerID;
            Response.Redirect("2CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 customerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            customerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["customerID"] = customerID;
            Response.Redirect("2CustomerConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByLastName(txtPostcode.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "customerID";
        lstCustomerList.DataTextField = "lastName";
        lstCustomerList.DataBind();
    }



    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByLastName("");

        txtPostcode.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "customerID";
        lstCustomerList.DataTextField = "lastName";
        lstCustomerList.DataBind();

    }
}