using System;
using System.Threading;


namespace EX1
{

    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.   


    struct Complex
    {
        public double im;
        public double re;
        
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
       

        //Метод вычитания комплексных чисел

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {



            Complex complex1;
            Console.WriteLine("Введите реальную часть первого числа:");
            complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого числа:");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            Complex complex2;
            Console.WriteLine("Введите реальную часть второго числа:");
            complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго числа:");
            complex2.im = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Какую операцию вы хотите произвести: сложение, вычитание или умножение?");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "сложение":
                    Complex result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "вычитание":
                    result = complex1.Multi(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case "умножение":
                    result = complex1.Minus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
            }

            
            
            
           
           
            
        }
    }
}