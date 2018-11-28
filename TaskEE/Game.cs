using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEE
{
    public class Game
    {
        internal int tries;
        internal int secretNumber;

        public Game()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 300);
        }

        public void Play()
        {
            Console.WriteLine("Try to guess a number from 1 to 300");

            while (true)
            {
                Console.Write("Enter the number: ");

                if (Check(Console.ReadLine()))
                {
                    break;
                }
                tries++;
            }
            Console.WriteLine($"Correct number: {secretNumber}, unsuccseful tries: {tries}");
        }

        internal bool Check(string input)
        {
            if (int.TryParse(input, out int result))
            {
                if (result == secretNumber)
                    return true;
                else if (result > secretNumber)
                    Console.WriteLine("Too much");
                else
                    Console.WriteLine("Too little");
            }
            else
            {
                Console.WriteLine("Numbers only!");
            }
            return false;
        }
    }
}
