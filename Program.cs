﻿using System.ComponentModel.Design;

namespace Part_8___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int incorrect = 0;
            bool done = false;
            string guess;
            string word = "COMPUTER";
            string displayWord = "--------";
            DrawMan(1);
            Console.WriteLine(displayWord);
            Console.WriteLine();
            while (!done) 
            {
                Console.WriteLine("Welcome to Hangman");
                Console.WriteLine();
                Console.WriteLine("Enter a letter to guess");
                Console.WriteLine("Enter Q to quit");
                guess = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine();
                //Correct
                if (guess == "C")
                {
                    Console.WriteLine(word[0]);
                }

                else if (guess == "O")
                {
                    Console.WriteLine(word[1]);
                }

                else if (guess == "M")
                {
                    Console.WriteLine(word[2]);
                }

                else if (guess == "P")
                {
                    Console.WriteLine(word[3]);
                }

                else if (guess == "U")
                {
                    Console.WriteLine(word[4]);
                }

                else if (guess == "T")
                {
                    Console.WriteLine(word[5]);
                }

                else if (guess == "E")
                {
                    Console.WriteLine(word[6]);
                }

                else if (guess == "R")
                {
                    Console.WriteLine(word[7]);
                }
                else
                {
                    incorrect += 1;
                }
                
                //Incorrect            
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
                //QUIT
                if (guess == "Q")
                    done = true;
                
                
            }
            
        }
        public static void DrawMan(int hang)
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
}        
    }
}