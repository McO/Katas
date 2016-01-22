using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class SolverTests
    {
        [Test]
        public void When_Translate_is_called_with_1_then_result_should_be_1()
        {
            var solver = Solver();
            var result = solver.Translate(1);
            Assert.AreEqual("1", result);
        }
    }
}
