using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CodeProject.ViewModels
{
    // Employee.cs is a Model -> Business Entity -> One which will represent your business -> Which could represent a table in a database.

    // ViewModel is created to decouble Model from a View. ViewModel -> View Specific Model.
    public class EmployeeViewModel
    {
        public string employeeName { get; set; }
        public string salary { get; set; }
        public string salaryColour { get; set; }
        public string userName { get; set; }
    }
}