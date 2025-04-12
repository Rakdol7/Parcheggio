using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Auto:MioThread
    {
        private int tempoS {  get; set; }
        private string targa {  get; set; }
        private string marca { get; set;}
        private string modello { get; set; }
        private Parcheggio parcheggio { get; set; }

        public Auto(Action action, int tempoS, string targa, string marca, string modello, Parcheggio parcheggio) : base(action)
        {
            this.tempoS = tempoS;
            this.targa = targa;
            this.marca = marca;
            this.modello = modello;
            this.parcheggio = parcheggio;
        }

        public override string ToString()
        {
            return marca+" "+modello+" "+targa+"("+tempoS+" sec)";
        }
    }
}
