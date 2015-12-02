using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Funcoes;

namespace MetodosDeRungeKutta
{
    public class FuncoesDeRKeRalston
    {
        public double[] CalculaRalston(double xi, double xf, double h)
        {

            double solucao = 0;
            double[] yRalston = new double[9];
            int j = 0;
            double yi = 1;
            solucao = yi;
            //double k1 = CalculaK1(xi, yi, h);
            double k1 = CalculaK1(xi);
            double k2 = CalculaK2(xi, yi, h, k1);
            double a = 1.0 / 3.0, b = 2.0 / 3.0;
            Console.WriteLine("Metodo de Runge Kutta (Ralston)");
            Console.WriteLine();
            Console.WriteLine("x[0,0]: " + solucao);
            yRalston[j] = solucao;

            for (double i = 0.5; i <= xf; i += h)
            {
                j++;
                solucao += (a * k1 + b * k2) * h;
                Console.WriteLine("x[" + i.ToString("0.0") + "]: " + solucao);
                yRalston[j] = solucao;
                k1 = CalculaK1(i);
                k2 = CalculaK2(i, yi, h, k1);
            }

            //return solucao;
            return yRalston;






        }

        public double[] CalculaRK4Ordem(double xi, double xf, double h)
        {
            double solucao = 1;
            double k1, k2, k3, k4;

            double[] yRungeKutta = new double[9];
            int j = 0;


            k1 = CalculaK1(xi);
            k2 = Calculak2Para4RK(xi, h);
            k3 = Calculak2Para4RK(xi, h);
            k4 = CalculaK1(xi + h);

            Console.WriteLine("Metodo de Runge Kutta 4 Ordem");
            Console.WriteLine();
            Console.WriteLine("x[0,0]: " + solucao);
            yRungeKutta[j] = solucao;
            for (double i = 0.5; i <= xf; i += h)
            {
                j++;
                solucao += (1.0 / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4) * h;
                Console.WriteLine("x[" + i.ToString("0.0") + "]: " + solucao);
                yRungeKutta[j] = solucao;
                k1 = CalculaK1(i);
                k2 = Calculak2Para4RK(i, h);
                k3 = Calculak2Para4RK(i, h);
                k4 = CalculaK1(i + h);
                
            }

            return yRungeKutta;

        }

        //private double CalculaK1(double xi, double y, double h)
        private double CalculaK1(double xi)
        {

            //FuncoesDeEuler eulerK1 = new FuncoesDeEuler();

            //return eulerK1.DerivK1(xi, y, h);

            return ExemploFuncoes.FuncaoEulerSimples(xi);

        }

        private double CalculaK2(double xi, double y, double h, double k1)
        {

            /*
            FuncoesDeEuler eulerK2 = new FuncoesDeEuler();

            return eulerK2.DerivK1((xi +(3/4)*h), y + ((3/4)* k1 * h), h);
            */
            double xK2 = xi + h * 3.0 / 4.0;
            return ExemploFuncoes.FuncaoEulerSimples(xK2);
        }

        private double Calculak2Para4RK(double xi, double h)
        {
            return ExemploFuncoes.FuncaoEulerSimples(xi + 0.5 * h);
        }
    }
}
