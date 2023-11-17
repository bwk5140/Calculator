using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class Operand2_State : State
    {
        public override State NextEntryState(char val)
        {
            string input = calculator.entryDisplay.Text;

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
            if (entryVal2 == 0 && char.IsDigit(val) && 
                !calculator.entryDisplay.Text.Contains("."))
            {
                entry = "" + val;
            }
            else
            {
                if (char.IsDigit(val))
                {
                    entry = calculator.entryDisplay.Text + val;
                }
                else
                {
                    if (!input.Contains("."))
                    {
                        entry = calculator.entryDisplay.Text + val;
                    }
                }
            }
            
            calculator.entryDisplay.Text = entry;

            entryVal2 = double.Parse(entry);
            inputState = "Operand2_State";
            unaryOperation = false;

            Enter();

            return this;
        }

        public override State NextEntryState(Operator oprtr)
        {
            Operator nextOperator = oprtr;
            //calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();

            if (nextOperator == calculator.square_root)
            {
                calculator.operandsDisplay.Text += " " + nextOperator.getSymbol() + " (" + entryVal2 + ")";
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
                    return this;
                }
                else
                {
                    entryVal2 = nextOperator.Calculate(entryVal2, entryVal1);
                    calculator.entryDisplay.Text = "" + entryVal2;
                    unaryOperation = true;

                    Enter();
                    return this;
                }     
            }
            else if (nextOperator == calculator.square_)
            {
                calculator.operandsDisplay.Text += " (" + entryVal2 + ")" + nextOperator.getSymbol();
                entryVal2 = nextOperator.Calculate(entryVal2, entryVal1);
                calculator.entryDisplay.Text = "" + entryVal2;
                unaryOperation = true;

                Enter();

                return this;
            }
            else if (nextOperator == calculator.negate)
            {
                entryVal2 = nextOperator.Calculate(entryVal2, entryVal1);
                calculator.entryDisplay.Text = "" + entryVal2;
                unaryOperation = true;

                Enter();

                return this;
            }
            else if (nextOperator == calculator.reciprocal_)
            {
                if (entryVal2 == 0)
                {
                    calculator.operandsDisplay.Text += " 1/(" + entryVal2 + ")";
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
                    return this;
                }
                else
                {
                    calculator.operandsDisplay.Text += " 1/(" + entryVal2 + ")";
                    entryVal2 = nextOperator.Calculate(entryVal2, entryVal1);
                    calculator.entryDisplay.Text = "" + entryVal2;
                    unaryOperation = true;

                    Enter();

                    return this;
                }
             
            }
            else if (nextOperator == calculator.clearAllOperator)
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
            else if (nextOperator == calculator.clearEntryOperator)
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
                    calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
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

                return calculator.operatorState;
            }
            else if (nextOperator == calculator.backspaceOperator)
            {
                if (!unaryOperation)
                {
                    string delete;
                    delete = calculator.entryDisplay.Text.Remove(calculator.entryDisplay.Text.Length - 1);
                    entry = delete;

                    if (entry.Equals(""))
                    {
                        entryVal2 = 0;
                        calculator.entryDisplay.Text = "" + entryVal2;
                    }
                    else if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                        || calculator.entryDisplay.Text.Contains("Invalid input"))
                    {
                        calculator.operandsDisplay.Text = "";
                        entryVal1 = 0;
                        entryVal2 = 0;
                        calculator.entryDisplay.Text = "" + entryVal2;
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
                        if (entryVal2 - (int)entryVal2 == 0 && !entry.Contains(""))
                        {

                            entryVal2 = int.Parse(entry);
                        }
                        else
                        {
                            entryVal2 = double.Parse(entry);
                        }
                        calculator.entryDisplay.Text = "" + entry;
                    }
                    Enter();
                }

                return this;
            }
            else if ((operator_ == calculator.divide && entryVal2 == 0))
            {
                entryVal1 = 0;
                entryVal2 = 0;
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
                unaryOperation = false;
                Enter();

                return calculator.operand1State;
            }
            else
            {
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                operator_ = oprtr;
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "" + entryVal1;
                entryVal2 = entryVal1;
                unaryOperation = false;

                Enter();
                return calculator.operatorState;
            }
        }

        public override State NextEntryState(Equals equals)
        {
            calculator.prevState = this;
            unaryOperation = false;

            if (operator_ == calculator.square_root)
            {
                calculator.operandsDisplay.Text = "" + operator_.getSymbol() + " " + entryVal1;
            }
            else if (operator_ == calculator.divide && entryVal2 == 0)
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
