namespace As
{
    public interface IAuthorService
    {
        List<Author> GetAllAutores();
        Author GetAutorById(int id);
        void CreateAutor(Author autor);
        void UpdateAutor(Author autor);
        void DeleteAutor(int id);
    }
}