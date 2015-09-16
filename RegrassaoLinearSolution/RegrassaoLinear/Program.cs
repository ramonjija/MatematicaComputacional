using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegrassaoLinear
{
    public class Program
    {

        static void Main(string[] args)
        {
            EquacaoLinear objEqLinar = new EquacaoLinear();
            objEqLinar.CalcularRegressaoLinear();
            Console.WriteLine(objEqLinar.ObterEquacao());


            Console.ReadLine();

        }
    }
}
