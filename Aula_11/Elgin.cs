using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        public void ImprimirEtiqueta(Produto produto)
        {
            // Implementação da impressão de etiqueta para a impressora Elgin
            Console.WriteLine($"Imprimindo etiqueta para o produto {produto.Id} na impressora Elgin...");
            Console.WriteLine($"Código de barras: {produto.CodigoDeBarras}, Preço: R${produto.Preco}");
            Console.WriteLine($"Configurações padrão da Elgin: Resolução: 300dpi, Tamanho: 10cm x 5cm, Tipo: Papel adesivo");
            Console.WriteLine("Etiqueta impressa com sucesso na Elgin!");
        }
        public string ObterMarca(){
            return "Elgin";
        }

    }
}