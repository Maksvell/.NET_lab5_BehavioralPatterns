using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Context
    {
        private IStrategy strategy;

        public Context() { }
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public decimal Execute(decimal operand1, decimal operand2)
        {
            return strategy.Execute(operand1, operand2);
        }

    }
}
