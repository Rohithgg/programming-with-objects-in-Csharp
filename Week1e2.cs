class Week1e2 {
    public static int distance_cal(int ms, int t)
    {
        var dis = ms * t;
        return dis;
    }
    
    public static void Week2()
    {
        Console.WriteLine("Enter the speed of the oject: ");
        var ms = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the duration: ");
        var t = int.Parse(Console.ReadLine());
        Console.WriteLine($"The Distance : {distance_cal(ms, t)} meters");
    }
}