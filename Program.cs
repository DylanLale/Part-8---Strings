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

            while (!done) 
            {
                Console.WriteLine("Welcome to Hangman");
                Console.WriteLine("Enter a letter to guess");
                guess = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine("Enter Q to quit");
                //Correct

                
                
                //Incorrect Hangmen
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
                Console.WriteLine(" /|\\ |");
                Console.WriteLine(" /    |");
                Console.WriteLine("      |");
                Console.WriteLine("=========");
            }
            else if (hang == 7)
            {
                Console.WriteLine("  +---+");
                Console.WriteLine("  |   |");
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\ |");
                Console.WriteLine(" / \\ |");
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