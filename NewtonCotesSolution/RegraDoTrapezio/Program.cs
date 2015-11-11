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
        const string equacaoExercicio = "v(t) = ((g*m)/c)*(1 - e^(-(c/m)*t))";
        const string equacaoExercicioAV1_24_1 = "deltaH = g * (0.132 + 1.56 *10^-4 * T + 2.64 * 10^-7 * T²)";

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

        private void ExecucaoExemploAV1_24_1()
        {
            RegraDoTrapezio exercicioAV1_24_1 = new RegraDoTrapezio();
            double[] H = { 300, 150, 100, 50, 25, 10, 5, 1, 0.05 };
            int[] n = { 1, 2, 3, 6, 12, 30, 60, 300, 6000 };
            double ti = -100, tf = 200;
            Console.WriteLine("Utilizacao da regra do trapezio para calcular a equacao: ");
            Console.WriteLine();
            Console.WriteLine(equacaoExercicioAV1_24_1);
            Console.WriteLine("Gramas: 1000 g");
            Console.WriteLine("Temperatura inicial " + ti + " °C");
            Console.WriteLine("Temperatura final " + tf + " °C");

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("H = " + H[i]);
                Console.WriteLine("s = " + exercicioAV1_24_1.CalculaExercicioAV1_24_1(ti, tf, n[i]));
            }
        }

        static void Main(string[] args)
        {
            Program RegraDoTrapezio = new Program();
           // RegraDoTrapezio.ExecucaoExercicioTrapezio();
            RegraDoTrapezio regra = new RegraDoTrapezio();
            Console.WriteLine(regra.CalculaRegraExemplo(0, 0.8, 100));
            //Não é necessário, utilizado para entender o problema 24.1
            //RegraDoTrapezio.ExecucaoExemploAV1_24_1();
            
            Console.ReadLine();




        }
    }
}
