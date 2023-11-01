using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class OperatorState : State
    {
        public override State NextEntryState(char val)
        {
            if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                || calculator.entryDisplay.Text.Contains("Invalid input"))
            {
                calculator.entryDisplay.Text = "";
            }
            if (!char.IsDigit(val))
            {
                entry = "0" + val;
                entryVal2 = double.Parse(entry);
                calculator.entryDisplay.Text = entry;
            }
            else
            {
                entry = "" + val;
                entryVal2 = double.Parse(entry);
                calculator.entryDisplay.Text = entry;
            }

            Enter();

            return calculator.operand2State;
        }

        public override State NextEntryState(Operator oprtr)
        {
            previousOperator = oprtr;

            if (previousOperator == calculator.square_root)
            {
                calculator.operandsDisplay.Text += previousOperator.getSymbol() + " (" + entryVal1 + ")";
                if (entryVal2 < 0)
                {
                    calculator.entryDisplay.Text = "Invalid input";
                }
                else
                {
                    entryVal2 = previousOperator.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal2;
                }

                Enter();
                return calculator.operand2State;
            }
            else if (previousOperator == calculator.square_)
            {
                calculator.operandsDisplay.Text += "("+ entryVal1 + ")" + previousOperator.getSymbol();
                entryVal2 = previousOperator.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal2;

                Enter();
                return calculator.operand2State;
            }
            else if (previousOperator == calculator.negate)
            {
                if (entryVal2 != 0)
                {
                    entryVal2 = previousOperator.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal2;

                    Enter();

                    return calculator.operand2State;
                }
                else
                {
                    return this;
                }
            }
            else if (previousOperator == calculator.reciprocal_)
            {
                if (entryVal2 == 0)
                {
                    calculator.operandsDisplay.Text = "(1/" + entryVal2 + ")";
                    calculator.entryDisplay.Text = "Cannot divide by zero";
                }
                else
                {
                    calculator.operandsDisplay.Text += " (1/" + entryVal1 + ")";
                    entryVal2 = previousOperator.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal2;
                }

                Enter();

                return calculator.operand2State;
            }
            else if (previousOperator == calculator.clearAllOperator)
            {
                calculator.operandsDisplay.Text = "";
                calculator.entryDisplay.Text = "0";
                entry = "";
                entryVal1 = 0;
                entryVal2 = 0;

                Enter();

                return calculator.operand1State;
            }
            else if (previousOperator == calculator.clearEntryOperator)
            {
                calculator.entryDisplay.Text = "0";
                entry = "";
                entryVal2 = 0;

                Enter();

                return this;
            }
            else if (previousOperator == calculator.backspaceOperator)
            {
                return this;
            }
            else if ((operator_ == calculator.divide && entryVal2 == 0))
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";
                
                Enter();

                return this;
            }
            else
            {
                operator_ = oprtr;
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "" + entryVal1;

                Enter();

                return this;
            }  
        }

        public override State NextEntryState(Equals equals)
        {
            calculator.prevState = this;

            if (operator_ == calculator.divide && entryVal2 == 0)
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";
            }
            else if ((operator_ == calculator.square_root && entryVal2 < 0))
            {
                calculator.operandsDisplay.Text = entryVal2 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Invalid input";
                operator_ = new NullOperator();
            }
            else if ((operator_ == calculator.reciprocal_ && entryVal2 == 0))
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";
                operator_ = new NullOperator();
            }
            else
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol()
                + " " + entryVal2 + " =";
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;
            }

            Enter();

            return calculator.equalState;
        }

        public override void Enter()
        {
            calculator.entryDisplay.SelectAll();
            calculator.entryDisplay.SelectionAlignment = HorizontalAlignment.Right;
            calculator.operandsDisplay.SelectAll();
            calculator.operandsDisplay.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
