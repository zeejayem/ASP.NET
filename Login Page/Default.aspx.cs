using System;
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //try the code to make sure everything goes
        //correctly
        try
        {
            //initialize the registered customer class and set its 
            //properties
            People rc = new People();
            rc.LastName = txtLastName.Text;
            rc.FirstName = txtFirstName.Text;
            rc.Email = txtEmail.Text;
            rc.Street = txtStreet.Text;
            rc.City = txtCity.Text;
            rc.State = txtState.Text;
            rc.Zip = txtZip.Text;
            rc.Phone = txtPhone.Text;
            rc.Password = txtPassword.Text;
            rc.Confirm = txtConfirm.Text;

            //save the RegisteredCustomer object to a session variable
            //so you can recall it on default2

            Session["customer"] = rc;

            //now redirect to the next page
            Response.Redirect("Default2.aspx");
        }
        catch (Exception ex)
        {
            //if there is an error show the error message
            lblError.Text = ex.Message;
        }

    }
}