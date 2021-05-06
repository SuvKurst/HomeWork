using System;

//Программа "Анкета"

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ваше имя?");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            string sName = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш рост? (В метрах, через запятую)");
            var tall = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваш вес? (В кг через запятую)");
            var weigh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(string.Format("{0} {1}, {2} лет, {3} см, {4} кг.", name, sName, age, tall, weigh)); //используя форматированный вывод;
            Console.WriteLine($"{name} {sName}, {age} лет, {tall} см, {weigh} кг."); //используя вывод со знаком $.

            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            var I = (weigh / (tall * tall));
            Console.WriteLine($"Ваш индекс тела составляет - {I}");
        }
    }


}
