using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to hangman");
            PlayGame();

        }
        public static void DrawMan(int hang)
        {
            if (hang == 5)
            {
                Console.WriteLine("  +---+");
                Console.WriteLine("  |   |");
                Console.WriteLine("      |");
                Console.WriteLine("      |");
                Console.WriteLine("      |");
                Console.WriteLine("      |");
                Console.WriteLine("=========");
            }
            else if (hang == 4)
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
            else if (hang == 2)
            {
                Console.WriteLine("  +---+");
                Console.WriteLine("  |   |");
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine("      |");
                Console.WriteLine("      |");
                Console.WriteLine("=========");
            }
            else if (hang == 1)
            {
                Console.WriteLine("  +---+");
                Console.WriteLine("  |   |");
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine(" /    |");
                Console.WriteLine("      |");
                Console.WriteLine("=========");
            }
            else if (hang == 0)
            {
                Console.WriteLine("  +---+");
                Console.WriteLine("  |   |");
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine(" / \\  |");
                Console.WriteLine("      |");
                Console.WriteLine("=========");
            }
        }

        static void PlayGame()
        {
            string[] wordBank = { "Pacman", "Captain", "Gamer", "Ralf", "Gold", "Programming", "tries", "button", "games" };

            int lives = 5;
            bool done = false;
            int RevealedLetters = 0;
            string input;
            char guess;
            Random random = new Random();


            string word = wordBank[random.Next(0, wordBank.Length)];
            string wordUpper = word.ToUpper();

            StringBuilder display = new StringBuilder(word.Length);
            for (int i = 0; i < word.Length; i++)
                display.Append('_');

            List<char> correct = new List<char>();
            List<char> incorrect = new List<char>();

            while (!done && lives > 0)
            {
                DrawMan(lives);
                Console.Write("Guess a letter: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correct.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrect.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordUpper.Contains(guess))
                {
                    correct.Add(guess);

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (wordUpper[i] == guess)
                        {
                            display[i] = word[i];
                        RevealedLetters++;
                        }
                    }

                    if (RevealedLetters == word.Length)
                        done = true;
                }
                else
                {
                    incorrect.Add(guess);

                    Console.WriteLine("No, there are no '{0}' 's in it!", guess);
                    Console.Beep();
                    lives--;
                        
                }

                    Console.WriteLine(display.ToString());
            }

            if (done)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose! The answer was '{0}'", word);

            Console.Write("Press ENTER to quit");
            Console.ReadLine();
        }
    }

}
    


             