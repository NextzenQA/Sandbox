using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShumaylaSeleniumTestProject
{
    interface IMarriages
    {
        int Expenditure();

        string MarriageProcess();
    }
    interface Computer
    {
        int ModelNumber();
        string CompanyName();
    }

    class Laptop : Computer
    {
        public int ModelNumber()
        {
            return 10101;
        }
        public string CompanyName()

        {
            return "Apple";
        }

    }

    class Desktop : Computer
    {
        public int ModelNumber()
        {
            return 20202;
        }
        public string CompanyName()

        {
            return "Dell";
        }

    }
    interface IDeathCeremony
    {

        int Expenditure();

        string CremationProcess();

    }
}




