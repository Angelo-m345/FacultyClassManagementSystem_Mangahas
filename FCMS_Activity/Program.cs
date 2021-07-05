using System;

namespace UI.Activity
{
    public class Program  //This class is the main method of the program.
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========FACULTY CLASS MANAGEMENT SYSTEM==========");


            USERLogin UL = new USERLogin();

            UL.Login();
        }
    }
}
