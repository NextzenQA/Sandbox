using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TempCSharpProject.Support
{
    public class MethodChaining
    {
        public static Intern intern;
        public MethodChaining Method1()
        {
            return this;
        }
        public int Method2()
        {
            return 0;
        }
        public void Method3()
        {

        }
    }
}
