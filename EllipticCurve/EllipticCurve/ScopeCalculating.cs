using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipticCurve
{
    class ScopeCalculating
    {
        public double CalculateScope(int valueX, int valueY, int Mod)
        {


            double Fdivide = 3 * (valueX * valueX) + 2;
            double Sdivide = 2 * valueY;
            int ifZero = Convert.ToInt32(Fdivide / Sdivide);
            int ifRational = Convert.ToInt32(Fdivide / Sdivide);
         //   if(ifRational - ifZero == 0)
         //   {
          //      double Scope = (Fdivide / Sdivide) % Mod;
         //       return Scope;
          //  }
           // else
          //  {
                double adding = Mod * (Sdivide - 1);
                double last = Fdivide + adding;
                double Scope = (last / Sdivide) % Mod;

                return Scope;
           // }
            
      
        }
    }
}
