using ASPMathAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace ASPMathAPI.Tests
{
    public class UnitTest1
    {
        private readonly Controllers.MathController mathController;
        public UnitTest1()
        {
            using var loggerFactory = LoggerFactory.Create(loggingBuilder => loggingBuilder
              .SetMinimumLevel(LogLevel.Trace)
              .AddConsole());

            ILogger<MathController> logger = loggerFactory.CreateLogger<MathController>();
            mathController = new MathController(logger);
        }

        [Fact]
        public void DoesAddTwoIntegers()
        {
            var result = mathController.Add(10, 20);

            Assert.Equal(30, result.Value);
        }

        [Fact]
        public void DoesSubtractTwoIntegers()
        {
            var result = mathController.Subtract(100, 50);

            Assert.Equal(50, result.Value);
        }

        [Fact]
        public void DoesDivideTwoIntegers()
        {
            var result = mathController.Divide(200, 20);

            Assert.Equal(10, result.Value);
        }

        [Fact]
        public void DoesMultiplyTwoIntegers()
        {
            var result = mathController.Multiply(10, 20);

            Assert.Equal(200, result.Value);
        }

        [Fact]
        public void DoesCalculateSI()
        {
            var result = mathController.SimpleInterest(1000, 10, 2);

            Assert.Equal(200, result.Value);
        }

        [Fact]
        public void DoesCalculateCI()
        {
            var result = mathController.CompoundInterest(1000, 10, 2);

            Assert.Equal(210, result.Value);
        }
    }
}