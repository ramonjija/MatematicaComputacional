using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Funcoes;

namespace RegrasDeSimpson
{
    public class FuncoesSimpson
    {
        //RegraDoTrapezio.ExemploFuncoes funcaoUtilizada;
        ExemploFuncoes funcaoUtilizada;
        RegraDoTrapezio.RegraDoTrapezio trap;

        public TimeSpan tempoSimp13 { get; set; }
        public TimeSpan tempoSimp38 { get; set; }
        public TimeSpan tempoSimp13m { get; set; }
        public TimeSpan tempoSimpInt { get; set; }

        /// <summary>
        /// Calcula a regra de simpson 1/3 utilizando os limites e selecionando entre exemplo ou exercicio
        /// </summary>
        /// <param name="a">limite inferior</param>
        /// <param name="b">limite superior</param>
        /// <param name="exercicio">seleção de funcao de exemplo ou exercicio</param>
        /// <returns>double</returns>
        public double CalculaSimp13(double a, double b, bool exercicio)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double solucao = 0;
            funcaoUtilizada = new ExemploFuncoes();
            double h = CalculaH(b, a, 2);
            double[] xValue = new double[3];
            xValue[0] = 0;
            for(int i = 1; i < xValue.Length; i++)
            {
                xValue[i] = h * i;
            }

            if (exercicio)
            {
                solucao = 2 * h * (funcaoUtilizada.FuncaoExercicio(xValue[0]) + 4 * funcaoUtilizada.FuncaoExercicio(xValue[1]) + funcaoUtilizada.FuncaoExercicio(xValue[2])) / 6;
            }
            else
            {
                solucao = 2 * h * (funcaoUtilizada.FuncaoExemplo(xValue[0]) + 4 * funcaoUtilizada.FuncaoExemplo(xValue[1]) + funcaoUtilizada.FuncaoExemplo(xValue[2])) / 6;
            }
            sw.Stop();
            tempoSimp13 = sw.Elapsed;

            return solucao;
        }
        /// <summary>
        /// Calcula regra de simpson 1/3
        /// </summary>
        /// <param name="h">media da altura entre os pontos a e b</param>
        /// <param name="f0">funcao utilizando x0</param>
        /// <param name="f1">funcao utilizando x1</param>
        /// <param name="f2">funcao utilizando x2</param>
        /// <returns>double</returns>
        public double CalculaSimp13(double h, double f0, double f1, double f2)
        {
            double solucao = 0;

            solucao = 2 * h * (f0 + 4 * f1 + f2) / 6;

            return solucao;
        }
        /// <summary>
        /// Calcula a regra de simpson 3/8 utilizando os limites e selecionando entre exemplo ou exercicio
        /// </summary>
        /// <param name="a">limite inferior</param>
        /// <param name="b">limite superior</param>
        /// <param name="exercicio">seleção de funcao de exemplo ou exercicio</param>
        /// <returns>double</returns>
        public double CalculaSimp38(double a, double b, bool exercicio)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double solucao = 0;
            funcaoUtilizada = new ExemploFuncoes();
            double h = CalculaH(b, a, 3);
            double[] xValue = new double[4];
            xValue[0] = 0;
            for (int i = 1; i < xValue.Length; i++)
            {
                xValue[i] = h * i;
            }

