using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Ввидите ваше имя: ");
                User.Name = Console.ReadLine();
                Console.WriteLine("Ввидите вашу фамилию: ");
                User.LastName = Console.ReadLine();
                Console.WriteLine ("Ввидите ваш логин: ");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.WriteLine("Есть ли у вас домашние животные? Да / Нет?");

                var result = Console.ReadLine();

                if (result == "Да") 
                {
                    User.HasPet = (true);
                }

                else
                {
                    User.HasPet = false;
                }
                Console.WriteLine("Ввидите ваш возраст: ");
                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Ввидите три ваших любимых цвета: ");
                for (int i = 0; i < User.favcolors.Length; i++) 
                {
                    User.favcolors[i] = Console.ReadLine();
                }

            }
        }
    }
}