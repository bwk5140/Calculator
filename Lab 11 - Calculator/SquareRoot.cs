using System;

namespace Lab_11___Calculator
{
    public class SquareRoot : Operator
    {
        public override double Calculate(double x, double y)
        {
            return Math.Sqrt(x);
        }

        public override string getSymbol()
        {
            return "√";
        }
    }
}
