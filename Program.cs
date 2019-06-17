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
            int temperature = 500;
            string stateOfMatter;

            //if (temperature < 0)
            //    stateOfMatter = "Solid";
            //else
            //    stateOfMatter = "Liquid";

            // Ternary operators
            stateOfMatter = temperature < 0 ? "Solid" : temperature > 100 ? "Gas" : "Liquid";

            Console.WriteLine("It is {0} degrees C and the state of matter is {1}", temperature, stateOfMatter);
            Console.Read();
        }
    }
}
