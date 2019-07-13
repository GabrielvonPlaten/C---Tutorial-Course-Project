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
        private string firstName;
        private string lastName;
        private string profession;
        private int age;

        // Constructor
        public Human(string firstName, string lastName, string profession, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.profession = profession;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, my name is {0} {1}. I'm {2} years old and I'm a {3}", firstName, lastName, age, profession);
        }
    }
}
