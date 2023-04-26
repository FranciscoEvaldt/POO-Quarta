using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Aula_09_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Rex";
            cachorro.Dono = "Chico";

            Gato gato = new Gato();
            gato.Nome = "Frajola";
            gato.Dono = "Maria";
        }
    }
}