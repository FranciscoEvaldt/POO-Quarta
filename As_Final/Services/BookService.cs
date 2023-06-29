namespace As
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _livroRepository;
        private readonly IAuthorRepository _autorRepository;

        public BookService(IBookRepository livroRepository, IAuthorRepository autorRepository)
        {
            _livroRepository = livroRepository;
            _autorRepository = autorRepository;
        }

        public List<Book> GetAllLivros()
        {
            return _livroRepository.GetAll();
        }

        public Book GetLivroById(int id)
        {
            return _livroRepository.GetById(id);
        }

        public void CreateLivro(Book livro)
        {
            _livroRepository.Create(livro);
        }

        public void UpdateLivro(Book livro)
        {
            _livroRepository.Update(livro);
        }

        public void DeleteLivro(int id)
        {
            _livroRepository.Delete(id);
        }

        public void AdicionarAutor(Book livro, Author autor)
        {
            var livroAutor = new BookAuthor
            {
                LivroId = livro.Id,
                AutorId = autor.Id
            };

            livro.Autores.Add(livroAutor);
            _livroRepository.Update(livro);

            autor.Livros.Add(livroAutor);
            _autorRepository.Update(autor);
        }
    }
}