using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1, 100);

            int Guess = 0;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");
            Console.ForegroundColor = ConsoleColor.White;

            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess < returnValue)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (Guess > returnValue)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is?");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Well done! The answer was " + returnValue);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
