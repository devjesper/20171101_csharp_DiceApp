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
                Assert.IsTrue(d.Value > 0 && d.Value < 7, "Wrong value.... " + d.Value);

            }

        }
        [TestMethod]
        public void TestOfDiceSpecificCreation()
        {

            Dice d2 = new Dice(5);
            Assert.IsTrue(d2.Value == 5);

        }
        [TestMethod]
        public void TestOfDiceCreationWithCheat()
        {

            Dice d3 = new Dice(1, true);
            d3.Roll();
            Assert.IsTrue(d3.Value == 6);

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
    }
}
