﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class TestFlote
    {
        [TestMethod]
        public void Flota_DodajBrodZaTriRazličitaBrodaSlažeFlotuOdTriBroda()
        {
            Mreža m = new Mreža(10, 10);
            Flota f = new Flota();

            var p1 = m.DajPoljaZaBrod(Smjer.Horizontalno, new Polje(0, 0), 5);
            Brod b1 = new Brod(p1);
            f.DodajBrod(b1);

            var p2 = m.DajPoljaZaBrod(Smjer.Vertikalno, new Polje(1, 3), 4);
            Brod b2 = new Brod(p2);
            f.DodajBrod(b2);

            var p3 = m.DajPoljaZaBrod(Smjer.Horizontalno, new Polje(4, 5), 3);
            Brod b3 = new Brod(p3);
            f.DodajBrod(b3);

            Assert.AreEqual(3, f.Brodovi.Count());
            Assert.IsTrue(f.Brodovi.Contains(b1));
            Assert.IsTrue(f.Brodovi.Contains(b2));
            Assert.IsTrue(f.Brodovi.Contains(b3));
        }

        [TestMethod]
        public void Flota_GadjajVracaPromasajZaPoljeKojeNijeUNitiJednomBrodu()
        {
            Mreža m = new Mreža(10, 10);
            Flota f = new Flota();

            var p1 = m.DajPoljaZaBrod(Smjer.Horizontalno, new Polje(0, 0), 5);
            Brod b1 = new Brod(p1);
            f.DodajBrod(b1);

            var p2 = m.DajPoljaZaBrod(Smjer.Vertikalno, new Polje(1, 3), 4);
            Brod b2 = new Brod(p2);
            f.DodajBrod(b2);

         

            Assert.AreEqual(RezultatGađanja.Promasaj,f.Gadjaj(new Polje(9,9)));
            Assert.IsTrue(f.Brodovi.Contains(b1));
            Assert.IsTrue(f.Brodovi.Contains(b2));
            
        }

        [TestMethod]
        public void Flota_GadjajVracaPogodakZaPoljaKojaSuUBrodu()
        {
            Mreža m = new Mreža(10, 10);
            Flota f = new Flota();

            var p1 = m.DajPoljaZaBrod(Smjer.Horizontalno, new Polje(0, 0), 5);
            Brod b1 = new Brod(p1);
            f.DodajBrod(b1);

            var p2 = m.DajPoljaZaBrod(Smjer.Vertikalno, new Polje(1, 3), 4);
            Brod b2 = new Brod(p2);
            f.DodajBrod(b2);



            Assert.AreEqual(RezultatGađanja.Pogodak, f.Gadjaj(new Polje(0, 1)));
            Assert.AreEqual(RezultatGađanja.Pogodak, f.Gadjaj(new Polje(1, 3)));
        }

        [TestMethod]
        public void Flota_GadjajVracaPotonuceZaZadnjePogodjenoPoljePrvogBroda()
        {
            Mreža m = new Mreža(10, 10);
            Flota f = new Flota();

            var p1 = m.DajPoljaZaBrod(Smjer.Horizontalno, new Polje(0, 0), 3);
            Brod b1 = new Brod(p1);
            f.DodajBrod(b1);

            var p2 = m.DajPoljaZaBrod(Smjer.Vertikalno, new Polje(1, 3), 4);
            Brod b2 = new Brod(p2);
            f.DodajBrod(b2);



            Assert.AreEqual(RezultatGađanja.Pogodak, f.Gadjaj(new Polje(0, 1)));
            Assert.AreEqual(RezultatGađanja.Pogodak, f.Gadjaj(new Polje(0, 2)));
            Assert.AreEqual(RezultatGađanja.Promasaj, f.Gadjaj(new Polje(0, 3)));
            Assert.AreEqual(RezultatGađanja.Potonuce, f.Gadjaj(new Polje(0, 0)));
        }

        [TestMethod]
        public void Flota_GadjajVracaPotonuceZaZadnjePogodjenoPoljeDrugogBroda()
        {
            Mreža m = new Mreža(10, 10);
            Flota f = new Flota();

            var p1 = m.DajPoljaZaBrod(Smjer.Horizontalno, new Polje(0, 0), 3);
            Brod b1 = new Brod(p1);
            f.DodajBrod(b1);

            var p2 = m.DajPoljaZaBrod(Smjer.Vertikalno, new Polje(1, 3), 2);
            Brod b2 = new Brod(p2);
            f.DodajBrod(b2);



            Assert.AreEqual(RezultatGađanja.Pogodak, f.Gadjaj(new Polje(0, 1)));
            Assert.AreEqual(RezultatGađanja.Pogodak, f.Gadjaj(new Polje(0, 2)));
            Assert.AreEqual(RezultatGađanja.Potonuce, f.Gadjaj(new Polje(0, 0)));

            Assert.AreEqual(RezultatGađanja.Pogodak, f.Gadjaj(new Polje(1, 3)));
            Assert.AreEqual(RezultatGađanja.Potonuce, f.Gadjaj(new Polje(2, 3)));
        }
    }
}
