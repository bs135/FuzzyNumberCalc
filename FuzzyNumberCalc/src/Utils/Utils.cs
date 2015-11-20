using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyNumberCalc.Utils
{
    public enum Operation
    {
        Add,
        Sub,
        Mul,
        Div
    }

    public static class ArithmeticInterval
    {
        public static Interval Calculate(Operation operation, Interval a, Interval b)
        {
            Interval result = new Interval();
            switch (operation)
            {
                case Operation.Add:
                    result.UpperBound = a.UpperBound + b.UpperBound;
                    result.LowerBound = a.LowerBound + b.LowerBound;
                    break;
                case Operation.Sub:
                    result.UpperBound = a.UpperBound - b.LowerBound;
                    result.LowerBound = a.LowerBound - b.UpperBound;
                    break;
                case Operation.Mul:
                    result.UpperBound = Math.Max(Math.Max(a.UpperBound * b.UpperBound, a.UpperBound * b.LowerBound), Math.Max(a.LowerBound * b.UpperBound, a.LowerBound * b.LowerBound));
                    result.LowerBound = Math.Min(Math.Min(a.UpperBound * b.UpperBound, a.UpperBound * b.LowerBound), Math.Min(a.LowerBound * b.UpperBound, a.LowerBound * b.LowerBound));
                    break;
                case Operation.Div:
                    if (b.UpperBound != 0 && b.LowerBound != 0)
                    {
                        result.UpperBound = Math.Max(Math.Max(a.UpperBound / b.UpperBound, a.UpperBound / b.LowerBound), Math.Max(a.LowerBound / b.UpperBound, a.LowerBound / b.LowerBound));
                        result.LowerBound = Math.Min(Math.Min(a.UpperBound / b.UpperBound, a.UpperBound / b.LowerBound), Math.Min(a.LowerBound / b.UpperBound, a.LowerBound / b.LowerBound));
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    public static class ExtensionPrinciple
    {
        public static decimal Calculate(Operation operation, decimal a, decimal b)
        {
            decimal result = 0;
            switch (operation)
            {
                case Operation.Add:
                    result = a + b;
                    break;
                case Operation.Sub:
                    result = a - b;
                    break;
                case Operation.Mul:
                    result = a * b;
                    break;
                case Operation.Div:
                    if (b != 0)
                        result = a / b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
