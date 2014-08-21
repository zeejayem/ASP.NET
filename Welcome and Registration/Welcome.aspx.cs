using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PersonKey"] != null)
        {
            ManagePerson mp = new ManagePerson((int)Session["PersonKey"]);
            Person p = mp.GetPerson();
            lblFirst.Text = p.firstName;
            lblLast.Text = p.lastName;
            lblEmail.Text = p.email;

        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }
}