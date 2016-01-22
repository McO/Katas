using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class SolverTests
    {
        private Solver _sut;
        [OneTimeSetUp]
        public void Init()
        {
            _sut = new Solver();
        }


        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        public string When_Translate_is_called_with_a_number_it_should_return_the_number_as_string(int number)
        {
            return _sut.Translate(number);
        }

        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(6, ExpectedResult = "Fizz")]
        public string When_Translate_is_called_with_a_number_divisible_by_3_it_should_return_Fizz(int number)
        {
            return _sut.Translate(number);
        }

        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(10, ExpectedResult = "Buzz")]
        public string When_Translate_is_called_with_a_number_divisible_by_5_it_should_return_Buzz(int number)
        {
            return _sut.Translate(number);
        }
    }
}
