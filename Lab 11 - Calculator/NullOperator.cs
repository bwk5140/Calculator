namespace Lab_11___Calculator
{
    public class NullOperator : Operator
    {
        public override double Calculate(double x, double y)
        {
            return x;
        }

        public override string getSymbol()
        {
            return "";
        }
    }
}
