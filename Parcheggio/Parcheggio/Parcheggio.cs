using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Parcheggio
    {
        private int ingressi {  get; set; }
        private int uscite { get; set;}
        private int posti { get; set; }
        private Form1 form { get; set; }
        private List<Ingresso> ingresso { get; set; }
        private List<Uscita> uscita { get; set; }

        public Parcheggio(int ingressi, int uscite, int posti, Form1 form)
        {
            this.ingressi = ingressi;
            this.uscite = uscite;
            this.posti = posti;
            this.form = form;
            this.ingresso = CreaIngressi(ingressi);
            this.uscita = CreaUscita(uscite);
        }

        
        private List<Ingresso> CreaIngressi(int ingressi)
        {
            List<Ingresso> ingr = new List<Ingresso>();
            for (int i = 0; i < ingressi; i++) 
            {
                Ingresso ing = new Ingresso();
                ingr.Add(ing);
                return ingr;
            }
            return null;
        }

        private List<Uscita> CreaUscita(int uscite)
        {
            List<Uscita> usc = new List<Uscita>();
            for (int i = 0; i < uscite; i++)
            {
                Uscita us = new Uscita();
                usc.Add(us);
                return usc;
            }
            return null;
        }
    }
}