            if (exercicio)
            {
                solucao = 3 * h * (funcaoUtilizada.FuncaoExercicio(xValue[0]) + 3 * (funcaoUtilizada.FuncaoExercicio(xValue[1]) + funcaoUtilizada.FuncaoExercicio(xValue[2])) + funcaoUtilizada.FuncaoExercicio(xValue[3])) / 8;
            }
            else
            {
                solucao = 3 * h * (funcaoUtilizada.FuncaoExemplo(xValue[0]) + 3 * (funcaoUtilizada.FuncaoExemplo(xValue[1]) + funcaoUtilizada.FuncaoExemplo(xValue[2])) + funcaoUtilizada.FuncaoExemplo(xValue[3])) / 8;
            }
            sw.Stop();
            tempoSimp38 = sw.Elapsed;
            return solucao;
        }
        /// <summary>
        /// Calcula regra de simpson 3/8
        /// </summary>
        /// <param name="h">media da altura entre os pontos a e b</param>
        /// <param name="f0">funcao utilizando x0</param>
        /// <param name="f1">funcao utilizando x1</param>
        /// <param name="f2">funcao utilizando x2</param>
        /// <param name="f3">funcao utilizando x3</param>
        /// <returns>double</returns>
        public double CalculaSimp38(double h, double f0, double f1, double f2, double f3)
        {
            double solucao = 0;

            solucao = 3 * h * (f0 + 3 * (f1 + f2) + f3) / 8;

            return solucao;
        }
        /// <summary>
        /// Calcula a regra multipla de simpson 1/3 utilizando os limites e selecionando entre exemplo ou exercicio
        /// </summary>
        /// <param name="a">limite inferior</param>
        /// <param name="b">limite superior</param>
        /// <param name="n">numero de segmentos</param>
        /// <param name="exercicio">seleção de funcao de exemplo ou exercicio</param>
        /// <returns>double</returns>
        public double CalculaSimp13m(double a, double b, int n, bool exercicio)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double soma = 0, solucao = 0;
            double[] xValues = new double[n + 1];
            double h = CalculaH(b, a, n);
            funcaoUtilizada = new ExemploFuncoes();

            xValues[0] = 0;
            for (int i = 1; i < xValues.Length; i++)
            {
                xValues[i] = Math.Round(h * i, 2);
            }

            funcaoUtilizada = new ExemploFuncoes();

            //adicao de selecao de exemplo ou exercicio
            if (exercicio)
            {
                soma = funcaoUtilizada.FuncaoExercicio(0);

                for (int i = 1; i < n - 2; i += 2)
                {
                    soma = soma + 4 * funcaoUtilizada.FuncaoExercicio(xValues[i]) + 2 * funcaoUtilizada.FuncaoExercicio(xValues[i + 1]);

                }

                soma = soma + 4 * funcaoUtilizada.FuncaoExercicio(xValues[n - 1]) + funcaoUtilizada.FuncaoExercicio(xValues[n]);

                solucao = h * soma / 3;
            }
            else
            {
                soma = funcaoUtilizada.FuncaoExemplo(0);

                for (int i = 1; i < n - 2; i += 2)
                {
                    soma = soma + 4 * funcaoUtilizada.FuncaoExemplo(xValues[i]) + 2 * funcaoUtilizada.FuncaoExemplo(xValues[i + 1]);

                }

                soma = soma + 4 * funcaoUtilizada.FuncaoExemplo(xValues[n - 1]) + funcaoUtilizada.FuncaoExemplo(xValues[n]);

                solucao = h * soma / 3;
            }


            sw.Stop();
            tempoSimp13m = sw.Elapsed;

            return solucao;
        }
        /// <summary>
        /// Calcula a regra multipla de simpson 1/3
        /// </summary>
        /// <param name="h">media da altura entre os pontos a e b</param>
        /// <param name="n">numero de segmentos</param>
        /// <param name="exercicio">seleção de funcao de exemplo ou exercicio</param>
        /// <returns>double</returns>
        public double CalculaSimp13m(double h, int n, bool exercicio)
        {
            double soma = 0, solucao = 0;
            double[] xValues = new double[n+1];
            funcaoUtilizada = new ExemploFuncoes();

            xValues[0] = 0;
            for(int i = 1; i < xValues.Length; i++)
            {
                xValues[i] = Math.Round(h * i, 2);
            }

            funcaoUtilizada = new ExemploFuncoes();

            //adicao de selecao de exemplo ou exercicio
            if (exercicio)
            {
                soma = funcaoUtilizada.FuncaoExercicio(0);

                for (int i = 1; i < n - 2; i += 2)
                {
                    soma = soma + 4 * funcaoUtilizada.FuncaoExercicio(xValues[i]) + 2 * funcaoUtilizada.FuncaoExercicio(xValues[i + 1]);

                }

                soma = soma + 4 * funcaoUtilizada.FuncaoExercicio(xValues[n - 1]) + funcaoUtilizada.FuncaoExercicio(xValues[n]);

                solucao = h * soma / 3;
            }
            else
            {
                soma = funcaoUtilizada.FuncaoExemplo(0);

                for (int i = 1; i < n - 2; i += 2)
                {
                    soma = soma + 4 * funcaoUtilizada.FuncaoExemplo(xValues[i]) + 2 * funcaoUtilizada.FuncaoExemplo(xValues[i + 1]);

                }

                soma = soma + 4 * funcaoUtilizada.FuncaoExemplo(xValues[n - 1]) + funcaoUtilizada.FuncaoExemplo(xValues[n]);

                solucao = h * soma / 3;
            }


           

            return solucao;
        }
        /// <summary>
        /// Calcula Regra de simpson tanto para par quanto para impar
        /// </summary>
        /// <param name="a">double limite inicial</param>
        /// <param name="b">double limite final</param>
        /// <param name="n">numero de segmentos</param>
        /// <param name="exercicio">seleção de funcao de exemplo ou exercicio</param>
        /// <returns>double</returns>
        public double CalculaSimpInt(double a, double b, int n, bool exercicio)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double h = 0, soma = 0, solucao = 0;
            double[] xValues = new double[n + 1];
            int impar = 0, m = 0;

            trap = new RegraDoTrapezio.RegraDoTrapezio();
            funcaoUtilizada = new ExemploFuncoes();

            h = (b - a) / n;
            xValues[0] = 0;
            for(int i = 1; i < xValues.Length; i++)
            {
                xValues[i] = h * i;
            }

            //adicao de selecao de exemplo ou exercicio
            if (exercicio)
            {
                if (n == 1)
                {
                    soma = trap.CalculaRegraSimples(h, funcaoUtilizada.FuncaoExercicio(xValues[n - 1]), funcaoUtilizada.FuncaoExercicio(xValues[n]));
                }
                else
                {
                    m = n;
                    impar = n % 2;
                    if (impar > 0 && n > 1)
                    {
                        soma += CalculaSimp38(h, funcaoUtilizada.FuncaoExercicio(xValues[n - 3]), funcaoUtilizada.FuncaoExercicio(xValues[n - 2]), funcaoUtilizada.FuncaoExercicio(xValues[n - 1]), funcaoUtilizada.FuncaoExercicio(xValues[n]));
                        m = n - 3;
                    }
                    if (m > 1)
                    {
                        soma += CalculaSimp13m(h, m, true);
                    }
                }
                solucao = soma;
            }
            else
            {
                if (n == 1)
                {
                    soma = trap.CalculaRegraSimples(h, funcaoUtilizada.FuncaoExemplo(xValues[n - 1]), funcaoUtilizada.FuncaoExemplo(xValues[n]));
                }
                else
                {
                    m = n;
                    impar = n % 2;
                    if (impar > 0 && n > 1)
                    {
                        soma += CalculaSimp38(h, funcaoUtilizada.FuncaoExemplo(xValues[n - 3]), funcaoUtilizada.FuncaoExemplo(xValues[n - 2]), funcaoUtilizada.FuncaoExemplo(xValues[n - 1]), funcaoUtilizada.FuncaoExemplo(xValues[n]));
                        m = n - 3;
                    }
                    if (m > 1)
                    {
                        soma += CalculaSimp13m(h, m, false);
                    }
                }
                solucao = soma;
            }
            sw.Stop();
            tempoSimpInt = sw.Elapsed;
            return solucao;

        }
        /// <summary>
        /// Funcao utilizada para se calcula a regra de 1/3 quando a funcao esta disponivel. Utilizada em Romberg.
        /// </summary>
        /// <param name="n">numero de segmentos</param>
        /// <param name="a">limite inical</param>
        /// <param name="b">limite final</param>
        /// <returns>doulbe funcao 1/3 para equacao</returns>
        public double CalculaSimpEq(int n, double a, double b)
        {
            funcaoUtilizada = new ExemploFuncoes();
            double solucao = 0;

            double h = (b - a) / n;
            double x = a;
            double soma = funcaoUtilizada.FuncaoExemplo(x);
            for (int i = 1; i < n - 2; i += 2)
            {
                x += h;
                soma += 4 * funcaoUtilizada.FuncaoExemplo(x);
                x += h;
                soma += 2 * funcaoUtilizada.FuncaoExemplo(x);
            }
            x += h;
            soma += 4 * funcaoUtilizada.FuncaoExemplo(x);
            soma += funcaoUtilizada.FuncaoExemplo(b);
            solucao = (b - a) * soma / (3 * n);


            return solucao;
        }
        private double CalculaH(double xe, double xi, int n)
        {
            return (xe - xi) / n;
        }
        private double CalculaH(double xe, double xi, double n)
        {
            return (xe - xi) / n;
        }

    }
}
