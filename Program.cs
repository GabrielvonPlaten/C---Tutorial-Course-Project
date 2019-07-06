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
            // Create a new class instance
            Human gabriel = new Human();
            // Access public class variables
            gabriel.firstName = "Gabriel";
            gabriel.lastName = "von Platen";
            gabriel.profession = "Web Developer";
            // Call public class methods
            gabriel.IntroduceMyself();
            gabriel.Profession();

            Human michael = new Human();
            michael.firstName = "Michael";
            michael.lastName = "Smith";
            michael.IntroduceMyself();

            Human sara = new Human();
            sara.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
