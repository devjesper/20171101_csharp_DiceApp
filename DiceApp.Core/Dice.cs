using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp.Core
{

    public class Dice
    {
        private static Random rnd = new Random();

        private int diceValue;

        public int DiceValue
        {
            get { return diceValue; }
            private set {
                // log
                // fejlhåndtering
                // sikkerhed
                // logik
                if (value < 1 || value > 6)
                    throw new ApplicationException("Wrong dice value");
                    

                this.diceValue = value;

            }
        }

        private bool cheat;

        public Dice()
        {

            this.cheat = false;
            this.Roll();

        }


        public Dice(int value)
        {
            this.DiceValue = value;
        }

        public Dice(int value, bool cheat) : this(value)
        {
            this.cheat = cheat;
        }

        public void Roll()
        {
            if (this.cheat == true)
                this.DiceValue = 6;
            else
                this.DiceValue = rnd.Next(1, 7);
        }

        public virtual string Print()
        {
            return "[" + this.DiceValue + "]";
        }


    }



    


}
