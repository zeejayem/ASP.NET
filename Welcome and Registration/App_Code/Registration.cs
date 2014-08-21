using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//libraries required for this class
using System.Data; //general data
using System.Data.SqlClient; //sql server
using System.Configuration; //to get access to the web config file

/// <summary>
/// Summary description for Registration
/// This class takes a customer and vehicle object
/// extracts the properties from them
/// and writes them to the automart database
/// </summary>
public class Registration
{
    Person p;
    PersonAddress pa;
    SqlConnection connect;

    public Registration(Person pers, PersonAddress persAd)
    {
        p = pers;
        pa = persAd;
        //get the connection string from the web config file
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
        //call the WriteToDatabase() method
        //it needs to be in a try catch because as the calling method
        //this is where the thrown method would be caught
        //we need to rethrow it so it makes it out
        //to the web form
        try
        {
            WriteToDatabase();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void WriteToDatabase()
    {
        //set up the sql strings for each table
        //PersonPassKey is hashed?
        string sqlPerson = "Insert into Person( PersonLastName, PersonFirstName, PersonUserName, PersonPlainPassword, PersonPassKey,PersonEntryDate, PersonUserPassword)"
            + " Values(@lastName, @firstName, @email, @password, @passkey,GetDate(), @hashedpass)";
        string sqlPersonAddress = "Insert into PersonAddress(Street, Apartment, State, City, Zip, PersonKey)"
            + " Values(@street, @apartment, @state, @city, @zip, Ident_Current('person'))";

        //create a command for each sqlstring and provide values
        //for the parameters
        SqlCommand cmdPerson = new SqlCommand(sqlPerson, connect);
        cmdPerson.Parameters.AddWithValue("@lastName", p.lastName);
        cmdPerson.Parameters.AddWithValue("@firstName", p.firstName);
        cmdPerson.Parameters.AddWithValue("@email", p.email);
        cmdPerson.Parameters.AddWithValue("@password", p.password);
        cmdPerson.Parameters.AddWithValue("@passkey", p.passkey);
        cmdPerson.Parameters.AddWithValue("@hasedpass", p.hashedpass);

        SqlCommand cmdPersonAddress = new SqlCommand(sqlPersonAddress, connect);
        cmdPersonAddress.Parameters.AddWithValue("@street", pa.street);
        cmdPersonAddress.Parameters.AddWithValue("@apartment", pa.apartment);
        cmdPersonAddress.Parameters.AddWithValue("@state", pa.state);
        cmdPersonAddress.Parameters.AddWithValue("@city", pa.city);
        cmdPersonAddress.Parameters.AddWithValue("@zip", pa.zip);
        

        //create a transaction object
        SqlTransaction tran = null;


        //open the connection
        connect.Open();
        //start the transaction
        tran = connect.BeginTransaction();

        //try the inserts, if all are successful
        //commit the transaction
        try
        {
            //assign all the commands to the same transaction
            cmdPerson.Transaction = tran;
            cmdPersonAddress.Transaction = tran;

            cmdPerson.ExecuteNonQuery();
            cmdPersonAddress.ExecuteNonQuery();

            tran.Commit();
        }
        catch (Exception ex)
        {
            //if there are any errors
            //roll back the transaction 
            //and throw the error
            tran.Rollback();
            throw ex;
        }
        finally //no matter what
        {
            connect.Close();
        }



    }
}