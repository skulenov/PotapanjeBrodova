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

        public RezultatGađanja Gadjaj(Polje polje)
        {
            foreach (Brod b in brodovi)
            {
                var rezultat = b.Gadjaj(polje);
                if (rezultat != RezultatGađanja.Promasaj)
                    return rezultat;
            }
            return RezultatGađanja.Promasaj;
        }

        List<Brod> brodovi = new List<Brod>();
    }
}
