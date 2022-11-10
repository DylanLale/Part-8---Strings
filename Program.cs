using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Part_8___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            int incorrect = 0;
            bool done = false;
            string[] listwords = new string[10];
            listwords[0] = "cow";
            listwords[1] = "headphones";
            listwords[2] = "computer";
            listwords[3] = "canada";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "photo";
            listwords[7] = "apples";
            listwords[8] = "orange";
            listwords[9] = "melons";
            Random generator = new Random();
            int idx = generator.Next(0, 9);
            StringBuilder mysteryWord = new StringBuilder();
            StringBuilder mysteryWord = new StringBuilder();

            (mysteryWord.ToString) = listwords[idx];
            string guess = new string[mysteryWord.Length];
            Console.WriteLine("Welcome to Hangman");
            Console.Write("Please enter your guess: ");

            while (!done)
            {
                for (int p = 0; p < mysteryWord.Length; p++)
                    guess[p] = '*';

                while (!done)
                {
                    char playerGuess = char.Parse(Console.ReadLine());
                    for (int i = 0; i < mysteryWord.Length; i++)
                    {
                        if (playerGuess == mysteryWord[i])
                            guess[i] = playerGuess;

                        else if (playerGuess != mysteryWord[i])
                        {
                            incorrect =+ 1;
                        }
                    }
                   
                    Console.WriteLine(guess);
                    //Incorrect
                    //

                    /*
                    if (incorrect == 0)
                    {
                        DrawMan(1);
                        Console.Beep();
                    }
                    if (incorrect == 1)
                    {
                        DrawMan(2);
                        Console.Beep();
                    }
                    if (incorrect == 2)
                    {
                        DrawMan(3);
                        Console.Beep();
                    }
                    if (incorrect == 3)
                    {
                        DrawMan(4);
                        Console.Beep();
                    }
                    if (incorrect == 4)
                    {
                        DrawMan(5);
                        Console.Beep();
                    }
                    if (incorrect == 5)
                    {
                        DrawMan(6);
                        Console.Beep();
                    }
                    if (incorrect == 6)
                    {
                        DrawMan(7);
                        Console.Beep();
                        done = true;
                    }




                }

            }

          /*public static void DrawMan(int hang)
            {
                if (hang == 1)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                }
                else if (hang == 2)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                }
                else if (hang == 3)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                }
                else if (hang == 4)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                }
                else if (hang == 5)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                }
                else if (hang == 6)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" /    |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                }
                else if (hang == 7)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" / \\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");

                }

                else if (hang == 8)
                {
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" \\O/  |");
                    Console.WriteLine("  |   |");
                    Console.WriteLine(" / \\  |");
                    Console.WriteLine("=========");
                
                }
          */
                }
            }        }
        }    
}
