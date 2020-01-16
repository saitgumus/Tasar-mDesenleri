using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        public IState state;

        public Context()
        {
            state = new Stopped();
        }

        public IState GetState()
        {
            return this.state;
        }

        public void SetPlay()
        {
            state.Play(this);
        }
        public void SetStop()
        {
            state.Stop(this);
        }
    }
}
