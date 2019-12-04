using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.Util
{
    public class FunctiiMat
    {
        public static double[] EqGrad2(double a, double b, double c, out bool infinitateSolutii)
        {
            double[] solutii = new double[0];
            infinitateSolutii = false;
            if (a == 0 && b == 0 && c == 0)
            {
                infinitateSolutii = true;
                return solutii;
            }
            if (a == 0 && b == 0)
            {
                return solutii;
            }

            if (a == 0)
            {
                Array.Resize(ref solutii, 1);
                solutii[0] = -c / b;
                return solutii;
            }

            double delta;
            delta = b * b - 4 * a * c;

            if (delta > 0)
            {

                Array.Resize(ref solutii, 2);
                solutii[0] = (-b + Math.Sqrt(delta)) / 2 * a;
                solutii[1] = (-b - Math.Sqrt(delta)) / 2 * a;
                return solutii;
            }

            if (delta == 0)
            {
                Array.Resize(ref solutii, 2);
                solutii[0] = solutii[1] = -b / 2 * a;
                return solutii;
            }
            return solutii;
        }
    }
}
