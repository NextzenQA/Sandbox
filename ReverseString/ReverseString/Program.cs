namespace ReverseAString;
public class ReverseString
{
    public static void Main()
    {
        string myName;
        myName = Console.ReadLine();
        //I should print my name in a reverse order
        //alleddav hdanrama ias
        //string[] nextxenTeamMembers = { "Sai", "Karrem", "Ganesh", "Murali", "Sowjanya" };
        //int[] evenNumbers = { 2, 4, 6, 8 };
        // char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
        char[] myCharArray = myName.ToCharArray();
        var start = 0;
        var end = myName.Length - 1;
        while (start < end)
        {
            //Storing
            char temp = myCharArray[start];
            //A
            //Overriding Start Value with End Value
            myCharArray[start] = myCharArray[end];
            //Overriding End Value with temp Value
            myCharArray[end] = temp;
            start++;
            end--;
        }
        Console.WriteLine(new string(myCharArray));
    }
}

