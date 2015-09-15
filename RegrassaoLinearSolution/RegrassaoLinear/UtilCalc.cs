using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegrassaoLinear
{
    public static class UtilCalc
    {
        public static double CalculaSxiyi(double[] xi, double[] yi)
        {
            double sxiyi = 0;

            for (int i = 0; i < xi.Length; i++)
            {
                sxiyi += (xi[i] * yi[i]);
            }

            return sxiyi;
        }

        public static double CalculaS(double[] xi)
        {
            double si = 0;

            for (int i = 0; i < xi.Length; i++)
            {
                si += xi[i];
            }

            return si;
        }

        public static double CalculaSxi2(double[] xi)
        {
            double sxi2 = 0;

            for (int i = 0; i < xi.Length; i++)
            {
                sxi2 += (xi[i] * xi[i]);
            }

            return sxi2;
        }

        public static string FormaEquacao(double a0, double a1)
        {
            string equacao = null;
            if (a1 > 0)
            {
                equacao = "y = " + Math.Round(a0, 8) + " + " + Math.Round(a1, 8) + "x";
            }
            else
            {
                equacao = "y = " + Math.Round(a0, 8) + " - " + Math.Abs(Math.Round(a1, 8)) + "x";
            }
            return equacao;

        }
    }
}
