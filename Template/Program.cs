using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        /// <summary>
        /// bir oyun için çeşitli skor hesaplama yöntemleri vardır
        /// oyun moduna göre hesaplama yapan abstract class var
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game game = new EasyGame();
            game.Calculate();

            game = new HardGame();
            game.Calculate();

            Console.ReadKey();
        }
    }
}
