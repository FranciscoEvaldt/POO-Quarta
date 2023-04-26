using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_2{
    class Program{
        static void Main(string[] args){
            IFormatadorTexto formatadorMaiusculo = new FormatadorMaiusculo();
            IFormatadorTexto formatadorMinusculo = new FormatadorMinusculo();
            IFormatadorTexto formatadorInvertido = new FormatadorInvertido();

            string texto1 = "Torres";
            string texto2 = "Torres";
            string texto3 = "Torres";

            Console.WriteLine(formatadorMaiusculo.Formatar(texto1));
            Console.WriteLine(formatadorMinusculo.Formatar(texto2));
            Console.WriteLine(formatadorInvertido.Formatar(texto3));
        }
    }
}
