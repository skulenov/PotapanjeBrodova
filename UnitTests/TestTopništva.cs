﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace UnitTests
{
    [TestClass]
    public class TestTopništva
    {
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaJeNapipavanje()
        {
            Topništvo t = new Topništvo();
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonPrvogPogotkaJeOkruživanje()
        {
            Topništvo t = new Topništvo();
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.Okruživanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonDrugogPogotkaJeSustavnoUništavanje()
        {
            Topništvo t = new Topništvo();
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.SustavnoUništavanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonPotonućaJeNapipavanje()
        {
            Topništvo t = new Topništvo();
            t.ObradiGađanje(RezultatGađanja.Potonuce);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }

        [TestMethod]
        public void Topništvo_TaktikaGađanjaNakonPromašajaSeNeMijenja()
        {
            Topništvo t = new Topništvo();  //Inicijalno je napipavanje
            t.ObradiGađanje(RezultatGađanja.Promasaj);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Promasaj);
            Assert.AreEqual(TaktikaGađanja.Okruživanje, t.TrenutnaTaktika);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Promasaj);
            Assert.AreEqual(TaktikaGađanja.SustavnoUništavanje, t.TrenutnaTaktika);
        }
        // 
    }
}
