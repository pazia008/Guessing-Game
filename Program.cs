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
            int CurrentGuesses = 0;

            void Attempt()
            {
                while (CurrentGuesses < 4)
                {
                    string Guess = Console.ReadLine();
                    int GuessNumbers = Int32.Parse(Guess);
                    if (GuessNumbers == SecretNumber)
                    {
                        Console.WriteLine("PROUD OF YOU!!");
                    }
                    else
                    {
                        Console.WriteLine("YOU have FAILED!");
                        CurrentGuesses++;

                    };

                }


            }
            Attempt();
        }
    }
}
