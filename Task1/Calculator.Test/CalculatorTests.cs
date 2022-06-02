using NUnit.Framework;
using System;
using Calculator;

namespace Calculator.Test
{
    public class Tests
    {
        [TestFixture]
        public class CalculatorTests
        {
            [Test]
            public void Sum_correct()
            {
                //arrange
                int a = 10;
                int b = 25;
                int expected = 35;
                //act
                int actual = Calculator.Sum(a, b);
                //assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void Minus_correct()
            {
                //arrange
                int a = 10;
                int b = 25;
                int expected = -15;
                //act
                int actual = Calculator.Minus(a, b);
                //assert
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(expected, actual);
                    Assert.AreEqual(10 - 5, 10 - 5);
                    Assert.AreNotEqual(-5, 0);
                });

            }

            [Test]
            public void Devision_correct()
            {
                //arrange
                int a = 35;
                int b = 10;
                //act
                int actual = Calculator.Devision(a, b);
                //assert
                Assert.AreNotEqual(5, actual);
            }

            [Test]
            public void Multiplication_correct()
            {
                //arrange
                int a = 10;
                int b = 25;
                int expected = 250;
                //act
                int actual = Calculator.Multiplication(a, b);
                //assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}