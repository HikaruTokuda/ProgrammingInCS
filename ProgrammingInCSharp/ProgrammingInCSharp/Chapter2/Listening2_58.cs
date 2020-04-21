using System;
using System.Linq.Expressions;

/// <summary>
/// Lambda expression tree.
/// 
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{

    class Listening2_58
    {
        public static void Listening2_58Main()
        {
            // This creates an expression tree that describes the square operation.
            Expression<Func<int, int>> square = CreateSquare();

            // Compile the tree to make an excuteable method and assign it to a delegate.
            Func<int, int> doSquare = square.Compile();

            // Call the delegate.
            Console.WriteLine("Square of 2: {0}", doSquare(2));

            Console.ReadKey();

        }

        public static Expression<Func<int, int>> CreateSquare()
        {
            // build the expression tree.
            // Expression<Func<int, int>> square = num => num * num;

            // The parameter for the expression is integer
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");

            // The operation to be performed is to square the parameter.
            BinaryExpression squareOperation = Expression.Multiply(numParam, numParam);

            // This creates an expression tree that describes the square operation.
            Expression<Func<int, int>> square =
                Expression.Lambda<Func<int, int>>(
                    squareOperation,
                    new ParameterExpression[] { numParam });

            return square;

        }
    }
}
