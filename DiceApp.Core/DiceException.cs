using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp.Core
{
    public class DiceException : Exception
    {
        public DiceException(string m) : base(m)
        {

        }
    }
}
