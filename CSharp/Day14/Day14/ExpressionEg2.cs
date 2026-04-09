using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class ExpressionEg2
    {
        static void Main()
        {
            Func<string, string, string> strJoin = (s1, s2) => String.Concat(s1, s2);

            Expression<Func<string, string, string>> strjoinexpr = (s1, s2) => String.Concat(s1, s2);

            var Result = strjoinexpr.Compile()("Banu", "Rekha");
            Console.WriteLine(Result);

            Console.WriteLine("------Expressions with Parameters -------");
            ExpressionsWithParameters();

            //Console.WriteLine("--------Using some functions-------");

            //Expression<Func<Product, bool>> expr1 = p => p.Price > 100;
            //Expression<Func<Product, bool>> expr2 = p => p.Id==3;

            //var combinedexpr = Expression.Lambda<Func<Product, bool>>(
            //    Expression.AndAlso(expr1.Body, expr2.Body));
            Console.Read();

        }

        static void ExpressionsWithParameters()
        {
            //1. create parameters
            ParameterExpression n1 = Expression.Parameter(typeof(int), "num1");
            ParameterExpression n2 = Expression.Parameter(typeof(int), "num2");

            //2. create an expression parameter
            ParameterExpression[] parameters = new ParameterExpression[] { n1, n2 };

            //3. Create expression body
            BinaryExpression exprbody = Expression.Multiply(n1, n2);

            //4. Create the Expression
            Expression<Func<int, int, int>> expr = Expression.Lambda<Func<int, int, int>>(exprbody, parameters);

            //5. Compile the expression
            Func<int, int, int> CompileFunc = expr.Compile();

            //6. Execute the expression
            Console.WriteLine("Expression using API resulted in {0} ", CompileFunc(25, 30));

            Console.WriteLine("Node Type : " + " " + exprbody.NodeType);
            Console.WriteLine("Parameter Type [1] : " + " " + expr.Parameters[1].Name);
            Console.WriteLine("Return type of the Expression : " + " " + expr.ReturnType);
        }
    }

    public class CustomVisit : ExpressionVisitor
    {
        protected override Expression VisitBinary(BinaryExpression node)
        {
            if(node.NodeType == ExpressionType.Multiply)
            {
                return Expression.Divide(node.Left, node.Right);
            }
            return base.VisitBinary(node);
        }
    }
}
