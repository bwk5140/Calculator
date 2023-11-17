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
                calculator.operandsDisplay.Text = "";
                calculator.entryDisplay.Text = "";
                calculator.division.Enabled = true;
                calculator.division.BackColor = System.Drawing.Color.White;
                calculator.reciprocal.Enabled = true;
                calculator.reciprocal.BackColor = System.Drawing.Color.White;
                calculator.square.Enabled = true;
                calculator.square.BackColor = System.Drawing.Color.White;
                calculator.squareRoot.Enabled = true;
                calculator.squareRoot.BackColor = System.Drawing.Color.White;
                calculator.multiplication.Enabled = true;
                calculator.multiplication.BackColor = System.Drawing.Color.White;
                calculator.addition.Enabled = true;
                calculator.addition.BackColor = System.Drawing.Color.White;
                calculator.subtraction.Enabled = true;
                calculator.subtraction.BackColor = System.Drawing.Color.White;
                calculator.plusMinus.Enabled = true;
                calculator.plusMinus.BackColor = System.Drawing.Color.White;
                calculator.decimalPoint.Enabled = true;
                calculator.decimalPoint.BackColor = System.Drawing.Color.White;
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
            inputState = "OperatorState";
            unaryOperation = false;
            Enter();

            return calculator.operand2State;
        }

        public override State NextEntryState(Operator oprtr)
        {
            previousOperator = oprtr;

            if (previousOperator == calculator.square_root)
            {
                calculator.operandsDisplay.Text += previousOperator.getSymbol() + " (" + entryVal2 + ")";
                if (entryVal2 < 0)
                {
                    calculator.entryDisplay.Text = "Invalid input";
                    calculator.division.Enabled = false;
                    calculator.division.BackColor = System.Drawing.Color.Transparent;
                    calculator.reciprocal.Enabled = false;
                    calculator.reciprocal.BackColor = System.Drawing.Color.Transparent;
                    calculator.square.Enabled = false;
                    calculator.square.BackColor = System.Drawing.Color.Transparent;
                    calculator.squareRoot.Enabled = false;
                    calculator.squareRoot.BackColor = System.Drawing.Color.Transparent;
                    calculator.multiplication.Enabled = false;
                    calculator.multiplication.BackColor = System.Drawing.Color.Transparent;
                    calculator.addition.Enabled = false;
                    calculator.addition.BackColor = System.Drawing.Color.Transparent;
                    calculator.subtraction.Enabled = false;
                    calculator.subtraction.BackColor = System.Drawing.Color.Transparent;
                    calculator.plusMinus.Enabled = false;
                    calculator.plusMinus.BackColor = System.Drawing.Color.Transparent;
                    calculator.decimalPoint.Enabled = false;
                    calculator.decimalPoint.BackColor = System.Drawing.Color.Transparent;

                    Enter();
                    return calculator.operand1State;
                }
                else
                {
                    entryVal2 = previousOperator.Calculate(entryVal2, entryVal1);
                    calculator.entryDisplay.Text = "" + entryVal2;
                    Enter();
                    return calculator.operand2State;
                }
            }
            else if (previousOperator == calculator.square_)
            {
                calculator.operandsDisplay.Text += "(" + entryVal1 + ")" + previousOperator.getSymbol();
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
                if (entryVal1 == 0)
                {
                    calculator.operandsDisplay.Text = "1/(" + entryVal1 + ")";
                    calculator.entryDisplay.Text = "Cannot divide by zero";
                    calculator.division.Enabled = false;
                    calculator.division.BackColor = System.Drawing.Color.Transparent;
                    calculator.reciprocal.Enabled = false;
                    calculator.reciprocal.BackColor = System.Drawing.Color.Transparent;
                    calculator.square.Enabled = false;
                    calculator.square.BackColor = System.Drawing.Color.Transparent;
                    calculator.squareRoot.Enabled = false;
                    calculator.squareRoot.BackColor = System.Drawing.Color.Transparent;
                    calculator.multiplication.Enabled = false;
                    calculator.multiplication.BackColor = System.Drawing.Color.Transparent;
                    calculator.addition.Enabled = false;
                    calculator.addition.BackColor = System.Drawing.Color.Transparent;
                    calculator.subtraction.Enabled = false;
                    calculator.subtraction.BackColor = System.Drawing.Color.Transparent;
                    calculator.plusMinus.Enabled = false;
                    calculator.plusMinus.BackColor = System.Drawing.Color.Transparent;
                    calculator.decimalPoint.Enabled = false;
                    calculator.decimalPoint.BackColor = System.Drawing.Color.Transparent;

                    Enter();
                    return calculator.operand1State;
                }
                else
                {
                    calculator.operandsDisplay.Text += " 1/(" + entryVal1 + ")";
                    entryVal2 = previousOperator.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal2;
                    Enter();
                    return calculator.operand2State;
                }

            }
            else if (previousOperator == calculator.clearAllOperator)
            {
                calculator.operandsDisplay.Text = "";
                calculator.entryDisplay.Text = "0";
                entry = "";
                entryVal1 = 0;
                entryVal2 = 0;
                calculator.division.Enabled = true;
                calculator.division.BackColor = System.Drawing.Color.White;
                calculator.reciprocal.Enabled = true;
                calculator.reciprocal.BackColor = System.Drawing.Color.White;
                calculator.square.Enabled = true;
                calculator.square.BackColor = System.Drawing.Color.White;
                calculator.squareRoot.Enabled = true;
                calculator.squareRoot.BackColor = System.Drawing.Color.White;
                calculator.multiplication.Enabled = true;
                calculator.multiplication.BackColor = System.Drawing.Color.White;
                calculator.addition.Enabled = true;
                calculator.addition.BackColor = System.Drawing.Color.White;
                calculator.subtraction.Enabled = true;
                calculator.subtraction.BackColor = System.Drawing.Color.White;
                calculator.plusMinus.Enabled = true;
                calculator.plusMinus.BackColor = System.Drawing.Color.White;
                calculator.decimalPoint.Enabled = true;
                calculator.decimalPoint.BackColor = System.Drawing.Color.White;

                Enter();

                return calculator.operand1State;
            }
            else if (previousOperator == calculator.clearEntryOperator)
            {
                if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                        || calculator.entryDisplay.Text.Contains("Invalid input"))
                {
                    calculator.operandsDisplay.Text = "";
                    entryVal1 = 0;
                    calculator.entryDisplay.Text = "0";
                    entry = "";
                    entryVal2 = 0;
                    calculator.division.Enabled = true;
                    calculator.division.BackColor = System.Drawing.Color.White;
                    calculator.reciprocal.Enabled = true;
                    calculator.reciprocal.BackColor = System.Drawing.Color.White;
                    calculator.square.Enabled = true;
                    calculator.square.BackColor = System.Drawing.Color.White;
                    calculator.squareRoot.Enabled = true;
                    calculator.squareRoot.BackColor = System.Drawing.Color.White;
                    calculator.multiplication.Enabled = true;
                    calculator.multiplication.BackColor = System.Drawing.Color.White;
                    calculator.addition.Enabled = true;
                    calculator.addition.BackColor = System.Drawing.Color.White;
                    calculator.subtraction.Enabled = true;
                    calculator.subtraction.BackColor = System.Drawing.Color.White;
                    calculator.plusMinus.Enabled = true;
                    calculator.plusMinus.BackColor = System.Drawing.Color.White;
                    calculator.decimalPoint.Enabled = true;
                    calculator.decimalPoint.BackColor = System.Drawing.Color.White;
                    Enter();
                    return calculator.operand1State;
                }
                else
                {
                    calculator.entryDisplay.Text = "0";
                    entry = "";
                    entryVal2 = 0;
                    calculator.division.Enabled = true;
                    calculator.division.BackColor = System.Drawing.Color.White;
                    calculator.reciprocal.Enabled = true;
                    calculator.reciprocal.BackColor = System.Drawing.Color.White;
                    calculator.square.Enabled = true;
                    calculator.square.BackColor = System.Drawing.Color.White;
                    calculator.squareRoot.Enabled = true;
                    calculator.squareRoot.BackColor = System.Drawing.Color.White;
                    calculator.multiplication.Enabled = true;
                    calculator.multiplication.BackColor = System.Drawing.Color.White;
                    calculator.addition.Enabled = true;
                    calculator.addition.BackColor = System.Drawing.Color.White;
                    calculator.subtraction.Enabled = true;
                    calculator.subtraction.BackColor = System.Drawing.Color.White;
                    calculator.plusMinus.Enabled = true;
                    calculator.plusMinus.BackColor = System.Drawing.Color.White;
                    calculator.decimalPoint.Enabled = true;
                    calculator.decimalPoint.BackColor = System.Drawing.Color.White;
                }

                Enter();

                return this;
            }
            else if (previousOperator == calculator.backspaceOperator)
            {
                calculator.division.Enabled = true;
                calculator.division.BackColor = System.Drawing.Color.White;
                calculator.reciprocal.Enabled = true;
                calculator.reciprocal.BackColor = System.Drawing.Color.White;
                calculator.square.Enabled = true;
                calculator.square.BackColor = System.Drawing.Color.White;
                calculator.squareRoot.Enabled = true;
                calculator.squareRoot.BackColor = System.Drawing.Color.White;
                calculator.multiplication.Enabled = true;
                calculator.multiplication.BackColor = System.Drawing.Color.White;
                calculator.addition.Enabled = true;
                calculator.addition.BackColor = System.Drawing.Color.White;
                calculator.subtraction.Enabled = true;
                calculator.subtraction.BackColor = System.Drawing.Color.White;
                calculator.plusMinus.Enabled = true;
                calculator.plusMinus.BackColor = System.Drawing.Color.White;
                calculator.decimalPoint.Enabled = true;
                calculator.decimalPoint.BackColor = System.Drawing.Color.White;
                return this;
            }
            else
            {
                operator_ = oprtr;
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "" + entryVal1;
                unaryOperation = false;
            }
            
            Enter();
            return this;

        }

        public override State NextEntryState(Equals equals)
        {
            if ((operator_ == calculator.divide && entryVal2 == 0))
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";
                calculator.division.Enabled = false;
                calculator.division.BackColor = System.Drawing.Color.Transparent;
                calculator.reciprocal.Enabled = false;
                calculator.reciprocal.BackColor = System.Drawing.Color.Transparent;
                calculator.square.Enabled = false;
                calculator.square.BackColor = System.Drawing.Color.Transparent;
                calculator.squareRoot.Enabled = false;
                calculator.squareRoot.BackColor = System.Drawing.Color.Transparent;
                calculator.multiplication.Enabled = false;
                calculator.multiplication.BackColor = System.Drawing.Color.Transparent;
                calculator.addition.Enabled = false;
                calculator.addition.BackColor = System.Drawing.Color.Transparent;
                calculator.subtraction.Enabled = false;
                calculator.subtraction.BackColor = System.Drawing.Color.Transparent;
                calculator.plusMinus.Enabled = false;
                calculator.plusMinus.BackColor = System.Drawing.Color.Transparent;
                calculator.decimalPoint.Enabled = false;
                calculator.decimalPoint.BackColor = System.Drawing.Color.Transparent;
                Enter();
                return calculator.operand1State;
            }
            else
            {
                if (calculator.prevState == calculator.operand1State &&
                    operator_.GetType() == nullOperator.GetType())
                {
                    calculator.operandsDisplay.Text = "" + entryVal1 + " =";
                }
                else
                {
                    calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol()
                    + " " + entryVal2 + " =";
                    unaryOperation = false;
                }
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;
                calculator.prevState = this;
                Enter();
                return calculator.equalState;
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
