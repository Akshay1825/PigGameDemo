using PigGameDemo.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameStore gameStore = new GameStore();
            gameStore.StartGame();
        }
    }
}
