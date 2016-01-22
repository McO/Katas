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
    }
}
