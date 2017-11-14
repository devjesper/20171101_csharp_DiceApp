using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceApp.Core;

namespace DiceApp.Test
{
    [TestClass]
    public class TestDice
    {
        [TestMethod]
        public void TestOfDiceSimpleCreation()
        {
            for (int i = 0; i < 1000; i++)
            {
                Dice d = new Dice();
                Assert.IsTrue(d.DiceValue > 0 && d.DiceValue < 7, "Wrong value.... " + d.DiceValue);

            }

        }
        [TestMethod]
        public void TestOfDiceSpecificCreation()
        {

            Dice d2 = new Dice(5);
            Assert.IsTrue(d2.DiceValue == 5);

        }
        [TestMethod]
        public void TestOfDiceCreationWithCheat()
        {

            Dice d3 = new Dice(1, true);
            d3.Roll();
            Assert.IsTrue(d3.DiceValue == 6);

        }

        [TestMethod]
        public void TestOfDicePrint()
        {

            for (int i = 1; i < 7; i++)
            {
                Dice d3 = new Dice(i);
                Assert.IsTrue(d3.Print() == "[" + i + "]");

            }

        }

        [TestMethod]
        public void TestOfDiceCupCreation()
        {

            DiceCup c = new DiceCup();
            Assert.IsTrue(c.Count() == 5);

            c = new DiceCup(1);
            Assert.IsTrue(c.Count() == 1);

            c = new DiceCup(10);
            Assert.IsTrue(c.Count() == 10);



        }
    }
}
