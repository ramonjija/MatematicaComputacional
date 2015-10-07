using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegraDoTrapezio
{
    class ExemploFuncoes
    {

        public double FuncaoExemplo1(double x)
        {
            //f(x) = 0,2 + 25x − 200x2 + 675x3 − 900x4 + 400x5
            return (0.2 + 25 * x - 200 * x * x + 675 * x * x * x - 900 * x * x * x * x + 400 * x * x * x * x * x);
        }
        /*
        public double FuncaoExemplo2(double t)
        {
            //((g*m)/c)*(1 - e^(-(c/m)*t));
            double g = 9.8;//m/s² aceleracao da gravidade
            double m = 68.1;//kg massa do paraquedista
            double c = 12.5;//kg/s coeficiente de arrasto
            //double e = Math.E;

            //((g * m) / c);

            return  (1 - Math.Exp(-(c / m) * t));
        }
        */
        public double FuncaoExemplo2B(double t)
        {
            double g = 9.8;//m/s² aceleracao da gravidade
            double m = 68.1;//kg massa do paraquedista
            double c = 12.5;//kg/s coeficiente de arrasto
            //double e = Math.E;

            //((g * m) / c);

            return ((g * m) / c)*(1 - Math.Exp(-(c / m) * t));
        }

    }
}
