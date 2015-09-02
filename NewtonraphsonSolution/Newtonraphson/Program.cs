using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Newtonraphson
{
    class Program
    {

        public void FuncaoNewtonraphson(double inicio, int exemplo, double tolerancia) {

            //double inicio = 0;
            //double tolerancia = 0.0000001;
            double xn = 0.0;
            double x = inicio;
            int i = 0;
            Stopwatch sw = new Stopwatch();
            TimeSpan tempo = TimeSpan.Zero;


            ExemploFuncoes funcoesUtilizadas = new ExemploFuncoes();

            switch (exemplo)
            {
                case 1:
                    Console.WriteLine("Iteracao " + i + " = " + x);
                    sw.Start();
                    while (true)
                    {

                        xn = Math.Round(x - (funcoesUtilizadas.FuncaoExemplo1(x) / funcoesUtilizadas.DerivadaFuncaoExemplo1(x)), 6);


                        if (Math.Abs(x - xn) < tolerancia)
                        {
                            //Encontrei a raiz
                            Console.WriteLine("Iteracao " + (i+1) + " = " + xn);
                            break;

                        }
                        else
                        {
                            x = xn;
                            i++;
                            Console.WriteLine("Iteracao " + i + " = " + xn);

                        }

                    }
                    sw.Stop();
                    tempo = sw.Elapsed;

                    break;

                case 2:

                    Console.WriteLine("Iteracao " + i + " = " + x);
                    sw.Start();
                    while (true)
                    {

                        xn = Math.Round(x - (funcoesUtilizadas.FuncaoExemplo2(x) / funcoesUtilizadas.DerivadaFuncaoExemplo2(x)), 6);


                        if (Math.Abs(x - xn) < tolerancia)
                        {
                            //Encontrei a raiz
                            Console.WriteLine("Iteracao " + (i + 1) + " = " + xn);
                            break;

                        }
                        else
                        {
                            x = xn;
                            i++;
                            Console.WriteLine("Iteracao " + i + " = " + xn);

                        }

                    }
                    sw.Stop();
                    tempo = sw.Elapsed;

                    break;

                case 3:

                    Console.WriteLine("Iteracao " + i + " = " + x);
                    sw.Start();
                    while (true)
                    {

                        xn = Math.Round(x - (funcoesUtilizadas.FuncaoExemplo3(x) / funcoesUtilizadas.DerivadaFuncaoExemplo3(x)), 6);


                        if (Math.Abs(x - xn) < tolerancia)
                        {
                            //Encontrei a raiz
                            Console.WriteLine("Iteracao " + (i + 1) + " = " + xn);
                            break;

                        }
                        else
                        {
                            x = xn;
                            i++;
                            Console.WriteLine("Iteracao " + i + " = " + xn);

                        }

                    }
                    sw.Stop();
                    tempo = sw.Elapsed;

                    break;

                default:

                    Console.WriteLine("Função não encontrada");
                    break;
                    
            }
            Console.WriteLine("");
            Console.WriteLine("Raiz utilizando o valor inicial " + inicio + " e tolerancia " + tolerancia);
            Console.WriteLine("");
            Console.WriteLine(xn);
            Console.WriteLine("");
            Console.WriteLine("O sistema levou " + tempo + " para ser resolvido");
            Console.WriteLine("");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program newtonraphson = new Program();

            int[] exemploEscolhido = { 0, 1, 2, 3 };
            double valorInicialInferior = 0.6;
            double tolerancia = 0.00001;
            //double valorInicialSuperior = 3;

            newtonraphson.FuncaoNewtonraphson(valorInicialInferior, exemploEscolhido[1], tolerancia);
            newtonraphson.FuncaoNewtonraphson(valorInicialInferior, exemploEscolhido[2], tolerancia);
            newtonraphson.FuncaoNewtonraphson(valorInicialInferior, exemploEscolhido[3], tolerancia);


        }
    }
}
