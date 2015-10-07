using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegraDoTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            RegraDoTrapezio aplicacaoDaRegra = new RegraDoTrapezio();
            //Console.WriteLine(regra1.CalculaRegra(0, 0.8, 2));
            //Console.WriteLine();
            //regra1.CalculaRegraN(0, 0.8, 2, 10);
            Console.WriteLine("Utilização da Regra do Trapezio para calcular o deslocamento do paraquedista: ");
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 10));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 20));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 50));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 100));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 200));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 500));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 1000));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 2000));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 5000));
            Console.WriteLine();
            Console.WriteLine("I = " + aplicacaoDaRegra.CalculaRegra2(0, 10, 10000));

            //Console.WriteLine(regra1.CalculaRegra2(0,10,10,1));
            Console.ReadLine();

        }
    }
}
