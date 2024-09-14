static class Week1e3
{
    private static double cal_cube(double x)
    {
        return Math.Cbrt(x);
    
    }
    public static void Week3()
    {
        Console.WriteLine("Enter the number :");
        var x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Cube root of {x} is {cal_cube(x)} ");

    }
}
