using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasLinearesApp
{
    class Utilidades
    {
        public static void zeros(double[] x0)
        {
            for (int i = 0; i <= x0.Length-1; i++)
            {
                x0[i] = 0;
            }
            //zera a matriz
        }


        internal static int norm(double[] x0)
        {
            throw new NotImplementedException();
        }
    }
}
