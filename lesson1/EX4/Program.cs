using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a}, {b}");

         
            int d = 1;
            int f = 2;
 
            d = d + f;
            f = f - d;
            f = -f;
            d = d - f;
            Console.WriteLine($"{d}, {f}");
        }
    }
}
