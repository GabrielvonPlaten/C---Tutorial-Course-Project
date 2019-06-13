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
            Console.WriteLine(Add(15, 20));
            Console.WriteLine(Multiply(15, 5));
            Console.WriteLine(Divide(25, 13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Return the decimals of the calculated value
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
