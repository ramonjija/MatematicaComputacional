using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegrasDeSimpson
{
    public class FuncoesSimpson
    {
        RegraDoTrapezio.ExemploFuncoes func1;
        RegraDoTrapezio.RegraDoTrapezio trap;
        public double CalculaSimp13(double h, double f0, double f1, double f2)
        {
            double solucao = 0;

            solucao = 2 * h * (f0 + 4 * f1 + f2) / 6;

            return solucao;
        }

        public double CalculaSimp38(double h, double f0, double f1, double f2, double f3)
        {
            double solucao = 0;

            solucao = 3 * h * (f0 + 3 * (f1 + f2) + f3) / 8;

            return solucao;
        }

        
        public double CalculaSimp13m(double h, int n)
        {
            double soma = 0, solucao = 0;
            double[] xValues = new double[n+1];
            xValues[0] = 0;
            for(int i = 1; i < xValues.Length; i++)
            {
                xValues[i] = Math.Round(h * i,2);
            }



            func1 = new RegraDoTrapezio.ExemploFuncoes();

            //adicao de selecao de funcao
                soma = func1.FuncaoExemplo1(0);
           
            for (int i = 1; i < n - 2; i += 2)
            {
                    soma = soma + 4 * func1.FuncaoExemplo1(xValues[i]) + 2 * func1.FuncaoExemplo1(xValues[i+1]);

            }

            soma = soma + 4 * func1.FuncaoExemplo1(xValues[n - 1]) + func1.FuncaoExemplo1(xValues[n]);

            solucao = h * soma / 3;

            return solucao;
        }

        public double CalculaSimpInt(double a, double b, int n)
        {
            double h = 0, soma = 0, solucao = 0;
            double[] xValues = new double[n + 1];
            int impar = 0, m = 0;

            h = (b - a) / n;
            xValues[0] = 0;
            for(int i = 1; i < xValues.Length; i++)
            {
                xValues[i] = h * i;
            }


            if (n == 1)
            {
                //soma = trap.CalculaRegraSimples(h, func1.FuncaoExemplo2B(xValues[n - 1]), func1.FuncaoExemplo2B(xValues[n]));
                soma = trap.CalculaRegraSimples(h, func1.FuncaoExemplo1(xValues[n - 1]), func1.FuncaoExemplo1(xValues[n]));
            }
            else
            {
                m = n;
                //impar = n / 2 - Convert.ToInt32(n / 2);
                impar = n % 2;
                if (impar > 0 && n > 1)
                {
                    //soma += CalculaSimp38(h, func1.FuncaoExemplo2B(xValues[n - 3]), func1.FuncaoExemplo2B(xValues[n - 2]), func1.FuncaoExemplo2B(xValues[n - 1]), func1.FuncaoExemplo2B(xValues[n]));
                    soma += CalculaSimp38(h, func1.FuncaoExemplo1(xValues[n - 3]), func1.FuncaoExemplo1(xValues[n - 2]), func1.FuncaoExemplo1(xValues[n - 1]), func1.FuncaoExemplo1(xValues[n]));
                    m = n - 3;
                }
                if (m > 1)
                {
                    soma += CalculaSimp13m(h, m);
                }
            }
            solucao = soma;

            return solucao;

        }

        private double CalculaH(double xe, double xi, double n)
        {
            return (xe - xi) / n;
        }

    }
}
