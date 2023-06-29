using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As
{
   public class AuthorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<int> LivrosIds { get; set; }
    }
}