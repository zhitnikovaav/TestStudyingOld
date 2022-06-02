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
            public void Sum_MaxValue()
            {
                Assert.Multiple(() =>
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(int.MaxValue, 1));
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(4, int.MaxValue));
                }
                );

            }


            [Test]
            public void Minus_MinValue()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Minus(int.MinValue, 4));
            }


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
            public void Division_correct()
            {
                //arrange
                int a = 35;
                int b = 10;
                //act
                int actual = Calculator.Division(a, b);
                //assert
                Assert.AreNotEqual(5, actual);
            }

            public void Division_Zero()
            {
                Assert.Throws<DivideByZeroException>(() => Calculator.Division(int.MinValue, 4));
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

            [Test]
            public void Multi_MaxMinValue()
            {
                Assert.Multiple(() =>
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(int.MaxValue, 2));
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(4, int.MaxValue));
                }
                );

            }
        }
    }
}