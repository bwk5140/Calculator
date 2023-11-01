using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class EntryState : State
    {
        public override State NextEntryState(char val)
        {
            if (calculator.entryDisplay.Text.Contains("Cannot divide by zero"))
            {
                calculator.entryDisplay.Text = "0";
            }

            if (!char.IsDigit(val))
            {
                entry = calculator.entryDisplay.Text + val;
                entryVal1 = double.Parse(entry);
            }
            else
            {
                entry = "" + val;
                entryVal1 = double.Parse(entry);
            }

            calculator.entryDisplay.Text = entry;
            Enter();

            return calculator.operand1State;
        }

        public override State NextEntryState(Operator oprtr)
        {
            operator_ = oprtr;

            if (operator_ == calculator.square_root)
            {
                calculator.operandsDisplay.Text = "" + operator_.getSymbol() + " " + entryVal1;
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;
                entryVal2 = entryVal1;

                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.square_)
            {
                calculator.operandsDisplay.Text = "" + entryVal1 + " " + operator_.getSymbol();

                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;
                entryVal2 = entryVal1;

                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.negate)
            {
                if (entryVal1 != 0)
                {
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                    entryVal2 = entryVal1;

                    Enter();

                    return calculator.operand1State;
                }
                else
                {
                    return this;
                }
                
            }
            else if (operator_ == calculator.reciprocal_)
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

                Enter();

                return calculator.operand1State;
            }
            else if (operator_ == calculator.clearAllOperator)
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
            else if (operator_ == calculator.clearEntryOperator)
            {
                calculator.entryDisplay.Text = "0";
                entry = "";
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
                string delete;
                delete = calculator.entryDisplay.Text.Remove(calculator.entryDisplay.Text.Length - 1);
                entry = delete;
                double newValue;
                entryVal2 = double.TryParse(entry, out newValue) ? newValue : 0;

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
            else
            {
                calculator.operandsDisplay.Text = "" + entryVal1 + " " + 
                    operator_.getSymbol() + " ";
                entryVal2 = entryVal1;

                Enter();

                return calculator.operatorState;
            }
        }

        public override State NextEntryState(Equals equals)
        {
            entryVal1 = operator_.Calculate(entryVal1, entryVal2);
            calculator.entryDisplay.Text = "" + entryVal1;
            calculator.operandsDisplay.Text = "" + entryVal1 + " =";

            calculator.prevState = this;

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
