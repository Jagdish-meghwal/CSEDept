﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Faculty_Default : System.Web.UI.Page
{
    dbcode csedpt = new dbcode();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            string Password = txtPassword.Text;
            string pass = csedpt.ExecuteScalar("select Password from FacultyTbl where Name='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "' and IsActive='1'");
            if (Password == pass)
            {
                DataTable dt = csedpt.SelectQuery("select ID, Name from FacultyTbl where Name='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "' and IsActive='1'");
                Session["Id"] = dt.Rows[0]["ID"].ToString();
                Session["AdminName"] = txtUserName.Text;
                Session["Role"] = "2";
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Response.Write("<Script>alert('Invalid User Name or Password')</Script>");
            }
        }
        catch (Exception ex)
        { }
    }
}