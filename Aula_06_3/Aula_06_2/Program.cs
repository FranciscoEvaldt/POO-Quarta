using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Aula_06_2;
class Program{
    static void Main(string[] args){
        Veiculo carro = new Carro("Fusca");
        carro.Acelerar();

        Veiculo moto = new Moto("CG 160");
        moto.Acelerar();
    }
}
