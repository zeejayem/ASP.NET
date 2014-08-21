using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTestApp.Models;//this gives access to the models

namespace MVCTestApp.Controllers
{
    public class CAEmployeeController : Controller
    {
        //
        // GET: /CAEmployee/

        public ActionResult Index()
        {
            CommunityAssistEntities cae = new CommunityAssistEntities();//the code below is linq
            var employees = from e in cae.EmployeeJobTitles//when trying to do links it's best to start with farthest out and work in.
                            orderby e.Employee.Person.PersonLastName
                            select new
                            {
                                e.Employee.Person.PersonLastName,
                                e.Employee.Person.PersonFirstName,
                                e.Employee.Person.PersonUsername,
                                e.Employee.EmployeeHireDate,
                                e.Jobtitle.JobTitleName,
                                e.Employee.EmployeeStatus
                            };
            List<CAEmployee> employeeList = new List<CAEmployee>();
            foreach (var x in employees)
            {
                CAEmployee emp = new CAEmployee();
                emp.LastName = x.PersonFirstName;
                emp.FirstName = x.PersonFirstName;
                emp.Email = x.PersonUsername;
                emp.HireDate = x.EmployeeHireDate.ToString();
                emp.JobTitle = x.JobTitleName;
                emp.status = x.EmployeeStatus;

                employeeList.Add(emp);
            }
            return View(employeeList);
        }

    }

    public class CAEmployee//this is to store the combination, holding the data.
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Email { set; get; }
        public string HireDate { set; get; }
        public string JobTitle { set; get; }
        public string status { set; get; }

    }
}
