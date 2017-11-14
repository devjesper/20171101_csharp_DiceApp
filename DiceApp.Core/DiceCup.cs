using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp.Core
{
    public class DiceCup
    {
        protected Dice[] dices;

        public DiceCup() : this(5)
        {}

        public DiceCup(int count)
        {
            this.dices = new Dice[count];
            for (int i = 0; i < count; i++)
            {
                dices[i] = new Dice();
            }
        }

        public void Roll() {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Roll();
            }
        }

        public string Print() {
            string tmp = "";
            for (int i = 0; i < dices.Length; i++)
            {
                tmp += dices[i].Print() + " ";
            }
            return tmp;
        }

        public int Count() {
            return this.dices.Length;
        }

        //public int Length {
        //    get {
        //        return this.dices.Length;
        //    }
        //}
    }
}
