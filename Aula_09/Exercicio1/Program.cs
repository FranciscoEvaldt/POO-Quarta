using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09
{
    class Program{
        static void Main(string[] args) 
        {
            IAnimal cachorro = new Cachorro();
            IAnimal gato = new Gato();
            IAnimal papagaio = new Papagaio();

            cachorro.EmitirSom();
            gato.EmitirSom();
            papagaio.EmitirSom();
        }
    }
}
