using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSyntaxTree
{
    public interface INode
    {
        double Value { get; }
    }

    public class NumberNode:INode
    {
        public double Value { get; }

        public NumberNode(double value) => Value = value;
    }
    public class SignNode:INode
    {
        public INode Left, Right;
        public Sign sign;
        public double Value
        {
            get
            {
                switch (sign)
                {
                    case Sign.plus:
                        return Left.Value + Right.Value;
                    case Sign.minus:
                        return Left.Value - Right.Value;
                    case Sign.multiply:
                        return Left.Value * Right.Value;
                    case Sign.divide:
                        double right = Right.Value;
                        if (right == 0)
                            throw new DivideByZeroException();
                        return Left.Value / right;
                }
                return 0;
            }
        }

        public SignNode(INode left, INode right, Sign sign)
        {
            Left = left;
            Right = right;
            this.sign = sign;
        }
    }
    public enum Sign
    {
        plus,
        minus,
        multiply,
        divide
    }
}
