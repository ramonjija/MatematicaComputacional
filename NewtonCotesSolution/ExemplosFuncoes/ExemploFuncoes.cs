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
    }
}
