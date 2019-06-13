using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        // Contants as fields
        // They are inside the class but outside the methods
        const double PI = 3.14;
        const int weeks = 52, months = 12;
        const string birthday = "1995-09-06";
        const string birthday2 = "06-09-1995";

        static void Main(string[] args)
        {
            Console.WriteLine("I was born at {0}. In another format: {1}", birthday, birthday2);
            Console.Read();
        }
    }
}
