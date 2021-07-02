using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET5Udemy.Model;
using RestWithASPNET5Udemy.Services;

namespace RestWithASPNET5Udemy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase//rota
    {
        private readonly ILogger<PersonController> _logger;
        //declara serviço
        private IPersonService _personService;//escopo global

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());//retornar a lista de person
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindByID(id);
            if (person == null) return NotFound();//Caso não o id não for encontrado
            
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person) //FromBody recebe o body e converter no formado de Person
        {            
            if (person == null) return BadRequest();            
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person) //FromBody recebe o body e converter no formado de Person
        {            
            if (person == null) return BadRequest();            
            return Ok(_personService.Create(person));
        }

         [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
             _personService.Delete(id);
            return NoContent();
        }

    }
}
