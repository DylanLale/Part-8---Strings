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
            string guess;
            string word = "COMPUTER";
            string displayWord = "--------";
            StringBuilder sb1 = new StringBuilder(displayWord);
            
            DrawMan(1);
            Console.WriteLine(displayWord);
            Console.WriteLine();
            while (!done) 
            {
                Console.WriteLine("Welcome to Hangman");
                Console.WriteLine();
                Console.WriteLine("Enter a letter to guess");
                Console.WriteLine("Enter Q to quit");
                Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(2000);
                //Correct
                if (word.Contains("C"))
                {
                    
                    displayWord.Remove(0,1);
                    Console.WriteLine(displayWord.Insert(0, "C"));
                }

                if (word.Contains("O"))
                {                
                    displayWord.Remove(1,1);
                    Console.WriteLine(displayWord.Insert(1, "O"));
                }

                else if (word.Contains("M"))
                {
                    displayWord.Remove(2,1);
                    Console.WriteLine(displayWord.Insert(2, "M"));
                }

                else if (word.Contains("P"))
                {
                    displayWord.Remove(3, 1);
                    Console.WriteLine(displayWord.Insert(3, "P"));
                }

                else if (word.Contains("U"))
                {
                    displayWord.Remove(4, 1);
                    Console.WriteLine(displayWord.Insert(4, "U"));
                }

                else if (word.Contains("T"))
                {
                    displayWord.Remove(5, 1);
                    Console.WriteLine(displayWord.Insert(5, "T"));
                }

                else if (word.Contains("E"))
                {
                    displayWord.Remove(6, 1);
                    Console.WriteLine(displayWord.Insert(6, "E"));
                }

                else if (word.Contains("R"))
                {
                    displayWord.Remove(7, 1);
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