using AutoMapper;

namespace As
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _usuarioRepository;
        private readonly IBookRepository _livroRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository usuarioRepository, IBookRepository livroRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _livroRepository = livroRepository;
            _mapper = mapper;
        }

        public List<User> GetAllUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

        public User GetUsuarioById(int id)
        {
            return _usuarioRepository.GetById(id);
        }

        public void CreateUsuario(User usuario)
        {
            _usuarioRepository.Create(usuario);
        }

        public void UpdateUsuario(User usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioRepository.Delete(id);
        }

        public void EmprestarLivro(User usuario, Book livro)
        {
            if (livro.Emprestado)
            {
                throw new Exception("Livro já emprestado");
            }

            var emprestimo = new Emprestimo
            {
                Usuario = usuario,
                Livro = livro
            };

            livro.Emprestado = true;

            usuario.Emprestimos.Add(emprestimo);

            _usuarioRepository.Update(usuario);
            _livroRepository.Update(livro);
        }

        public void DevolverLivro(User usuario, Book livro)
        {
            var emprestimo = usuario.Emprestimos.FirstOrDefault(e => e.Livro == livro);
            if (emprestimo == null)
            {
                throw new Exception("Livro não emprestado pelo usuário");
            }

            usuario.Emprestimos.Remove(emprestimo);

            livro.Emprestado = false;

            _usuarioRepository.Update(usuario);
            _livroRepository.Update(livro);
        }

        public List<BookDTO> ObterLivrosEmprestados(int usuarioId)
        {
            var emprestimos = GetUsuarioById(usuarioId)?.Emprestimos;
            if (emprestimos != null)
            {
                var livrosEmprestados = emprestimos.Select(e => _mapper.Map<BookDTO>(e.Livro)).ToList();
                return livrosEmprestados;
            }
            return new List<BookDTO>();
        }

    }
}