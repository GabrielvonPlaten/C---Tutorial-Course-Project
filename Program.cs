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
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
                Console.WriteLine("Your number is " + userInputAsInt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Your input was not a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The value was empty. Null.");
            }

            Console.Read();
        }

    }
}
