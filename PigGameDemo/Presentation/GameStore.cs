using PigGameDemo.Controller;
using PigGameDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PigGameDemo.Presentation
{
    internal class GameStore
    {
        GameManager gameManager;
        PigGame game;

        public GameStore()
        {
            game = new PigGame();
            gameManager = new GameManager(game);
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to the game of Pig");

            while (!game.GameOver)
            {
                Console.WriteLine("Your total score: " + game.TotalScore);
                Console.WriteLine("Your current turn score: " + game.CurrentScore);

                Console.Write("Enter 'r' to roll or 'h' to hold: ");
                char choice = Console.ReadKey().KeyChar;

                SwitchCase(choice);

                if (gameManager.CheckGameOver())
                {
                    Console.WriteLine("Congratulations ! You won the game with a score of 20 or more");
                    break;
                }
            }
        }
        public void SwitchCase(char choice)
        {
            switch (choice)
            {
                case 'r':
                    Roll();
                    break;

                case 'h':
                    Hold();
                    break;

                default:
                    Console.WriteLine("\nEnter Valid Input\n");
                    break;
            }

        }
        public void Roll()
        {
            gameManager.Roll();
            Console.WriteLine(game.CurrentScore == 0
              ? "\nYou rolled a 1 ! No points for this turn\n"
              : "\nYou rolled and your turn score is now " + game.CurrentScore + "\n");
        }

        public void Hold()
        {
            game.TotalScore += game.CurrentScore;
            game.CurrentScore = 0;
            Console.WriteLine("\nYou Chose to hold. Your total score is now " + game.TotalScore  + "\n");
        }
    }
}
