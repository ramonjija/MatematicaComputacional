using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegrassaoLinear
{
    class Program
    {

        static void FuncRegressaoLinear()
        {

            double[] xi = { 1, 2, 3, 4, 5, 6, 7 };
            double[] yi = { 0.5, 2.5, 2.0, 4.0, 3.5, 6.0, 5.5 };

            double Sxiyi = 0;
            double Sxi = 0;
            double Syi = 0;
            double Sxi2 = 0;

            double mediaXi = 0;
            double mediaYi = 0;

            double a1 = 0;
            double a0 = 0;

            int n = xi.Length;

            //Inicio do calculo

            Sxiyi = (UtilCalc.CalculaSxiyi(xi, yi));
            Sxi = (UtilCalc.CalculaS(xi));
            Syi = (UtilCalc.CalculaS(yi));
            Sxi2 = (UtilCalc.CalculaSxi2(xi));
            mediaXi = Sxi / n;
            mediaYi = Syi / n;





            a1 = ((n * Sxiyi) - (Sxi * Syi)) / ((n * Sxi2) - (Sxi * Sxi));
            a0 = (mediaYi - a1 * mediaXi);

            Console.WriteLine(UtilCalc.FormaEquacao(a0, a1));



        }


        static void Main(string[] args)
        {
            Program.FuncRegressaoLinear();
            Console.ReadLine();
            
        }
    }
}
