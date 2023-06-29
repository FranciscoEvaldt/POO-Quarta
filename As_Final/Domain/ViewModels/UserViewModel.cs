namespace As
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Book> LivrosEmprestados { get; set; }
    }
}