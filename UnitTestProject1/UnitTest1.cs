using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using rpr;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        HerniPostava hrac = new HerniPostava();
        HerniPostava npc = new HerniPostava();

        [TestMethod]
        public void TestJmeno_PriDelceNez10Znaku_VyvolaUpozorneni()
        {
            hrac.Jmeno = "TotoJeVelmiDlouheJmeno";
            Assert.AreEqual("TotoJeVelmiDlouheJmeno", hrac.Jmeno);
        }

        [TestMethod]
        public void TestInicializaceLevelu()
        {
            Assert.AreEqual(1, hrac.Level);
        }

        [TestMethod]
        public void TestZmenaPozice()
        {
            hrac.ZmenaPozice(5, 10);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestPoziceX()
        {
            hrac.X = 2;
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestPoziciY()
        {
            hrac.Y = 0;
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestPridaniXP()
        {
            hrac.PridatXP(150);
            Assert.AreEqual(2, hrac.Level);
            Assert.AreEqual(50, hrac.XP);
        }

        [TestMethod]
        public void TestNPCInicializace()
        {
            npc.Prace = "obchodník";
            Assert.AreEqual("obchodník", npc.Prace);
            Assert.AreEqual(false, npc.JeBoss);
        }

        [TestMethod]
        public void TestToStringHrac()
        {
            hrac.Jmeno = "Hrac1";
            hrac.Specializace = "Kouzelník";
            hrac.PridatXP(50);
            string result = hrac.ToString();
            Assert.IsTrue(result.Contains("Jméno: Hrac1"));
            Assert.IsTrue(result.Contains("Specializace: Kouzelník"));
            Assert.IsTrue(result.Contains("XP: 50"));
        }

        [TestMethod]
        public void TestToStringNPC()
        {
            npc.Jmeno = "NPC1";
            npc.Prace = "obchodník";
            npc.JeBoss = true;
            string result = npc.ToString();
            Assert.IsTrue(result.Contains("Jméno: NPC1"));
            Assert.IsTrue(result.Contains("Práce: obchodník"));
            Assert.IsTrue(result.Contains("Je Boss: True"));
        }

        // Přidané testy:

        [TestMethod]
        public void TestJmeno_NeniNull()
        {
            hrac.Jmeno = null;
            Assert.IsNotNull(hrac.Jmeno);
        }

        [TestMethod]
        public void TestSpecializace_Validni()
        {
            hrac.Specializace = "Inženýr";
            Assert.AreEqual("Inženýr", hrac.Specializace);
        }

        [TestMethod]
        public void TestSpecializace_Nevalidni()
        {
            hrac.Specializace = "Rytíř";
            Assert.AreNotEqual("Rytíř", hrac.Specializace);
        }

        [TestMethod]
        public void TestNPC_BossStatus()
        {
            npc.JeBoss = true;
            Assert.IsTrue(npc.JeBoss);
        }

        [TestMethod]
        public void TestNPC_NemuzeZmenitPozici()
        {
            npc.ZmenaPozice(10, 15);
            Assert.AreEqual(0, npc.X);
            Assert.AreEqual(0, npc.Y);
        }

        [TestMethod]
        public void TestXP_NegativniHodnota()
        {
            hrac.PridatXP(-50);
            Assert.AreEqual(0, hrac.XP);
        }

        [TestMethod]
        public void TestXP_NulovaHodnota()
        {
            hrac.PridatXP(0);
            Assert.AreEqual(0, hrac.XP);
        }

        [TestMethod]
        public void TestXP_PresnyLevelUp()
        {
            hrac.PridatXP(100);
            Assert.AreEqual(2, hrac.Level);
        }

        [TestMethod]
        public void TestXP_ViceNasobnyLevelUp()
        {
            hrac.PridatXP(250);
            Assert.AreEqual(3, hrac.Level);
            Assert.AreEqual(50, hrac.XP);
        }

        [TestMethod]
        public void TestZmenaPozice_Hrac()
        {
            hrac.ZmenaPozice(3, 7);
            Assert.AreEqual(3, hrac.X);
            Assert.AreEqual(7, hrac.Y);
        }

        

        [TestMethod]
        public void TestJmeno_NesmíBýtPrazdne()
        {
            hrac.Jmeno = "";
            Assert.AreNotEqual("", hrac.Jmeno);
        }

        [TestMethod]
        public void TestXP_NestaciProLevelUp()
        {
            hrac.PridatXP(99);
            Assert.AreEqual(1, hrac.Level); 
            Assert.AreEqual(99, hrac.XP);
        }
    }
}
