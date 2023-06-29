using As;
using Microsoft.EntityFrameworkCore;

namespace As
{
    public class AutorRepository : IAuthorRepository
    {
        private readonly DataContext _context;

        public AutorRepository(DataContext context)
        {
            _context = context;
        }

        public List<Author> GetAll()
        {
            return _context.Autores.Include(a => a.Livros).ToList();
        }

        public Author GetById(int id)
        {
            return _context.Autores.Include(a => a.Livros).FirstOrDefault(a => a.Id == id);
        }

        public void Create(Author autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();
        }

        public void Update(Author autor)
        {
            _context.Autores.Update(autor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var autor = _context.Autores.Find(id);
            if (autor != null)
            {
                _context.Autores.Remove(autor);
                _context.SaveChanges();
            }
        }
    }
}