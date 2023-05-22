using CalulatorWeb.DTOs;
using CalulatorWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalulatorWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        [HttpPost("add")]
        public IActionResult Add(CalculatorDTO dto)
        {
            int result = _calculatorService.Add(dto.Operand1, dto.Operand2);
            return Ok(result);
        }

        [HttpPost("subtract")]
        public IActionResult Subtract(CalculatorDTO dto)
        {
            int result = _calculatorService.Substract(dto.Operand1, dto.Operand2);
            return Ok(result);
        }
    }
}
