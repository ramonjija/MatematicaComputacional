using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegrassaoLinear
{
    public class EquacaoLinear
    {
        private string equacao { get; set; }
        private double a1 { get; set; }
        private double a0 { get; set; }
        private double[] st { get; set; }
        private double[] sr { get; set; }
        private double syx { get; set; }
        private double r2 { get; set; }
        private double[] yAjustado { get; set; }
        private double sy { get; set; }


        /// <summary>
        /// Metodo responsável por formar o objeto de equação linear, nesse caso os valores de xi e yi são
        /// inseridos utilizando os valores dados no livro em sala.
        /// </summary>
        /// <returns>Object object.CalcularRegressaoLinear()</returns>
        public EquacaoLinear CalcularRegressaoLinear()
        {

            double[] xi = { 1, 2, 3, 4, 5, 6, 7 };
            double[] yi = { 0.5, 2.5, 2.0, 4.0, 3.5, 6.0, 5.5 };

            double Sxiyi = 0;
            double Sxi = 0;
            double Syi = 0;
            double Sxi2 = 0;

            double mediaXi = 0;
            double mediaYi = 0;

            double a1 = 0;
            double a0 = 0;

            int n = xi.Length;

            double tempSt = 0;
            this.st = new double[n];
            double tempSr = 0;
            this.sr = new double[n];

            this.yAjustado = new double[n];


            //Inicio do calculo

            Sxiyi = (this.CalculaSxiyi(xi, yi));
            Sxi = (this.CalculaS(xi));
            Syi = (this.CalculaS(yi));
            Sxi2 = (this.CalculaSxi2(xi));
            mediaXi = Sxi / n;
            mediaYi = Syi / n;


            a1 = ((n * Sxiyi) - (Sxi * Syi)) / ((n * Sxi2) - (Sxi * Sxi));
            a0 = (mediaYi - a1 * mediaXi);


            for (int i = 0; i < n; i++)
            {
                this.st[i] = ((yi[i] - mediaYi) * (yi[i] - mediaYi));
                tempSt += this.st[i];

                //this.st[i] = tempSt;
                this.sr[i] = ((yi[i] - a1 * xi[i] - a0) * (yi[i] - a1 * xi[i] - a0));
                tempSr += this.sr[i];

                yAjustado[i] = a0 + a1 * xi[i];


            }



            this.syx = Math.Sqrt(tempSr / (n - 2));
            this.r2 = (tempSt - tempSr) / tempSt;
            this.a1 = a1;
            this.a0 = a0;
            this.equacao = this.FormaEquacao(a0, a1);
            this.yAjustado = yAjustado;

            return this;

        }
        /// <summary>
        /// Sobrecarga do método que calcula a regressao linear, neste metodo é necessario inserir os valores de xi e yi para
        /// obter o objeto.
        /// </summary>
        /// <param name="xi">Array de valores de xi</param>
        /// <param name="yi">Array de valores de yi</param>
        /// <returns>Object object.CalcularRegressaoLinear(xi, yi)</returns>
        public EquacaoLinear CalcularRegressaoLinear(double[] xi, double[] yi)
        {

            double Sxiyi = 0;
            double Sxi = 0;
            double Syi = 0;
            double Sxi2 = 0;

            double mediaXi = 0;
            double mediaYi = 0;

            double a1 = 0;
            double a0 = 0;

            int n = xi.Length;

            double tempSt = 0;
            this.st = new double[n];
            double tempSr = 0;
            this.sr = new double[n];

            this.yAjustado = new double[n];


            //Inicio do calculo

            Sxiyi = (this.CalculaSxiyi(xi, yi));
            Sxi = (this.CalculaS(xi));
            Syi = (this.CalculaS(yi));
            Sxi2 = (this.CalculaSxi2(xi));
            mediaXi = Sxi / n;
            mediaYi = Syi / n;


            a1 = ((n * Sxiyi) - (Sxi * Syi)) / ((n * Sxi2) - (Sxi * Sxi));
            a0 = (mediaYi - a1 * mediaXi);


            for (int i = 0; i < n; i++)
            {
                this.st[i] = ((yi[i] - mediaYi) * (yi[i] - mediaYi));
                tempSt += this.st[i];

                //this.st[i] = tempSt;
                this.sr[i] = ((yi[i] - a1 * xi[i] - a0) * (yi[i] - a1 * xi[i] - a0));
                tempSr += this.sr[i];

                yAjustado[i] = a0 + a1 * xi[i];

            }

            this.syx = Math.Sqrt(tempSr / (n - 2));
            this.r2 = (tempSt - tempSr) / tempSt;
            this.a1 = a1;
            this.a0 = a0;
            this.equacao = this.FormaEquacao(a0, a1);
            this.yAjustado = yAjustado;

            return this;
        }
        /// <summary>
        /// Metodo utilizado para obter a equação linar montada y = a0 + a1x
        /// </summary>
        /// <returns>string object.ObterEquacao()</returns>
        public string ObterEquacao()
        {
            return this.equacao;
        }
        /// <summary>
        /// Método responsável por obter o valor de a1
        /// </summary>
        /// <returns>double object.ObterA1()</returns>
        public double ObterA1()
        {
            return this.a1;
        }
        /// <summary>
        /// Método responsável por obter o valor de a0
        /// </summary>
        /// <returns>double object.ObterA0()</returns>
        public double ObterA0()
        {
            return this.a0;
        }
        /// <summary>
        /// Metodo responsável por objter o valor da lista de (yi - mediaY)²
        /// </summary>
        /// <returns>double[] object.ObterSt()</returns>
        public double[] ObterSt()
        {
            return st;
        }
        /// <summary>
        /// Método responsável por obter o somatório dos valores de (yi - mediaY)²
        /// </summary>
        /// <returns>double[] object.ObterSomatorioSt()</returns>
        public double ObterSomatorioSt()
        {
            double SomaSt = 0;

            for (int i = 0; i < this.st.Length; i++)
            {
                SomaSt += st[i];
            }

            return SomaSt;
        }
        /// <summary>
        /// Metodo responsável por objter o valor da lista de (yi - a0 - a1*xi)²
        /// </summary>
        /// <returns>double object.ObterSr()</returns>
        public double[] ObterSr()
        {
            return this.sr;
        }
        /// <summary>
        /// Método responsável por obter o somatório dos valores de (yi - a0 - a1*xi)²
        /// </summary>
        /// <returns>double object.ObterSomatorioSr()</returns>
        public double ObterSomatorioSr()
        {
            double SomaSr = 0;

            for (int i = 0; i < this.st.Length; i++)
            {
                SomaSr += sr[i];
            }

            return SomaSr;
        }
        /// <summary>
        /// Obtém a quantificação do erro padrão da estimativa
        /// </summary>
        /// <returns>double object.ObterSYX()</returns>
        public double ObterSYX()
        {
            return this.syx;
        }
        /// <summary>
        /// Obtém a quantificação da extensão da melhoria.
        /// </summary>
        /// <returns>double object.ObterR2()</returns>
        public double ObterR2()
        {
            return this.r2;
        }
        /// <summary>
        /// Método responsável por obter o somatório de yi
        /// </summary>
        /// <returns>double object.ObterSomatorioY()</returns>
        public double ObterSomatorioY()
        {
            return this.sy;
        }
        /// <summary>
        /// Método responsável por obter os valores ajustados de Y
        /// </summary>
        /// <returns>double[] object.ObterValoresAjustados()</returns>
        public double[] ObterValoresAjustados()
        {
            return this.yAjustado;
        }
        /// <summary>
        /// Método privado utilizado para calcular o somatorio de xi*yi
        /// </summary>
        /// <param name="xi"></param>
        /// <param name="yi"></param>
        /// <returns>double this.Calculaxiyi(xi,yi)</returns>
        private double CalculaSxiyi(double[] xi, double[] yi)
        {
            double sxiyi = 0;

            for (int i = 0; i < xi.Length; i++)
            {
                sxiyi += (xi[i] * yi[i]);
            }

            return sxiyi;
        }
        /// <summary>
        /// Método privado utilizado para calcular o somatório de xi
        /// </summary>
        /// <param name="xi"></param>
        /// <returns>double CalculaS(xi)</returns>
        private double CalculaS(double[] xi)
        {
            double si = 0;

            for (int i = 0; i < xi.Length; i++)
            {
                si += xi[i];
            }

            return si;
        }
        /// <summary>
        /// Método utilizado para calcular o somatório de xi²
        /// </summary>
        /// <param name="xi"></param>
        /// <returns>double CalculaS(xi)</returns>
        private double CalculaSxi2(double[] xi)
        {
            double sxi2 = 0;

            for (int i = 0; i < xi.Length; i++)
            {
                sxi2 += (xi[i] * xi[i]);
            }

            return sxi2;
        }
        /// <summary>
        /// Método privado responsável por retornar a string contendo a equação y = a0 + a1x
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <returns>string this.CalculaSxi2()</returns>
        private string FormaEquacao(double a0, double a1)
        {
            string equacao = null;
            if (a1 > 0)
            {
                equacao = "y = " + Math.Round(a0, 8) + " + " + Math.Round(a1, 8) + "x";
            }
            else
            {
                equacao = "y = " + Math.Round(a0, 8) + " - " + Math.Abs(Math.Round(a1, 8)) + "x";
            }
            return equacao;

        }


    }
}
