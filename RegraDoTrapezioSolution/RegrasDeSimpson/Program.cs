using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegraDoTrapezio;

namespace RegrasDeSimpson
{
    class Program
    {
        const string equacaoExemplo = "f(x) = 0,2 + 25x − 200x2 + 675x3 − 900x4 + 400x5";
        const string equacaoExercicio = "v(t) = ((g*m)/c)*(1 - e^(-(c/m)*t));";

        private void ExecucaoExemploSimpson()
        {
            FuncoesSimpson funcSimp = new FuncoesSimpson();
            RegraDoTrapezio.ExemploFuncoes funcExemplos = new ExemploFuncoes();
            /*Variaveis para o exercicio*/
            double a = 0, b = 0.8;
            int n = 4, nParImpar = 5;
            bool exercicio = false;

            Console.WriteLine("Utilizacao das funcoes para o exemplo:");
            Console.WriteLine();
            Console.WriteLine(equacaoExemplo);
            Console.WriteLine();

            Console.WriteLine("Resultado 1/3 = " + Math.Round(funcSimp.CalculaSimp13(a, b, exercicio), 6)); //OK Exemplo
            Console.WriteLine();

            Console.WriteLine("Resultado 1/3 Multiplo = " + Math.Round(funcSimp.CalculaSimp13m(a, b, n, exercicio), 6));// OK Exemplo
            Console.WriteLine();

            Console.WriteLine("Resultado 3/8 = " + Math.Round(funcSimp.CalculaSimp38(a, b, exercicio), 6)); //OK Exemplo
            Console.WriteLine();

            Console.WriteLine("Resultado Regra Multipla Par e Impar = " + Math.Round(funcSimp.CalculaSimpInt(a, b, nParImpar, exercicio), 6));// OK Exemplo
            Console.WriteLine();
        }

        private void ExecucaoExercicioSimpson()
        {
            FuncoesSimpson funcSimp = new FuncoesSimpson();
            RegraDoTrapezio.ExemploFuncoes funcExemplos = new ExemploFuncoes();
            /*Variaveis para o exercicio*/
            double a = 0, b = 10;
            int n = 10;
            bool exercicio = true;

            Console.WriteLine("Utilizacao das funcoes para o exercicio:");
            Console.WriteLine();
            Console.WriteLine(equacaoExercicio);
            Console.WriteLine();

            Console.WriteLine("Resultado 1/3 = " + Math.Round(funcSimp.CalculaSimp13(a, b, exercicio), 6)); //OK Exercicio
            Console.WriteLine("O sistema levou " + funcSimp.tempoSimp13 + " para ser resolvido");
            Console.WriteLine();


            Console.WriteLine("Resultado 1/3 Multiplo = " + Math.Round(funcSimp.CalculaSimp13m(a, b, n, exercicio), 6)); //OK Exercicio
            Console.WriteLine("O sistema levou " + funcSimp.tempoSimp13m + " para ser resolvido");
            Console.WriteLine();

            Console.WriteLine("Resultado 3/8 = " + Math.Round(funcSimp.CalculaSimp38(a, b, exercicio), 6)); //OK Exercicio
            Console.WriteLine("O sistema levou " + funcSimp.tempoSimp38 + " para ser resolvido");
            Console.WriteLine();

            Console.WriteLine("Resultado Regra Multipla Par e Impar = " + Math.Round(funcSimp.CalculaSimpInt(a, b, n, exercicio), 6));// OK Exercicio
            Console.WriteLine("O sistema levou " + funcSimp.tempoSimpInt + " para ser resolvido");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            Program regrasDeSimpson = new Program();

            regrasDeSimpson.ExecucaoExemploSimpson();
            regrasDeSimpson.ExecucaoExercicioSimpson();

            Console.ReadKey();

        }
    }
}
