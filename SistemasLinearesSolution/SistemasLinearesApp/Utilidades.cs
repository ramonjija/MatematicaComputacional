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
            for (int i = 0; i <= x0.Length - 1; i++)
            {
                x0[i] = 0;
            }
            //zera a matriz
        }

        public static void trocaMatriz(double[,] a, double[] b)
        {
            b[0] = 7;
            b[1] = -4;
            b[2] = 9;

            a[0, 0] = 10;
            a[0, 1] = 2;
            a[0, 2] = -1;
            a[1, 0] = 1;
            a[1, 1] = 8;
            a[1, 2] = 3;
            a[2, 0] = -2;
            a[2, 1] = -1;
            a[2, 2] = 10;
        }

        public static void trocaMatriz(double[,] a, double[] b, double[] vA)
        {
            b[0] = 7;
            b[1] = -4;
            b[2] = 9;

            a[0, 0] = 10;
            a[0, 1] = 2;
            a[0, 2] = -1;
            a[1, 0] = 1;
            a[1, 1] = 8;
            a[1, 2] = 3;
            a[2, 0] = -2;
            a[2, 1] = -1;
            a[2, 2] = 10;

            vA[0] = 0;
            vA[1] = 0;
            vA[2] = 0;
        }

        public static void printaMatrizExemplo(int exemplo)
        {
            double[] b = { 7, 3, -5 };
            double[,] a = { { 4, 2, -9 }, { 5, -6, -8 }, { 1, -2, 15 } };

            Console.WriteLine("Matriz Utilizada");

            if (exemplo == 1)
            {
                Utilidades.trocaMatriz(a,b);

            }
                for (int i = 0; i < b.Length; i++)
                {
                    //Console.Write("|");
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i, j] < 0)
                        {
                            Console.Write(" " + a[i, j]);
                        }
                        else
                        {
                            Console.Write("  " + a[i, j]);
                        }
                    }
                    if (b[i] < 0)
                    {
                        Console.Write(" " + b[i]);
                    }
                    else
                    {
                        Console.Write("  " + b[i]);
                    }
                    Console.WriteLine("");
                }
            }
        }
}
