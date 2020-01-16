using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Moving : IState
    {
        public void Play(Context context)
        {
            if (context.GetState() is Moving)
            {
                Console.Write("zaten movin durumunda.");
                return;
            }
            context.state = new Moving();

        }

        public void Stop(Context context)
        {
            context.state = new Stopped();
        }

        public override string ToString()
        {
            return "Moving";
        }
    }
}
