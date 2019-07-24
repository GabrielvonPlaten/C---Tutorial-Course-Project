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

        // Default consturctor
        public Human()
        {
            Console.WriteLine("Constructor called. Object Created");   
        }

        public Human(string firstName, string lastName, string profession)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.profession = profession;
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Paramiterized constructor
        public Human(string firstName, string lastName, string profession, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.profession = profession;
            this.age = age;
        }


        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && lastName != null && profession != null)
            {
                Console.WriteLine("Hi, my name is {0} {1}. I'm {2} years old and I'm a {3}", firstName, lastName, age, profession);
            }
            else if(firstName!= null && lastName != null)
            {
                Console.WriteLine("Hi, my name is {0} {1}", firstName, lastName);
            }
            else if(firstName != null && lastName != null && profession != null)
            {
                Console.WriteLine("Hi, my name is {0} {1}, and I'm a {2}", firstName, lastName, profession);
            }
            else if(firstName != null)
            {
                Console.WriteLine("Hi, my name is {0}", firstName);
            }
        }
    }
}
