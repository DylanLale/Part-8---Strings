using System.ComponentModel.Design;
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
            string guess;
            string word = "COMPUTER";
            string displayWord = "--------";
            StringBuilder sb1 = new StringBuilder(displayWord);
            IndexOf(word);
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
                Thread.Sleep(2000);
                //Correct
                if (guess == "C")
                {
                    
                    displayWord.Remove(0,1);
                    Console.WriteLine(displayWord.Insert(0, "C"));
                }

                if (guess == "O")
                {                
                    displayWord.Remove(1,2);
                    Console.WriteLine(displayWord.Insert(1, "O"));
                }

                else if (guess == "M")
                {
                    displayWord.Remove(1,3);
                    Console.WriteLine(displayWord.Insert(2, "M"));
                }

                else if (guess == "P")
                {
                    displayWord.Remove(1, 4);
                    Console.WriteLine(displayWord.Insert(3, "P"));
                }

                else if (guess == "U")
                {
                    displayWord.Remove(1, 5);
                    Console.WriteLine(displayWord.Insert(4, "U"));
                }

                else if (guess == "T")
                {
                    displayWord.Remove(1, 6);
                    Console.WriteLine(displayWord.Insert(5, "T"));
                }

                else if (guess == "E")
                {
                    displayWord.Remove(1, 7);
                    Console.WriteLine(displayWord.Insert(6, "E"));
                }

                else if (guess == "R")
                {
                    displayWord.Remove(1, 8);
                    Console.WriteLine(displayWord.Insert(7, "R"));
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