namespace Lab_11___Calculator
{
    public class Square : Operator
    {
        public override double Calculate(double x, double y)
        {
            return (x * x);
        }

        public override string getSymbol()
        {
            return "²";
        }
    }
}
