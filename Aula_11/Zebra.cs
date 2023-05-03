using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    public class Zebra : IImpressoraDeCodigoDeBarras
    {
        public void ImprimirEtiqueta(Produto produto)
        {
            // Implementação da impressão de etiqueta para a impressora Zebra
            Console.WriteLine($"Imprimindo etiqueta para o produto {produto.Id} na impressora Zebra...");
            Console.WriteLine($"Código de barras: {produto.CodigoDeBarras}, Preço: R${produto.Preco}");
            Console.WriteLine($"Configurações padrão da Zebra: Resolução: 600dpi, Tamanho: 15cm x 7cm, Tipo: Poliéster");
            Console.WriteLine("Etiqueta impressa com sucesso na Zebra!");
        }
        public string ObterMarca(){
            return "Zebra";
        }

    }
}