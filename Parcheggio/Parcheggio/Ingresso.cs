using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Ingresso
    {
        private int tempoI {  get; set; }
        private Queue<Auto> codaI { get; set; }

        public Ingresso()
        {
            this.tempoI = 1000;//metti il random
            this.codaI = new Queue<Auto>();
        }
    }
}
