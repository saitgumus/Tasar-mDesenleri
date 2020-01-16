using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        /// <summary>
        /// nesnenin durum bilgisinin değişmesiyle nesnenin değişmesini tematize eder.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Context player = new Context();
            player.SetPlay();
            Console.WriteLine("anlık durum-" + player.GetState().ToString());


            player.SetPlay();
            Console.WriteLine("anlık durum-" + player.GetState().ToString());


            player.SetStop();
            Console.WriteLine("anlık durum-" + player.GetState().ToString());

            player.SetStop();
            Console.WriteLine("anlık durum-" + player.GetState().ToString());

            Console.ReadKey();
        }
    }
}
