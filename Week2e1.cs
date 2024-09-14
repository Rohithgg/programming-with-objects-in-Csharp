namespace PWOlab;

public class Week2e1
{
    private static int Arrow(int nums)
    {
        return 0;
    }
    public static void Week21()
    {
        Console.WriteLine("Enter number :");
        var t = int.Parse(Console.ReadLine());
        var list = new List<string>();
        for (var i = 0; i <= t; i++)
        {
            var ss = new string('>', i);
            list.Add(ss);
        }
        Console.WriteLine(list);
    }
}