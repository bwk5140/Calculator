using System;

namespace Lab_11___Calculator
{
    public class Square : Operator
    {
        public override double Calculate(double x, double y)
        {
            return Math.Pow(x , 2.0);
        }

        public override string getSymbol()
        {
            return "²";
        }
    }
}
