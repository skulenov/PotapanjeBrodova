using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum RezultatGađanja
    {
        Promasaj,
        Pogodak,
        Potonuce
    }
    public class Brod
    {
        public Brod(IEnumerable<Polje> polja)
        {
            this.Polja = polja;
        }

        public int Duljina
        {
            get { return Polja.Count(); }
        }

        public RezultatGađanja Gadjaj(Polje p)
        {
            if (!Polja.Contains(p))
                return RezultatGađanja.Promasaj;
            
            pogodjenaPolja.Add(p);
            if (pogodjenaPolja.Count == Polja.Count())
                return RezultatGađanja.Potonuce;
            return RezultatGađanja.Pogodak;
        }

        public readonly IEnumerable<Polje> Polja;
        private HashSet<Polje> pogodjenaPolja = new HashSet<Polje>();
    }
}
