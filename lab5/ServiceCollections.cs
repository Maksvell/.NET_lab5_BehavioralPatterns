using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer;
using PresentationLayer;

namespace lab3
{
    public static class ServiceCollections
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<IClient, Client>();
            serviceDescriptors.AddTransient<IRunner, Runner>();
            return serviceDescriptors;
        }
    }
}
