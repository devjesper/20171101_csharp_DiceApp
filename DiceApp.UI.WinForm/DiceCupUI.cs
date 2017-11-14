using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceApp.UI.WinForm
{
    public class DiceCupUI : DiceApp.Core.DiceCup
    {
        public void Draw(ImageList lst, Graphics g, int x, int y) {
            
            foreach (var dice in this.dices)
            {                
                lst.Draw(g, new Point(x, y), dice.DiceValue-1);
                x += 120;
            }

        }

        public DiceCupUI(int count) : base(count)
        {

        }
    }
}
