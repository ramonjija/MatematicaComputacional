using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegraDoTrapezio
{
    class RegraDoTrapezio
    {
        double solucao = 0;
        ExemploFuncoes funcao1;
        double soma = 0;

        public double CalculaRegra(double xi, double xe, double n)
        {
            double h = CalculaH(xe, xi, n);
            funcao1 = new ExemploFuncoes();

            soma = funcao1.FuncaoExemplo1(xi);

            for(int i = 1; i < n; i++)
            {
                soma += 2 * funcao1.FuncaoExemplo1(xi + h * i);
            }
            soma += funcao1.FuncaoExemplo1(xe);

            solucao = h * soma / 2;

            return Math.Round(solucao,4);
        }

        public double CalculaRegra2(double xi, double xe, double n)
        {
            double h = CalculaH(xe, xi, n);

            Console.WriteLine("h = " + h + " | " + " n = " + n);
            funcao1 = new ExemploFuncoes();

            soma = funcao1.FuncaoExemplo2B(xi);

            for (int i = 1; i < n; i++)
            {
                soma += 2 * funcao1.FuncaoExemplo2B(xi + h * i);
            }
            soma += funcao1.FuncaoExemplo2B(xe);

            solucao = h * soma / 2;

            return Math.Round(solucao, 5);
        }
        /*
        public double CalculaRegra2(double xi, double xe, double n, double h)
        {
            //((g*m)/c)*(1 - e^(-(c/m)*t));
            /*double g = 9.8;//m/s² aceleracao da gravidade
            double m = 68.1;//kg massa do paraquedista
            double c = 12.5;//kg/s coeficiente de arrasto
           
            funcao1 = new ExemploFuncoes();

            soma = funcao1.FuncaoExemplo2(xi);

            for (int i = 1; i < n; i++)
            {
                soma += 2 * funcao1.FuncaoExemplo2(xi + h * i);
            }
            soma += funcao1.FuncaoExemplo2(xe);

            solucao = h * soma / 2;

            return Math.Round(solucao, 4);
        }
         */
        private double CalculaH(double xe, double xi, double n)
        {
            return (xe - xi) / n;
        }

        public void CalculaRegraN(double xe, double xi, int nInicial, int nFinal)
        {
            Console.WriteLine("Regra do Trapézio: ");
            Console.WriteLine();
            for(int i = nInicial; i <= nFinal; i++)
            {
                Console.Write("n = " + i + " ");
                Console.WriteLine(" | "+ "I = " +CalculaRegra(xe, xi, i));

            }
        }

    }
}
