using System;

namespace DesignPatternsTraining.InterpreterDesignPattern
{
    public class TerminalExpression : IExpression
    {
        String data;

        public TerminalExpression(String data)
        {
            this.data = data;
        }

        public bool interpreter(String con)
        {
            if (con.Contains(data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
