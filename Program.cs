using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Registration();
            Login();
            Console.Read();
        }

        public static void Registration()
        {
            Console.WriteLine("Registration.");
            Console.Write("Enter your username: ");
            username = Console.ReadLine();
            Console.Write("Your password: ");
            password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Registration completed!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Login.");
            Console.Write("Enter your username: ");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Enter your password");
                if (password == Console.ReadLine())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Logged in!");
                    Console.ForegroundColor = ConsoleColor.White;
                } else
                {
                    Console.WriteLine("Login failed");
                }
            } else
            {
                Console.WriteLine("Login failed");
            }
        }

    }
}
