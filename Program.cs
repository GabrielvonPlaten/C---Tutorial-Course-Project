using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        // Starting point of my program
        static void Main(string[] args)
        {
            string myName = "Gabriel von Platen";
            string message = "My name is " + myName;
            message = message.ToUpper();

            string newMessage = "THIS IS MY NEW MESSAGE";
            newMessage = newMessage.ToLower();

            Console.WriteLine(message);
            Console.WriteLine(newMessage);
            Console.Read();
        }
    }
}
