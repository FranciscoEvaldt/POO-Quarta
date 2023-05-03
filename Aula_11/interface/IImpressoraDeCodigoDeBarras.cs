using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    public interface IImpressoraDeCodigoDeBarras{
        void ImprimirEtiqueta(Produto produto);
        string ObterMarca();
    }
}