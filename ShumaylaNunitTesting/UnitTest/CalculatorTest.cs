using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShumaylaNunitTesting.UnitTest;

namespace ShumaylaNunitTesting.UnitTest
{
    
    
        public class CalculatorTest
        {
            [Test]
            public void VaidateMyCalculatorAddFunctionality()
            {
                int a = 3;
                int b = 5;
                int expectedResult = 8;
                //Unjit test = tests a line of code or method or function
                Calculator calculator = new Calculator();
                int actualResult = calculator.AddTwotNumber(a, b);
                if (actualResult == expectedResult)
                {
                    Console.WriteLine("Oh god my developer is awesome, addition functionality is working great");
                }
                else
                {

                }
                Console.WriteLine("Oh god! I suck, I don't even know how to sum");
            }
        }
    
  
    /*  [Test]
        public void VaidateMyCalculatorMultiplicationFunctionality()
            {
             int a = 3;
             int b = 5;
             int expectedResult = 15;
            //Unjit test = tests a line of code or method or function
             Calculator calculator = new Calculator();
            int actualResult = calculator.MultiplicationTwoNumbers(a, b);
             if (actualResult == expectedResult)
             {
                Console.WriteLine("Multiplication successfull");
             }
            else
            {
                Console.WriteLine("Mutiplication failed");
            }
    }   */
 }


