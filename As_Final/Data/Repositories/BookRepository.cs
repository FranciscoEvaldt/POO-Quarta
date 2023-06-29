using Microsoft.EntityFrameworkCore;

namespace As
{
    public class LivroRepository : IBookRepository
    {
        private readonly DataContext _context;

        public LivroRepository(DataContext context)
        {
            _context = context;
        }

        public List<Book> GetAll()
        {
            return _context.Livros.Include(l => l.Autores).ToList();
        }

        public Book GetById(int id)
        {
            return _context.Livros.Include(l => l.Autores).FirstOrDefault(l => l.Id == id);
        }

        public void Create(Book livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void Update(Book livro)
        {
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var livro = _context.Livros.Find(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                _context.SaveChanges();
            }
        }
    }
}