using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //retrieve the value from the query string
        //based on the name (name/value pair)
        string last = Request.QueryString["name"];
        lblthankYou.Text = "Thank you, " + last + ", for your submission";
    }
}