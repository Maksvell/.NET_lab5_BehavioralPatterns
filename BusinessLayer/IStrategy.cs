using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IStrategy
    {
        public decimal Execute(decimal operand1, decimal operand2);
    }
}
