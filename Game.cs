using RockPaperScissors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        private string[] choices = { "Rock", "Paper", "Scissors" };

        public void Play()
        {
            bool playAgain = true;

            while (playAgain)

            {
                Console.WriteLine("Choose Rock, Paper, or Scissors:");
                string playerChoice = Console.ReadLine()?.Trim();

                if (!IsValidChoice(playerChoice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                string computerChoice = GetRandomChoice();
                Console.WriteLine($"Computer chose: {computerChoice}");

                string result = DetermineWinner(playerChoice, computerChoice);
                Console.WriteLine(result);

                Console.WriteLine("Do you want to play again? (yes/no)");
                string response = Console.ReadLine()?.ToLower();
                playAgain = response == "yes";
            }
        }

        private bool IsValidChoice(string choice)
        {
            return Array.Exists(choices, C => C.Equals(choice, StringComparison.OrdinalIgnoreCase));
        }

        private string GetRandomChoice()
        {
            Random random = new Random();
            int index = random.Next(choices.Length);
            return choices[index];
        }
        private string DetermineWinner(string playerChoice, string computerChoice)
        {

            if (playerChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))

            {
                return "It's a draw!";
            }

            else if

                ((playerChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice == "Scissors") ||

            (playerChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice == "Rock") ||

     (playerChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice == "Paper"))

            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }

        }

    }

}

















