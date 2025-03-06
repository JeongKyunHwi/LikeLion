using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame main_game = new MainGame();
            main_game.Initialize();
            main_game.Progress();
        }
    }
}
