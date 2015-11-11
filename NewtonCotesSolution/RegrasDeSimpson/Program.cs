using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegraDoTrapezio;
using Funcoes;

namespace RegrasDeSimpson
{
    class Program
    {
        const string equacaoExemplo = "f(x) = 0,2 + 25x − 200x2 + 675x3 − 900x4 + 400x5";
        const string equacaoExercicio = "v(t) = ((g*m)/c)*(1 - e^(-(c/m)*t));";
        const string equacaoExercicioAV1_24_1 = "deltaH = g * (0.132 + 1.56 *10^-4 * T + 2.64 * 10^-7 * T²);";

        private void ExecucaoExemploSimpson()
        {
            FuncoesSimpson funcSimp = new FuncoesSimpson();
            ExemploFuncoes funcExemplos = new ExemploFuncoes();
            double a = 0, b = 0.8;
            int n = 4, nParImpar = 5;
            bool exercicio = false;

            Console.WriteLine("Utilizacao das funcoes para o exemplo:");
            Console.WriteLine();
            Console.WriteLine(equacaoExemplo);
            Console.WriteLine();

            Console.WriteLine("Resultado 1/3 = " + Math.Round(funcSimp.CalculaSimp13(a, b, exercicio, 12), 6)); //OK Exemplo
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
            ExemploFuncoes funcExemplos = new ExemploFuncoes();
            double a = 0, b = 10;
            int n = 10;
            int nEq = 256;
            bool exercicio = true;

            Console.WriteLine("Utilizacao das funcoes para o exercicio:");
            Console.WriteLine();
            Console.WriteLine(equacaoExercicio);
            Console.WriteLine();

            Console.WriteLine("Resultado 1/3 = " + Math.Round(funcSimp.CalculaSimp13(a, b, exercicio, 100), 6)); //OK Exercicio
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

            //Exercicio Romberg
            Console.WriteLine("Aplicação no exemplo 21.1 como solicitado na aula 3");
            Console.WriteLine("Resultado Regra 1/3 quando a funcao e conhecida = " + Math.Round(funcSimp.CalculaSimpEq(nEq, 0, 0.8), 6));// OK Exercicio
            Console.WriteLine("O utilizando " + nEq + " segmentos");
            Console.WriteLine("O sistema levou " + funcSimp.tempoSimpInt + " para ser resolvido");

            Console.WriteLine();
        }
        private void ExecucaoExercicioAV1_24_1()
        {
            FuncoesSimpson funcAv1 = new FuncoesSimpson();
            double g = 1200;
            double ti = -150, tf = 100, inc = 50;

            Console.WriteLine("Utilização da funcao do exercicio 24.1:");
            Console.WriteLine();
            Console.WriteLine(equacaoExercicioAV1_24_1);
            Console.WriteLine();
            Console.WriteLine("Resultado da utilizacao de simpson 1/3 com: ");
            Console.WriteLine("Gramas: " + g + " g");
            Console.WriteLine("Temperatura inicial: " + ti + " °C");
            Console.WriteLine("Temperatura final: " + tf + " °C");
            Console.WriteLine("Incremento: " + inc + " °C");
            Console.WriteLine();
            Console.WriteLine("Quantidade de calor " + funcAv1.CalculaSimp13mAV1_24_1(ti, tf, inc, g)+" cal");
        }

        static void Main(string[] args)
        {

            Program regrasDeSimpson = new Program();

            regrasDeSimpson.ExecucaoExemploSimpson();
            //regrasDeSimpson.ExecucaoExercicioSimpson();
            //regrasDeSimpson.ExecucaoExercicioAV1_24_1();

            Console.ReadKey();

        }
    }
}
