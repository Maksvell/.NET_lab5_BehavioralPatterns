using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;

namespace PresentationLayer
{
    public class Runner : IRunner
    {
        private readonly IClient client;

        public Runner(IClient client)
        {
            this.client = client;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Введіть алгебраїчний вираз у форматі operand1 operator operand2:");
                try
                {
                    string expression = Console.ReadLine();
                    client.DoOperation(expression);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();
            }
        }
}
}
