using System.Data.Common;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

namespace HangMan
{



    class Program
    {
        static List<String> wordPool = new List<string>();

        static private String secretWord = "";
        static int[] secretCharPositions;
        static int guessesLeft = 5;
        static int wordLength = 0;
        static bool won = false;

        private static void Main(string[] args)
        {
            CreateWordPool();

            Console.WriteLine("Play a game of hangman? Yes or No?");

            string input = Console.ReadLine().ToLower();

            if (input == "No".ToLower() || input == "N".ToLower())
            {
                Console.WriteLine("See you next game.");
                return;
            }
            else
            {
                Random rng = new(100);
                int lowerBound = 0;
                int upperBound = 4;
                int rInt = rng.Next(lowerBound, upperBound);
                secretWord = wordPool[rInt];
                secretCharPositions = new int[secretWord.Length];
                Console.WriteLine("I take that answer for a yes. Guess a letter");
                input = Console.ReadLine().ToLower();
            }

            while (won == false && guessesLeft > 0)
            {

                if (secretWord.Contains(input))
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretCharPositions[i] == 1 && secretWord[i].ToString().Equals(input))
                        {
                            Console.WriteLine("You already guessed that letter. Try another letter. You have " + guessesLeft + " guesses left.");
                            Console.Clear();
                            input = Console.ReadLine().ToLower();

                        }
                        else if (secretCharPositions[i] != 1 && secretWord[i].ToString().Equals(input))
                        {
                            secretCharPositions[i] = 1;
                            wordLength++;
                            Console.WriteLine("You guessed correctly; you have " + guessesLeft + " guesses left. Guess again");
                            
                        }
                        
                    }
                }
                else if (guessesLeft == 1)
                {
                    --guessesLeft;
                    won = false;
                }
                else
                {
                    Console.WriteLine("Wrong guess. You have " + --guessesLeft + " guesses left.");
                    Console.WriteLine(MakeHangMan(guessesLeft));
                }
                if (wordLength == secretWord.Length)
                {
                    won = true;
                }
                input = Console.ReadLine();
            }
            if (won == false)
            {
                Console.WriteLine(MakeHangMan(guessesLeft));
                Console.WriteLine("Sorry, you are out of guesses: the correct word was " + secretWord);
            }
            else
            {
                Console.WriteLine("You won: the correct word was " + secretWord);
            }
        }

        private static void CreateWordPool()
        {

            wordPool.Add("low");
            wordPool.Add("pillar");
            wordPool.Add("house");
            wordPool.Add("Sink".ToLower());
            wordPool.Add("it");
        }

        public static string MakeHangMan(int GuessesLeft)
        {
            switch (guessesLeft)
            {
                case 4:
                    return "   __\n /x x\\\n  --- ";
                case 3:
                    return "   __\n /x x\\\n  --- \n   |";
                case 2:
                    return "   __\n /x x\\\n  --- \n__ | __";
                case 1:
                    return "   __\n  /x x\\\n   --- \n __ | __\n    |";
                case 0:
                    return "   __\n  /x x\\\n   --- \n __ | __\n    |\n   / \\";
                default:
                    return "";
            }
            
        }
    }
}