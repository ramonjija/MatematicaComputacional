using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace RegraDoTrapezio
{
    class Program
    {
        const string equacaoExemplo = "f(x) = 0,2 + 25x − 200x2 + 675x3 − 900x4 + 400x5";
        const string equacaoExercicio = "v(t) = ((g*m)/c)*(1 - e^(-(c/m)*t));"; 

        private void ExecucaoExercicioTrapezio()
        {
            RegraDoTrapezio aplicacaoDaRegra = new RegraDoTrapezio();
            int[] segmentos = { 10, 20, 50, 100, 200, 500, 1000, 2000, 5000, 10000 };
            Console.WriteLine("Utilização da Regra do Trapezio para calcular o deslocamento do paraquedista: ");
            Console.WriteLine();
            Console.WriteLine(equacaoExercicio);
            Console.WriteLine();
            Stopwatch sw = new Stopwatch();
            TimeSpan tempo = TimeSpan.Zero;
            sw.Start();
            for (int i = 0; i < segmentos.Length; i++)
            {
                Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegraExercicio(0, 10, segmentos[i]));
                //Console.WriteLine("O sitema levou " + aplicacaoDaRegra.tempoTrapezio + " para ser resolvido");
            }
            sw.Stop();
            tempo = sw.Elapsed;
            Console.WriteLine();
            Console.WriteLine("O sistema levou " + tempo + " com a regra do trapezio para ser resolvido");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Program RegraDoTrapezio = new Program();
            RegraDoTrapezio.ExecucaoExercicioTrapezio();

            RegraDoTrapezio regra = new RegraDoTrapezio();
            Console.WriteLine(regra.CalculaRegraEq(4, 0, 0.8));

            Console.ReadLine();

        }
    }
}
