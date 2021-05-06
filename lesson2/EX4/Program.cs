using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Реализовать метод проверки логина и пароля.
            // На вход метода подается логин и пароль.
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            // С помощью цикла do while ограничить ввод пароля тремя попытками.

            int count = 3;

            do
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();

                if (login == "root" && password == "GeekBrains")
                {
                    Console.Write("Authorization successfull!");
                    break;
                }
                else
                {
                    Console.Write($"Login or Password wrong, try again! \n");
                }
                count--;
            }
            while (count > 0);
            

        }
    }
}
