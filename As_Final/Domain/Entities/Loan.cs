namespace As
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public User Usuario { get; set; }
        public int LivroId { get; set; }
        public Book Livro { get; set; }
    }
}