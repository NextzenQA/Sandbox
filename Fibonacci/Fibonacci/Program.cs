namespace Fibonacci;

public class FibonacciWork{



    public static void Main() {
        //Prime Numbers
        //2,3,5,7,11,13,17,.....
        //user will input a number, I should tell him 
        //Take user Input as String
        string userInput = Console.ReadLine();

        //Parse input string to integer
        int userInputtedNumber = Int32.Parse(userInput);
        bool isPrime = true;
        switch (userInputtedNumber) { 
            case 0:
            case 1:
                isPrime = false;
                break;

            case 2:
                break;

            default:
                for (int x=2; x < userInputtedNumber/2; x++) {
                    //my loop runs from 2 to half of whatever user gave
                    if (userInputtedNumber % x == 0) {
                        isPrime = false;
                        break;
                    }
                }
                break;
        }


        if (isPrime)
        {
            Console.WriteLine($"{userInputtedNumber} is a prime number");
        }
        else {
            Console.WriteLine($"{userInputtedNumber} is not a prime number");
        }

    }
    public static void Fibonacci() {

        Console.WriteLine("Hello Ganesh");

       
        // 0 1 1 2 3 5 8 13 
        //8

        //Take user Input as String
        string userInput = Console.ReadLine();

        //Parse input string to integer
        int userInputtedNumber = Int32.Parse(userInput);

        //Variable declarions
        int a = 0, b = 1, c = 0;

        Console.Write($"{a} {b}");

        //
        for (int x =0; x< userInputtedNumber; x++) {
            //My next number in fibonacci sereies
            c = a + b;
            Console.Write($" {c}");
            //My first number should become second number
            a = b;

            //My second number should become the next number in fibonacci sereies
            b = c;

        }

    }
}