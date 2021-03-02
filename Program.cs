using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the seCreT number?");
            Console.WriteLine("--------------------------------");


            var random = new Random();
            int SecretNumber = random.Next(1, 100);
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
                        Console.WriteLine($"({CurrentGuesses}/4)");
                        break;
                    }
                    else if (GuessNumbers > SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/4)");
                        Console.WriteLine("....Your Guess Was Too High");
                        CurrentGuesses++;

                    }
                    else if (GuessNumbers < SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/4)");
                        Console.WriteLine("....Your Guess Was Too Low");
                        CurrentGuesses++;

                    };

                }


            }
            Attempt();
        }
    }
}
