using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomMathOperations;

namespace NUnitTesting
{
    [TestFixture]
    public class MathNUnitTest
    {
        BasicMath bm=new BasicMath();
        [Test]
        public void Test_Add()
        {
            int result = bm.Add(4, 5);

            int expected = 9;
            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Test_Subtract()
        {
            int result = bm.Subtract(4, 5);

            int expected = -1;
            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Test_Multiply()
        {
            int result = bm.Mutiply(4, 5);

            int expected = 20;
            Assert.That(result.Equals(expected));
        }

        [Test]
        public void Test_Division()
        {
            int result = bm.Divide(4, 5);

            int expected = 0;
            Assert.That(result.Equals(expected));
        }
    }
}
