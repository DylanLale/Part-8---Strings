using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static string[] wordBank = { "Pacman", "Captain", "Gamer", "Ralf", "Gold", "Programming", "tries", "button", "games" };
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to hangman");
            PlayGame();
            DrawMan(5);
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


                static void PlayGame()
                {
                    Random random = new Random();


                    string wordToGuess = wordBank[random.Next(0, wordBank.Length)];
                    string wordToGuessUppercase = wordToGuess.ToUpper();

                    StringBuilder display = new StringBuilder(wordToGuess.Length);
                    for (int i = 0; i < wordToGuess.Length; i++)
                        display.Append('_');

                    List<char> correctGuesses = new List<char>();
                    List<char> incorrectGuesses = new List<char>();

                    int lives = 5;
                    bool won = false;
                    int lettersRevealed = 0;

                    string input;
                    char guess;

                    while (!won && lives > 0)
                    {
                    DrawMan(lives);
                    Console.Write("Guess a letter: ");

                        input = Console.ReadLine().ToUpper();
                        guess = input[0];

                        if (correctGuesses.Contains(guess))
                        {
                            Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                            continue;
                        }
                        else if (incorrectGuesses.Contains(guess))
                        {
                            Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                            continue;
                        }

                        if (wordToGuessUppercase.Contains(guess))
                        {
                            correctGuesses.Add(guess);

                            for (int i = 0; i < wordToGuess.Length; i++)
                            {
                                if (wordToGuessUppercase[i] == guess)
                                {
                                    display[i] = wordToGuess[i];
                                    lettersRevealed++;
                                }
                            }

                            if (lettersRevealed == wordToGuess.Length)
                                won = true;
                        }
                        else
                        {
                            incorrectGuesses.Add(guess);

                            Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                            Console.Beep();
                            lives--;
                        
                        }

                        Console.WriteLine(display.ToString());
                    }

                    if (won)
                        Console.WriteLine("You won!");
                    else
                        Console.WriteLine("You lost! It was '{0}'", wordToGuess);

                    Console.Write("Press ENTER to exit...");
                    Console.ReadLine();
                }
            }

        }
    }
}
                   