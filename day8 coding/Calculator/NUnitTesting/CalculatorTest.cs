using CalculatorExample;



namespace NUnitTesting
{
    public class Tests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectResult()
        {
            double result = _calculator.Add(5, 3);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_ShouldReturnCorrectResult()
        {
            double result = _calculator.Subtract(10, 4);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_ShouldReturnCorrectResult()
        {
            double result = _calculator.Multiply(2, 5);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Divide_ShouldReturnCorrectResult()
        {
            double result = _calculator.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void DivideByZero_ShouldThrowException()
        {
            Assert.That(() => _calculator.Divide(10, 0), Throws.ArgumentException);
        }

        [Test]
        public void AddZero_ShouldReturnCorrectResult()
        {
            double result = _calculator.Add(5, 0);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void SubtractZero_ShouldReturnCorrectResult()
        {
            double result = _calculator.Subtract(5, 0);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}