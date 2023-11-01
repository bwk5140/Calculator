using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class Operand1_State : State
    {
        public override State NextEntryState(char val)
        {
            string input = "" + val;

            if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                || calculator.entryDisplay.Text.Contains("Invalid input"))
            {
                calculator.operandsDisplay.Text = "";
                calculator.entryDisplay.Text = "";
                calculator.division.Enabled = true;
                calculator.reciprocal.Enabled = true;
                calculator.square.Enabled = true;
                calculator.squareRoot.Enabled = true;
                calculator.multiplication.Enabled = true;
                calculator.addition.Enabled = true;
                calculator.subtraction.Enabled = true;
                calculator.plusMinus.Enabled = true;
                calculator.decimalPoint.Enabled = true;
            }

            if (entryVal1 == 0 &&
                !calculator.entryDisplay.Text.Contains(".") && !input.Contains("."))
            {
                entry = "" + val;
            }
            else if ((entryVal1 == 0 && calculator.entryDisplay.Text.Contains("."))
                || entryVal1 > 0)
            {
                entry = calculator.entryDisplay.Text + val;
            }

            calculator.entryDisplay.Text = entry;

            entryVal1 = double.Parse(entry);

            Enter();
            return this;
        }
        public override State NextEntryState(Operator oprtr)
        {
            calculator.prevState = this;
            operator_ = oprtr;
            if (operator_ == calculator.square_root)
            {
                calculator.operandsDisplay.Text = "" + operator_.getSymbol() + " (" + entryVal1 + ")";
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
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                    entryVal2 = entryVal1;
                }

                Enter();

                return this;
            }
            else if (operator_ == calculator.square_)
            {
                calculator.operandsDisplay.Text = "(" + entryVal1 + ")" + operator_.getSymbol();

                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;
                entryVal2 = entryVal1;

                Enter();

                return this;
            }
            else if (operator_ == calculator.negate)
            {
                if (entryVal1 != 0)
                {
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                    entryVal2 = entryVal1;
                    Enter();
                }
                    return this;
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

                return this;
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

                return this;
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

                return this;
            }
            else if (operator_ == calculator.backspaceOperator)
            {
                string delete;
                delete = calculator.entryDisplay.Text.Remove(calculator.entryDisplay.Text.Length - 1);
                entry = delete;

                if (entry.Equals(""))
                {
                    entryVal1 = 0;
                }
                else if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                        || calculator.entryDisplay.Text.Contains("Invalid input"))
                {
                    entryVal1 = 0;
                    calculator.operandsDisplay.Text = "";
                    calculator.entryDisplay.Text = "" + entryVal1;
                    calculator.division.Enabled = true;
                    calculator.reciprocal.Enabled = true;
                    calculator.square.Enabled = true;
                    calculator.squareRoot.Enabled = true;
                    calculator.multiplication.Enabled = true;
                    calculator.addition.Enabled = true;
                    calculator.subtraction.Enabled = true;
                    calculator.plusMinus.Enabled = true;
                    calculator.decimalPoint.Enabled = true;
                }
                else
                {
                    if (entryVal1 - (int)entryVal1 == 0)
                    {

                        entryVal1 = int.Parse(entry);
                    }
                    else
                    {
                        entryVal1 = double.Parse(entry);
                    }
                }


                calculator.entryDisplay.Text = "" + entryVal1;
                Enter();

                return this;
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

            calculator.prevState = this;
            operator_ = new NullOperator();
            if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                || calculator.entryDisplay.Text.Contains("Invalid input"))
            {
                entryVal1 = 0;
                entryVal2 = 0;
                calculator.operandsDisplay.Text = "";
                calculator.entryDisplay.Text = "" + entryVal1;
                calculator.division.Enabled = true;
                calculator.reciprocal.Enabled = true;
                calculator.square.Enabled = true;
                calculator.squareRoot.Enabled = true;
                calculator.multiplication.Enabled = true;
                calculator.addition.Enabled = true;
                calculator.subtraction.Enabled = true;
                calculator.plusMinus.Enabled = true;
                calculator.decimalPoint.Enabled = true;
            }
            else
            {
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;
                calculator.operandsDisplay.Text = "" + entryVal1 + " =";
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
