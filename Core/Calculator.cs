using System;

namespace Core
{
    public sealed class Calculator
    {
        public int Add(int addendA, int addendB)
        {
            return addendA + addendB;
        }

        public int Subtract(int subtracting, int minuing)
        {
            return subtracting - minuing;
        }

        public int Divide(int dividend, int divisor)
        {
            return (int) Math.Ceiling( (double) dividend/divisor );
        }

        public int Multiplication(int multiplying, int multiplier)
        {
            return multiplying * multiplier;
        }
    }

}
