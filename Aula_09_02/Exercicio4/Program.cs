using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            double a = 10.0;
            double b = 2.0;

            Console.WriteLine("Soma: " + calculadora.Somar(a, b));
            Console.WriteLine("Subtração: " + calculadora.Subtrair(a, b));
            Console.WriteLine("Multiplicação: " + calculadora.Multiplicar(a, b));
            Console.WriteLine("Divisão: " + calculadora.Dividir(a, b));
        }
    }
}