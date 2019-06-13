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
            Console.WriteLine("Result: " + Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.Write("Please enter the first number: ");
            string numberInput = Console.ReadLine();
            Console.Write("Please enter the second number: ");
            string numberInput2 = Console.ReadLine();

            int num1 = Int32.Parse(numberInput);
            int num2 = Int32.Parse(numberInput2);
            int result = num1 + num2;

            return result;
        }
    }
}
