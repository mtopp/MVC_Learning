﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    class Input
    {
        public int menuOption()
        {
            var userInput = Console.ReadLine();
            int userSelection;
            bool result = Int32.TryParse(userInput, out userSelection);
            Console.Clear();
            return userSelection;
        }

        public string userFirstName()
        {
            var fNameInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(fNameInput))
            {
                return fNameInput;
            }
            else
            {
                return "Blank";
            }

        }

        public string userLastName()
        {
            var lNameInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(lNameInput))
            {
                return lNameInput;
            }
            else
            {
                return "Blank";
            }
        }

        public int RemoveUser()
        {
            throw new NotImplementedException();
        }
    }
}