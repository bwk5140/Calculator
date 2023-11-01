using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class EqualState : State
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
                entryVal1 = double.Parse(entry);
            }
            else
            {
                entry = "" + val;
                entryVal1 = double.Parse(entry);
            }
            
            calculator.operandsDisplay.Text = "";
            calculator.entryDisplay.Text = entry;

            Enter();

            return calculator.operand1State;
        }

        public override State NextEntryState(Operator oprtr)
        {
            operator_ = oprtr;
            if (operator_ == calculator.square_root)
            {
                if (entryVal1 < 0)
                {
                    calculator.entryDisplay.Text = "Invalid input";
                    calculator.division.Enabled = false;
                    calculator.reciprocal.Enabled = false;
                    calculator.square.Enabled = false;
                    calculator.squareRoot.Enabled = false;
                    calculator.multiplication.Enabled = false;
                    calculator.addition.Enabled = false;
                    calculator.subtraction.Enabled = false;
                    calculator.plusMinus.Enabled = false;
                    calculator.decimalPoint.Enabled = false;
                }
                else
                {
                    calculator.operandsDisplay.Text = "" + operator_.getSymbol() + " (" + entryVal1 + ")";
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                }

                entryVal2 = entryVal1;
                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.square_)
            {
                calculator.operandsDisplay.Text = "" + " (" + entryVal1 + ")" + operator_.getSymbol();
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;

                entryVal2 = entryVal1;
                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.negate)
            {
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;

                entryVal2 = entryVal1;
                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.reciprocal_)
            {
                if (entryVal1 == 0)
                {
                    calculator.operandsDisplay.Text = " (1/" + entryVal1 + ")";
                    calculator.entryDisplay.Text = "Cannot divide by zero";
                    calculator.division.Enabled = false;
                    calculator.reciprocal.Enabled = false;
                    calculator.square.Enabled = false;
                    calculator.squareRoot.Enabled = false;
                    calculator.multiplication.Enabled = false;
                    calculator.addition.Enabled = false;
                    calculator.subtraction.Enabled = false;
                    calculator.plusMinus.Enabled = false;
                    calculator.decimalPoint.Enabled = false;
                }
                else
                {
                    calculator.operandsDisplay.Text = " (1/" + entryVal1 + ")";
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                    entryVal2 = entryVal1;
                }
                
                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.clearAllOperator ||
                operator_ == calculator.clearEntryOperator)
            {
                calculator.operandsDisplay.Text = "";
                calculator.entryDisplay.Text = "0";
                entry = "";
                entryVal1 = 0;
                entryVal2 = 0;
                calculator.division.Enabled = true;
                calculator.reciprocal.Enabled = true;
                calculator.square.Enabled = true;
                calculator.squareRoot.Enabled = true;
                calculator.multiplication.Enabled = true;
                calculator.addition.Enabled = true;
                calculator.subtraction.Enabled = true;
                calculator.plusMinus.Enabled = true;
                calculator.decimalPoint.Enabled = true;

                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.backspaceOperator)
            {
                entryVal2 = 0;

                if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                        || calculator.entryDisplay.Text.Contains("Invalid input"))
                {
                    calculator.entryDisplay.Text = "" + entryVal2;
                    entryVal1 = 0;
                    calculator.division.Enabled = true;
                    calculator.reciprocal.Enabled = true;
                    calculator.square.Enabled = true;
                    calculator.squareRoot.Enabled = true;
                    calculator.multiplication.Enabled = true;
                    calculator.addition.Enabled = true;
                    calculator.subtraction.Enabled = true;
                    calculator.plusMinus.Enabled = true;
                    calculator.decimalPoint.Enabled = true;
                    calculator.operandsDisplay.Text = "";
                    Enter();

                    return calculator.operand1State;
                }

                else
                {
                    calculator.operandsDisplay.Text = "";
                    calculator.entryDisplay.Text = "" + entryVal1;
                    operator_ = new NullOperator();
                    Enter();

                    return calculator.operatorState;
                }             
            }

            else
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();

                entryVal2 = entryVal1;
                Enter();

                return calculator.operatorState;
            }
            
        }

        public override State NextEntryState(Equals equals)
        {
            if ((operator_ == calculator.divide && entryVal2 == 0))
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";

                Enter();
                return calculator.operand1State;
            }
            else
            {
                if (calculator.prevState == calculator.operand1State)
                {
                    calculator.operandsDisplay.Text = "" + entryVal1 + " =";
                }
                else
                {
                    calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol()
                    + " " + entryVal2 + " =";
                }
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;

                Enter();
                return this;
            }

            
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
