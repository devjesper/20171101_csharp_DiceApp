using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceApp.Core;

namespace DiceApp.Test
{
    [TestClass]
    public class TestDice
    {
        [TestMethod]
        public void TestDiceCreation()
        {
            Dice d = new Dice();
            Assert.IsTrue(d.Value > 0 && d.Value < 7, "Wrong value.... " + d.Value);


        }
        [TestMethod]
        public void TestDiceCreation2()
        {

            Dice d2 = new Dice(5);
            Assert.IsTrue(d2.Value == 5);

        }
        [TestMethod]
        public void TestDiceCreation3()
        {

            Dice d3 = new Dice(1, true);
            d3.Roll();
            Assert.IsTrue(d3.Value == 6);

        }

        [TestMethod]
        public void TestDicePrint()
        {

            Dice d3 = new Dice(1);            
            Assert.IsTrue(d3.Print() == "[1]");


        }
    }
}
