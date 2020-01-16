using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class HardGame : Game
    {
        public override void Calculate()
        {
            ScoringAlgorithm algorithm;
            Console.WriteLine("Hard mode");
            algorithm = new HardScoreAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 10, 20)));
        }
    }
}
