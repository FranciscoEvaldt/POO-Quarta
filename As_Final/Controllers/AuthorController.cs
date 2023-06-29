using As;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace As
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _autorService;
        private readonly IBookService _livroService;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorService autorService, IBookService livroService, IMapper mapper)
        {
            _autorService = autorService;
            _livroService = livroService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllAutores()
        {
            var autores = _autorService.GetAllAutores();
            var autorDTOs = _mapper.Map<List<AuthorDTO>>(autores);
            return Ok(autorDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetAutorById(int id)
        {
            var autor = _autorService.GetAutorById(id);
            if (autor == null)
                return NotFound();

            var autorDTO = _mapper.Map<AuthorDTO>(autor);
            return Ok(autorDTO);
        }

        [HttpPost]
        public IActionResult CreateAutor([FromBody] AuthorDTO autorDTO)
        {
            var autor = _mapper.Map<Author>(autorDTO);
            _autorService.CreateAutor(autor);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Autor cadastrado com sucesso",
                autor
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAutor(int id, [FromBody] AuthorDTO autorDTO)
        {
            var autor = _mapper.Map<Author>(autorDTO);
            autor.Id = id;
            _autorService.UpdateAutor(autor);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Autor atualizado com sucesso",
                autor
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAutor(int id)
        {
            _autorService.DeleteAutor(id);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Autor deletado com sucesso"
            });
        }
    }


}
