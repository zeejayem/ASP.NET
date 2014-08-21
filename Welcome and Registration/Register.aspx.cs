using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //hide the linkbutton
        //if (!IsPostBack)
        //btnLogin.Visible = false;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        //get the passcode
        PasscodeGenerator pg = new PasscodeGenerator();
        int passkey = pg.GetPasscode();

        //initialize customer and vehicle
        Person p = new Person();
        PersonAddress pa = new PersonAddress();

        //initialize PasswordHash
        PasswordHash ph = new PasswordHash();

        //Assign the values from the textboxes
        //to the classes
        p.lastName = txtLastName.Text;
        p.firstName = txtFirstName.Text;
        p.email = txtEmail.Text;
        p.password = txtPassword.Text;
        p.passkey = ph.HashIt(txtPassword.Text, passkey.ToString());

        pa.street = txtStreet.Text;
        pa.apartment = txtApartment.Text;
        pa.city = txtCity.Text;
        pa.state = txtState.Text;
        pa.zip = txtZip.Text;
 
        try
        {
            //try to write to the database
            Registration r = new Registration(p, pa);
            lblResult.Text = "Thank you for registering";
            //btnLogin.Visible = true;
        }
        catch (Exception ex)
        {
            //if it fails show the error
            lblResult.Text = ex.ToString();
        }
    }
}