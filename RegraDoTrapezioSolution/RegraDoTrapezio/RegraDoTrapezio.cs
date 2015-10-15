using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace RegraDoTrapezio
{
   public class RegraDoTrapezio
    {
        public TimeSpan tempoTrapezio { get; set; }

        double solucao = 0;
        ExemploFuncoes funcao1;
        double soma = 0;

        public double CalculaRegraSimples(double h, double f0, double f1)
        {
            return h * (f0 + f1) / 2;
        }
        
        //Exemplo Livro
        public double CalculaRegraExemplo(double xi, double xe, double n)
        {
            double h = CalculaH(xe, xi, n);
            funcao1 = new ExemploFuncoes();

            soma = funcao1.FuncaoExemplo(xi);

            for(int i = 1; i < n; i++)
            {
                soma += 2 * funcao1.FuncaoExemplo(xi + h * i);
            }
            soma += funcao1.FuncaoExemplo(xe);

            solucao = h * soma / 2;

            return Math.Round(solucao,4);
        }

        //Exercicio Livro
        public double CalculaRegraExercicio(double xi, double xe, double n)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double h = CalculaH(xe, xi, n);

            Console.WriteLine("h = " + h + " | " + " n = " + n);
            funcao1 = new ExemploFuncoes();
            
            //Funcao Paraquedista
            soma = funcao1.FuncaoExercicio(xi);

            for (int i = 1; i < n; i++)
            {
                soma += 2 * funcao1.FuncaoExercicio(xi + h * i);
            }
            soma += funcao1.FuncaoExercicio(xe);

            solucao = h * soma / 2;

            sw.Stop();

            tempoTrapezio = sw.Elapsed;

            return Math.Round(solucao, 5);
        }
       
        private double CalculaH(double xe, double xi, double n)
        {
            return (xe - xi) / n;
        }

        //Exemplo Livro
        public void CalculaRegraN(double xe, double xi, int nInicial, int nFinal)
        {
            Console.WriteLine("Regra do Trapézio: ");
            Console.WriteLine();
            for(int i = nInicial; i <= nFinal; i++)
            {
                Console.Write("n = " + i + " ");
                Console.WriteLine(" | "+ "I = " +CalculaRegraExemplo(xe, xi, i));

            }
        }

    }
}
