using Microsoft.Extensions.DependencyInjection;
using Repository.Implementation;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer
{
    public static class ServiceCollection
    {
        public static IServiceCollection ApplicationLayerServices(this IServiceCollection services)
        {
            services.AddTransient<ListingUpdater>();
            return services;
        }
    }
}
