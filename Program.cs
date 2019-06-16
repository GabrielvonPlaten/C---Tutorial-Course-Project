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
            int age = 15;
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young.");
                    break;
                case 25:
                    Console.WriteLine("Old enough");
                    break;
                default:
                    Console.WriteLine("Cannot calculate");
                    break;
            }

            string username = "Gabriel";

            switch (username)
            {
                case "Gabriel":
                    Console.WriteLine("Your name is Gabriel");
                    break;
                case "Root":
                    Console.WriteLine("Your name is Root");
                    break;
                default:
                    Console.WriteLine("Could not read usename");
                    break;
            }

            Console.Read();
        }

    }
}
