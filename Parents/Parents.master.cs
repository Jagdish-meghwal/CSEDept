﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parents_Parents : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Id"] != null)
        {
            userhello.InnerText = Session["AdminName"].ToString();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("../Admin/Default.aspx");
    }
}
