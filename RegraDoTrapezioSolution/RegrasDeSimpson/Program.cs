using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegraDoTrapezio;

namespace RegrasDeSimpson
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncoesSimpson funcSimp = new FuncoesSimpson();
            RegraDoTrapezio.ExemploFuncoes funcExemplos = new ExemploFuncoes();


            Console.WriteLine("Resultado 1/3 = " + Math.Round(funcSimp.CalculaSimp13(0.4, funcExemplos.FuncaoExemplo1(0), funcExemplos.FuncaoExemplo1(0.4), funcExemplos.FuncaoExemplo1(0.8)),6)); //OK Exemplo
            Console.WriteLine();

            Console.WriteLine("Resultado 1/3 Multiplo = " + Math.Round(funcSimp.CalculaSimp13m(0.2, 4),6));// OK Exemplo
            Console.WriteLine();

            double hPara38 = 0.8 / 3;
            Console.WriteLine("Resultado 3/8 = " + Math.Round(funcSimp.CalculaSimp38(hPara38, funcExemplos.FuncaoExemplo1(0), funcExemplos.FuncaoExemplo1(0.2667), funcExemplos.FuncaoExemplo1(0.5333), funcExemplos.FuncaoExemplo1(0.8)), 6)); //OK Exemplo
            Console.WriteLine();

            Console.WriteLine("Resultado 3/8 Multiplo = " + Math.Round(funcSimp.CalculaSimpInt(0, 0.8, 5),6));// OK Exemplo
            Console.ReadLine();


        }
    }
}
