using System;

namespace Lab_11___Calculator
{
    public abstract class State
    {
        public static Calculator calculator;

        public static double entryVal1;
        public static double entryVal2;
        public static string entry;
        public static string inputState = "EntryState";
        public static bool unaryOperation = true;

        public static Operand1_State operand1 = new Operand1_State();
        public static Operand2_State operand2 = new Operand2_State();
        public static EqualState equalState = new EqualState();
        public static EntryState entryState = new EntryState();
        public static Operator operator_ = new NullOperator();
        public static Operator previousOperator = new NullOperator();
        public static NullOperator nullOperator = new NullOperator();
        //public static OperandsDisplayState equation = new OperandsDisplayState();

        public static State Start()
        {
            return entryState;
        }
        public virtual State NextEntryState(Operator oprtr)
        {
            throw new NotImplementedException("Not available yet.");
        }

        public virtual State NextEntryState (Equals eequal)
        {
            throw new NotImplementedException("Not available yet.");
        }
        public virtual State NextEntryState(char entry)
        {
            throw new NotImplementedException("Not available yet.");
        }
        public virtual void Enter()
        {
            throw new NotImplementedException("Not available yet.");
        }
    }
}
