using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp.Core.Old
{
    class DiceWithField
    {

        private static Random rnd = new Random();

        public int Value;
        private bool Cheat;

        public DiceWithField()
        {

            this.Cheat = false;
            this.Roll();

        }


        public DiceWithField(int value)
        {
            if (value < 1 || value > 6)
                value = 1;
            this.Value = value;
        }

        public DiceWithField(int value, bool cheat) : this(value)
            {
            this.Cheat = cheat;
        }

        public void Roll()
        {
            if (this.Cheat == true)
                this.Value = 6;
            else
                this.Value = rnd.Next(1, 7);
        }

        public string Print()
        {
            return "[" + this.Value + "]";
        }



    }
}
