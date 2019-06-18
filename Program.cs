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
            
            int lengthOfText = 0;
            string wholeText = "";

            do
            {
                Console.Write("Please enter a name:");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText = nameOfAFriend;
                
            } while (lengthOfText < 20);

            Console.Write("Thank you. " + wholeText);
            Console.Read();
        }
    }
}
