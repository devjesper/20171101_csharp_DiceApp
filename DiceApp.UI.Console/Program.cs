using DiceApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dice d = new Dice();
            //System.Console.WriteLine(d.Print());

            //Dice d2 = new Dice(5);
            //System.Console.WriteLine(d2.Print());

            //Dice d3 = new Dice(1, true);
            //d3.Roll();
            //System.Console.WriteLine(d3.Print());

            //Dice d4 = new Dice();
            //d4.DiceValue = 100;

            //Dice[] dices = new Dice[5];
            //for (int i = 0; i < 5; i++)
            //    dices[i] = new Dice();

            //System.Diagnostics.Debugger.Break();

            //for (int i = 0; i < 5; i++)
            //    dices[i].Roll();


            DiceCup c = new DiceCup();
            System.Console.WriteLine(c.Print());
            c.Roll();
            System.Console.WriteLine(c.Print());

            //int l = c.Length;
            //l = c.Count();



        }
    }
}
