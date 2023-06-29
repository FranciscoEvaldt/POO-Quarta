namespace As
{
    public interface IUserService
    {
        List<User> GetAllUsuarios();
        User GetUsuarioById(int id);
        void CreateUsuario(User usuario);
        void UpdateUsuario(User usuario);
        void DeleteUsuario(int id);
        void EmprestarLivro(User usuario, Book livro); 
        void DevolverLivro(User usuario, Book livro); 
        public List<BookDTO> ObterLivrosEmprestados(int usuarioId);
    }
}