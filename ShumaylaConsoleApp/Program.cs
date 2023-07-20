
FoodDecision:
Console.WriteLine("Do you want to order any food, Type 'S' for Sandwich, Type 'P' for Pizza");
string userDecision = Console.ReadLine();

if (userDecision.Equals("S"))
{
SandwichSize:
    Console.WriteLine("What Size ? 1 - 'Small' 2 - 'Medium', 3 - 'Jumbo'");
    string sizeOfSandwich = Console.ReadLine();
    int size = Int32.Parse(sizeOfSandwich);

    switch (size)
    {
        case 1:
            Console.WriteLine("Small Sandwich is 2 dollars");
            break;

        case 2:
            Console.WriteLine("Medium Sandwich is 3 dollars");
            break;

        case 3:
            Console.WriteLine("Jumbo Sandwich is 4 dollars");
            break;

        default:
            Console.WriteLine("Invalid selection");
            goto SandwichSize;
            break;
    }
}

else if (userDecision.Equals("P"))
{
 PizzaSize:
    Console.WriteLine("What Size ? 1 - 'Small' 2 - 'Medium', 3 - 'Large'");
    string sizeOfPizza = Console.ReadLine();
    int size = Int32.Parse(sizeOfPizza);

    switch (size)
    {
        case 1:
            Console.WriteLine("Small Pizza is 6 dollars");
            break;

        case 2:
            Console.WriteLine("Medium Pizza is 8 dollars");
            break;

        case 3:
            Console.WriteLine("Jumbo Pizza is 10 dollars");
            break;

        default:
            Console.WriteLine("Invalid selection");
            goto PizzaSize;
            break;
    }
}

else
{
    Console.WriteLine("Invalid Input");
    goto FoodDecision;
}
