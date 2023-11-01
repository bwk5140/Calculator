namespace Lab_11___Calculator
{
    public class Reciprocal : Operator
    {
        public override double Calculate(double x, double y)
        {
            return (1 / x);
        }

        public override string getSymbol()
        {
            return "";
        }
    }
}
