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
            // Read input of user
            Console.Write("Enter a number: ");
            string strInput = Console.ReadLine();
            int intInput1 = Int32.Parse(strInput);
            Console.Write("Enter your second number: ");
            string strInput2 = Console.ReadLine();
            int intInput2 = Int32.Parse(strInput2);
            Console.Write("Your calculated number is ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Add(intInput1, intInput2));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
            

    }
}
