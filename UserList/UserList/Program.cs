﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    // Try and create a class that is a List<User> that handles all UserList methods.
    class Program
    {
        private static List<User> usersList;

        public static void Main()
        {
            Display.MainMenu();
            Input input = new Input();
            int selection = input.menuOption();

            switch (selection)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    ListUsers();
                    break;
                //case 3:
                //    RemoveUser();
                //    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Display.IncorrectOption();
                    Main();
                    break;
            }
        }

        static Program()
        {
            usersList = new List<User>();
        }

        public static List<User> UserList
        {
            get { return usersList; }
            set { usersList = value; }
        }

        private static void AddUser()
        {
            Display.UserFirstName();
            Input input = new Input();
            var fName = input.userFirstName();
            Display.UserLastName();
            var lName = input.userLastName();
            UserList.Add(new User(fName, lName));
            Display.AddUserSuccess(fName, lName);
            Console.ReadLine();
            Main();
        }

        private static void ListUsers()
        {
            if (UserList.Count > 0)
            {
                Display.ListAllUsers(UserList);
            }
            else
            {
                Display.ListEmpty();
            }

            Console.ReadLine();
            Main();
        }

        //private static void RemoveUser()
        //{
        //    if (UserList.Count > 0)
        //    {
        //        Display.ListAllUsers(UserList);
        //        Display.RemoveUser();
        //        Input input = new Input();
        //        try
        //        {
        //            int userNum = input.RemoveUser();
        //        }
        //        catch (ArgumentException e)


        //    }
        //    else
        //    {
        //            Display.ListEmpty();
        //        }

        //        Console.ReadLine();
        //        Main();
        //    }
        //}
    }
}