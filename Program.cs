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
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNum = 0;

            Console.WriteLine("Last number was {0}", currentNum);
            Console.WriteLine("Please enter the next score");
            Console.WriteLine("Current amount of entries {0}", count);
            Console.WriteLine("Please enter -1 once you are ready to calculate the average.");

            while (input != "-1")
            {

                input = Console.ReadLine();
                if(input.Equals("-1"))
                {
                    Console.WriteLine("-----------------------------------------------");
                    // Calculate average
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }

                if (int.TryParse(input, out currentNum) && currentNum > 0 && currentNum < 21)
                {
                    total += currentNum;
                } else
                {
                    if (!input.Equals("-1"))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }

                count++;
            }

            Console.Read();
        }
    }
}
