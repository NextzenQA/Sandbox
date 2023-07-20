BevarageDecision:
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Do you want to order a Bevarage," +
    "Type 'C' for Coffee, Type 'T' for Tea");
string userDecision = Console.ReadLine();
/*
if (userDecision.Equals("C"))
{
    Console.WriteLine("What Size ? 's' = small, m = medium, 'l' = large ");
}
else if (userDecision.Equals("T")){
    Console.WriteLine("What Size ? 's' = small, m = medium, 'l' = large ");

}
else
{
    Console.WriteLine("Invalid Input");
    goto Label;
}

*/
if (userDecision.Equals("C"))
{
    CoffeeSize:
    Console.WriteLine("What Size ? 's' = small, m = medium, 'l' = large ");
    string sizeOfCoffee = Console.ReadLine();

    switch (sizeOfCoffee)
    {
        case "s":
            Console.WriteLine("Small coffee is 1 dollar");
            break;
        case "m":
            Console.WriteLine("Small coffee is 2 dollar");
            break;
        case "l":
            Console.WriteLine("Small coffee is 3 dollar");
            break;
        default:
            Console.WriteLine("Invalid selection");
            goto CoffeeSize;
            break;
    }
}
else if (userDecision.Equals("T"))
{
    Console.WriteLine("What Size ? 's' = small, m = medium, 'l' = large ");

}
else
{
    Console.WriteLine("Invalid Input");
    goto BevarageDecision;
}

