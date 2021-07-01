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
    public class CalculatorController : ControllerBase//rota
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{seconNumber}")]// metodo get na url ficaria assim https://localhost:5001/Calculator/sum/2/2
        public IActionResult Sum(string firstNumber, string seconNumber)
        {

            //validar ser o valor informado é um numero
            if (IsNumeric(firstNumber) && IsNumeric(seconNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(seconNumber);//calculo e convesão
                return Ok(sum.ToString());//retorno
            }
            return BadRequest("Invalid Input");//em caso de erro
        }

        [HttpGet("subtraction/{firstNumber}/{seconNumber}")]// metodo get na url ficaria assim https://localhost:5001/Calculator/subtraction/2/2
        public IActionResult Subtraction(string firstNumber, string seconNumber)
        {

            //validar ser o valor informado é um numero
            if (IsNumeric(firstNumber) && IsNumeric(seconNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(seconNumber);//calculo e convesão
                return Ok(sum.ToString());//retorno
            }
            return BadRequest("Invalid Input");//em caso de erro
        }

        [HttpGet("multiplication/{firstNumber}/{seconNumber}")]// metodo get na url ficaria assim https://localhost:5001/Calculator/subtraction/2/2
        public IActionResult Multiplication(string firstNumber, string seconNumber)
        {

            //validar ser o valor informado é um numero
            if (IsNumeric(firstNumber) && IsNumeric(seconNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(seconNumber);//calculo e convesão
                return Ok(sum.ToString());//retorno
            }
            return BadRequest("Invalid Input");//em caso de erro
        }

        [HttpGet("divisiontion/{firstNumber}/{seconNumber}")]// metodo get na url ficaria assim https://localhost:5001/Calculator/subtraction/2/2
        public IActionResult Divisiontion(string firstNumber, string seconNumber)
        {

            //validar ser o valor informado é um numero
            if (IsNumeric(firstNumber) && IsNumeric(seconNumber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(seconNumber);//calculo e convesão
                return Ok(sum.ToString());//retorno
            }
            return BadRequest("Invalid Input");//em caso de erro
        }

        [HttpGet("multiplication/{firstNumber}/{seconNumber}")]// metodo get na url ficaria assim https://localhost:5001/Calculator/subtraction/2/2
        public IActionResult Multiplication(string firstNumber, string seconNumber)
        {

            //validar ser o valor informado é um numero
            if (IsNumeric(firstNumber) && IsNumeric(seconNumber))
            {
                var sum = (ConvertToDecimal(firstNumber) + ConvertToDecimal(seconNumber)) / 2;//calculo e convesão
                return Ok(sum.ToString());//retorno
            }
            return BadRequest("Invalid Input");//em caso de erro
        }

        [HttpGet("square-root/{firstNumber}}")]// metodo get na url ficaria assim https://localhost:5001/Calculator/subtraction/2/2
        public IActionResult SquareRoot(string firstNumberr)
        {

            //validar ser o valor informado é um numero
            if (IsNumeric(firstNumber) )
            {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(firstNumber));//calculo e convesão
                return Ok(squareRoot.ToString());//retorno
            }
            return BadRequest("Invalid Input");//em caso de erro
        }

        //validar se o valor informado é um numero
        private bool IsNumeric(string strNumero)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumero,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                 out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumero)
        {
            decimal decimaValue;
            if (decimal.TryParse(strNumero, out decimaValue))
            {
                return decimaValue;
            }

            return 0;
        }
    }
}
