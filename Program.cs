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
            //for(int counter = 0; counter < 50; counter += 5)
            //{
            //    Console.WriteLine(counter + 5);
            //}

            for(int counter = 1; counter < 20; counter+= 2)
            {
                Console.WriteLine(counter);
            }

            Console.Read();
        }
    }
}
