using System.Collections.Generic;

namespace As
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<int> LivrosIds { get; set; }
    }
}