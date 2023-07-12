using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavanUnitTestCases.UnitTest
{
    public class CalculatorTests
    {

        [Test]
        public void ValidateMyCalculatorAddFuntionality() {
            
            int a = 5;
            int b = 10;
            int expectedResults = 15;
            // Unit Test = Test a Line or Code or Method or Function
            Calculator calculator = new Calculator();
            int actualResults = calculator.AddTwoNumbers(a, b);
            if (actualResults == expectedResults) 
            {
                Console.WriteLine("Developer is Verygood, Addition Functionality is working properly");
            }
            else
            {
                Console.WriteLine("Developer is Very Bad, Addition is Functionality is not working properly");
            }
        }
        [Test]
        public void ValidateMyCalculatorMultiplicationFuntionality()
        {

            int a = 5;
            int b = 10;
            int expectedResults = 50;
            // Unit Test = Test a Line or Code or Method or Function
            Calculator calculator = new Calculator();
            int actualResults = calculator.MultiplicationTwoNumbers(a, b);
            if (actualResults == expectedResults)
            {
                Console.WriteLine("Developer is Verygood, Multiplication functionality is working properly");
            }
            else
            {
                Console.WriteLine("Developer is Very Bad, Multiplication functionality is not working properly");
            }
        }
        }
}
