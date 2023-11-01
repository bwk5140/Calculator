using System;

namespace Lab_11___Calculator
{
    public class Negate : Operator
    {
        public override double Calculate(double x, double y)
        {
            x *= -1;
            return x;
        }

        public override string getSymbol()
        {
            return "";
        }
    }
}
