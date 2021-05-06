using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. 



            int a; 
            int b = 0;
                do
                {
                    Console.WriteLine("Введите любые целые числа.");
                    a = int.Parse(Console.ReadLine());

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
