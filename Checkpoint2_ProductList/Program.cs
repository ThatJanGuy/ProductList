using Checkpoint2_ProductList;

Console.WriteLine("Let's make a  product list.\n");
ProductList myProductList = new ProductList();

myProductList.Add();

Console.WriteLine();
myProductList.Display("jan");

Console.WriteLine("\nWould you like to add more products?");
while (true)
{
    Console.Write("(y/n) > ");
    char addMore = Console.ReadKey().KeyChar;

    if(addMore != 'y' && addMore != 'n')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nOnly 'y' and 'n' are valid inputs.");
        Console.ResetColor();
    }
    else if (addMore == 'y')
    {
        Console.Clear();
        myProductList.Add();
        myProductList.Display();
        Console.WriteLine("\nWould you like to add more products?");

    }
    else
    {
        break;
    }
} 

