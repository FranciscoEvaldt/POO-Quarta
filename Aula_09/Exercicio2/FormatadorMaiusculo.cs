using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_2
{
    public class FormatadorMaiusculo : IFormatadorTexto
    {
        public string Formatar(string texto)
        {
            return texto.ToUpper();
        }
    }
}