using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class ManagePerson
{
    Person p;
    int id;
    SqlConnection connect;

    public ManagePerson(int customerID)
    {

        id = customerID;
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
    }

    public Person GetPerson()
    {
        //same pattern. 
        //1. Create Sql String
        //2. Create command object
        //3. give values to any parameters
        //4. create a reader object
        //5. open the connection
        //6. Execute the reader
        //7. loop through the reader to get the data
        //8. Close reader
        //9. Close Connection
        //10. return the object containing the data


<<<<<<< HEAD
        p = new Person();
=======
        Person p = new Person();
>>>>>>> SCCC ITC172 - .NET
        string sql = "Select PersonLastName, PersonFirstName, PersonUserName "
            + "from Person p "
            + "Where p.PersonKey=@customerID";

        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@customerID", id);
        SqlDataReader reader;

        connect.Open();
        reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                p.lastName = reader["PersonLastName"].ToString();
                p.firstName = reader["PersonFirstName"].ToString();
                p.email = reader["PersonUserName"].ToString();
            }
        }
        reader.Close();
        connect.Close();

        return p;
    }
}
