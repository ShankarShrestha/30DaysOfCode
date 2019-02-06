using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _30DayCode.Day1;
using _30DayCode.Day2;

namespace _30DayCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////// Day 1 ////////////
            Average av = new Average();
            DisplayNumber dn = new DisplayNumber();
            MultiplicationTable mt = new MultiplicationTable();
            StringSwap ss = new StringSwap();
            Temperature tt = new Temperature();
            LongWord lw = new LongWord();

            //av.FindAverage();
            //dn.GetNumber();
            //mt.FindMultiplication();
            //ss.SwapString();
            //lw.FindLongWord();
            //tt.TemperatureConversion();

            ///////////Day 2///////////////
            CubeNumber cn = new CubeNumber();
            cn.FindCubic();
        }
    }
}
