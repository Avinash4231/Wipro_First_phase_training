using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomMathOperations;

namespace MSTesting
{
    [TestClass]
    public class BasicMathTest
    {
        BasicMath bm=new BasicMath();
        [TestMethod]
        public void Test_Add()
        {
            int result = bm.Add(4, 5);

            //here we are checkig whether the expected output and the actual output are same or not
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            int result = bm.Subtract(4, 5);

            //here we are checkig whether the expected output and the actual output are same or not
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            int result = bm.Mutiply(4, 5);

            //here we are checkig whether the expected output and the actual output are same or not
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Test_Division()
        {
            int result = bm.Divide(4, 5);

            //here we are checkig whether the expected output and the actual output are same or not
            Assert.AreEqual(0, result);
        }
    }
}
