using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Duration d1 = new Duration(7800);
            // Console.WriteLine($"{d1.hours} {d1.minutes} {d1.seconds}");
            // Console.WriteLine(d1.ToString());
            Duration d2 = new Duration(3600);

            DateTime d = (DateTime)d1;

            Duration d3 = d1 + d2;
            Console.WriteLine(d3.ToString());
            Console.WriteLine(d);
        }
    }
}
