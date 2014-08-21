using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["customer"] != null)
        {
            //get the customer from the session and copy
            //it into a new registeredcustomer object
            //you have to cast the session object into
            //the correct type of object
            People rc = (People)Session["customer"];

            //just reverse what you did when you wrote the fields to the object
            //take the fields and write them to the textboxes
            txtLastName.Text = rc.LastName;
            txtFirstName.Text = rc.FirstName;
            txtEmail.Text = rc.Email;
            txtStreet.Text = rc.Street;
            txtCity.Text = rc.City;
            txtState.Text = rc.State;
            txtZip.Text = rc.Zip;
            txtPhone.Text = rc.Phone;
            txtPassword.Text = rc.Password;
            txtConfirm.Text = rc.Confirm;
        }
        else
        {
            Response.Redirect("Default2.aspx");
        }

    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        string last = txtLastName.Text;
        //this uses the http Get. It is not unique to asp. It is a 
        //part of the basic http protocol
        Response.Redirect("Default3.aspx?name=" + last);
    }
}