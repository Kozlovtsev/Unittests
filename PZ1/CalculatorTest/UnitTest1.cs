using PZ1;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public async Task AddAsync_ShouldReturnCorrectSum()
        {
            double a = 15.5;
            double b = 10.3;

            double result = await _calculator.AddAsync(a, b);

            Assert.Equal(25.8, result, 1);
        }

        [Fact]
        public void Divide_LargeNumbers_ShouldReturnCorrectQuotient()
        {
            double a = 1e308;
            double b = 1e154;

            double result = _calculator.Divide(a, b);

            Assert.Equal(1e154, result, 1);
        }

        [Fact]
        public void Add_InvalidData_ShouldThrowArgumentException()
        {
            double a = double.NaN;
            double b = 10.0;

            Assert.Throws<ArgumentException>(() => _calculator.Add(a, b));
        }

        [Fact]
        public void Multiply_ByNegative_ShouldReturnNegativeProduct()
        {
            double a = -4.5;
            double b = 2.0;

            double result = _calculator.Multiply(a, b);

            Assert.Equal(-9.0, result, 1);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            double a = 9.0;
            double b = 0.0;

            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-2, -3, -5)]
        [InlineData(-2, 3, 1)]
        public void Add_ShouldReturnCorrectSum(double a, double b, double expected)
        {
            double result = _calculator.Add(a, b);

            Assert.Equal(expected, result, 1);
        }
    }
}