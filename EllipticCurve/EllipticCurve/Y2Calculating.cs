using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipticCurve
{
    class Y2Calculating
    {
        public int CalculateY2(int Scope, int X1, int X2, int Y1,int mod)
        {
            int value = Scope * (X1 - X2) - Y1;
            if (value < 0)
            {
                value = value + mod;
            }
                return value % mod;
        }
    }
}
