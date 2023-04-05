using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_2{
    abstract class Veiculo{
        public string Modelo { get; set; }

        public abstract void Acelerar();
    }

}