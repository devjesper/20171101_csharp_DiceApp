using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceApp.Core;

namespace DiceApp.Test
{
    [TestClass]
    public class TestDice
    {
        [TestMethod]
        public void TestDiceSimpleCreation()
        {
            for (int i = 0; i < 1000; i++)
            {
                Dice d = new Dice();
                Assert.IsTrue(d.DiceValue > 0 && d.DiceValue < 7, "Wrong value.... " + d.DiceValue);
            }

        }

        [TestMethod]
        public void TestLudoDiceSimpleCreation()
        {
            for (int i = 0; i < 1000; i++)
            {
                LudoDice d = new LudoDice();
                Assert.IsTrue(d.DiceValue > 0 && d.DiceValue < 7, "Wrong value.... " + d.DiceValue);
            }

        }
        [TestMethod]
        public void TestDiceSpecificCreation()
        {

            Dice d2 = new Dice(5);
            Assert.IsTrue(d2.DiceValue == 5);

            d2 = new Dice(7);
            Assert.IsTrue(d2.DiceValue == 1);

            d2 = new Dice(0);
            Assert.IsTrue(d2.DiceValue == 1);


        }

        [TestMethod]
        public void TestLudoDiceSpecificCreation()
        {

            LudoDice d2 = new LudoDice(5);
            Assert.IsTrue(d2.DiceValue == 5);

            d2 = new LudoDice(7);
            Assert.IsTrue(d2.DiceValue == 1);

            d2 = new LudoDice(0);
            Assert.IsTrue(d2.DiceValue == 1);


        }

        [TestMethod]
        public void TestDiceCreationWithCheat()
        {

            Dice d3 = new Dice(1, true);
            d3.Roll();
            Assert.IsTrue(d3.DiceValue == 6);

        }

        [TestMethod]
        public void TestDicePrint()
        {

            for (int i = 1; i < 7; i++)
            {
                Dice d3 = new Dice(i);
                Assert.IsTrue(d3.Print() == "[" + i + "]");

            }

        }

        [TestMethod]
        public void TestDiceCupCreation()
        {

            DiceCup c = new DiceCup();
            Assert.IsTrue(c.Count() == 5);

            c = new DiceCup(1);
            Assert.IsTrue(c.Count() == 1);

            c = new DiceCup(10);
            Assert.IsTrue(c.Count() == 10);



        }

        [TestMethod]
        public void TestDiceCupRoll()
        {

            DiceCup c = new DiceCup();
            c.Roll();
            // no exception
            Assert.IsTrue(true);


        }


        [TestMethod]
        public void TestLudoDiceIsStar()
        {

            for (int i = 1; i < 7; i++)
            {
                LudoDice d = new LudoDice(i);
                if (i == 5)
                    Assert.IsTrue(d.IsStar());
                else
                    Assert.IsFalse(d.IsStar());

            }


        }

        [TestMethod]
        public void TestLudoDiceIsGlobe()
        {

            for (int i = 1; i < 7; i++)
            {
                LudoDice d = new LudoDice(i);
                if(i==3)
                    Assert.IsTrue(d.IsGlobe());
                else
                    Assert.IsFalse(d.IsGlobe());

            }


        }

    }
}
