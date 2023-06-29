namespace As
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _autorRepository;

        public AuthorService(IAuthorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public List<Author> GetAllAutores()
        {
            return _autorRepository.GetAll();
        }

        public Author GetAutorById(int id)
        {
            return _autorRepository.GetById(id);
        }

        public void CreateAutor(Author autor)
        {
            _autorRepository.Create(autor);
        }

        public void UpdateAutor(Author autor)
        {
            _autorRepository.Update(autor);
        }

        public void DeleteAutor(int id)
        {
            _autorRepository.Delete(id);
        }
    }
}