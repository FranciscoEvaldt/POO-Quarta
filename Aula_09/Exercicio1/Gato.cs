using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09
{
    public class Gato : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
    }
}