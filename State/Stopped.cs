using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Stopped : IState
    {
        public void Play(Context context)
        {
            context.state = new Moving();
        }

        public void Stop(Context context)
        {
            if (context.GetState() is Stopped)
            {
                Console.Write("zaten stop durumunda.");
                return;
            }
            context.state = new Stopped();
        }

        public override string ToString()
        {
            return "Stopped";
        }
    }
}
