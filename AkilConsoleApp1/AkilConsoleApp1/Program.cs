BeverageDecision:
Console.WriteLine("Do you want to order a Beverage, Type 'C' for Coffee, Type 'T' for Tea");
string userDecision = Console.ReadLine();

if (userDecision.Equals("C"))
{
CoffeeSize:
    Console.WriteLine("What Size ? '1' - small 2 - 'medium', 3 - 'Large'");
    string sizeOfCoffee = Console.ReadLine();
    int size = Int32.Parse(sizeOfCoffee);

    switch (size)
    {
        case 1:
            Console.WriteLine("Small coffee is 1 dollar");
            break;

        case 2:
            Console.WriteLine("medium coffee is 2 dollar");
            break;

        case 3:
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
    Console.WriteLine("What Size ? 's' - small m - 'medium', l - 'Large'");
}
else
{
    Console.WriteLine("Invalid Input");
    goto BeverageDecision;
}
