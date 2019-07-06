using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    // This class is a blueprint for a datatype
    class Human
    {
        // Member variable
        public string firstName = "{Placeholder Name}";
        public string lastName = "{Placeholder Lastname}";
        public string profession = "{Placeholder Profession}";

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, my name is {0} {1}", firstName, lastName);

        }

        public void Profession()
        {
            Console.WriteLine("I am a {0}", profession);
        }
    }
}
