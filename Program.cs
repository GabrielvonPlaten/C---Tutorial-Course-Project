using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    // Class names should have the cameCase naming convention
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            int num = 1231342;
            long bigNum = num;

            float myFloat = 13.68f;
            double myNewDouble = myFloat;

            // Explicit conversion
            // Cast double to int
            double myDouble = 167.13;
            int myInt;
            myInt = (int)myDouble;

            // typeConversion
            // Convernt to string type
            string myString = myDouble.ToString(); // "167.13"
            string myFloatString = myFloat.ToString();


            Console.WriteLine(myFloatString);
            Console.Read();
            
        }
    }
}
