using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CodeProject.Models
{
    public class EmployeeBusinessLayer
    {
        // Employee.cs is like the schema of a database table
        // This class is the business layer / handles the data of the Employee.cs
        // Additionally, this class is also to be kept separate from the view - hence the EmployeeListViewModel.cs 
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee();
            emp.firstName = "Sophie";
            emp.lastName = "Hall";
            emp.salary = 27000;
            employees.Add(emp);

            emp = new Employee();
            emp.firstName = "Mike";
            emp.lastName = "Topping";
            emp.salary = 16500;
            employees.Add(emp);

            return employees;
        }
         
    }
}