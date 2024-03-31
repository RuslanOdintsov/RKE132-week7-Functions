Console.WriteLine("Are you coming or leaving?");
string userChoice = Console.ReadLine();

if (userChoice == "coming")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}


static void PrintHello()
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, KingKong.");
}