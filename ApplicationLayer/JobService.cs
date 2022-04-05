using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class JobService : IJob
    {
        private readonly IServiceScopeFactory serviceScopeFactory;
        private static readonly Object lockObject = new Object();

        public JobService(IServiceScopeFactory service)
        {
            serviceScopeFactory = service ?? throw new ArgumentNullException(nameof(service));
        }

        public Task Execute(IJobExecutionContext context)
        {
            try
            {

                using (var scope = serviceScopeFactory.CreateScope())
                {
                    var processor = scope.ServiceProvider.GetService<ListingUpdater>();

                    processor.CancelExpiredBids();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return Task.FromResult(1);
        }



    }
}
