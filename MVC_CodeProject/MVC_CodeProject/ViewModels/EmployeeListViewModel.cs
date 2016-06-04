using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CodeProject.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> employees { get; set; }
        public string userName { get; set; }
    }
}