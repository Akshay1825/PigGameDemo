using PigGameDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGameDemo.Controller
{
    internal class GameManager
    {
        PigGame game;
        Random random;

        public GameManager(PigGame game)
        {
            this.game = game;
            random = new Random();
        }

        public void Roll()
        {
            int roll = random.Next(1, 7); 
            game.CurrentScore = (roll == 1) ? 0 : game.CurrentScore + roll;
        }

        public bool CheckGameOver()
        {
            if (game.TotalScore >= 20)
            {
                game.GameOver = true;
            }
            return game.GameOver;
        }
    }
}
