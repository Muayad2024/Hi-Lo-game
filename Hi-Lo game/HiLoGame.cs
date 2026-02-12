using System;
using System.Collections.Generic;
using System.Text;

namespace Hi_Lo_game
{
    static class HiLoGame     //all the members are static
    {
        private const int MAXIMUM = 10;    //this is a constant and no one can change it
        private static int currentNumber = Random.Shared.Next(1, MAXIMUM + 1);
        private static int nextNumber = Random.Shared.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static int GetPot() { return pot; }

        public static void Guess(bool higher)
        {
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
                

            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong."); 
                pot--;

            }
            currentNumber = nextNumber;
            nextNumber = Random.Shared.Next(1, MAXIMUM + 1);
            Console.WriteLine($"The current number is {currentNumber}");

        }
        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (nextNumber >= half)
            {
                Console.WriteLine($"The current number is {currentNumber}," + $" the next number is at least {half}");
            }
            else
            {
                Console.WriteLine($"The current number is {currentNumber}," +
                $" the next is at most {half}");
            }
            pot--;
        }


    }
}
