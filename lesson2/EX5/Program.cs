using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Введите вашу массу в кг:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах:");
            double height = Convert.ToDouble(Console.ReadLine());

            double index = weight / (height * 2);

            index = Math.Round(index, 2);

            if (index > 18.5 && index < 25)
            {

                Console.WriteLine($"Индекс составляет {index}. Ваш вес в норме.");
            }
            else if (index < 18.5)
            {
                Console.WriteLine($"Индекс составляет {index}. Ваш вес меньше нормы, рекомендуется набрать пару щёчек)");
            }
            else
            {
                Console.WriteLine($"Индекс составляет {index}. Ваш вес больше нормы, рекомендуется обед разделить с другом, а ужин отдать врагу.");
            }
        }
    }
}
