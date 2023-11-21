using ArttSabor.Domain.Entities;
using ArttSabor.Persistence.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArttSabor.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaRepository _repository;

        public CategoriasController(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        // GET: Categorias/GetCategorias
        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> GetCategorias()
        {
            var result = await _repository.Get();
            return Ok(result);
        }

        // GET api/<CategoriasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoriasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
