using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegracaoDeRomberg
{
    class Program
    {
        const string equacaoExemplo = "f(x) = 0,2 + 25x − 200x2 + 675x3 − 900x4 + 400x5";

        private void ExecucaoExercicioRomberg()
        {
            IntegracaoDeRomberg romberg = new IntegracaoDeRomberg();
            Console.WriteLine("Utilização de Romberg para calcular a integral da equacao: ");
            Console.WriteLine();
            Console.WriteLine(equacaoExemplo);
            Console.WriteLine();
            Console.WriteLine("O valor da integral é " + romberg.CalculaIntegracao(0, 0.8, 20, 1.623467) + " com " + romberg.iteracoes + " iteracoes");
            Console.WriteLine();
            Console.WriteLine("O sistema levou " + romberg.tempoExecucao + " para ser executado");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program IntegracaoDeRomberg = new Program();
            IntegracaoDeRomberg.ExecucaoExercicioRomberg();
        }
    }
}
