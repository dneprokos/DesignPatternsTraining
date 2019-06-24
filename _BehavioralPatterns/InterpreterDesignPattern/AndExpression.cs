using System;

namespace DesignPatternsTraining.InterpreterDesignPattern
{
    public class AndExpression: IExpression
    {
        IExpression expr1;
        IExpression expr2;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        public bool interpreter(String con)
        {
            return expr1.interpreter(con) && expr2.interpreter(con);
        }
    }
}
