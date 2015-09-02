using System;

namespace Newtonraphson
{

    /*
     Área responsável por armazenar as funçoes utilizadas como exemplo  
    */



    class ExemploFuncoes
    {

        public double FuncaoExemplo1(double x)
        {
            //2x^2 + 3x + 1 = 0

            return (2 * x * x + 3 * x + 1);

        }

        public double DerivadaFuncaoExemplo1(double x)
        {

            //4x + 3

            return (4 * x + 3);
        }

        public double FuncaoExemplo2(double x)
        {

            //x^3 + 5x - 3

            return (x * x * x + 5 * x - 3);
        }

        public double DerivadaFuncaoExemplo2(double x)
        {
            //3x^2 - 5

            return (3 * x * x + 5);
        }

        public double FuncaoExemplo3(double x)
        {
            return x * x  + x - 6;
        }

        public double DerivadaFuncaoExemplo3(double x)
        {
            return 2 * x + 1;
        }
    }
}
