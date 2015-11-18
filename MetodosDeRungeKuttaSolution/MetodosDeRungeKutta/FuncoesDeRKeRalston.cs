using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Funcoes;

namespace MetodosDeRungeKutta
{
    class FuncoesDeRKeRalston
    {
        public void CalculaRalston(double xi, double xf, double h)
        {

            double solucao = 0;
            double yi = 1;
            solucao = yi;
            double k1 = CalculaK1(xi, yi, h);
            double k2 = CalculaK2(xi, yi, h, k1);
            double a = 1.0 / 3.0, b = 2.0 / 3.0;
            Console.WriteLine("Metodo de Runge Kutta (Ralston)");
            Console.WriteLine();
            Console.WriteLine("x[0,0]: " + solucao);
            for (double i = 0.5; i <= xf; i += h)
            {
               
                solucao += (a * k1 + b * k2)*h;
                Console.WriteLine("x[" + i.ToString("0.0") + "]: "+solucao);
                k1 = CalculaK1(i, yi, h);
                k2 = CalculaK2(i, yi, h, k1);
            }

            //return solucao;
            





        }

        private double CalculaK1(double xi, double y, double h)
        {

            //FuncoesDeEuler eulerK1 = new FuncoesDeEuler();

            //return eulerK1.DerivK1(xi, y, h);

            return ExemploFuncoes.FuncaoEulerSimples(xi);

        }

        private double CalculaK2(double xi, double y, double h, double k1) {

            /*
            FuncoesDeEuler eulerK2 = new FuncoesDeEuler();

            return eulerK2.DerivK1((xi +(3/4)*h), y + ((3/4)* k1 * h), h);
            */
            double xK2 = xi + h * 3.0/4.0;
            return ExemploFuncoes.FuncaoEulerSimples(xK2); 
        }
    }
}
