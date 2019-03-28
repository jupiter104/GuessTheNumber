using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 10);

            Console.WriteLine("Guess the secret number between 1 and 10");

            for (int i = 1; i < 5; i++)
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                if (number == secretNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
                else
                    Console.WriteLine("Try again!");
            }
            Console.Read();
        }
    }
}
