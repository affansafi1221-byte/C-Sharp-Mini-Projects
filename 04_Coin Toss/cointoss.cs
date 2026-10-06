using System;

namespace C_Sharp_Mini_Projects
{
    internal class cointoss
    {
        public static void Run()
        {
            Random random = new Random();

            Console.WriteLine("===== Coin Toss =====");
            Console.Write("Choose Heads or Tails: ");

            string guess = Console.ReadLine();

            int coin = random.Next(0, 2);

            string result;

            if (coin == 0)
            {
                result = "Heads";
            }
            else
            {
                result = "Tails";
            }

            Console.WriteLine("Coin: " + result);

            if (guess.ToLower() == result.ToLower())
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}