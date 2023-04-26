using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_5
{
    public interface IServicoPagamento
    {
        void EfetuarPagamento(double valor);
        void EstornarPagamento(double valor);
    }
}