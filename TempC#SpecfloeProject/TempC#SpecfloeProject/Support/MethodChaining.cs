using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempCSpecfloeProject.Support
{
    public class MethodChaining
    {
        public Intern intern;
        public MethodChaining Method1() {
            return this;
        }

        public ChromeDriver Method2()
        {
            return new ChromeDriver();
        }

        public void Method3()
        {

        }
    }
}
