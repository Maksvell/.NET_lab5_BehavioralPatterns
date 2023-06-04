using System;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer;
using PresentationLayer;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IServiceCollection serviceDescriptors = new ServiceCollection();
            serviceDescriptors.AddServices();
            IServiceProvider serviceProvider = serviceDescriptors.BuildServiceProvider();
            serviceProvider.GetService<IRunner>().Run();
        }
    }
}
