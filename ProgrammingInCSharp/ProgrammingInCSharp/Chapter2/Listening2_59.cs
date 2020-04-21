using System;
using System.Linq.Expressions;

namespace ProgrammingInCSharp.Chapter2
{
    /// <summary>
    /// Modifying an expression tree.
    /// An expression is immutable, which means that the elements in the expression cannot be changed once the expression has been created.
    /// To modify an expression tree you must make a copy of the tree which contaions the modified behaviors.
    /// </summary>
    public class MultiplyToAdd : ExpressionVisitor
    {
        public Expression Modify(Expression expression)
        {

            return Visit(expression);
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            if(b.NodeType == ExpressionType.Multiply)
            {
                Expression left = this.Visit(b.Left);
                Expression right = this.Visit(b.Right);

                // Make this binary expression an Add rather than a amultiply operation.
                return Expression.Add(left, right);
            }

            return base.VisitBinary(b);
        }
    }

    class Listening2_59
    {
        public static void Listening2_59Main()
        {
            MultiplyToAdd m = new MultiplyToAdd();
            Expression<Func<int, int>> square = Listening2_58.CreateSquare();

            Expression<Func<int, int>> addExpression = (Expression<Func<int, int>>)m.Modify(square);
            Func<int, int> doAdd = addExpression.Compile();

            Console.WriteLine("Square of 2: {0}", doAdd(2));
            Console.ReadKey();

        }
    }
}
