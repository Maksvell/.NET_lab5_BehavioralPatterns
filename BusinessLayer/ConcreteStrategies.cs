using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ConcreteStrategyAdd : IStrategy
    {
        public decimal Execute(decimal operand1, decimal operand2)
        {
            return operand1 + operand2;
        }
    }
    public class ConcreteStrategyMultiply : IStrategy
    {
        public decimal Execute(decimal operand1, decimal operand2)
        {
            return operand1 * operand2;
        }
    }
    public class ConcreteStrategyDivide : IStrategy
    {
        public decimal Execute(decimal operand1, decimal operand2)
        {
            if (operand2 == 0)
            {
                throw new ArgumentException("Division by zero is not allowed");
            }
            return operand1 / operand2;
        }
    }
}
