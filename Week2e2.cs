namespace PWOlab;

public class Week2e2
{
    
    public static void Week22()
    {
        Console.WriteLine("enter in time: ");
        var intime = int.Parse(Console.ReadLine());
        Console.WriteLine("enter out time: ");
        var outtime = int.Parse(Console.ReadLine());
        Console.WriteLine("enter rate: ");
        var rate = int.Parse(Console.ReadLine());
        Console.WriteLine("enter overtime: ");
        var overtime = double.Parse(Console.ReadLine());
        Console.WriteLine($"{OverTime(intime, outtime, rate, overtime)}");
    }
    static int OverTime(int intime, int outtime, int rate, double overtime)
         {
             double money = 0;
             var din = Convert.ToDouble(intime);
             var dout = Convert.ToDouble(outtime);
             var drate = Convert.ToDouble(rate);
     
             if ((intime >= 9) && (outtime <= 17))
             {
                 money += rate;
             }
             else if (outtime > 17)
             {
                 money += drate * (dout - 17) * overtime;
             }
             return Convert.ToInt32(money);
         }
}
