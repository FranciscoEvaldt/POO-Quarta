using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As
{
     public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}