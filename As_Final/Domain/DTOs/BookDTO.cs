using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As
{
public class BookDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Emprestado { get; set; } 
        public List<int> AutoresIds { get; set; }
    }
}