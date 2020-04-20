using System;
using System.Linq.Expressions;



namespace ProgrammingInCSharp
{
    class Listening2_58
    {
        public static void Listening2_58Main()
        {
            // build the expression tree.
            // Expression<Func<int, int>> square = num => num * num;

            // The parameter for the expression is integer
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");

            // The operation to be performed is to square the parameter
            BinaryExpression squareOperation = Expression.Multiply(numParam, numParam);

            //
        }
    }
}
