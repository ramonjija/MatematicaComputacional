using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosDeRungeKutta
{
    class Program
    {
        static void Main(string[] args)
        {

            FuncoesDeEuler funcExemplo1 = new FuncoesDeEuler();
            //funcExemplo1.EulerSimples(0, 4, 0.5);
            //funcExemplo1.EulerSimples();
            //Console.ReadLine();

            funcExemplo1.EulerModularMelhorada(1, 0, 4, 0.5, 10);

           
            Console.ReadLine();

        }
    }
}
