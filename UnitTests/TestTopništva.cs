using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;
namespace UnitTests
{
    [TestClass]
    public class TestTopništva
    {
        int[] duljineBrodova = {1,2,3 };
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaJeNapipavanje()
        {
            Topništvo t = new Topništvo(10, 10, duljineBrodova);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonPrvogPogotkaJeOkruživanje()
        {
            Topništvo t = new Topništvo(10, 10, duljineBrodova);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.Okruživanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonDrugogPogotkaJeSustavnoUništavanje()
        {
            Topništvo t = new Topništvo(10, 10, duljineBrodova);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.SustavnoUništavanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonPotonućaJeNapipavanje()
        {
            Topništvo t = new Topništvo(10, 10, duljineBrodova);
            t.ObradiGađanje(RezultatGađanja.Potonuće);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonPromašajaSeNeMijenja()
        {
            Topništvo t = new Topništvo(10, 10, duljineBrodova);  //Inicijalno je napipavanje
            t.ObradiGađanje(RezultatGađanja.Promašaj);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Promašaj);
            Assert.AreEqual(TaktikaGađanja.Okruživanje, t.TrenutnaTaktika);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Promašaj);
            Assert.AreEqual(TaktikaGađanja.SustavnoUništavanje, t.TrenutnaTaktika);
        }
        [TestMethod]
        public void Topništvo_NapipavanjeDajeBiloKojePoljeNaPraznojMreži()
        {
            Topništvo t = new Topništvo(10, 10, duljineBrodova);
            Assert.IsTrue(new Mreža(10,10).DajSlobodnaPolja().Contains(t.UputiPucanj()));
        }
        // 
    }
}
