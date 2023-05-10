namespace ReverseAString;

public class ReverseString {


    public static void Main() { 
        


        string myName;

        myName = Console.ReadLine();

        //I should print my name in a reverse order
        //alleddav hdanrama ias

        string[] nextxenTeamMembers = { "Sai", "Karrem", "Ganesh", "Murali", "Sowjanya" };
        int[] evenNumbers = { 2, 4, 6, 8};
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

        //How to retrive data from array, nextxenTeamMembers[2]
        //index always start from zero

        //Loops
        //1. convert string to char array

        char[] myCharArray = myName.ToCharArray();

        //{'A', 'M', 'A', 'R', 'N', 'A', 'D', 'H'}

        //{'H', 'M', 'A', 'R', 'N', 'A', 'D', 'A'} - Loop 1

        //{'H', 'D', 'A', 'R', 'N', 'A', 'M', 'A'} - Loop 2

        //{'H', 'D', 'A', 'R', 'N', 'A', 'M', 'A'} - Loop 3

        //{'H', 'D', 'A', 'N', 'R', 'A', 'M', 'A'} - Loop 4

        var start = 0;
        var end = myName.Length - 1;

        //0
        //7
        while (start < end) {
            //Loop 1 - start - 0, 7 - true - all good
            //Loop 2 - start - 1, 6 - true - all good
            //Loop 3 - start - 2, 5 - true - all good
            //Loop 4 - start - 3, 4 - true - all good
            //Loop 5 - start - 4, 3 - False - no entry


            //{'A', 'M', 'A', 'R', 'N', 'A', 'D', 'H'}

            //Storing
            char temp = myCharArray[start];
            //A

            //Overriding Start Value with End Value
            myCharArray[start] = myCharArray[end];
            //{'H', 'M', 'A', 'R', 'N', 'A', 'D', 'H'}

            //Overriding End Value with temp Value
            myCharArray[end] = temp;
            //{'H', 'M', 'A', 'R', 'N', 'A', 'D', 'A'}

            start++;
            end--;
        }



        Console.WriteLine(new string(myCharArray));








    }


}