Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{   PrintHello(); }
else
{   PrintGoodBye(); }

PrintHello();
PrintGoodBye();

static void PrintHello() // Funktsioon / meetod
{    Console.WriteLine("Hello, world!");}

static void PrintGoodBye()
{   Console.WriteLine("Adios amigos!"); }