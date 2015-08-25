using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SistemasLinearesApp
{
    class Program
    {
        public void simples()
        {
            int[] ListaDeVariaveis = new int[10];
            int[] ListaDeNumeros = new int[10];
            int tamanhoDaArray;
            string numeroLido;
            double resultadoFinal = 0.0000f;

            Console.WriteLine("Este sistema resolve equações do tipo aX+b:");

            //tamanhoDaArray = Convert.ToInt32(Console.ReadLine()) + 1;
            tamanhoDaArray = 2;
            Console.WriteLine("Digite o valor dos coeficientes (a e b) com o sinal.");
            for (int i = 1; i <= tamanhoDaArray; i++)
            {
                
                Console.WriteLine("Digite o valor do numero " + i);
                numeroLido = Console.ReadLine();
                if (numeroLido != "")
                {
                    ListaDeNumeros[i] = Convert.ToInt32(numeroLido);
                }
                else
                {
                    --i;
                    Console.WriteLine("Digite um numero.");
                }
            }

            if (--tamanhoDaArray == 1)
            {
                resultadoFinal = Convert.ToDouble(-ListaDeNumeros[2]) / Convert.ToDouble(ListaDeNumeros[1]);
            }

            Console.WriteLine(resultadoFinal);
            Console.ReadLine();
        }

        public void gauss()
        {
            //Exemplos de utilização
            //double[] b = { 15, 10, 11 };
            //double[,] a = { { 5, 5, 0 }, { 2, 4, 1 }, { 3, 4, 0 } };

            //double[] b = { 2, 1, 3 };
            //double[,] a = { { 1, -1, 2 }, { 2, 1, -1 }, { -2, -5, 3 } };
            //OK
            //double[] b = { 6, 8, -1 };
            //double[,] a = { { 0.5, -1, 1 }, { 3, 2, 1 }, { 5, -1, -3 } };
            //OK
            Stopwatch sw = new Stopwatch();
            TimeSpan tempo = TimeSpan.Zero;
            sw.Start();
            //double[] b = { 15, 10, 11 };
            //double[,] a = { { 5, 5, 0 }, { 2, 4, 1 }, { 3, 4, 0 } };

            double[] b = { 7, 3, -5 };
            double[,] a = { { 4, 2, -9 }, {5, -6, -8 }, { 1, -2, 15 } };



            double[] x = new double[b.Length];

            int k, i, j; int n = b.Length; double m;

            for (k = 0; k <= n - 2; k++)
            {
                for (i = k + 1; i <= n - 1; i++)
                {
                    m = a[i, k] / a[k, k];

                    for (j = 0; j < n; j++)
                    {
                        a[i, j] = a[i, j] - (m * a[k, j]);
                    }
                    b[i] = b[i] - (m * b[k]);

                }
            }
            //Até aqui o calculo está correto!

            x[n - 1] = b[n - 1] / a[(n - 1), (n - 1)];
            for (k = n - 2; k >= 0; k--)
            {
                x[k] = b[k];
                for (i = k + 1; i <= n - 1; i++)
                {
                    x[k] = x[k] - a[k, i] * x[i];
                }
                x[k] = x[k] / a[k, k];
            }
            sw.Stop();
            tempo = sw.Elapsed;
            Console.WriteLine("Resultado utilizando o método de Gauss: X, Y e Z");
            Console.WriteLine("");
            for (i = 0; i < x.Length; i++)
            {
                Console.WriteLine(Math.Round((x[i]),3));
            }
            Console.WriteLine("");
            Console.WriteLine("O sistema levou: " + tempo + " com o metodo de Gauss para ser resolvido");
            Console.WriteLine("");
            //Console.ReadKey();
            //OK! Funcionando corretamente
        }

        public void jacobi()
        {
            Stopwatch sw = new Stopwatch();
            TimeSpan tempo = TimeSpan.Zero;
            sw.Start();
            int i, j, k;
            //double soma = 0;
            //double[,] a = { { 2, 3 }, { 5, 7 } };//Matriz dos coeficientes


            //double[,] a = { { 5, -2, 1 }, { -1, -7, 3 }, { 2, 1, 8 } };<---
            //NOVO TESTE 
            double[] b = { 7, 3, -5 };
            double[,] a = { { 4, 2, -9 }, { 5, -6, -8 }, { 1, -2, 15 } };
            //

            //double[] x0 = new double[a.Length];//Vetor de 0

            //double[] b = { 11, 13 };//vetor dos termos constantes
            //double[] b = { 3, -2, 1 }; <---
            double[] x0 = new double[b.Length];

            //double[] vA = { 1.1, 2.3, 3.3 };//vetor de aproximação inicial

            //double[] vA = { 0, 0, 0 };<---
            double[] vA = { 1, 2, 3 };

            //const int tol = 2; //Tolerancia
            const int numDeIteracoes = 50; //Numero maximo de iterações
            double[] soltem = new double[3];
            double[] sol = new double[3];

            int numDeLinhas = 3;

            //Cria zeros na Eq.
            Utilidades.zeros(x0);

            //Inicia a iteração
            k = 1;
            Console.WriteLine("Resultado por Jacobi com " + numDeIteracoes + " iteracoes:");
            Console.WriteLine("");
            while (k <= numDeIteracoes)
            {

                //Iteração de Jacobi
                for (i = 0; i < numDeLinhas; i++)
                {
                    x0[i] = 0;
                    for (j = 0; j <= numDeLinhas - 1; j++)
                    {
                        if (i != j)
                        {
                            Math.Round((x0[i] += a[i, j] * vA[j]),3);
                        }

                    }
                    x0[i] = Math.Round(((b[i] - x0[i]) / a[i, i]), 3);

                }
                Array.Copy(x0, vA, x0.Length);
                //Critério de parada

                /*if (Math.Abs(b[i] - x0[i]) < tol)
                {
                    Console.WriteLine(x0[i]);
                    break;
                }
                Array.Copy(x0, b, numDeLinhas);
                k = k + 1;
                x0[i - 1] = b[i - 1];
                */

                Console.WriteLine("Iteração " + k);
                k = k + 1;
                for (int l = 0; l < numDeLinhas; l++)
                {
                    Console.WriteLine(x0[l]);
                }
                Console.WriteLine("");
            }
            sw.Stop();
            tempo = sw.Elapsed;
            Console.WriteLine("O sistema levou " + tempo + " com o metodo de Jacobi para ser resolvido");
            Console.WriteLine("");
            //Console.ReadKey();

        }

        public void gaussSeidel() //OK
        {
            Stopwatch sw = new Stopwatch();
            TimeSpan tempo;
            sw.Start();
            int i, j, k;
            double soma = 0;
            //double[,] a = { { 5, -2, 1 }, { -1, -7, 3 }, { 2, 1, 8 } };
            //double[] b = { 3, -2, 1 };

            //NOVO TESTE 
            double[] b = { 7, 3, -5 };
            double[,] a = { { 4, 2, -9 }, { 5, -6, -8 }, { 1, -2, 15 } };

            double[] x0 = { 1, 2, 3 }; //new double[b.Length];
            //double[] vA = { 0, 0, 0 };
            const int numDeIteracoes = 50;
            double[] soltem = new double[3];
            double[] sol = new double[3];

            int numDeLinhas = 3;

            //Cria zeros na Eq.
            //Utilidades.zeros(x0);
            

            //Inicia a iteração
            k = 1;
            Console.WriteLine("Resultado por Gauss-Seidel com " + numDeIteracoes + " iteracoes:");
            Console.WriteLine("");
            while (k <= numDeIteracoes)
            {

                //Iteração de Gauss-Seidell
                for (i = 0; i < numDeLinhas; i++)
                {
                    soma = 0;
                    for (j = 0; j <= numDeLinhas - 1; j++)
                    {
                        if (i != j)
                        {
                            soma += Math.Round((a[i, j] * x0[j]),3);
                        }

                    }
                    x0[i] = Math.Round(((b[i] - soma) / a[i, i]),3);

                }
                //Array.Copy(x0, vA, x0.Length);
                //Critério de parada

                /*if (Math.Abs(b[i] - x0[i]) < tol)
                {
                    Console.WriteLine(x0[i]);
                    break;
                }
                Array.Copy(x0, b, numDeLinhas);
                k = k + 1;
                x0[i - 1] = b[i - 1];
                */
                //Array.Copy(x0, b, numDeLinhas);
                Console.WriteLine("Iteração " + k);
                k = k + 1;
                for (int l = 0; l < numDeLinhas; l++)
                {
                    Console.WriteLine(x0[l]);
                }
                Console.WriteLine("");
            }
            sw.Stop();
            tempo = sw.Elapsed;
            Console.WriteLine("O sistema levou " + tempo + " com o metodo de Seidel para ser resolvido");
            Console.WriteLine("");
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {

            Program Sistema = new Program();
            //Sistema.simples();
            Sistema.gauss();
            Console.ReadKey();
            Sistema.jacobi();
            Console.ReadKey();
            Sistema.gaussSeidel();

        }
    }
}
