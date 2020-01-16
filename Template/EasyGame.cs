using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class EasyGame : Game
    {
        public override void Calculate()
        {
            ScoringAlgorithm algorithm;
            Console.WriteLine("Easy mode");
            algorithm = new EasyScoringAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 10, 20)));
        }
    }
}
