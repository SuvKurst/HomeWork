using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод подсчета количества цифр числа.

            Console.WriteLine("Введите число.");
           
                int n = int.Parse(Console.ReadLine());
                int count = 0;

                while (n != 0)
                {
                    count++;
                    n = n / 10;
                }
                Console.WriteLine($"Число состоит из {count} символов.");
          
        }
    }
}
