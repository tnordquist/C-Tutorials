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

            string input;

        
            input = Console.ReadLine(); 

            if (input == "No".ToLower() || input == "N".ToLower())
            {
                Console.WriteLine("See you next game.");
                return;
            }
            else if (input.Equals("yes".ToLower()) || input.Equals("y".ToLower()))
            {
                Random rng = new(100);
                int lowerBound = 0;
                int upperBound = 4;
                int rInt = rng.Next(lowerBound, upperBound);
                secretWord = wordPool[rInt];
                secretCharPositions = new int[secretWord.Length];
                Console.WriteLine("I take that answer for a yes. Guess a letter");
            } 
            else
            {
                Random rng = new(100);
                int lowerBound = 0;
                int upperBound = 4;
                int rInt = rng.Next(lowerBound, upperBound);
                secretWord = wordPool[rInt];
                secretCharPositions = new int[secretWord.Length];
                Console.WriteLine("Guess a letter");
            }

            while (won == false && guessesLeft > 0)
            {
                string letterGuessed = Console.ReadLine().ToLower();

                if (secretWord.Contains(letterGuessed))
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretCharPositions[i] != 1 && secretWord[i].ToString().Equals(letterGuessed))
                        {
                            secretCharPositions[i] = 1;
                            wordLength++;
                            Console.WriteLine("You guessed correctly");
                        }
                        else if (secretCharPositions[i] == 1 && secretWord[i].ToString().Equals(letterGuessed))
                        {
                            Console.WriteLine("You already guessed that letter");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong guess. You have " + --guessesLeft + " guesses left.");
                }
                Console.Clear();
                if (wordLength == secretWord.Length)
                {
                    won = true;
                }
            }
            if (won == false)
            {
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
            wordPool.Add("Sink");
            wordPool.Add("it");
        }
    }
}