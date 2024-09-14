using System.Linq.Expressions;

namespace PWOlab;

public class Week1e7
{
    private static string addbinary(string a, string b)
    {
        var tb1 = Convert.ToInt32(a, 2);
        var tb2 = Convert.ToInt32(b, 2);
        var sum = tb1 + tb2;
        return Convert.ToString(sum, 2);
    } 
    public static void Week7()
    {
        Console.WriteLine("Enter first Binary: ");
        var a = Console.ReadLine();
        Console.WriteLine("Enter second Binary: ");
        var b = Console.ReadLine();
        Console.WriteLine($"Sum of {a} and {b} is {addbinary(a, b)}");
    }
}