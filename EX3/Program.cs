using System;

namespace EX3
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            Console.WriteLine("Введите координаты первой точки по Х?");
            string xFirst = Console.ReadLine();
            Double x1 = Convert.ToDouble(xFirst);
            Console.WriteLine("и по Y?");
            string yFirst = Console.ReadLine();
            Double y1 = Convert.ToDouble(yFirst);
            Console.WriteLine("Введите координаты второй точки по Х?");
            Double x2 = Convert.ToDouble(Console.ReadLine()); //Сократил написание и перевод из строки в дабл
            Console.WriteLine("и по Y?");
            Double y2  = Convert.ToDouble(Console.ReadLine());

            var dis = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            

            Console.WriteLine($"Расстояние между точками составляет - {dis}");
            
            
            static Double Dist(Double x1, Double y1, Double x2, Double y2)
                        {
                return (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
                        };
            Double dist1 = Dist(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками составляет - {dist1}"); //Посчитанно методом

        }   
        
    }
}
