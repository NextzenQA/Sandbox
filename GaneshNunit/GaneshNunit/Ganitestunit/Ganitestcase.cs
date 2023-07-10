using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GaneshNunit.Ganitestunit.Calulatordev;

namespace GaneshNunit.Ganitestunit

{
    public class CalculaorTest
    {
        [Test]

        public void validateMyCalculatorAddFunctionality()
        {

            int a = 3;
            int b = 5;
            int expectedResult = 8;

            Calculator calculator = new Calculator();
            int actualResult = calculator.AddTwoNumbers(a, b);
            if (actualResult == expectedResult)
            {
                Console.WriteLine("Oh god ! I am awesome, addition functionality is working great");
            }
            else
            {

                Console.WriteLine("Oh god ! I suck, I dont even know how to sum");

            }


        }
        [Test]

        public void validateMyCalculatorMultiplicationFunctionality()
        {
            int a = 3;
            int b = 5;
            int expectedResult = 15;

            Calculator calculator = new Calculator();
            int actualResult = calculator.MultiplicationTwoNumbers(a, b);
            if (actualResult == expectedResult)
            {
                Console.WriteLine("Oh god ! I am awesome, Multiplication functionality is working great");
            }
            else
            {

                Console.WriteLine("Oh god ! I suck, I dont even know how to Multiply");
            }



        }
    }
}
