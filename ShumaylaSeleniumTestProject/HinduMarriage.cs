using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShumaylaSeleniumTestProject
{
    internal class HinduMarriage : IMarriages, IDeathCeremony
    {
        public string CremationProcess()
        {
            return "This is Hindu Cremation Process";
        }
        public int Expenditure()
        {
            return 200000;
        }
        public string MarriageProcess()
        {
            return "Hindu Marriages are in Temple or Banquet Hall";
        }
    }
}
