string yn = "y";
do
{
    Console.Write("\r\nHow many people are we making PB&J sandwiches for? ");
    int numbPeople;
    if (int.TryParse(Console.ReadLine(), out numbPeople))
    {
        int numbPeople2 = numbPeople * 2;
        Console.WriteLine("You need:\r\n");
        Console.WriteLine($"\t{numbPeople2} slices of bread");
        Console.WriteLine($"\t{numbPeople2} tablespoons of peanut butter");
        Console.WriteLine($"\t{numbPeople2 * 2} teaspoons of jelly");
        Console.WriteLine("\r\n\twhich is...\r\n");
        Console.WriteLine("You need:\r\n");
        int loavesBread = (int)(double)Math.Ceiling((double)numbPeople2 / 28);
        Console.WriteLine($"\t{loavesBread} loaves of bread");
        int jarsPB = (int)(double)Math.Ceiling((double)numbPeople2 / 32);
        Console.WriteLine($"\t{jarsPB} jars of peanut butter");
        int jarsJ = (int)(double)Math.Ceiling((double)numbPeople2 * 2 / 48);
        Console.WriteLine($"\t{jarsJ} jars of jelly");
    }
    else
    {
        Console.WriteLine("Sorry, that was not an integer.");
    }
    Console.Write("\r\nWould you like to restart? Enter yes or y to continue, or any other key to exit: ");
    yn = Console.ReadLine();
}
while (yn == "y" || yn == "yes");
Console.WriteLine("Goodbye!");