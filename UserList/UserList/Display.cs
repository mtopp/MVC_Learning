﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    class Display
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose from the options below:"
                + "\n"
                + "\n1. Add User"
                + "\n2. View User List"
                + "\n3. Remove User"
                + "\n4. Exit"
                + "\n");
        }

        public static void IncorrectOption()
        {
            Console.Write("The value you entered was incorrect."
                + "\n"
                + "\nPress Enter to try again."
                + "\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void UserFirstName()
        {
            Console.WriteLine("Enter Users First Name"
                + "\n");
        }

        public static void UserLastName()
        {
            Console.Clear();
            Console.WriteLine("Enter Users Last Name"
                + "\n");
        }

        public static void AddUserSuccess(string fName, string lName)
        {
            Console.Clear();
            Console.WriteLine("The User {0} {1} has been added!", fName, lName);
            Console.WriteLine("\n\n\nPress Enter to Continue.");
        }

        public static void ListAllUsers(List<User> users)
        {
            Console.WriteLine("User List"
            + "\n------------"
            + "\n");

            var allUsers = users.Select(user => user.userFirstName + " " + user.userLastName);
            int i = 1;

            foreach (var user in allUsers)
            {
                Console.WriteLine("{0}. {1}", i, user
                    + "\n");
                i++;
            }
        }

        public static void ListEmpty()
        {
            Console.WriteLine("User List is Empty!");
        }

        public static void RemoveUser()
        {
            Console.WriteLine("\n\nEnter the corresponding number next to the user you want to remove.");
        }
    }
}
