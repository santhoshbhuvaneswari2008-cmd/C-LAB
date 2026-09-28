using System;
using System.Threading;
class EvenOddThread
{
    static void DisplayEven()
    {
        Console.WriteLine("Even Number Thread Started");
        for (int i = 2; i <= 10; i += 2)
        {
            Console.WriteLine("Even: " + i);
            Thread.Sleep(400);
        }
    }
    static void DisplayOdd()
    {
        Console.WriteLine("Odd Number Thread Started");
        for (int i = 1; i <= 9; i += 2)
        {
            Console.WriteLine("Odd : " + i);
            Thread.Sleep(400);
        }
    }
    static void Main(string[] args)
    {
        Thread t1 = new Thread(DisplayEven);
        Thread t2 = new Thread(DisplayOdd);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine("Both Threads Completed Successfully.");
        Console.ReadKey();
    }
}
