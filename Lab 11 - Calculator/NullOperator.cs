using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
