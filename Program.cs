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
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operator
            num3 = -num1;
            Console.WriteLine("Num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is sunny? {0}", !isSunny);

            int num = 0;
            num++;
            Console.WriteLine("Num is {0}", num); // 1
            Console.WriteLine("Num is {0}", num++); // 1 | post increment
            Console.WriteLine("Num is {0}", ++num); // 3 | pre increment

            // decrement operator
            num--;
            Console.WriteLine("Num is {0}", num); // 2
            Console.WriteLine("Num is {0}", num--); // 2
            Console.WriteLine("Num is {0}", --num); // 0

            double result;
            double doubleNum1 = num1; 
            double doubleNum2 = num2;

            result = num1 + num2;
            Console.WriteLine("Result of num1({0}) + num2({1}) is {2}", num1, num2, result); // 8
            result = num1 - num2;
            Console.WriteLine("Result of num1({0}) - num2({1}) is {2}", num1, num2, result); // 2
            result = num1 * num2;
            Console.WriteLine("Result of num1({0}) * num2({1}) is {2}", num1, num2, result); // 15
            result = doubleNum1 / doubleNum2;
            Console.WriteLine("Result of num1({0}) / num2({1}) is {2}", num1, num2, result); // 1
            result = num1 % num2;
            Console.WriteLine("Result of num1({0}) % num2({1}) is {2}", num1, num2, result); // 1

            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("Result of {0} > {1} is {2}", num1, num2, isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of {0} == {1} is {2}", num1, num2, isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result of {0} != {1} is {2}", num1, num2, isEqual);

            // Conditional operator
            bool isLowerAndSunny;

            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result of {0} && {1} is {2}", isLower, isSunny, isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Result of {0} || {1} is {2}", isLower, isSunny, isLowerAndSunny);

            Console.Read();
        }

    }
}
