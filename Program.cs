using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the seCreT number?");
            Console.WriteLine("--------------------------------");


            int SecretNumber = 42;
            int CurrentGuesses = 1;

            void Attempt()
            {
                while (CurrentGuesses < 5)
                {
                    string Guess = Console.ReadLine();
                    int GuessNumbers = Int32.Parse(Guess);

                    if (GuessNumbers == SecretNumber)
                    {
                        Console.WriteLine("PROUD OF YOU!!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        CurrentGuesses++;

                    };

                }


            }
            Attempt();
        }
    }
}
