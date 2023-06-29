using Microsoft.EntityFrameworkCore;

namespace As
{
    public class UsuarioRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UsuarioRepository(DataContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Usuarios
                .Include(u => u.Emprestimos)
                .ThenInclude(e => e.Livro)
                .ToList();
        }

        public User GetById(int id)
        {
            return _context.Usuarios
                .Include(u => u.Emprestimos)
                .ThenInclude(e => e.Livro)
                .FirstOrDefault(u => u.Id == id);
        }

        public void Create(User usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(User usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}