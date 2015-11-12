using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Funcoes;

namespace MetodosDeRungeKutta
{
    public class FuncoesDeEuler
    {

        public double[] xp { get; private set; }
        public double[] yp { get; private set; }
        //public double x { get; private set; }
        //public double y { get; private set; }

        /// <summary>
        /// Implementacao da funcao de euler simples
        /// </summary>
        /// <param name="xi">limite inicial</param>
        /// <param name="xf">limite final</param>
        /// <param name="dx">tamanho do passo</param>
        public void EulerSimples(double xi, double xf, double dx)
        {
            double x, y;
            double nc; // numero de passos do calculo
            double dydx;//derivada


            x = xi;
            y = 1;

            //dx tamanho do passo
            nc = (xf - xi) / dx;

            Console.WriteLine("Condicoes Iniciais ");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine();
            Console.WriteLine("Saidas: ");

            //Laco para implementar o metodo de euler e mostrar os resultados

            for (int i = 1; i <= nc; i++)
            {
                dydx = ExemploFuncoes.FuncaoEulerSimples(x);
                y += dydx * dx;
                x += dx;
                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);
                Console.WriteLine();
            }


        }
        /// <summary>
        /// Implementacao da funcao de euler simples com valores padrao do livro
        /// </summary>
        public void EulerSimples()
        {
            double x, y;
            double xi = 0, xf = 4;
            double nc; // numero de passos do calculo
            double dydx;//derivada
            double dx = 0.5;
            //ExemploFuncoes funcEuler = new ExemploFuncoes();

            x = xi;
            y = 1;

            //dx tamanho do passo
            nc = (xf - xi) / dx;

            Console.WriteLine("Condicoes Iniciais ");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine();
            Console.WriteLine("Saidas: ");

            //Laco para implementar o metodo de euler e mostrar os resultados

            for (int i = 1; i <= nc; i++)
            {
                dydx = ExemploFuncoes.FuncaoEulerSimples(x);
                y += dydx * dx;
                x += dx;
                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);
                Console.WriteLine();
            }


        }

        /*VERSAO 1 DA IMPLEMENTACAO DO ALGORITMO MELHORADO*/
        /*
        public List<Dictionary<double,double>> EulerModularMelhorada(double y, double xi, double xf, double dx, double xout)
        {
            List<Dictionary<double, double>> listaRespostasXY = new List<Dictionary<double, double>>();
            Dictionary<double, double> respostasXY = new Dictionary<double, double>();

            double x, xend, h;
            int m;
            //xp = new double[20];
            //yp = new double[20];

            x = xi;
            m = 0;
            //yp[m] = x;
            //yp[m] = y;

            //respostasXY[m] = new Dictionary<double, double>();
            respostasXY.Add(x, y);
            //respostasXY[m].Add(x, y);


            while (true)
            {
                xend = x + xout;
                if (xend > xf)
                {
                    xend = xf;
                }
                h = dx;
                Integrador(ref x, ref y, h, xend, ref respostasXY);
                listaRespostasXY.Add(respostasXY);
                m += 1;
                // Valores do vetor
                if (x >= xf)
                {
                    break;
                }
                //respostasXY[m] = new Dictionary<double, double>();
            }   
            return listaRespostasXY;

        }

        private void Integrador(ref double x, ref double y, double h, double xend, ref Dictionary<double,double> respostaXY)
        {
            while (true)
            {
                if (xend - x < h)
                {
                    h = xend - x;
                }
                //Euler(x, y, h, ynew);
                y = Euler(ref x, y, h);
                respostaXY.Add(x, y);
                
                if (x >= xend)
                {
                    break;
                }
            }
        }

        private double Euler(ref double x, double y, double h)
        {
            //Devis(x, y, h, ynew);
            //ynew = y + dydx * h;
            double ynew;
            ynew = y + Derivs(x, y, h) * h;
            x += h;
            return ynew;
        }

        private double Derivs(double x, double y, double dx)
        {
            double dydx = ExemploFuncoes.FuncaoEulerSimples(x);
            y += dydx * dx;
            x += dx;

            return dydx;
        }
        */



        /*VERSAO 2 DA IMPLEMENTACAO DO ALGORITMO MELHORADO*/
        public void EulerModularMelhorada2(double y, double xi, double xf, double dx, double xout)
        {
            double x, xend, h;
            int m;
            double[] xp = new double[99];
            double[] yp = new double[99];

            x = xi;
            m = 0;
            yp[m] = x;
            yp[m] = y;

            while (true)
            {
                xend = x + xout;
                if (xend > xf)
                {
                    xend = xf;
                }
                h = dx;
                Integrador(ref x, y, h, xend, ref yp, ref xp, m);
                //m = m + 1;
                //adiciona x e y no vetor
                if (x >= xf)
                {
                    break;
                }

            }
            //Mostra os resultados de 0 ate xout
            Console.WriteLine("Intervalo de saida definido de 0 até " + xout);
            Console.WriteLine();
            for (int i = 0; i <= xout; i++)
            {
                
                Console.WriteLine("x["+i+"]: " + xp[i]);
                Console.WriteLine("y["+i+"]: " + yp[i]);
                Console.WriteLine();
            }
        }

        private void Integrador(ref double x, double y, double h, double xend, ref double[] yp, ref double[] xp, int m)
        {
           
            while (true)
            {
                m = m + 1;
                if (xend - x < h)
                {
                    h = xend - x;
                }
                //Euler(x, y, h, ynew);
                y = Euler(ref x, y, h);
                yp[m] = y;
                xp[m] = x;

                if (x >= xend)
                {
                    break;
                }
                //m = m + 1;
            }
        }

        private double Euler(ref double x, double y, double h)
        {
            //Devis(x, y, h, ynew);
            //ynew = y + dydx * h;
            double ynew;
            ynew = y + Derivs(x, y, h) * h;
            x += h;
            return ynew;
        }

        private double Derivs(double x, double y, double dx)
        {
            double dydx = ExemploFuncoes.FuncaoEulerSimples(x);
            y += dydx * dx;
            x += dx;

            return dydx;
        }
    }
}

