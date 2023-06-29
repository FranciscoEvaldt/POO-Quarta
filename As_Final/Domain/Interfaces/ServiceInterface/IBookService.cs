namespace As
{
    public interface IBookService
    {
        List<Book> GetAllLivros();
        Book GetLivroById(int id);
        void CreateLivro(Book livro);
        void UpdateLivro(Book livro);
        void DeleteLivro(int id);
        void AdicionarAutor(Book livro, Author autor);
    }
}