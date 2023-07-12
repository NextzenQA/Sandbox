using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempCSpecfloeProject.Support
{
    public class Intern
    {
        public string Firstname;

        public string Lastname;

        public string University;

        public static string IntershipRole = "Trainee QA Engineer";
        public void GetTheBackground() {
            Console.WriteLine("My name is " + Firstname + " " + Lastname +
                " I am from " + University + " They are working as " + IntershipRole);
        }

        public static void PrintHisRole()
        {
            Console.WriteLine(IntershipRole);
        }


    }

   


}
