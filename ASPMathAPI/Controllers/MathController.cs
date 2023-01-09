using Microsoft.AspNetCore.Mvc;
using Math = ASPMathAPI.Library.Math;

namespace ASPMathAPI.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class MathController : Controller
    {
        private Math math;

        private readonly ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
            math = new Math();

        }

        [HttpGet(Name = "AddNumber")]
        [ActionName ("AddNumber")]
        public ActionResult<int> Add(int a, int b)
        {
            return math.Add(a, b);
        }

        [HttpGet(Name = "DivideNumber")]
        [ActionName("DivideNumber")]
        public ActionResult<int> Divide(int a, int b)
        {
            return math.Divide(a, b);
        }

        [HttpGet(Name = "SubtractNumber")]
        [ActionName("SubtractNumber")]
        public ActionResult<int> Subtract(int a, int b)
        {
            return math.Subtract(a, b);
        }

        [HttpGet(Name = "MultiplyNumber")]
        [ActionName("MultiplyNumber")]
        public ActionResult<int> Multiply(int a, int b)
        {
            return math.Multiply(a, b);
        }


        [HttpGet(Name = "CalculateSI")]
        [ActionName("CalculateSI")]
        public ActionResult<double> SimpleInterest(double p, double r, double t)
        {
            return System.Math.Round(((p * r * t) / 100), 2);
        }


        [HttpGet(Name = "CalculateCI")]
        [ActionName("CalculateCI")]
        public ActionResult<double> CompoundInterest(double p, double r, double t)
        {
            double totalAmount = p * (System.Math.Pow((1 + r / 100), t));
            return System.Math.Round(totalAmount - p, 2);
        }


    }
}