using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace HangMan
{



    class Program
    {
        static List<String> wordPool = new List<string>();

        static private String secretWord = "";
        static int[] secretCharPositions;
        static int guessesLeft = 5;

        private static void Main(string[] args)
        {
            CreateWordPool();

            Console.WriteLine("Play a game of hangman? 0 for no, 1 for yes");

            int input = int.Parse(Console.ReadLine());



            if (input == 1)
            {
                Random rng = new(100);
                int lowerBound = 0;
                int upperBound = 4;
                int rInt = rng.Next(lowerBound,upperBound);
                secretWord = wordPool[rInt];
                secretCharPositions = new int[secretWord.Length];
            }

            while (guessesLeft > 0)
            {
                string letterGuessed = (Console.ReadLine());

                if (secretWord.Contains(letterGuessed))
                {
                    for(int i = 0; i < secretWord.Length; i ++)
                    {
                        if (secretWord[i].ToString().Equals(letterGuessed))
                        {
                            secretCharPositions[i] = 1;
                        }
                    }
                    Console.WriteLine("Yay");
                } 
                else
                {
                    guessesLeft--;
                }

            }

        }

        private static void CreateWordPool()
        {

            wordPool.Add("Hello");
            wordPool.Add("house");
            wordPool.Add("Sink");
            wordPool.Add("catepillar");
            wordPool.Add("hydroponics");
        }
    }
}