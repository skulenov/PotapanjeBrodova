using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;
namespace UnitTests
{
    [TestClass]
    public class TestNapipača
    {
        [TestMethod]
        public void Napipač_ListaPoljaZaHorizontalniBrodDuljine3MoraSadržavati15Polja()
        {
            Mreža m = new Mreža(1, 7);
            const int duljinaBroda = 3;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());
        }

        //[TestMethod]
        //public void Napipač_ListaPoljaZaHorizontalniBrodDuljine3MoraSadržavatiPoljaUOdređenomBroju()
        //{
        //    Mreža m = new Mreža(1, 7);
        //    const int duljinaBroda = 3;
        //    Napipač n = new Napipač(m, duljinaBroda);
        //    Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());
        //    //provjera koliko se koje polje puta pojavi u listi
        //}

        [TestMethod]
        public void Napipač_ListaPoljaZaVertikalniBrodDuljine3MoraSadržavati15Polja()
        {
            Mreža m = new Mreža(5, 2);
            const int duljinaBroda = 4;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(16, n.DajKandidateZaVertikalniBrod().Count());
        }
    }
}
