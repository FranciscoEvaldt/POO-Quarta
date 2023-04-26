using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_5
{
    public class PagamentoPaypal : IServicoPagamento
    {
        public void EfetuarPagamento(double valor)
        {
            Console.WriteLine("Pagamento no Paypal no valor de R$" + valor + " efetuado com sucesso.");
        }

        public void EstornarPagamento(double valor)
        {
            Console.WriteLine("Estorno de pagamento no Paypal no valor de R$" + valor + " efetuado com sucesso.");
        }
    }
}