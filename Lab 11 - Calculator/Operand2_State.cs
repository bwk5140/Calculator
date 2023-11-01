using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public class Operand2_State : State
    {
        public override State NextEntryState(char val)
        {
            if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                || calculator.entryDisplay.Text.Contains("Invalid input"))
            {
                calculator.entryDisplay.Text = "";
            }
            if (entryVal2 == 0 && char.IsDigit(val) && 
                !calculator.entryDisplay.Text.Contains("."))
            {
                entry = "" + val;
            }
            else
            {
                entry = calculator.entryDisplay.Text + val;
            }
            
            calculator.entryDisplay.Text = entry;

            entryVal2 = double.Parse(entry);

            Enter();

            return this;
        }

        public override State NextEntryState(Operator oprtr)
        {
            Operator nextOperator = oprtr;
            calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();

            if (nextOperator == calculator.square_root)
            {
                calculator.operandsDisplay.Text += " " + nextOperator.getSymbol() + " (" + entryVal2 + ")";
                if (entryVal2 < 0)
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

                    Enter();
                    return calculator.operand1State;
                }
                else
                {
                    entryVal2 = nextOperator.Calculate(entryVal2, entryVal1);
                    calculator.entryDisplay.Text = "" + entryVal2;

                    Enter();
                    return this;
                }     
            }
            else if (nextOperator == calculator.square_)
            {
                calculator.operandsDisplay.Text += " (" + entryVal2 + ")" + nextOperator.getSymbol();
                entryVal2 = nextOperator.Calculate(entryVal1, entryVal2);
                calculator.entryDisplay.Text = "" + entryVal2;

                Enter();

                return this;
            }
            else if (nextOperator == calculator.negate)
            {
                entryVal2 = nextOperator.Calculate(entryVal2, entryVal1);
                calculator.entryDisplay.Text = "" + entryVal2;

                Enter();

                return this;
            }
            else if (nextOperator == calculator.reciprocal_)
            {
                if (entryVal2 == 0)
                {
                    calculator.operandsDisplay.Text += " (1/" + entryVal2 + ")";
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
                else
                {
                    calculator.operandsDisplay.Text += " (1/" + entryVal2 + ")";
                    entryVal2 = nextOperator.Calculate(entryVal2, entryVal1);
                    calculator.entryDisplay.Text = "" + entryVal2;

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
            else if (nextOperator == calculator.clearEntryOperator)
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

                return calculator.operatorState;
            }
            else if (nextOperator == calculator.backspaceOperator)
            {
                string delete;
                delete = calculator.entryDisplay.Text.Remove(calculator.entryDisplay.Text.Length - 1);
                entry = delete;

                if (entryVal2 != entryVal1)
                {
                    if (entry.Equals(""))
                    {
                        entryVal2 = 0;
                    }
                    else if (calculator.entryDisplay.Text.Contains("Cannot divide by zero")
                        || calculator.entryDisplay.Text.Contains("Invalid input"))
                    {
                        calculator.operandsDisplay.Text = "";
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

                    }
                    else
                    {
                        if (entryVal2 - (int)entryVal2 == 0)
                        {

                            entryVal2 = int.Parse(entry);
                        }
                        else
                        {
                            entryVal2 = double.Parse(entry);
                        }
                    }
                }

                calculator.entryDisplay.Text = "" + entryVal2;
                Enter();

                return this;
            }
            else if ((operator_ == calculator.divide && entryVal2 == 0))
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
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
            else
            {
                entryVal1 = operator_.Calculate(entryVal1, entryVal2);
                operator_ = oprtr;
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
                calculator.entryDisplay.Text = "" + entryVal1;
                entryVal2 = entryVal1;

                Enter();
                return calculator.operatorState;
            }
        }

        public override State NextEntryState(Equals equals)
        {
            calculator.prevState = this;

            if (operator_ == calculator.square_root)
            {
                calculator.operandsDisplay.Text = "" + operator_.getSymbol() + " " + entryVal1;
            }
            else if (operator_ == calculator.divide && entryVal2 == 0)
            {
                calculator.operandsDisplay.Text = entryVal1 + " " + operator_.getSymbol();
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
