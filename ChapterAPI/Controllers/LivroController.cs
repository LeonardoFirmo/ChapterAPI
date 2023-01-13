using ChapterAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;   

        public LivroController(LivroRepository livro) 
        {
            _livroRepository = livro;

        }
        [HttpGet]
        public IActionResult Listar() 
        {
            try
            {
                return Ok(_livroRepository.Ler());
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }

    }
}
