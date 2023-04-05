using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06
{
    class Cachorro : Animal
    {
        public Cachorro(string nome)
        {
            Nome = nome;
        }

        public override void Falar()
        {
            Console.WriteLine($"{Nome} diz: Au au!");
        }
    }

    class Gato : Animal
    {
        public Gato(string nome)
        {
            Nome = nome;
        }

        public override void Falar()
        {
            Console.WriteLine($"{Nome} diz: Miau!");
        }
    }

}