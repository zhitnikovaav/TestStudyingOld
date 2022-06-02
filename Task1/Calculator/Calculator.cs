using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Devision(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("B is equal to 0");
            }
            return a / b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
