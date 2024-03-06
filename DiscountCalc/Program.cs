//arve < 10 - 1%
//arve >= 10 && arve < 20 - 5%
//arve >= 20 - 10%

Console.WriteLine("Sisesta arve: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscout(userInput);

Console.WriteLine($"Teie allahindlus on: {discount}");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Teie uus arve allahindlusega {discount}%: {newTotal}");
static double CalculateDiscout(int arve)
{
    if (arve < 10)
    { return 1; }
    else if (arve >= 10 && arve < 20)
    { return 5; }
    else
    { return 10; }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}