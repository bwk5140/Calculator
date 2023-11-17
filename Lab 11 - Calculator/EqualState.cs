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
                entryVal1 = double.Parse(entry);
            }
            else
            {
                entry = "" + val;
                entryVal1 = double.Parse(entry);
            }
            
            calculator.operandsDisplay.Text = "";
            calculator.entryDisplay.Text = entry;

            inputState = "EqualState";
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
                }
                else
                {
                    calculator.operandsDisplay.Text = "" + operator_.getSymbol() + " (" + entryVal1 + ")";
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                }
                Enter();

                return this;
            }
            else if (operator_ == calculator.square_)
            {
                calculator.operandsDisplay.Text = "" + " (" + entryVal1 + ")" + operator_.getSymbol();
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;

                Enter();

                return this;
            }
            else if (operator_ == calculator.negate)
            {
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;

                Enter();

                return this;
            }
            else if (operator_ == calculator.reciprocal_)
            {
                if (entryVal1 == 0)
                {
                    calculator.operandsDisplay.Text = " 1/(" + entryVal1 + ")";
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
                }
                else
                {
                    calculator.operandsDisplay.Text = " 1/(" + entryVal1 + ")";
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
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
            else if (operator_ == calculator.clearEntryOperator)
            {
                if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                || calculator.entryDisplay.Text.Contains("Invalid input"))
                {
                    entryVal1 = 0;
                    entryVal2 = 0;
                    calculator.operandsDisplay.Text = "";
                    calculator.entryDisplay.Text = "" + entryVal1;
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
                    if (unaryOperation)
                    {
                        calculator.entryDisplay.Text = "0";
                        entry = "";
                        entryVal1 = 0;
                    }
                    else
                    {
                        calculator.operandsDisplay.Text = "";
                        calculator.entryDisplay.Text = "0";
                        entry = "";
                        entryVal1 = 0;
                    }
                }

                Enter();

                return this;
            }
            else if (operator_ == calculator.backspaceOperator)
            {
                if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                        || calculator.entryDisplay.Text.Contains("Invalid input"))
                {
                    calculator.operandsDisplay.Text = "";
                    calculator.entryDisplay.Text = "" + entryVal2;
                    entryVal1 = 0;
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
                    if (!unaryOperation /*entryVal2 != 0 */)
                    {
                        calculator.operandsDisplay.Text = "";
                        //entryVal2 = 0;
                        operator_ = previousOperator;
                        Enter();
                    }
                }
                calculator.prevState = this;
                return this;
            }

            else
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                previousOperator = operator_;

                entryVal2 = entryVal1;
                Enter();

                return calculator.operatorState;
            }
            
        }

        public override State NextEntryState(Equals equals)
        {
            if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                || calculator.entryDisplay.Text.Contains("Invalid input"))
            {
                entryVal1 = 0;
                entryVal2 = 0;
                calculator.operandsDisplay.Text = "";
                calculator.entryDisplay.Text = "" + entryVal1;
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
            else if ((operator_ == calculator.divide && entryVal2 == 0))
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "Cannot divide by zero";

                Enter();
                return calculator.operand1State;
            }
            else
            {
                if (calculator.prevState == calculator.operand1State ||
                    unaryOperation)
                {
                    calculator.operandsDisplay.Text = "" + entryVal1 + " =";
                    operator_ = nullOperator;
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                }
                else
                {
                    if (operator_.Equals(previousOperator))
                    {
                        calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol()
                        + " " + entryVal2 + " =";
                        entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    }
                    else
                    {
                        calculator.operandsDisplay.Text = entryVal1 + " " + previousOperator.getSymbol()
                        + " " + entryVal2 + " =";
                        entryVal1 = previousOperator.Calculate(entryVal1, entryVal2);
                    }
                }
                
                calculator.entryDisplay.Text = "" + entryVal1;

                calculator.prevState = this;
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
