using As;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace As
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _livroService;
        private readonly IAuthorService _autorService;
        private readonly IMapper _mapper;

        public BookController(IBookService livroService, IAuthorService autorService, IMapper mapper)
        {
            _livroService = livroService;
            _autorService = autorService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllLivros()
        {
            var livros = _livroService.GetAllLivros();
            var livroDTOs = _mapper.Map<List<BookDTO>>(livros);
            return Ok(livroDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetLivroById(int id)
        {
            var livro = _livroService.GetLivroById(id);
            if (livro == null)
            {
                return NotFound();
            }
            var livroDTO = _mapper.Map<BookDTO>(livro);
            return Ok(livroDTO);
        }

        [HttpPost]
        public IActionResult CreateLivro([FromBody] BookDTO livroDTO)
        {
            var livro = _mapper.Map<Book>(livroDTO);
            _livroService.CreateLivro(livro);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Livro cadastrado com sucesso",
                livro
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLivro(int id, [FromBody] BookDTO livroDTO)
        {
            var livro = _mapper.Map<Book>(livroDTO);
            livro.Id = id;
            _livroService.UpdateLivro(livro);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Livro atualizado com sucesso",
                livro
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLivro(int id)
        {
            _livroService.DeleteLivro(id);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Livro deletado com sucesso"
            });
        }

        [HttpPost("{livroId}/autores/{autorId}")]
        public IActionResult AdicionarAutor(int livroId, int autorId)
        {
            var livro = _livroService.GetLivroById(livroId);
            var autor = _autorService.GetAutorById(autorId);

            if (livro == null || autor == null)
            {
                return NotFound();
            }

            _livroService.AdicionarAutor(livro, autor);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Autor adicionado ao livro com sucesso"
            });
        }
    }
}