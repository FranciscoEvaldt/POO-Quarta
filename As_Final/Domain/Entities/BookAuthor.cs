namespace As
{
    public class BookAuthor
    {
        public int LivroId { get; set; }
        public Book Livro { get; set; }
        public int AutorId { get; set; }
        public Author Autor { get; set; }
    }
}