using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_11___Calculator
{
    public partial class Calculator : Form
    {
        State nextState;
        public EntryState entryState = new EntryState(); 
        public Operand1_State operand1State = new Operand1_State();
        public Operand2_State operand2State = new Operand2_State();
        public EqualState equalState = new EqualState();
        public OperatorState operatorState = new OperatorState();
        
        public ClearAll clearAllOperator = new ClearAll();
        public ClearEntry clearEntryOperator = new ClearEntry();
        public Backspace backspaceOperator = new Backspace();

        public State prevState;
        public Add add = new Add();
        public Subtract subtract = new Subtract();
        public Divide divide = new Divide();
        public Multiply multiply = new Multiply();
        public Square square_ = new Square();
        public SquareRoot square_root = new SquareRoot();
        public Reciprocal reciprocal_ = new Reciprocal();
        public Equals equalSign = new Equals();
        public Negate negate = new Negate();
        Equals equals_ = new Equals();

        public Calculator()
        {
            InitializeComponent();

            nextState = entryState;
            prevState = operand1State;

            entryDisplay.SelectAll();
            entryDisplay.SelectionAlignment = HorizontalAlignment.Right;

            State.calculator = this;
        }

        private void decimal_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('.');
        }

        private void zero_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('0');
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(negate);
        }

        private void one_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('1');
        }
        private void two_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('2');
        }
        private void three_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('3');
        }

        private void four_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('4');
        }

        private void five_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('5');
        }

        private void six_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('6');
        }

        private void seven_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('7');
        }

        private void eight_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('8');
        }

        private void nine_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState('9');
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(clearAllOperator);           
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(clearEntryOperator);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(add);
   
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(equals_);
        }

        private void Square_click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(square_);
        }

        private void SquareRoot_click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(square_root);
        }

        private void Reciprocal_click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(reciprocal_);
        }

        private void Subtract_click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(subtract);
        }

        private void Multiply_click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(multiply);
        }

        private void Divide_click(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(divide);
        }

        private void Backspace_clicked(object sender, EventArgs e)
        {
            nextState = nextState.NextEntryState(backspaceOperator);
        }

        private void emptyButton1_Click(object sender, EventArgs e)
        {

        }

        private void entryDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void operandsDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
