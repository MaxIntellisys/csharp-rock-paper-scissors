using System;
using System.Linq;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // string playAgain;
            ColorPrint(ConsoleColor.DarkCyan, "---> Rock Paper Scissors Game <---");

            while (true)
            {
                GameLoop();

                Console.WriteLine("Play again? [Y/N]");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
        }

        static void Greet()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Hello {name}");
            Console.ResetColor();
        }

        static void ColorPrint(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Random rnd = new Random();

        static void GameLoop()
        {
            int[] validChoice = { 0, 1, 2 };
            int player;
            Console.WriteLine("Enter corresponding number:");
            Console.WriteLine("(0)✊ (1)👋 (2)🤞");

            while (true)
            {

                player = Int32.Parse(Console.ReadLine());

                if (validChoice.Contains(player))
                {
                    break;
                }
                else
                {
                    ColorPrint(ConsoleColor.Red, "Please enter one valid option!");
                }
            }

            CompareOptions(player);
        }

        static void CompareOptions(int player)
        {
            string[] options = { "Rock", "Paper", "Scissors" };
            int random = rnd.Next(options.Length);
            string machine = options[random];
            string selectionsMessage = $"Machine: {machine} - You: {options[player]}";

            if (machine == "Rock")
            {
                if (options[player] == "Rock")
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.Yellow, "It's a tied 🎀");
                }
                else if (options[player] == "Paper")
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.DarkGreen, "You win 🎉!");
                }
                else
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.DarkGray, "Sorry you lost 😢!");
                }
            }
            else if (machine == "Paper")
            {
                if (options[player] == "Paper")
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.Yellow, "It's a tied 🎀");
                }
                else if (options[player] == "Scissors")
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.DarkGreen, "You win 🎉!");
                }
                else
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.DarkGray, "Sorry you lost 😢!");
                }
            }
            else if (machine == "Scissors")
            {
                if (options[player] == "Scissors")
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.Yellow, "It's a tied 🎀");
                }
                else if (options[player] == "Rock")
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.DarkGreen, "You win 🎉!");
                }
                else
                {
                    Console.WriteLine(selectionsMessage);
                    ColorPrint(ConsoleColor.DarkGray, "Sorry you lost 😢!");
                }
            }

        }
    }
}
