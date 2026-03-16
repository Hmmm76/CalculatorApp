namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine($"Сборът е: {calc.Sum(5, 3)}");
    }
}