using System;

namespace src
{

    public class Calculator
    {
        public float Add(float a, float b)
        {
            return a + b;
        }

        public float Sub(float a, float b)
        {
            return a - b;
        }

        public float Mul(float a, float b)
        {
            return a * b;
        }

        public float Div(float a, float b)
        {
          if (b == 0) throw new ArithmeticException("Divide By Zero Error");
        return a / b;
        }                  

        public float Mod(float a, float b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a % b;
        }
    }
}