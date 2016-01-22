using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class SolverTests
    {
        [Test]
        public void When_Translate_is_called_with_1_then_result_should_be_1()
        {
            var solver = new Solver();
            var result = solver.Translate(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void When_Translate_is_called_with_2_then_result_should_be_2()
        {
            var solver = new Solver();
            var result = solver.Translate(2);
            Assert.AreEqual("2", result);
        }
    }
}
