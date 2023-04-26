using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_2
{
    public class FormatadorInvertido : IFormatadorTexto
    {
        public string Formatar(string texto)
        {
            char[] chars = texto.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}