using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {

        public double calc1(int minuts)
        {
            int overminuts;
            double overfinal;
            double final;
            if (minuts > 200)
            {
                overminuts = minuts - 200;
                minuts = 200;
                overfinal = overminuts * 1.6;
                final = minuts * 0.7 + overfinal;
            }
            else
            {
                final = minuts * 0.7;
            }
            return final;
        }
        public decimal calc2(int minuts)
        {
            int overminuts;
            decimal overfinal;
            decimal final;
            if (minuts > 100)
            {
                overminuts = minuts - 100;
                minuts = 100;
                overfinal = (decimal)(overminuts * 1.6);
                final = (decimal)(minuts * 0.3) + overfinal;
            }
            else
            {
                final = (decimal)(minuts * 0.3);
            }
            return final;
        }
    }
}
