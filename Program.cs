using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            bool isAdmin = true;
            bool isRegistered = true;
            string username = "";
            username = Console.ReadLine();

            if (isRegistered && username != "" && username.Equals("Admin"))
            {
                Console.WriteLine("Welcome back!");
                Console.WriteLine("Hi there, Admin!");
                Console.WriteLine("Looged in as {0}", username); 
            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Read();
        }

    }
}
