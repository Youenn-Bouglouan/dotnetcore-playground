using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var users = new List<string>();

            while (true)
            {
                DisplayMenu();

                var choice = Console.ReadLine();

                users.Add(choice);

                Console.WriteLine("You chose '{0}'", choice);
                
                Console.WriteLine("Full list of users:");
                foreach (var user in users)
                {
                    Console.WriteLine(user);
                }
            }
        }

        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMenu");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static int Add(int i, int j)
        {
            return i + j;
        }
    }
}