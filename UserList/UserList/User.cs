using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    class User
    {
        public string userFirstName { get; set; }
        public string userLastName { get; set; }
        public bool userActive { get; set; }

        public User(string fname, string lname)
        {
            userFirstName = fname;
            userLastName = lname;
            userActive = true;
        }
    }
}