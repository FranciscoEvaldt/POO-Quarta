using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06
{
    abstract class Animal
    {
        public string Nome { get; set; }

        public abstract void Falar();
    }

}