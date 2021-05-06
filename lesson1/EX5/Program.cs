using System;

namespace EX5
{
    class Program
    {
        static string ItIsMe(String name, String sName, String city)
        {
            string word1 = $"My name is {name} {sName}, í'm from {city}.";
            //Console.SetCursorPosition(Console.WindowWidth / 2 - word1.Length / 2, Console.WindowHeight / 2);
            Console.ReadLine();
            return word1; //Console.WriteLine(world);
        }
        static void Main(string[] args)
        {

            /*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организовать в центре экрана.
            в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).*/

            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            string sName = Console.ReadLine();
            Console.WriteLine("Введите название вашего города: ");
            string city = Console.ReadLine();

            string me = ItIsMe(name, sName, city);

            string word = $"My name is {name} {sName}, í'm from {city}. (Without using method)";

            Console.SetCursorPosition(Console.WindowWidth / 2 - word.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(word); //Вывод без использования созданного метода
            Console.SetCursorPosition(Console.WindowWidth / 2 + 1 - me.Length / 2, Console.WindowHeight / 2 + 1);
            Console.WriteLine(me); //Вывод с использованием созданного метода
            Console.ReadLine();



        }
    }
}
