using Microsoft.Extensions.DependencyInjection;
using Repository.Implementation;
using Repository.Interface;
using System;

namespace Repository
{
    public static class ServiceCollection
    {
        public static IServiceCollection RepoLayerServices(this IServiceCollection services)
        {
            services.AddScoped<IListingRepository, ListingRepository>();
            services.AddScoped<IBidRepository, BidRepository>();
            return services;
        }
    }
}
