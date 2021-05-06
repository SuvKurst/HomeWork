using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {

            //а) С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            //Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.


            int a;
            int b = 0;
            do
            {
               
                Console.WriteLine("Введите любые целые числа.");
                int.TryParse(Console.ReadLine(), out a);
                 

                if (a % 2 != 0 && a > 0)
                {
                    b = b + a; //Складываем нечетные положительные числа в В
                }

            }
            while (a != 0);// Повторять пока условие истинно(true)

            Console.WriteLine(Convert.ToString(b));


        }
    }
}
