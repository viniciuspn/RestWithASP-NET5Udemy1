using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase//rota
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{seconNumber}")]// metodo get na url ficaria assim https://localhost:5001/Calculator/sum/2/2
        public IActionResult Sum(string firstNumber, string seconNumber)
        {

                  return BadRequest("Invalid Input");//em caso de erro
        }

    }
}
