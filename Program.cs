using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the seCreT number?");
            Console.WriteLine("--------------------------------");

            string Guess = Console.ReadLine();
            int GuessNumbers = Int32.Parse(Guess);
            int SecretNumber = 69;

            void Attempt()
            {
                while (GuessNumbers != SecretNumber)
                {
                    if (GuessNumbers == SecretNumber)
                    {
                        Console.WriteLine("PROUD OF YOU");
                    }
                    else
                    {
                        Console.WriteLine("YOU have FAILED!");
                    };
                }

            }
            Attempt();
        }
    }
}
