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

            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter to increase amount by one.");
                Console.ForegroundColor = ConsoleColor.White;
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            };

            Console.Read();
        }
    }
}
