using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipticCurve
{
    class X2Calculating
    {
        public int X2Value(int scope, int x1,int mod)
        {
            int value = ((scope * scope) - (2 * (x1)));
            if (value < 0)
            {

                value = value + mod;
            }
            return (value % mod);
        }
    }
}
