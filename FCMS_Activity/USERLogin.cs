﻿using BL.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Activity
{
    public class USERLogin
    {
        public void Login()   //User Login called by Main Method.
                              //Serves as gateway of the system.

        {
            Console.WriteLine("==========User Login==========");
            string usernameC = "PUPuser";
            string passwordC = "P103003";

            string username, password;

            Console.Write("username: ");
            username = Console.ReadLine();
            Console.Write("password: ");
            password = Console.ReadLine();


            if (username == usernameC && password == passwordC)
            {
                Console.WriteLine("Successfully Logged In");
                FacultyoStudent();
            }


            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public static void FacultyoStudent()
        {



            Console.WriteLine("Faculty or Student");
            Console.WriteLine("==================");
            Console.WriteLine("Type S, F, or E");
            Console.WriteLine("S - Student Room Asssignment");
            Console.WriteLine("F - Faculty Assignment");
            Console.WriteLine("E - Exit");
            Console.Write("Type your choice: ");
            char FacultyoStudent = Convert.ToChar(Console.ReadLine());
            FacultyoStudent = char.ToUpper(FacultyoStudent);

            switch (FacultyoStudent)
            {
                case 'S':
                    ViewStudent.Student();
                    break;

                case 'F':
                    ViewFaculty.Faculty();
                    break;

                case 'E':
                    Console.WriteLine("The app is Shuting Down, Thank You!");
                    break;
            }
        }

    }
}
