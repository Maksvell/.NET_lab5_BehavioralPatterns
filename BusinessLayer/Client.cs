using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Client : IClient
    {
        private Context context;

        public Client()
        {
            context = new Context();
        }

        private void ChangeStrategy(string _operator)
        {
            switch (_operator)
            {
                case "+":
                    context.SetStrategy(new ConcreteStrategyAdd());
                    break;
                case "*":
                    context.SetStrategy(new ConcreteStrategyMultiply());
                    break;
                case "/":
                    context.SetStrategy(new ConcreteStrategyDivide());
                    break;
                default:
                    throw new Exception("Wrong format of operator");
            }
        }

        public void DoOperation(string expression)
        {
            string[] parts = expression.Split(' ');

            if (parts.Length != 3)
            {
                throw new Exception("Wrong format of expression");
            }

            ChangeStrategy(parts[1]);

            decimal operand1, operand2;
            if (!decimal.TryParse(parts[0], out operand1) || !decimal.TryParse(parts[2], out operand2))
            {
                throw new Exception("Wrong format of operand");
            }

            Console.WriteLine("Результат: " + context.Execute(operand1, operand2));
        }

    }
}
