using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public ICollection<string> Autores { get; set; }
    }
}