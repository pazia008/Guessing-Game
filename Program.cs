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

            string Level = "Choose a levle: EASY, MEDIUM or HARD (E/M/H)";
            Console.Write($"{Level}");
            string LevelAnswer = Console.ReadLine().ToLower();

            if (LevelAnswer == "e")
            {
                while (CurrentGuesses < 9)
                {
                    string Guess = Console.ReadLine();
                    int GuessNumbers = Int32.Parse(Guess);

                    if (GuessNumbers == SecretNumber)
                    {
                        Console.WriteLine("PROUD OF YOU!!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/8)");
                        break;

                    }
                    else if (GuessNumbers > SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/8)");
                        Console.WriteLine("....Your Guess Was Too High");
                        CurrentGuesses++;

                    }
                    else if (GuessNumbers < SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/8)");
                        Console.WriteLine("....Your Guess Was Too Low");
                        CurrentGuesses++;

                    };

                }
            }
            else if (LevelAnswer == "m")
            {
                while (CurrentGuesses < 7)
                {
                    string Guess = Console.ReadLine();
                    int GuessNumbers = Int32.Parse(Guess);

                    if (GuessNumbers == SecretNumber)
                    {
                        Console.WriteLine("PROUD OF YOU!!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/6)");
                        break;

                    }
                    else if (GuessNumbers > SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/6)");
                        Console.WriteLine("....Your Guess Was Too High");
                        CurrentGuesses++;

                    }
                    else if (GuessNumbers < SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/6)");
                        Console.WriteLine("....Your Guess Was Too Low");
                        CurrentGuesses++;

                    };
                }
            }
            else if (LevelAnswer == "h")
            {
                while (CurrentGuesses < 4)
                {
                    string Guess = Console.ReadLine();
                    int GuessNumbers = Int32.Parse(Guess);

                    if (GuessNumbers == SecretNumber)
                    {
                        Console.WriteLine("PROUD OF YOU!!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/3)");
                        break;

                    }
                    else if (GuessNumbers > SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/3)");
                        Console.WriteLine("....Your Guess Was Too High");
                        CurrentGuesses++;

                    }
                    else if (GuessNumbers < SecretNumber)
                    {
                        Console.WriteLine("YOU have FAILED!");
                        Console.WriteLine($"you are on guess {CurrentGuesses}");
                        Console.WriteLine($"({CurrentGuesses}/3)");
                        Console.WriteLine("....Your Guess Was Too Low");
                        CurrentGuesses++;

                    };
                };
            }
        }
    }
}
