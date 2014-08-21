﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginClass lc = new LoginClass(txtUser.Text, txtPassword.Text);
        int personKey = lc.ValidateLogin();
        if (personKey != 0)
        {
            Session["PersonKey"] = personKey;
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            lblError.Text = "Invalid login";
        }


    }
    protected void lblRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}