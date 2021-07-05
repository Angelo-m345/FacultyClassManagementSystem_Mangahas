using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Activity
{
    public class BSCEStudents //This Class contains list of BSIT students.
                        //called by ViewStudent class
         { 
        public static void BSCE2Students()
        {
            string[] StudentC = {"Ralph Talay     ",
                                 "Francisco Reyes ",
                                 "Rody Bartolome  ",
                                 "Alyanna Romero  ",
                                 "Robert Alarcon  ",
                                 "Andrew Emerson  ",
                                 "Joshua Vilanueva",
                                 "Jason Batumbkal "};

            foreach (string b in StudentC)
            {
                Console.WriteLine(b);
            }
        }
    }
}
