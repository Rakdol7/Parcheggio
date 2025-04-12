using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class MioThread
    {
        private Thread automobile;
        private Action action;

        public MioThread(Action action)
        {
            automobile = new Thread(new ThreadStart(action));
            this.action = action;
        }

        public void Start()
        {
            automobile.Start();
        }

        public void Join()
        {
            automobile.Join();
        }
    }
}
