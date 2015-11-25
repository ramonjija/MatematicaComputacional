using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosDeRungeKutta
{
    class Program
    {
        private void exibeEulerModular(List<Dictionary<double, double>> listaDeRespostas)
        {
            foreach (Dictionary<double, double> valorDic in listaDeRespostas)
            {
                foreach (var key in valorDic.Keys)
                {
                    Console.WriteLine("x: " + key);
                    Console.WriteLine("y: " + valorDic[key]);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

        private void executaEuler()
        {
            /*
            FuncoesDeEuler funcExemplo1 = new FuncoesDeEuler();
            funcExemplo1.EulerSimples(0, 4, 0.5);
            funcExemplo1.EulerSimples();

            Console.WriteLine("Execucao da funcao modular melhorada de euler");
            List<Dictionary<double, double>> respostasxy = funcExemplo1.EulerModularMelhorada(1, 0, 4, 0.5, 10);

            exibeEulerModular(respostasxy);
            */

        }

        static void Main(string[] args)
        {
            /*
            Program euler = new Program();
            euler.executaEuler();
            
            
            CORRETO
            */
            FuncoesDeEuler eulerTeste = new FuncoesDeEuler();
            eulerTeste.EulerModularMelhorada2(1, 0, 4, 0.5, 7);
            Console.ReadLine();

            FuncoesDeRKeRalston testeRalston = new FuncoesDeRKeRalston();
            testeRalston.CalculaRalston(0, 4, 0.5);
            Console.ReadLine();

            FuncoesDeRKeRalston testeRK4 = new FuncoesDeRKeRalston();
            testeRK4.CalculaRK4Ordem(0, 4, 0.5);
            Console.ReadLine();
        }
    }
}
