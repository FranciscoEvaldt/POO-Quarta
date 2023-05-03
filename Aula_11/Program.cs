using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de impressoras
            List<IImpressoraDeCodigoDeBarras> impressoras = new List<IImpressoraDeCodigoDeBarras> {
            new Elgin(),
            new Zebra()
            };

            // Solicita o código de barras do produto a ser impresso na etiqueta
            Console.Write("Informe o código de barras do produto: ");
            string codigoDeBarras = Console.ReadLine();

            // Cria um objeto Produto com os dados informados pelo usuário
            Produto produto = new Produto
            {
                Id = 1,
                CodigoDeBarras = codigoDeBarras,
                Preco = 9.99
            };

            // Imprime a etiqueta para cada impressora na lista
            foreach (IImpressoraDeCodigoDeBarras impressora in impressoras)
            {
                impressora.ImprimirEtiqueta(produto);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}