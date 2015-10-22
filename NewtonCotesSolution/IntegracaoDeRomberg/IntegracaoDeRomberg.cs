using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using RegraDoTrapezio;
using RegrasDeSimpson;

namespace IntegracaoDeRomberg
{
    class IntegracaoDeRomberg
    {

        public int iteracoes { get; set; }
        public TimeSpan tempoExecucao { get; set; }

        public double CalculaIntegracao(double a, double b, int maxit, double es)
        {

            Stopwatch sw = new Stopwatch();
            tempoExecucao = TimeSpan.Zero;
            sw.Start();

            RegraDoTrapezio.RegraDoTrapezio trap = new RegraDoTrapezio.RegraDoTrapezio();
            FuncoesSimpson simp = new FuncoesSimpson();
            double[,] I = new double[maxit, maxit];
            double ea = 0;
            int n = 1;
            int j = 0;
            int iter = 0;
            double solucao = 0;
            I[1, 1] = trap.CalculaRegraEq(n, a, b);

            while (true)
            {
                iter += 1;
                
                n = (int)Math.Pow(2, iter);
               
                I[iter+1,1] = trap.CalculaRegraEq(n, a, b);

                for(int k = 2; k <= iter + 1; k++)
                {
                    j = 2 + iter - k;
                    I[j, k] = (Math.Pow(4, k - 1) * I[j + 1, k - 1] - I[j, k - 1]) / (Math.Pow(4, k - 1) - 1);
                }
                ea = Math.Abs((I[1, iter] - I[2, iter - 1]) / I[1, iter]) * 100;
                if(iter >= maxit || ea <= es)
                {
                    break;
                }
            }

            iteracoes = iter;
            solucao = Math.Round(I[1, iter + 1],6);
            sw.Stop();

            tempoExecucao = sw.Elapsed;

            return solucao;
        }
    }
}
