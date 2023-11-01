namespace Lab_11___Calculator
{
    public class Divide : Operator
    {
        public override double Calculate(double x, double y)
        {
            return (x / y);
        }

        public override string getSymbol()
        {
            return "÷";
        }
    }
}
