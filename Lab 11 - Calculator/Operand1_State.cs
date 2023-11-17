using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class Operand1_State : State
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
            
            if (input.Equals("0") && char.IsDigit(val))
            {
                entry = "" + val;
            }
            else
            {
                /*
                if (calculator.prevState.GetType() == equalState.GetType())
                {
                    if (!char.IsDigit(val))
                    {
                        entry = "0" + val;
                    }
                    else
                    {
                        entry = "" + val;
                    }
                }
                */
                /*
                if
                {
                */
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
                //}
            }

            calculator.entryDisplay.Text = entry;

            entryVal1 = double.Parse(entry);
            inputState = "Operand1_State";
            unaryOperation = false;

            Enter();
            return this;
        }
        public override State NextEntryState(Operator oprtr)
        {
            //calculator.prevState = this;
            operator_ = oprtr;
            previousOperator = operator_;
            if (operator_ == calculator.square_root)
            {
                calculator.operandsDisplay.Text = "" + operator_.getSymbol() + " (" + entryVal1 + ")";
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
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                    //entryVal2 = entryVal1;
                    unaryOperation = true;
                }

                Enter();

                return this;
            }
            else if (operator_ == calculator.square_)
            {
                calculator.operandsDisplay.Text = "(" + entryVal1 + ")" + operator_.getSymbol();

                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal1;
                //entryVal2 = entryVal1;
                unaryOperation = true;

                Enter();

                return this;
            }
            else if (operator_ == calculator.negate)
            {
                if (entryVal1 != 0)
                {
                    entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                    calculator.entryDisplay.Text = "" + entryVal1;
                    //entryVal2 = entryVal1;
                    unaryOperation = true;
                    Enter();
                }
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
                    //entryVal2 = entryVal1;
                    unaryOperation = true;
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

                return this;
            }
            else if (operator_ == calculator.clearEntryOperator)
            {
                if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                       || calculator.entryDisplay.Text.Contains("Invalid input"))
                {
                    calculator.operandsDisplay.Text = "";
                }

                calculator.entryDisplay.Text = "0";
                entry = "";
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

                return this;
            }
            else if (operator_ == calculator.backspaceOperator)
            {
                if (!unaryOperation)
                {
                    string delete;
                    delete = calculator.entryDisplay.Text.Remove(calculator.entryDisplay.Text.Length - 1);
                    entry = delete;

                    if (entry.Equals(""))
                    {
                        entryVal1 = 0;
                        entry = "" + entryVal1;
                        calculator.entryDisplay.Text = "" + entry;
                    }
                    
                    else
                    {
                        if (entryVal1 - (int)entryVal1 == 0 && !entry.Contains("."))
                        {

                            entryVal1 = int.Parse(entry);
                        }
                        else
                        {
                            entryVal1 = double.Parse(entry);
                        }
                        calculator.entryDisplay.Text = "" + entry;
                    }   
                }
                else if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                            || calculator.entryDisplay.Text.Contains("Invalid input"))
                {
                    entryVal1 = 0;
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
                }
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
            unaryOperation = true;
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
