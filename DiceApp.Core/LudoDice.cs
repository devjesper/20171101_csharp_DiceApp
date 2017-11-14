using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp.Core
{
    public class LudoDice : Dice
    {

        public bool IsStar() {

            if (this.DiceValue == 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsGlobe()
        {

            if (this.DiceValue == 3)
                return true;
            return false;

        }

        public LudoDice() : base()
        {

        }

        public LudoDice(int value) : base(value)
        {

        }
  

    }
}
