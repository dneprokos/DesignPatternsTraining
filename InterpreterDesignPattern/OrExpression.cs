using System;

namespace DesignPatternsTraining.InterpreterDesignPattern
{
    public class OrExpression: IExpression
    {
        IExpression expr1;
        IExpression expr2;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        public bool interpreter(String con)
        {
            return expr1.interpreter(con) || expr2.interpreter(con);
        }
    }
}
