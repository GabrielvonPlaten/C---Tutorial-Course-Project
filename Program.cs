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
            Console.Write("Insert the temperature: ");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;

            // TryParse outputs a number into a variable and return true if it succeeds, otherwise returns false
            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An invalid value was sent. Temperature was set to 0 by default.");
            }

            Console.ForegroundColor = ConsoleColor.White;
            if (numTemp < 20)
            {
                Console.WriteLine("The temperature is {0}", numTemp);
            } else if (numTemp == 20)
            {
                Console.WriteLine("It's {0} degress C", numTemp);
            } else
            {
                Console.WriteLine("It's mildly warm. {0} C", numTemp);
            }

            Console.Read();
        }

    }
}
