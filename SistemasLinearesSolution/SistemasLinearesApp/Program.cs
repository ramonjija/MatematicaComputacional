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

            Console.WriteLine("Digite quantas incognitas o sistema possui:");

            tamanhoDaArray = Convert.ToInt32(Console.ReadLine()) + 1;
            for (int i = 1; i <= tamanhoDaArray; i++)
            {
                Console.WriteLine("A seguir deve-se digitar o valor dos coeficientes (a, b, c, etc) com o sinal.");
                Console.WriteLine("Digite o valor do numero " + i);
                numeroLido = Console.ReadLine();
                if (numeroLido != "")
                {
                    ListaDeNumeros[i] = Convert.ToInt32(numeroLido);
                }
                else
                {
                    --i;
                    Console.WriteLine("Digite um valor.");
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
            TimeSpan tempo;
            sw.Start();
            double[] b = { 15, 10, 11 };
            double[,] a = { { 5, 5, 0 }, { 2, 4, 1 }, { 3, 4, 0 } };

            double[] x = new double[3];

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
                Console.WriteLine(x[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("O sistema levou: " + tempo + " para ser resolvido");

            //OK! Funcionando corretamente
        }

        public void jacobi()
        {
            int i, j, k;
            double soma = 0;
            //double[,] a = { { 2, 3 }, { 5, 7 } };//Matriz dos coeficientes
            //double[,] a = { { 3, -1, -1 }, { -1, 3, 1 }, { 2, 1, 4 } };
            //double[,] a = { { 5, -2, 1 }, { 0.5, 3, 2 }, { -25, 0.5, 2 } };

            //double[,] a = { { 4, -2, 1 }, { 1, 5, 3 }, { 2, 1, 4 } };
            double[,] a = { { 5, -2, 1 }, { -1, -7, 3 }, { 2, 1, 8 } };
            //double[] x0 = new double[a.Length];//Vetor de 0
            
            //double[] b = { 11, 13 };//vetor dos termos constantes
            //double[] b = { 1, 3, 7 };

            //double[] b = { 2, 1, 3 };

            double[] b = { 3, -2, 1 };
            double[] x0 = new double[b.Length];
            //double[] b = { -0.5, 2.5, 1 };
            //double[] vA = { 1.1, 2.3, 3.3 };//vetor de aproximação inicial

            //double[] vA = { 1, 2, 3 };

            double[] vA = { 0, 0, 0 };

            //const int tol = 2; //Tolerancia
            const int numDeIteracoes = 10; //Numero maximo de iterações
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
                    //x0[i] = 0;
                    for (j = 0; j <= numDeLinhas - 1; j++)
                    {
                        //if (i == j) continue;
                        if (i != j)
                        {
                            //x0[j] += a[i, j] * vA[j];
                            soma += a[i, j] * vA[j];
                        }

                        //x0[i] = x0[i] - a[i, j] * vA[j];
                        //x0[i] + a[i, j] * vA[j];
                    }
                    //x0[i] = (x0[i] + b[i]) / a[i, i];
                    //soltem[i] = (x0[i] + b[i]) / a[i, i]; //(a[i, j - 1] - x0[i]) / a[i, i];
                    
                    //soltem[i] = (b[i] - x0[i]) / a[i, i];

                    //x0[i] = (b[i] - x0[i]) / a[i, i];
                    
                    x0[i] = (b[i] - soma) / a[i, i];
                   
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
            Console.ReadKey();


            /*int i, j, k;
            bool retorno = true;
            float soma = 0;
            double[,] x = { { 5, 5, 0 }, { 2, 4, 1 }, { 3, 4, 0 } };
            double[] x0 = new double[x.Length];
            
            Utilidades.zeros(x0);

            /*copiar( x0 , x ) ;
            if(diagonalmenteDominante(a) ) {
            for (k =1; k<=maximo ; k ++) {
            soma = 0 ;
            for ( i =0; i< a.Length; i++) {
            for ( j =0; j< a.Length; j++) {
            if ( i != j ) {
            soma = soma + (a[i,j]∗x0[j] ) ;
            }
            }
            x[i] = (b[i]−soma)/a[i,i] ;
            }
            if(parar(x, x0)) {
            break;
            }
            copiar(x, x0) ;
            }
            if(k >= maximo){
            retorno = false ;
            }
            else retorno = true;
            }
            return (retorno) ;*/

        }

        public void gaussSeidel()
        {
            throw new NotImplementedException();
        }


        public static void Main(string[] args)
        {

            Program Sistema = new Program();
            //Sistema.gauss();
            //Sistema.simples();
            Sistema.jacobi();


        }
    }
}
