﻿using System;
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
            Human gabriel = new Human("Gabriel", "von Platen", "Web Developer", 23);
            // Call public class methods
            gabriel.IntroduceMyself();

            Human michael = new Human("Michael", "Smith", "Sales Man");
            michael.IntroduceMyself();

            Human miriam = new Human("Miriam", "Valery");
            miriam.IntroduceMyself();

            Human oscar = new Human("Oscar");
            oscar.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
