using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult sumGet(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");

        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult subGet(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");

        }

        [HttpGet("mut/{firstNumber}/{secondNumber}")]
        public IActionResult mutGet(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mut = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(mut.ToString());
            }

            return BadRequest("Invalid Input");

        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult divGet(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(div.ToString());
            }

            return BadRequest("Invalid Input");

        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult meanGet(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mean = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(mean.ToString());
            }

            return BadRequest("Invalid Input");

        }

        [HttpGet("root/{firstNumber}")]
        public IActionResult rootGet(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var root = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(root.ToString());
            }

            return BadRequest("Invalid Input");

        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalvalue;
            if(decimal.TryParse(strNumber, out decimalvalue))
            {
                return decimalvalue;
            }

            return 0;
        }

    }
}
