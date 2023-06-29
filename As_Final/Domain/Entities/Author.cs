using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As
{
    public class Author
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<BookAuthor> Livros { get; set; }

    }
}