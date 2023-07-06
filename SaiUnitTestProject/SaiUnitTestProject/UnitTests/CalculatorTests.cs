using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiUnitTestProject.UnitTests
{
    public class CalculatorTests
    {

        [Test]
        public void ValidateMyCalculatorAddFunctionality() { 
            
            //You can organize your tests as units
            //each unit will have a starting point and ending point
            //all of these units are independent
            //unit testing framework supports assertions, which enable us to compare two objects

            //Developers as well as testers

            //Cheap
            //Fast
            //Stable


            int a = 3;
            int b = 5;
            int expectedResult = 8;

            //Unit Test - tests a line of code or method or function
            Calculator calculator = new Calculator();
            int actualResult = calculator.AddTwoNumbers(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ValidateMyCalculatorMultiplicationFunctionality()
        {
            int a = 3;
            int b = 5;
            int expectedResult = 15;

            //Unit Test - tests a line of code or method or function
            Calculator calculator = new Calculator();
            int actualResult = calculator.MultiplicationTwoNumbers(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
