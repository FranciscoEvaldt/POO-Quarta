using AS;
using AutoMapper;

namespace As
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Book, BookDTO>()
                .ForMember(dest => dest.AutoresIds, opt => opt.MapFrom(src => src.Autores.Select(la => la.AutorId).ToList()));
            CreateMap<BookDTO, Book>()
                .ForMember(dest => dest.Autores, opt => opt.Ignore());

            CreateMap<Author, AuthorDTO>()
                .ForMember(dest => dest.LivrosIds, opt => opt.MapFrom(src => GetLivrosIds(src)));
            CreateMap<AuthorDTO, Author>()
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => GetLivros(src)));

            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
            CreateMap<User, UserViewModel>();
            CreateMap<LoanDTO, User>()
                .ForMember(dest => dest.Emprestimos, opt => opt.Ignore());

            CreateMap<BookDTO, BookViewModel>();
            CreateMap<BookViewModel, BookDTO>();
            CreateMap<AuthorDTO, AuthorViewModel>()
                .ForMember(dest => dest.LivrosIds, opt => opt.MapFrom(src => GetLivros(src)));
            CreateMap<AuthorViewModel, AuthorDTO>();

        }

        private List<int> GetLivrosIds(Author autor)
        {
            var livrosIds = new List<int>();
            foreach (var livroAutor in autor.Livros)
            {
                livrosIds.Add(livroAutor.LivroId);
            }
            return livrosIds;
        }

        private List<BookAuthor> GetLivros(AuthorDTO autorDTO)
        {
            var livros = new List<BookAuthor>();
            foreach (var livroId in autorDTO.LivrosIds)
            {
                var livroAutor = new BookAuthor { LivroId = livroId };
                livros.Add(livroAutor);
            }
            return livros;
        }
    }
}