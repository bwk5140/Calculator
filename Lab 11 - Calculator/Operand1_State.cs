using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class Operand1_State : State
    {
        public override State NextEntryState(char val)
        {
            if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                || calculator.entryDisplay.Text.Contains("Invalid input"))
            {
                calculator.entryDisplay.Text = "";
            }

            if (entryVal1 == 0 &&
                !calculator.entryDisplay.Text.Contains("."))
            {
                entry = "" + val;
            }
            else
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

                    return calculator.operand1State;
                }
                else
                {
                    return this;
                }
            }
            else if (operator_ == calculator.reciprocal_)
            {
                if (entryVal1 == 0)
                {
                    calculator.operandsDisplay.Text = "1/" + entryVal1;
                    calculator.entryDisplay.Text = "Cannot divide by zero";
                }
                else
                {
                    calculator.operandsDisplay.Text = "1/" + entryVal1;
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

                Enter();

                return this;
            }
            else if (operator_ == calculator.clearEntryOperator)
            {
                calculator.entryDisplay.Text = "0";
                entry = "";
                entryVal2 = 0;

                Enter();

                return this;
            }
            else if (operator_ == calculator.backspaceOperator)
            {
                string delete;
                delete = calculator.entryDisplay.Text.Remove(calculator.entryDisplay.Text.Length - 1);
                entry = delete;

                if (entry.Equals("") || entryVal1 < 0)
                {
                    entryVal1 = 0;
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
            else if ((operator_ == calculator.divide && entryVal1 == 0))
            {
                calculator.operandsDisplay.Text = entryVal2 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";

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

            if (operator_ == calculator.divide && entryVal1 == 0)
            {
                calculator.operandsDisplay.Text = entryVal2 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";
            }
            else if ((operator_ == calculator.square_root && entryVal1 < 0))
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Invalid input";
                operator_ = new NullOperator();
            }
            else if ((operator_ == calculator.reciprocal_ && entryVal1 == 0))
            {
                calculator.operandsDisplay.Text = entryVal2 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";
                operator_ = new NullOperator();
            }
            else
            {
                calculator.prevState = this;
                operator_ = new NullOperator();
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
