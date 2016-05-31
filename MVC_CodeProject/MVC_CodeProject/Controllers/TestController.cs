using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeProject.Models;

namespace MVC_CodeProject.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        // If exists, will override a ToString return type (e.g. GetCustomer()) with the return of this function:
        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }

    public class TestController : Controller
    {
        //Returns string "Hello World"
        public string GetString()
        {
            return "Hello World";
        }

        public Customer GetCustomer()
        {
            // When return type is some object like ‘customer’, it will return ‘ToString()’ implementation of that object.
            // By default ‘ToString()’ method returns fully qualified name of the class which is “NameSpace.ClassName”;
            // E.g in this case - Returns "WebApplication1.Controllers.Customer"
            Customer c = new Customer();
            c.CustomerName = "Mike";
            c.Address = "Worthing";
            return c;
        }

        // By default all public functions are "Action Methods", which mean they can be invoked via the web.
        // Pre-fixing [NonAction] to a function means it cannot be invoked from the web. 
        // n: Non-public functions also cannot be invoked from the web.
        [NonAction]
        public string SimpleMethod()
        {
            return "Hi, I am not an action method";
        }

        // Returns the View "~/Views/Test/MyView.cshtml"
        // n: The Test controller can access only those views which are inside Test folder or "~/Views/Shared" folder.
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.firstName = "Mike";
            emp.lastName = "Topping";
            emp.salary = 16500;

            // ViewData way of doing it
            ViewData["Employee"] = emp;
            //return View("MyView");

            // ViewBag way of doing it
            ViewBag.Employee = emp;
            return View("MyView");
        }
    }
}
