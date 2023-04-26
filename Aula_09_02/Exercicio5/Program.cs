using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PagamentoCartao pagamentoCartao = new PagamentoCartao();
            pagamentoCartao.EfetuarPagamento(100.0);
            pagamentoCartao.EstornarPagamento(50.0);

            PagamentoBoleto pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.EfetuarPagamento(150.0);
            pagamentoBoleto.EstornarPagamento(75.0);

            PagamentoPaypal pagamentoPaypal = new PagamentoPaypal();
            pagamentoPaypal.EfetuarPagamento(200.0);
            pagamentoPaypal.EstornarPagamento(100.0);
        }
    }

}