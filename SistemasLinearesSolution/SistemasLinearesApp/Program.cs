using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasLinearesApp
{
    class Program
    {
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
                        a[i,j] = a[i,j] - (m * a[k,j]);
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
            for (i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            //OK! Funcionando corretamente
        }
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

        

        // public void jacobi() { }
        // public void gaussSeidel { }




        public static void Main(string[] args)
        {

            Program Sistema = new Program();
            Sistema.gauss();
            Sistema.simples();                       


        }
    }
}
