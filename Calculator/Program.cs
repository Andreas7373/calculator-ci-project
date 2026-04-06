namespace Calculator;

public class Program
{
    public static void Main(string[] args)
    {
        var calc = new Calculator();

        Console.WriteLine("2 + 3 = " + calc.Add(2, 3));
    }
}