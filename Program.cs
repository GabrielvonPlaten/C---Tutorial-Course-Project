using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        // Starting point of my program
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 24;
            int num3; // 0
            int sum = num1 + num2;
            double d1 = 3.5;
            double d2 = 1.337;
            double sumd = d1 / d2;

            float f1 = 2.4f;
            // Use casting
            // int divDandI = num1 / d1; Cannot divide one data type with another which is different (int and double).

            num3 = 15;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(num1);
            Console.WriteLine("The sum of the doubles is " + sumd);
            Console.Read();
        }
    }
}
