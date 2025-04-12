using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Uscita
    {
        private int tempoU { get; set; }
        private Queue<Auto> codaU { get; set; }

        public Uscita()
        {
            this.tempoU = 1000;//metti il random
            this.codaU = new Queue<Auto>();
        }
    }
}
