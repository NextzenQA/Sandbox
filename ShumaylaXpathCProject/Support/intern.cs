using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShumaylaXpathCProject.Support
{
    public class intern
    {
        public string Firstname;

        public string Lastname;

        public string University;

        public static string InternshipRole = "Trainee QA Engineer";
        public void GetTheBackground()
        {
            Console.WriteLine("My Name is" + Firstname + " " + Lastname + 
                "I am from" + University + "They are working as" + InternshipRole);
        }
        public static void PrintHisRole()
        {
            Console.WriteLine(InternshipRole);
        }
    }
  
}
