namespace PWOlab;
using System;
public class Week1e4
{
    public static void Week4()
    {
        Console.WriteLine("Enter the number of random numbers to genarate: ");
        var x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter minimum range: ");
        var mini = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter maximum range: ");
        var max = int.Parse(Console.ReadLine());
        Random rand = new();
        Console.WriteLine("Generated random numbers are: ");
        for (int i = 0; i <= x - 1; i++)
        {
            Console.Write($"{rand.Next(mini, max + 1)} ");
        }
    }
}