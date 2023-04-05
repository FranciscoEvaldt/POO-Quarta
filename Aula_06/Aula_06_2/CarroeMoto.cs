using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_2{
    class Carro : Veiculo{
        public Carro(string modelo){
            Modelo = modelo;
        }

        public override void Acelerar(){
            Console.WriteLine($"Acelerando {Modelo}!");
        }
    }

    class Moto : Veiculo{
        public Moto(string modelo){
            Modelo = modelo;
        }

        public override void Acelerar(){
            Console.WriteLine($"Acelerando {Modelo}!");
        }
    }

}