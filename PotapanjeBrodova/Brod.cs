using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum RezultatGadjanja
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

        public RezultatGadjanja Gadjaj(Polje p)
        {
            if (!Polja.Contains(p))
                return RezultatGadjanja.Promasaj;
            
            pogodjenaPolja.Add(p);
            if (pogodjenaPolja.Count == Polja.Count())
                return RezultatGadjanja.Potonuce;
            return RezultatGadjanja.Pogodak;
        }

        public readonly IEnumerable<Polje> Polja;
        private HashSet<Polje> pogodjenaPolja = new HashSet<Polje>();
    }
}
