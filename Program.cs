using System.ComponentModel.Design;

namespace Part_8___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int incorrect = 0;
            bool done = false;
            string guess;
            while (!done) 
            {
                Console.WriteLine("Welcome to Hangman");
                Console.WriteLine("Enter a letter to guess");
                guess = Console.ReadLine();
                if (incorrect == 0)
                {
                    DrawMan(1);
                }
                if (incorrect == 1)
                {
                    DrawMan(2);
                }
                if (incorrect == 2)
                {
                    DrawMan(3);
                }
                if (incorrect == 3)
                {
                    DrawMan(4);
                }
                if (incorrect == 4)
                {
                    DrawMan(5);
                }
                if (incorrect == 5)
                {
                    DrawMan(6);
                }
                if (incorrect == 6)
                {
                    DrawMan(7);
                }
                Console.Beep();
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