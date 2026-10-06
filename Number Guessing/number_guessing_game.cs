using System;

namespace C_Sharp_Mini_Projects
{
    internal class number_guessing_game
    {
        public static void Run()
        {
            Random random = new Random();

            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("===== Number Guessing Game =====");
            Console.WriteLine("I have chosen a number between 1 and 100.");
            Console.WriteLine("Try to guess it!");

            while (guess != secretNumber)
            {
                Console.Write("\nEnter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the number!");
                    Console.WriteLine("Attempts: " + attempts);
                }
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}