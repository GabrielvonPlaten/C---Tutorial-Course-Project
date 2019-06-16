using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Gabriel";

        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(315, "Michael");
            CheckHighScore(350, "John");
            CheckHighScore(190, "Denis");
            Console.Read();
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("New highscore is " + score + "!");
                Console.WriteLine("It is now held by " + playerName + "!");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                Console.WriteLine("The old highscore could not be broken");
                Console.WriteLine("The highscore is still " + highscore + " and it is held by " + highscorePlayer);
            }
        }
    }
}
