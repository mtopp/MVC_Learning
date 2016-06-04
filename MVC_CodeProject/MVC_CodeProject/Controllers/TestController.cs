using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeProject.Models;
using MVC_CodeProject.ViewModels;

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
            //return View("MyView");

            // Using strongly typed view
            return View("MyView", emp);
        }

        public ActionResult ViewVM()
        {
            Employee emp = new Employee();
            emp.firstName = "Mike";
            emp.lastName = "Topping";
            emp.salary = 16500;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.employeeName = emp.firstName + " " + emp.lastName;
            vmEmp.salary = emp.salary.ToString("C");

            if (emp.salary > 15000)
            {
                vmEmp.salaryColour = "yellow";
            }
            else
            {
                vmEmp.salaryColour = "green";
            }

            vmEmp.userName = "Admin";

            return View("MyVMView", vmEmp);
        }

        public ActionResult ViewListVM()
        {
            EmployeeListViewModel employeeList = new EmployeeListViewModel();

            EmployeeBusinessLayer empBusiness = new EmployeeBusinessLayer();

            // Populates employee list using EmployeeBusinessLayer.cs
            List<Employee> employees = empBusiness.GetEmployees();

            // Creates empty list of ViewModel employees
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            // For each employee in populated list of employees
            foreach (Employee empItem in employees)
            {
                // Creates new instance a single ViewModel employee
                EmployeeViewModel empViewModel = new EmployeeViewModel();

                // Assigns values found in list of employees (model list)
                empViewModel.employeeName = empItem.firstName + " " + empItem.lastName;
                empViewModel.salary = empItem.salary.ToString("C");

                if (empItem.salary > 20000)
                {
                    empViewModel.salaryColour = "yellow";
                }
                else
                {
                    empViewModel.salaryColour = "green";
                }

                // The ViewModel employee is added to the ViewModel list of employees
                empViewModels.Add(empViewModel);
            }

            // "employeeList" is set to = the ViewModel list of employees
            // This is done because "empViewModels" is of a type 'List' 
            // - and "MyVMListView" requires that a type of 'EmployeeListViewModel' is passed to it i.e. "employeeList"
            employeeList.employees = empViewModels;
            employeeList.userName = "Admin";

            return View("MyVMListView", employeeList);
        }

    }
}
