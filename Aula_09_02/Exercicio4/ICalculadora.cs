using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_4
{
    public interface ICalculadora
    {
        double Somar(double a, double b);
        double Subtrair(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b);
    }
}