using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGameDemo.Model
{
    internal class PigGame
    {
        public int TotalScore { get; set; }
        public int CurrentScore { get; set; }
        public bool GameOver { get; set; }

        public PigGame()
        {
            TotalScore = 0;
            CurrentScore = 0;
            GameOver = false;
        }
    }
}
