using System.Collections.Generic;

namespace PotapanjeBrodova
{
    public class Flota
    {
        public void DodajBrod(Brod b)
        {
            brodovi.Add(b);
        }

        public IEnumerable<Brod> Brodovi
        {
            get { return brodovi; }
        }

        public int BrojBrodova
        {
            get { return brodovi.Count; }
        }

        public RezultatGadjanja Gadjaj(Polje polje)
        {
            foreach (Brod b in brodovi)
            {
                var rezultat = b.Gadjaj(polje);
                if (rezultat != RezultatGadjanja.Promasaj)
                    return rezultat;
            }
            return RezultatGadjanja.Promasaj;
        }

        List<Brod> brodovi = new List<Brod>();
    }
}
