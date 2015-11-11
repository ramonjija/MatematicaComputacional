using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcoes
{
    public class ExemploFuncoes
    {
        public double FuncaoExemplo(double x)
        {
            //f(x) = 0,2 + 25x − 200x2 + 675x3 − 900x4 + 400x5
            return (0.2 + 25 * x - 200 * x * x + 675 * x * x * x - 900 * x * x * x * x + 400 * x * x * x * x * x);
        }

        public double FuncaoExercicio(double t)
        {
            double g = 9.8;//m/s² aceleracao da gravidade
            double m = 68.1;//kg massa do paraquedista
            double c = 12.5;//kg/s coeficiente de arrasto

            return ((g * m) / c) * (1 - Math.Exp(-(c / m) * t));
        }
        /// <summary>
        /// Funcao utilizada no exercicio AV1 pagina 566 exercicio 24.1
        /// </summary>
        /// <param name="T">Temperatura</param>
        /// <returns>double capacidade calorifica</returns>
        public double FuncaoExercicioAv1_24_1(double T)
        {
            double g = 1000;
            return g * (0.132 + 1.56 * Math.Pow(10, -4) * T + 2.64 * Math.Pow(10, -7) * T * T);
        }
        /// <summary>
        /// Sobrecarga da funcao utilizada no exercicio AV1 pagina 566 exercicio 24.1
        /// </summary>
        /// <param name="T">Temperatura</param>
        /// <param name="g">Quantidade de gramas do material a ser elevado</param>
        /// <returns>double capacidade calorifica</returns>
        public double FuncaoExercicioAv1_24_1(double T, double g)
        {
            return g * (0.132 + 1.56 * Math.Pow(10, -4) * T + 2.64 * Math.Pow(10, -7) * T * T);

        }

        //AV2
        /// <summary>
        /// Equacao utilizada para o metodo de euler simples
        /// </summary>
        /// <param name="x">valor de x</param>
        /// <returns>double</returns>
        public static double FuncaoEulerSimples(double x)
        {
            return (-2 * x * x * x + 12 * x * x - 20 * x + 8.5);
        }
    }
}
